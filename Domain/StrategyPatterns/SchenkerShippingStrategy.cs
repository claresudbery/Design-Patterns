using Domain.FactoryPatterns;

namespace Domain.StrategyPatterns
{
    public class SchenkerShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 3.00d;
        }
    }
}