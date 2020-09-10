using System;

namespace TemplateMethodSample.Food
{
    class Hamburger : FastFood
    {
        public override void PrepareMainIngredient()
        {
            Console.WriteLine("Meat");
        }

        public override void AddTopings()
        {
            Console.WriteLine("Ketchup");
        }
    }
}
