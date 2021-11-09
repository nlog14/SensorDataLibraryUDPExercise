using System;

namespace SensorDataLibraryUDPExercise
{
    public class SensorData
    {
        public int Id { get; set; } 
        public string SensorName { get; set; }
        public int Speed { get; set; }
        public DateTime TimeStamp { get; set; }

        

        public SensorData(int id, string sensorName, int speed, DateTime timeStamp)
        {
            Id = id;
            SensorName = sensorName;
            Speed = speed;
            TimeStamp = timeStamp;

        }

    }
}
