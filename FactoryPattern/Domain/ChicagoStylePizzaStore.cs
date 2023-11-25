using Implementations;
using Interfaces;

namespace Domain
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override IPizza? CreatePizza(string type)
        {
            IPizza? pizza = null;

            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }
            
            return pizza;
        }
    }
}