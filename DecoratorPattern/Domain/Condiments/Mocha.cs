namespace Domain.Condiments 
{
    public class Mocha : ICondimentDecorator
    {
        IBeverage beverage;

        public Mocha(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public double GetCost()
        {
            return beverage.GetCost() + .20;
        }

        public string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}