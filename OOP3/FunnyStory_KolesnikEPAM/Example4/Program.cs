using System;

namespace Example4
{
    // Base Class

    public class User

    {

        public virtual void GetInfo()

        {

            Console.WriteLine("Base Class");

        }

    }

    // Derived Class

    public class SuperUser : User

    {

        public override void GetInfo()

        {

            Console.WriteLine("Derived Class");

        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            User obj = new SuperUser();
            obj.GetInfo();
            obj = new User();
            obj.GetInfo();
            Console.ReadLine();
        }
    }
}
