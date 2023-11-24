using Strategies.Interfaces;

namespace  Strategies.Implementations {
    public class Squeak : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squeeeeak!");
        }
    }
}