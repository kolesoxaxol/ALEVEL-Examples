using System;

namespace TemplateMethodSample.Food
{
    class HotDog : FastFood
    {
        public override bool CustomerWantsTopings()
        {
            Console.Write("Do you want mustard?: ");
            var userInput = Console.ReadLine();

            return userInput.ToLower() == "yes" || userInput.ToLower() == "y";
        }

        public override void PrepareMainIngredient()
        {
            Console.WriteLine("Sausage");
        }

        public override void AddTopings()
        {
            Console.WriteLine("Mustard");
        }
    }
}
