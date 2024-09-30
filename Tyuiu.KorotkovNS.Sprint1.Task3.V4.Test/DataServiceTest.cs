using Tyuiu.KorotkovNS.Sprint1.Task3.V4.Lib;
namespace Tyuiu.KorotkovNS.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int quantity = 7;
            double wait = 22.75;
            var res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Assert.AreEqual(wait, res);
        }
    }
}