using System;

namespace Example1
{
    class Медведь:Герои, IVehicle
    {
        public Медведь()
        {
            setColor(ConsoleColor.DarkYellow);
        }

        public override string ToString()
        {
 	       return "Медведи:";
        } 

        public  void Move()
        {
          textOut("-Мы ехали на велосипеде");
        }

        public override void Speak()
        {
            textOut("-Мы медведи");
        }
    }
}
