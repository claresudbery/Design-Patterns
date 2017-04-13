namespace Domain.StrategyPatterns
{
    public interface IShippingStrategy
    {
        double Calculate(Order order);
    }
}