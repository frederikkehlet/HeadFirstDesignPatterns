using Strategies.Interfaces;

namespace  Strategies.Implementations {
    public class NormalQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quaaaack!");
        }
    }
}

