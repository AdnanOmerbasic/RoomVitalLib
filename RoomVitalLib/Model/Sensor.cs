using RoomVitalLib.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model
{
    public class Sensor
    {
        public int Temperatur { get; }
        public int Luftfugtighed { get; }
        public int Luftkvalitet { get; }

        public Sensor(int temperatur, int luftfugtighed, int luftkvalitet)
        {
            Temperatur = temperatur;
            Luftfugtighed = luftfugtighed;
            Luftkvalitet = luftkvalitet;
        }

        public override string ToString()
        {
            return $"{{{nameof(Temperatur)}={Temperatur.ToString()}, {nameof(Luftfugtighed)}={Luftfugtighed.ToString()}, {nameof(Luftkvalitet)}={Luftkvalitet.ToString()}}}";
        }
    }
}
