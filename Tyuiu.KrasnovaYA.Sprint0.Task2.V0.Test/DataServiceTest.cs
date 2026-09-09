using Tyuiu.KrasnovaYA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KrasnovaYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Яна";
            var res = DataServise.GetMessage(name);

            Assert.AreEqual("Привет, Яна", res);
        }
    }
}
