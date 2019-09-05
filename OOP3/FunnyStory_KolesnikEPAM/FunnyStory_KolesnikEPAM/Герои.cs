using System;

namespace Example1
{
    abstract class Герои
    {
        ConsoleColor textColor;

        public static void Smile()
        {
            Console.WriteLine("Все смеются");
        }
        public static void Eat()
        {
            Console.WriteLine("Пряники жуют");
        }

        public string Type
        {
            get;
            set;
        }

        protected void setColor(ConsoleColor newColor)
        {
            textColor = newColor;
        }

        abstract public void Speak();

        protected void textOut(string msg)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }

        public static void frighten()
        {
            Console.WriteLine("Звери задрожали, в обморок упали!");
        }
    }
}
