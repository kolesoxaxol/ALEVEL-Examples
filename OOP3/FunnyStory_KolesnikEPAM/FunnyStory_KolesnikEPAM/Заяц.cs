using System;

namespace Example1
{
    class Заяц : Герои, IVehicle
    {
        public Заяц()
        {
            setColor(ConsoleColor.White);
        }
        public override string ToString()
        {
            return "Зайчики:";
        }
        public void Move()
        {
            textOut("-Мы в трамвайчике");

        }
        public override void Speak()
        {
            textOut("-Мы Зайчики!");
        }
    }
}
