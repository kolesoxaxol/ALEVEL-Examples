using System;

namespace Example1
{
    class Таракан:Герои
    {
        private static Таракан obj=null;
        string type="Рыжий и усатый";
        string place = "Из подворотни";

        private Таракан()
        {
            Console.WriteLine("<Появляется таракан...>");
            setColor(ConsoleColor.DarkRed);
        }

        public void Growl()
        {
            textOut("-Рычу ! ры - ры ");
        }

        public void Shout()
        {
            textOut("-Кричу");
        }

        public void Stir()
        {
            textOut("-Усами шевелю");
        }

        public override string ToString()
        {
            return "Таракан - Одиночка!\r\n" + "Та-ра-кан! Таракан, Таракан, Тараканище!";
        }

        public override void Speak()
        {
            textOut("-Погодите, не спешите, Я вас мигом проглочу! Проглочу, проглочу, не помилую");
        }

        public static Таракан Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new Таракан();
                }
                return obj;
            }
        }

        public string Types
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public string Places
        {
            get
            {
                return place;
            }
            set
            {
                place = value;
            }
        }
    }
}
