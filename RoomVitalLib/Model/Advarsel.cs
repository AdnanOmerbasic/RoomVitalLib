using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model
{
    public class Advarsel: Sensor
    {
        public DateTime Dato { get; set; }

        public Advarsel(DateTime dato, int temperatur, int luftfugtighed, int luftkvalitet)
            :base(temperatur, luftfugtighed, luftkvalitet)
        {
            Dato = dato;
        }

        public override string ToString()
        {
            return $"{{{nameof(Dato)}={Dato.ToString()}, {nameof(Temperatur)}={Temperatur.ToString()}, {nameof(Luftfugtighed)}={Luftfugtighed.ToString()}, {nameof(Luftkvalitet)}={Luftkvalitet.ToString()}}}";
        }
    }
}
