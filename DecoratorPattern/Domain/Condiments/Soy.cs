namespace Domain.Condiments
{
    public class Soy : ICondimentDecorator
    {
        IBeverage beverage;

        public Soy(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double GetCost()
        {
            return beverage.GetCost() + .15;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}