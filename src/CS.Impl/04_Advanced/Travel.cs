using System.Collections.Generic;

namespace CS.Impl._04_Advanced
{
    public class Travel
    {
        public TravelRoadmap BuildTravelRoadmap(City initial, City destination)
        {
            var distanceHelper = new DistanceHelper();

            var distance = distanceHelper.GetDistance(initial, destination);

            switch (distance)
            {
                case Distance.Short:
                    return new TravelRoadmap
                    {
                        Modes = new List<TransportMode> { TransportMode.Foot, TransportMode.Car, TransportMode.Train }
                    };
                case Distance.Medium:
                    return new TravelRoadmap
                    {
                        Modes = new List<TransportMode> { TransportMode.Car, TransportMode.Train, TransportMode.Plane }
                    };
                case Distance.Long:
                    return new TravelRoadmap
                    {
                        Modes = new List<TransportMode> { TransportMode.Boat, TransportMode.Plane }
                    };
            }

            return null;
        }
    }

    public class TravelRoadmap
    {
        public IEnumerable<TransportMode> Modes { get; set; }
    }

    public enum City
    {
        Barcelona,
        London,
        Sydney
    }

    public enum TransportMode
    {
        Foot,
        Car,
        Train,
        Boat,
        Plane
    }

    public class DistanceHelper
    {
        public Distance GetDistance(City initial, City destination)
        {
            if (initial == destination)
            {
                return Distance.Short;
            }

            if (initial == City.Barcelona && destination == City.London ||
                initial == City.London && destination == City.Barcelona)
            {
                return Distance.Medium;
            }

            return Distance.Long;
        }
    }

    public enum Distance
    {
        Short,
        Medium,
        Long
    }
}