using System;

namespace Example1
{
    class Рак : Герои, IVehicle, IFear
    {
        public Рак()
        {
            setColor(ConsoleColor.Red);
        }

        public override string ToString()
        {
            return "Просто Раки ;)";
        }

        public void Move()
        {            
            textOut("-Мы раки на храмой собаке");
        }

        public override void Speak()
        {
            textOut("-МЫ РАКИ!!!<КЛАЦ-КЛАЦ>");
        }

        public void FrightSpeak()
        {
            textOut("-Не кричи и не рычи, Мы и сами усачи, Можем мы и сами Шевелить усами!<КЛАЦ-КЛАЦ-КЛАЦ>");
        }
    }
}
