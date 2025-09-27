using Tyuiu.AytuvarovTK.Sprint1.Task7.V3.Lib;

namespace Tyuiu.AytuvarovTK.Sprint1.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double z = 0.478;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(z, res);
        }
    }
}
