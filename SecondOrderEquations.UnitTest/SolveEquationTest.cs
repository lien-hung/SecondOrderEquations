using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SecondOrderEquations.UnitTest
{
    [TestClass]
    public class SolveEquationTests
    {
        [TestMethod]
        [DataRow("2", "abc", "-3", "Vui lòng nhập lại các hệ số.")]
        [DataRow("0", "-8", "4", "Hệ số a = 0 không thể giải.")]
        [DataRow("1", "5", "10", "Phương trình vô nghiệm.")]
        [DataRow("1", "4", "4", "Phương trình có nghiệm kép x = -2")]
        [DataRow("1", "-6", "5", "Phương trình có hai nghiệm phân biệt x1 = 5; x2 = 1")]
        public void SolveEquationTest(string strA, string strB, string strC, string expected)
        {
            // Act
            MainForm main = new MainForm();
            string actual = main.SolveEquation(strA, strB, strC);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
