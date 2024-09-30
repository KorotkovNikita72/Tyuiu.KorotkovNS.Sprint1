using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KorotkovNS.Sprint1.Task4.V30.Lib
{
    public class DataService : ISprint1Task4V30
    {
        public double Calculate(double x, double y)
        {
            var res = (x + Math.Pow(y, 3)) / (Math.Exp(x - y));
            return res;
        }
    }
}
