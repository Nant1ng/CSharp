﻿namespace StrategyCalculator.MathOperations
{
    public class Subtraction : IStrategy
    {
        public int Execute(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }
    }
}
