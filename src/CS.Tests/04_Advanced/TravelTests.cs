using System.Linq;
using CS.Impl._04_Advanced;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS.Tests._04_Advanced
{
    [TestClass]
    public class TravelTests
    {
        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnShortDistanceFromAndToBarcelona()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.Barcelona, City.Barcelona);
            
            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnShortDistanceFromAndToSydney()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.Sydney, City.Sydney);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnShortDistanceFromAndToLondon()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.London, City.London);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnMediumDistanceFromBarcelonaToLondon()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.Barcelona, City.London);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnMediumDistanceFromLondonToBarcelona()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.London, City.Barcelona);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnLongDistanceFromBarcelonaToSydney()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.Barcelona, City.Sydney);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void UseAppropriateMode_When_TravellingOnLongDistanceFromSydneyToBarcelona()
        {
            // Arrange
            var subject = new Travel();

            // Act
            var travelRoadmap = subject.BuildTravelRoadmap(City.Sydney, City.London);

            // Assert
            Assert.IsNotNull(travelRoadmap);
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Foot));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Car));
            Assert.IsFalse(travelRoadmap.Modes.Contains(TransportMode.Train));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Boat));
            Assert.IsTrue(travelRoadmap.Modes.Contains(TransportMode.Plane));
        }

        [TestMethod]
        public void SetupTheRightDistanceWhenCitiesAreAtShortDistance()
        {
            // Arrange
            var distanceHelper = new DistanceHelper();

            // Act
            var barcelonaDistance = distanceHelper.GetDistance(City.Barcelona, City.Barcelona);
            var sydneyDistance = distanceHelper.GetDistance(City.Sydney, City.Sydney);
            var londonDistance = distanceHelper.GetDistance(City.London, City.London);

            // Assert
            Assert.AreEqual(Distance.Short, barcelonaDistance);
            Assert.AreEqual(Distance.Short, sydneyDistance);
            Assert.AreEqual(Distance.Short, londonDistance);
        }

        [TestMethod]
        public void SetupTheRightDistanceWhenCitiesAreAtMediumDistance()
        {
            // Arrange
            var distanceHelper = new DistanceHelper();

            // Act
            var distance1 = distanceHelper.GetDistance(City.Barcelona, City.London);
            var distance2 = distanceHelper.GetDistance(City.London, City.Barcelona);

            // Assert
            Assert.AreEqual(Distance.Medium, distance1);
            Assert.AreEqual(Distance.Medium, distance2);
        }

        [TestMethod]
        public void SetupTheRightDistanceWhenCitiesAreAtLongDistance()
        {
            // Arrange
            var distanceHelper = new DistanceHelper();

            // Act
            var distance1 = distanceHelper.GetDistance(City.Sydney, City.Barcelona);
            var distance2 = distanceHelper.GetDistance(City.Barcelona, City.Sydney);
            var distance3 = distanceHelper.GetDistance(City.London, City.Sydney);
            var distance4 = distanceHelper.GetDistance(City.Sydney, City.London);

            // Assert
            Assert.AreEqual(Distance.Long, distance1);
            Assert.AreEqual(Distance.Long, distance2);
            Assert.AreEqual(Distance.Long, distance3);
            Assert.AreEqual(Distance.Long, distance4);
        }
    }
}
