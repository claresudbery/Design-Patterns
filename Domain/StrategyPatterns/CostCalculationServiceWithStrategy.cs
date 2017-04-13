using Domain.FactoryPatterns;

namespace Domain.StrategyPatterns
{
    public class CostCalculationServiceWithStrategy
    {
        private readonly IShippingStrategy _shippingStrategy;

        public CostCalculationServiceWithStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost(Order order)
        {
            return _shippingStrategy.Calculate(order);
        }
    }
}