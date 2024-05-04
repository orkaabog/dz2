using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LocationData
    {
        public DateTime CreatedAt { get; private set; }
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }

        public LocationData(double latitude, double longitude)
        {
            CreatedAt = DateTime.Now;
            Latitude = latitude;
            Longitude = longitude;
        }
    }

    public class PathManager
    {
        private List<LocationData> locations;

        public PathManager()
        {
            locations = new List<LocationData>();
        }

        public void AddLocation(LocationData location)
        {
            locations.Add(location);
        }

        public void RemoveLocation(LocationData location)
        {
            locations.Remove(location);
        }
    }
}
