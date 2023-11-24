using Strategies.Interfaces;

namespace  Strategies.Implementations {
    public class FlyNoWay : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Rubberducks don't fly!");
        }
    }
}

