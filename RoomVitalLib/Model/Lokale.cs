﻿namespace RoomVitalLib.Model
{
    public class Lokale : Sensor
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int AntalPersoner { get; set; }

        public StørrelseType StørrelseType { get; set; }

        public Lokale(int id, string navn, int antalPersoner, StørrelseType størrelseType, int temperatur, int luftfugtighed, int luftkvalitet)
            :base(temperatur,luftfugtighed, luftkvalitet)
        {
            Id = id;
            Navn = navn;
            AntalPersoner = antalPersoner;
            StørrelseType = størrelseType;
        }

        public void ValidereNavn()
        {
            if(Navn == null || Navn.Length < 2)
            {
                throw new ArgumentOutOfRangeException("Lokalets navn skal være minimum 2 tegn: " + Navn);
            }
        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Navn)}={Navn}, {nameof(AntalPersoner)}={AntalPersoner.ToString()}, {nameof(StørrelseType)}={StørrelseType.ToString()}, {nameof(Temperatur)}={Temperatur.ToString()}, {nameof(Luftfugtighed)}={Luftfugtighed.ToString()}, {nameof(Luftkvalitet)}={Luftkvalitet.ToString()}}}";
        }
    }
}