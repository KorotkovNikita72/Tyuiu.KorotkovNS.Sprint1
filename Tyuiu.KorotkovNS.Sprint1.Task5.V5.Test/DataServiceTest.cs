using Tyuiu.KorotkovNS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.KorotkovNS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 5;
            Assert.AreEqual(wait, result);
        }
    }
}