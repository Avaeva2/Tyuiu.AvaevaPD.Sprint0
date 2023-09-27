using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AvaevaPD.Sprint0.Task4.V0.Lib;
namespace Tyuiu.AvaevaPD.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5)); //сумма
        }
        [TestMethod]
        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5)); //вычитание
        }
        [TestMethod]
        public void CheckedMultiolicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5)); //умножениие
        }
        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3)); //деление
        }
    }


}
