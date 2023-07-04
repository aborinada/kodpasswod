using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PasswordTests
    {
        [TestMethod]
        public void Digit()
        {
            //Arrange
            string password = "qwertyQ#123";
            bool expected = true;

            //Act
            bool actual = Password.Digit(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Digit1()
        {
            //Arrange
            string password = "$#%@!";
            bool expected = false;

            //Act
            bool actual = Password.Digit(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
