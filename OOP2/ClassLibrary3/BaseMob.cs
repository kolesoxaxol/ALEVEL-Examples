using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class BaseMob
    {
        private int health = 100;
        private string Name { get; set; }
        private int damage = 120;

        public BaseMob()
        {
            Console.WriteLine("BaseMob constructor1");
        }

        public BaseMob(int health, string name, int damage)
        {
            this.health = health;
            this.Name = name;
            this.damage = damage;
            Console.WriteLine("BaseMob constructor");
        }

        public void ReduceHealth(int reduceDamage)
        {
            this.health = health - reduceDamage;

        }
        




    }
}
