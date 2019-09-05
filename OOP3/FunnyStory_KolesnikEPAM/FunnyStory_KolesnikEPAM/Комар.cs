using System;

namespace Example1
{
    class Комар:Герои, IVehicle
    {
        public Комар()
        {
            setColor(ConsoleColor.Magenta);
        }
        public override string ToString()
        {
            return "Комарики:";
        }

        public void Move()
        {
            textOut("-Мы на воздушном шарике!");
        }
        public override void Speak()
        {
            textOut("-Мы комарики!");
        }
    }
}
