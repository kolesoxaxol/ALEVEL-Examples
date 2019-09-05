using System;

namespace Example1
{
    class Кот:Герои, IVehicle
    {
        public Кот()
        {
            setColor(ConsoleColor.Black);
        }

        public override string ToString()
        {
            return "Кот (Шредингера):";
        }

        public  void Move()
        {
            textOut("-Я за медведями задом наперед и одновременно передом назад!");
        }
        public override void Speak()
        {
            textOut("Я Кот Шредингера!");
        }
    }
}
