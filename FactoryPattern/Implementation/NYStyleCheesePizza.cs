using Interfaces;

namespace Implementations
{
    public class NYStyleCheesePizza : IPizza
    {
        public void Bake()
        {
            System.Console.WriteLine("Baking NY style cheese pizza...");
        }

        public void Box()
        {
            System.Console.WriteLine("Boxing NY style cheese pizza...");
        }

        public void Cut()
        {
            System.Console.WriteLine("Cutting NY style cheese pizza...");
        }

        public void Prepare()
        {
            System.Console.WriteLine("Preparing NY style cheese pizza...");
        }
    }
}