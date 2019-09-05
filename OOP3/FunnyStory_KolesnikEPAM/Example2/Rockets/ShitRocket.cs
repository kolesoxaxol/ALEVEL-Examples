using Example2.Engine;

namespace Example2.Rockets
{
    class ShitRocket
    {
        public RocketHeader Header { get; set; }  // головная часть
        public ShitEngine Engine { get; set; }  // двигатель

        public int Weight
        {
            get
            {
                return Header.GetWeight() + Engine.Weight; // масса головной части + масса движка + масса космонавтов
            }
        }
    }
}
