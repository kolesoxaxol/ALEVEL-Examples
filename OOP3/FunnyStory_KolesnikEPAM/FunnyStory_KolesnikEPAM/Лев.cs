using System;

namespace Example1
{
    class Лев:Герои, IVehicle
    {
        public Лев()
        {
            setColor(ConsoleColor.Yellow);
        }

        public override string ToString()
        {
            return "Львы:";
        }

        public void Move()
        {
            textOut("-Мы в крутом автомобиле");
        }

        public override void Speak()
        {
            textOut("-Мы львы!");
        }
    }
}
