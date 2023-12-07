using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model
{
    public class Sensor
    {
        public int Temperatur { get; set; }
        public int Luftfugtighed { get; set; }
        public int Luftkvalitet { get; set; }

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
