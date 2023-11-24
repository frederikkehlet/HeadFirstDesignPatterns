namespace Domain.Beverages 
{
    public class DarkRoast : IBeverage
    {
        public double GetCost()
        {
            return .99;
        }

        public string GetDescription()
        {
            return "Dark Roast Coffee";
        }
    }
}