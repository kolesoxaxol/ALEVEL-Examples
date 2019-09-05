using System;

namespace Example1
{
    class Жаба:Герои, IVehicle, IFear
    {
        public Жаба()
        {
            setColor(ConsoleColor.Green);
        }
        public void Move()
        {
            
            textOut("-Я на метле");
        }
        public override string ToString()
        {
            return "Жаба:";
        }
        public override void Speak()
        {
            textOut("-Я ЖабА!");
           
        }
        public void FrightSpeak()
        {
            textOut("-Бедный крокодил меня проглотил");
        }
    }
}
