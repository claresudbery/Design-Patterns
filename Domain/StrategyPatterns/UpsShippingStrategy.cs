using Domain.FactoryPatterns;

namespace Domain.StrategyPatterns
{
    public class UpsShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 4.25d;
        }
    }
}