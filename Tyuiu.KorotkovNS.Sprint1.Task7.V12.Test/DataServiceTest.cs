using Tyuiu.KorotkovNS.Sprint1.Task7.V12.Lib;
namespace Tyuiu.KorotkovNS.Sprint1.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 333;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);

        }
    }
}