using System;
using FunnyStory_KolesnikEPAM;

namespace Example1
{
    class Волк : Герои, IVehicle, IFear
    {
        public  Волк()
        {
            setColor(ConsoleColor.Blue);
        }
        public  override string ToString()
        {
            return "Волки:";

        }
        public void Move()
        {
            textOut("-Кто на ком, а мы на кобыле!");
        }
        public override void Speak()
        {
            textOut("-Мы ВОЛКИ!");
        }

        public void FrightSpeak()
        {
            textOut("-Мы от испуга скушали друг друга");
        }
    }
}
