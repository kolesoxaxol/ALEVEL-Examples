using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace ALvlBlog.WebApi.Filters
{
    public class AuthorizeBlogFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (Authorize(actionContext))
            {
                return;
            }

            HandleUnauthorizedRequest(actionContext);
        }

        protected override void HandleUnauthorizedRequest(HttpActionContext actionContext)
        {
            var challengeMessage = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            throw new HttpResponseException(challengeMessage);
        }


        private bool Authorize(HttpActionContext actionContext)
        {
            try
            {
                string ipAdresses = HttpContext.Current.Request.UserHostAddress; // 127.0.0.1 32.32.32.32 

                if (!IsIpAddressAllowed(ipAdresses.Trim()))
                {
                    return false;
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        private bool IsIpAddressAllowed(string ipAddress)
        {
            if (!string.IsNullOrWhiteSpace(ipAddress))
            {
                var allowedAddress = ConfigurationManager.AppSettings["AllowedIpAddress"];

                if (string.IsNullOrEmpty(allowedAddress))
                {
                    return true;
                }

                string[] addresses = allowedAddress.Split(',');

                return addresses.Where(a => a.Trim().Equals(ipAddress, StringComparison.InvariantCultureIgnoreCase)).Any();
            }

            return false;
        }


    }
}