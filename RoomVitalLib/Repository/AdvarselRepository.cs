using RoomVitalLib.Interface;
using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Repository
{
    public class AdvarselRepository : IAdvarselRepository
    {
        public int MinTemp {  get; set; } = 0;
        public int MaxTemp { get; set; } = 100;

        private readonly List<Advarsel> _advarselList = new List<Advarsel>();

        public Advarsel CheckTemp(int currentTemp)
        {
            if(currentTemp < MinTemp || currentTemp > MaxTemp)
            { 
                return new Advarsel(DateTime.Now, currentTemp, 0, 0);
            }
            return null;
        }

        public Advarsel create(Advarsel advarsel)
        {
           _advarselList.Add(advarsel);
           return advarsel;
        }

        public List<Advarsel> GetAdvarsel()
        {
            return new List<Advarsel>(_advarselList);
        }

        public void SetTemperatur(int min, int max)
        {
            if(min <= max)
            {
                MinTemp = min;
                MaxTemp = max;
            }
        }
    }
}
