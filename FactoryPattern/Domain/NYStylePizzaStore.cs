using Implementations;
using Interfaces;

namespace Domain
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override IPizza? CreatePizza(string type)
        {
            IPizza? pizza = null;

            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }
            
            return pizza;
        }
    }
}