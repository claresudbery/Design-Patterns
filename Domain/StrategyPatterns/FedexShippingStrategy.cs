﻿using Domain.FactoryPatterns;

namespace Domain.StrategyPatterns
{
    public class FedexShippingStrategy : IShippingStrategy
    {
        public double Calculate(Order order)
        {
            return 5.00d;
        }
    }
}