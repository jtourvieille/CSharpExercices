using System;
using System.Collections.Generic;
using System.Linq;
using CS.Impl._03_Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._03_Linq
{
    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        [Description("Write a program to find the string which starts and ends with a specific character.")]
        public void StartAndEnsWithSpecificCharacter()
        {
            // Arrange
            var subject = new Linq();

            // Act
            var actual = subject.FindStringsWhichStartsAndEndsWithSpecificCharacter("A", "M",
                new List<string>
                {
                    "ROME",
                    "LONDON",
                    "NAIROBI",
                    "CALIFORNIA",
                    "ZURICH",
                    "NEW DELHI",
                    "AMSTERDAM",
                    "ABU DHABI",
                    "PARIS"
                });

            // Assert
            Assert.AreEqual(1, actual.Count());
            Assert.AreEqual("AMSTERDAM", actual.ElementAt(0));
        }

        [TestMethod]
        [Description("Write a program to create a list of numbers and display the numbers greater than 80 as output. ")]
        public void GreaterThan80()
        {
            // Arrange
            var subject = new Linq();
            var expectedList = new List<int> {200, 740, 230, 482, 95};

            // Act
            var actual = subject.GetGreaterNumbers(80,
                new List<int>
                {
                    55,
                    200,
                    740,
                    76,
                    230,
                    482,
                    95
                });

            // Assert
            Assert.AreEqual(5, actual.Count());
            foreach (var actualNumber in actual)
            {
                Assert.IsTrue(expectedList.Contains(actualNumber));
            }
        }

        [TestMethod]
        [Description("Write a program to display the top n-th records.")]
        public void TopNRecords()
        {
            // Arrange
            var subject = new Linq();
            var expectedList = new List<int> { 24, 13, 9 };

            // Act
            var actual = subject.GetTopNRecords(3,
                new List<int>
                {
                    5,
                    7,
                    13,
                    24,
                    6,
                    9,
                    8,
                    7
                });

            // Assert
            Assert.AreEqual(3, actual.Count());
            foreach (var actualNumber in actual)
            {
                Assert.IsTrue(expectedList.Contains(actualNumber));
            }
        }

        [TestMethod]
        [Description("Write a program to Count File Extensions and Group it using LINQ.")]
        public void FileCountByExtension()
        {
            // Arrange
            var subject = new Linq();
            var expectedList = new Dictionary<string, int>
            {
                { "frx", 1 },
                { "txt", 3 },
                { "dbf", 1},
                { "pdf", 2},
                { "frt", 1},
                { "xml", 1}
            };

            // Act
            var actual = subject.GetFileCountByExtension(
                new List<string>
                {
                    "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf",
                    "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt"
                });

            // Assert
            Assert.AreEqual(6, actual.Count);
            foreach (var actualFc in actual)
            {
                Assert.IsTrue(expectedList.Contains(actualFc));
            }
        }

        [TestMethod]
        [Description("Write a program to display a receipe using LINQ.")]
        public void DisplayReceipe()
        {
            // Arrange
            var items = new List<Item>
            {
                new Item {Id = 1, Label = "Phone", Price = 249},
                new Item {Id = 2, Label = "Computer", Price = 999},
                new Item {Id = 3, Label = "TV", Price = 799}
            };

            var clients = new List<Client>
            {
                new Client {Id = 1, Name = "Bob"},
                new Client {Id = 2, Name = "Leïa"}
            };

            var purchases = new List<Purchase>
            {
                new Purchase {ItemId = 1, ClientId = 1, Quantity = 2},
                new Purchase {ItemId = 2, ClientId = 1, Quantity = 1},
                new Purchase {ItemId = 1, ClientId = 2, Quantity = 1},
                new Purchase {ItemId = 2, ClientId = 2, Quantity = 2},
                new Purchase {ItemId = 3, ClientId = 2, Quantity = 3},
            };

            var expected = new List<Tuple<string, string, int, double>>
            {
                new Tuple<string, string, int, double>("Bob", "Phone", 2, 249),
                new Tuple<string, string, int, double>("Bob", "Computer", 1, 999),
                new Tuple<string, string, int, double>("Leïa", "Phone", 1, 249),
                new Tuple<string, string, int, double>("Leïa", "Computer", 2, 999),
                new Tuple<string, string, int, double>("Leïa", "TV", 3, 799)
            };

            // Act
            var subject = new Linq();
            var finalReceipe = subject.GetFinalReceipe(items, clients, purchases).ToList();

            // Assert
            Assert.AreEqual(expected.Count, finalReceipe.Count);

            foreach (var actualReceipeLine in finalReceipe)
            {
                Assert.IsTrue(expected.Exists(x =>
                    x.Item1 == actualReceipeLine.Item1 && x.Item2 == actualReceipeLine.Item2 &&
                    x.Item3 == actualReceipeLine.Item3 && x.Item4 == actualReceipeLine.Item4));
            }
        }
    }
}
