﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KorotkovNS.Sprint1.Task1.V0.Lib
{
    public class DataService : ISprint1Task1V0
    {
        public double Calculate(double x, double y)
        {
            return x / (1 - y);
        }
    }
}
