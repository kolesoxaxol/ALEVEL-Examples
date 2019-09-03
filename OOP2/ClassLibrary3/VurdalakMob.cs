using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class VurdalakMob : BaseMob
    {
        public string TeamNumber { get; set; }

        public VurdalakMob(string teamNumber)
        {
            this.TeamNumber = teamNumber;

            Console.WriteLine("VurdalakMob constructor");
        }

        public void TakeTree()
        {
            Console.WriteLine("Job done master");
        }

    }
}
