using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AvaevaPD.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AvaevaPD.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Полина";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Полина", res);
        }
    }
}
