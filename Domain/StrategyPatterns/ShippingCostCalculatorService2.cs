using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.StrategyPatterns
{
    public class ShippingCostCalculatorService2
    {
        public double CalculateShippingCost(Order order, Func<Order, double> shippingCostStrategy)
        {
            return shippingCostStrategy(order);
        }
    }
}
