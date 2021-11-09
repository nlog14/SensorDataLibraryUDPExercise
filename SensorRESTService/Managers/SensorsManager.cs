using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorDataLibraryUDPExercise;

namespace SensorRESTService.Managers
{
    public class SensorsManager
    {
        private static int nextID = 1;

        public static readonly List<SensorData> Data = new List<SensorData>()
        {
            new SensorData(nextID++, "Nohely", 100, DateTime.Now),
            new SensorData(nextID++, "Amethyst", 90, DateTime.Now)

        };
        public IEnumerable<SensorData> GetAll()
        {
            return Data;
        }

        public SensorData Create(SensorData newSensorData)
        {
            newSensorData.Id = nextID++;
            Data.Add(newSensorData);
            return newSensorData;
        }

    }
}
