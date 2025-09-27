using Tyuiu.AytuvarovTK.Sprint1.Task6.V15.Lib;

namespace Tyuiu.AytuvarovTK.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string strT = "Привет, как дела?";
            DataService ds = new DataService();
            bool res = ds.CheckLettersCount(strT);
            bool wait = true;  
            Assert.AreEqual(wait, res);
        }
    }
}
