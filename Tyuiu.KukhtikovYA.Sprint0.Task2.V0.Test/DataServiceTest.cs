using Tyuiu.KukhtikovYA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KukhtikovYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            string name = "Ярослав";
            string res = DataService.GetMessage(name);
            
            Assert.AreEqual("Привет, Ярослав", res);
        }
    }
}