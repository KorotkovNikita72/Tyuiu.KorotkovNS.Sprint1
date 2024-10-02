using Tyuiu.KorotkovNS.Sprint1.Task6.V16.Lib;
namespace Tyuiu.KorotkovNS.Sprint1.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "����� ������� ������? ������ ��������������!";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            Assert.IsTrue(res);
        }
        [TestMethod]
        public void ValidExpression2()
        {
            string strTest = "������� � ���� �������� �����, ��� �����";
            DataService ds = new DataService();
            bool res = ds.CheckSpecSymbols(strTest);
            Assert.IsFalse(res);
        }
    }
}