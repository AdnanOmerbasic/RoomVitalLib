using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomVitalLib.Model
{
    public class Bruger
    {

        public string BrugerNavn { get; set; }
        public string Password { get; set; }


        public Bruger(string brugerNavn, string password)
        {
            BrugerNavn = brugerNavn;
            Password = password;
        }

        public override string ToString()
        {
            return $"{{{nameof(BrugerNavn)}={BrugerNavn}, {nameof(Password)}={Password}}}";
        }
    }
}
