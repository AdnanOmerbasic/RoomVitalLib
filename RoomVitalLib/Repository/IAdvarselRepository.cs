using RoomVitalLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Interface
{
    public interface IAdvarselRepository
    {
        public Advarsel create(Advarsel advarsel);
        public List<Advarsel> GetAdvarsel();

        public Advarsel CheckTemp(int currentTemp);

        public void SetTemperatur(int min, int max);
    }
}
