using Tyuiu.KrasnovaYA.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KrasnovaYA.Sprint0.Task4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]

        public void CheckedSubstractinValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        [TestMethod]

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}