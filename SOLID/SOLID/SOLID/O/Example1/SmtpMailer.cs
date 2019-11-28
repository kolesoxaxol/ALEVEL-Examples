using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.O
{
    public class SmtpMailer
    {
        private readonly Logger logger;

        public SmtpMailer()
        {
            logger = new Logger();
            //Но ведь по принципу единственности ответственности не SmptMailer отвечает за логирование, почему изменения дошли и до него? 
            //logger = new DatabaseLogger();
        }



        public void SendMessage(string message)
        {
            // отсылка сообщения

            logger.Log(string.Format("Отправлено '{0}'", message));
        }
    }
}
