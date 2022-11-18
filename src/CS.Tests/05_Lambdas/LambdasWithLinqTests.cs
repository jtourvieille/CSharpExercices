using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using static CS.Impl._05_Lambdas.LambdasWithLinq;

namespace CS.Tests._05_Lambdas
{
    [TestClass]
    public class LambdasWithLinqTests
    {
        [TestMethod]
        public void TestGetMoyenneDesPrixDesChaisesA4PeidsParMateriaux()
        {
            // Arrange
            var chaises = new List<Chaise>()
            {
                new Chaise { Materiaux = Materiaux.Bois, Pieds = 4, Prix = 100},
                new Chaise { Materiaux = Materiaux.Bois, Pieds = 4, Prix = 200},
                new Chaise { Materiaux = Materiaux.Plastique, Pieds = 4, Prix = 300},
                new Chaise { Materiaux = Materiaux.Plastique, Pieds = 3, Prix = 400},
                new Chaise { Materiaux = Materiaux.Plastique, Pieds = 3, Prix = 500},
                new Chaise { Materiaux = Materiaux.Metal, Pieds = 4, Prix = 600},
            };

            var expected = new Dictionary<Materiaux, int>()
            {
                {Materiaux.Bois, 150 },
                {Materiaux.Plastique, 300 },
                {Materiaux.Metal, 600 },
            };
            // Act

            var result = GetMoyenneDesPrixDesChaisesA4PeidsParMateriaux(chaises);

            // Assert
            foreach (var materiaux in Enum.GetValues(typeof(Materiaux)) as IEnumerable<Materiaux>)
            {
                Assert.AreEqual(expected[materiaux], result[materiaux]);
            }
        }
    }
}
