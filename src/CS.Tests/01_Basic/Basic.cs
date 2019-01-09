using System.Collections.Generic;
using CS.Impl._01_Basic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._01_Basic
{
    [TestClass]
    public class Basic
    {
        [TestMethod]
        [Description("Write a program to return Hello and your name in the same line. Expected output : Hello Jounad Tourvieille")]
        public void HelloYou()
        {
            // Arrange
            var subject = new HelloYou();

            // Act
            var actual = subject.SayHello();

            // Assert
            Assert.AreEqual("Hello Jounad Tourvieille", actual);
        }

        [TestMethod]
        [Description("Write a program to return the sum of two numbers. Expected output when input is 5 + 10: 15")]
        public void SumOfTwoNumbers()
        {
            // Arrange
            var subject = new Math();

            // Act
            var actual = subject.Sum(5, 10);

            // Assert
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        [Description("Write a program to return the result of dividing two numbers. Expected output when input is 10 / 2: 5")]
        public void DivideTwoNumbers()
        {
            // Arrange
            var subject = new Math();

            // Act
            var actual = subject.Divide(10, 2);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        [Description("Write a program to compute the sum of all the elements of an array of integers. Expected output when input is [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]: 69")]
        public void SumTable()
        {
            // Arrange
            var integersTable = new List<int> { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            var subject = new Math();

            // Act
            var actual = subject.SumTable(integersTable);

            // Assert
            Assert.AreEqual(69, actual);
        }

        [TestMethod]
        [Description("Write a program to reverse the words of a sentence. Expected output when input is Hi there how are you: you are how there Hi")]
        public void ReverseSentence()
        {
            // Arrange
            var subject = new Sentence();

            // Act
            var actual = subject.Reverse("Hi there how are you");

            // Assert
            Assert.AreEqual("you are how there Hi", actual);
        }
    }
}
