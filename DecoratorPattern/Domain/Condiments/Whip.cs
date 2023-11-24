namespace Domain.Condiments 
{
    public class Whip : ICondimentDecorator
    {
        IBeverage beverage;

        public Whip(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double GetCost()
        {
            return beverage.GetCost() + .10;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}