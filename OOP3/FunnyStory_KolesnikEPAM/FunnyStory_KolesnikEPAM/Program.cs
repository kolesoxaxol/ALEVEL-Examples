using System;
using Example1;
using LibraryForStory;  // подключение библиотеки
namespace FunnyStory_KolesnikEPAM
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "ТАРАКАНИЩЕ";
                Console.WriteLine("               ТАРАКАНИЩЕ\r\n");
                
                Console.WriteLine("Created by Koleso\nStory by Chykovskiy");
                Console.WriteLine();
                
                Медведь bears = new Медведь();
                Console.WriteLine(bears);
                bears.Move();
                Console.WriteLine();

                Кот cat = new Кот();
                Console.WriteLine(cat);
                cat.Move();
                Console.WriteLine();
                
                Комар mosquito = new Комар();
                Console.WriteLine(mosquito);
                mosquito.Move();
                Console.WriteLine();

                Рак  crayfish= new Рак();
                Console.WriteLine(crayfish);
                crayfish.Speak();
                crayfish.Move();
                Console.WriteLine();

                Волк wolf = new Волк();
                Console.WriteLine(wolf);
                wolf.Move();
                Console.WriteLine();

                Лев lion = new Лев();
                Console.WriteLine(lion);
                lion.Move();
                Console.WriteLine();

                Заяц hare = new Заяц();
                Console.WriteLine(hare);
                hare.Move();
                Console.WriteLine();

                Жаба frog = new Жаба();
                Console.WriteLine(frog);
                frog.Move();
                Console.WriteLine();

                Герои.Smile();
                Герои.Eat();
                Таракан roach = Таракан.Instance;
                Console.WriteLine(roach.Places);
                Console.WriteLine(roach.Types);
                Console.WriteLine(roach);
                roach.Growl();
                roach.Shout();
                roach.Stir();
                roach.Speak();
                Console.WriteLine();

                Герои.frighten();

                Console.WriteLine(frog);
                frog.FrightSpeak();
                Console.WriteLine();

                Console.WriteLine(wolf);
                wolf.FrightSpeak();
                Console.WriteLine();

                Console.WriteLine(crayfish);
                crayfish.FrightSpeak();
                Console.WriteLine();

                Sparrow obj10 = new Sparrow();
                Console.WriteLine();
                Console.WriteLine();
                
                obj10.Speak();
                obj10.Kill();
                Console.ReadLine();
          
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
                     
        }
    }
}
