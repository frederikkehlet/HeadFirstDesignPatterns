using Interfaces;

namespace Implementations
{
    public class ChicagoStyleCheesePizza : IPizza
    {
        public void Bake()
        {
            System.Console.WriteLine("Baking Chicago style cheese pizza...");
        }

        public void Box()
        {
            System.Console.WriteLine("Boxing Chicago style cheese pizza...");
        }

        public void Cut()
        {
            System.Console.WriteLine("Cutting Chicago style cheese pizza...");
        }

        public void Prepare()
        {
            System.Console.WriteLine("Preparing Chicago style cheese pizza...");
        }
    }
}