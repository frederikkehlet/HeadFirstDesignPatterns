using Interfaces;

namespace Domain
{
    public abstract class PizzaStore
    {
        public IPizza? OrderPizza(string type)
        {
            IPizza? pizza = CreatePizza(type);
            
            pizza?.Prepare();
            pizza?.Bake();
            pizza?.Cut();
            pizza?.Box();

            return pizza;
        }
        
        protected abstract IPizza? CreatePizza(string type);          
    }
}