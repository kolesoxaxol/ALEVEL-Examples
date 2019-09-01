using System;
using System.CodeDom;

namespace Example1
{
    // try use both SplitNamemethod  
    // try remove init firstName into method and check difference between two method
    // when u can use it? 
    // what we need to do for preventing use out? 



    class Program
    {

        // Splits a string containing a first and last name separated
        // by a space into two distinct strings, one containing the first name and one containing the last name

        static void SplitName(string fullName, out string firstName, out string lastName)
        {
            // NOTE: firstName and lastName have not been assigned to yet.  Their values cannot be used.
            int spaceIndex = fullName.IndexOf(' ');
            firstName = fullName.Substring(0, spaceIndex).Trim();
            lastName = fullName.Substring(spaceIndex).Trim();
        }





        //static void SplitName(string fullName, ref string firstName, ref string lastName)
        //{
        //    // NOTE: firstName and lastName have not been assigned to yet.  Their values cannot be used.
        //    int spaceIndex = fullName.IndexOf(' ');
        //   // firstName = fullName.Substring(0, spaceIndex).Trim();
        //    lastName = fullName.Substring(spaceIndex).Trim();
        //}





        public static void ChangeRef(ref int numberRef)
        {
            numberRef = 25;
            Console.WriteLine($"Inside the ChangeRef method the numberRef is {numberRef}");
        }

        public static void ChangeOut(out int numberOut)
        {
            numberOut = 60;
            Console.WriteLine($"Inside the ChangeOut method the numberOut is {numberOut}");
        }


        static void Main(string[] args)
        {
            
            string fullName = "Yevhenii Koliesnik";
            string firstName;
            string lastName;

            // NOTE: firstName and lastName have not been assigned yet.  Their values may not be used.
            SplitName(fullName, out firstName, out lastName);

            //SplitName(fullName,ref firstName, ref lastName);
            // NOTE: firstName and lastName have been assigned, because the out parameter passing mode guarantees it.
            Console.WriteLine("First Name: {0}. Last Name: {1}", firstName, lastName);



            // ++++++++++++++++++++++++++++++++++++++//
            int numberRef = 15;

            Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
            ChangeRef(ref numberRef);
            Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");

            Console.WriteLine();

            int numberOut;
            Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
            ChangeOut(out numberOut);
            Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");

            

            Console.ReadLine();
        }
    }
}
