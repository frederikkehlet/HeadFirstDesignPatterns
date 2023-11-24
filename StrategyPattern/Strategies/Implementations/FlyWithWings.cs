using Strategies.Interfaces;

namespace Strategies.Implementations {
    public class FlyWithWings : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying like a mallard duck!");
        }
    }
}

