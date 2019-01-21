using System;
using CS.Impl._04_Advanced;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._04_Advanced
{
    [TestClass]
    public class SingletonTests
    {
        [TestMethod]
        public void GetTheSameInstanceOfSimpleSingleton()
        {
            // Arrange & act
            var myObject1 = new object();
            var myObject2 = new object();
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;

            // Assert
            Assert.AreNotEqual(myObject1.GetHashCode(), myObject2.GetHashCode());
            Assert.AreEqual(singleton2.GetHashCode(), singleton1.GetHashCode());
        }

        [TestMethod]
        public void GetTheSameInstanceOfSingletonUsingIoC()
        {
            // Arrange
            using (var serviceProvider = new ServiceCollection().AddSingleton<IMySingleton, MySingleton>().BuildServiceProvider())
            {
                // Act
                var singleton1 = serviceProvider.GetService<IMySingleton>();
                var singleton2 = serviceProvider.GetService<IMySingleton>();

                // Assert
                Assert.AreEqual(singleton2.GetHashCode(), singleton1.GetHashCode());
            }
        }
    }
}
