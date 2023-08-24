using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    abstract class Auto
    {
        protected string model;
        protected double tankinhalt, verbrauch, fahrtkosten;

       

        public Auto(string model, double verbrauch, double tankinhalt)
        {
            this.model=model;
            this.verbrauch=verbrauch;
            this.tankinhalt=tankinhalt;
            this.fahrtkosten = 0;
        }

        public string Model
        {
            get { return model; }
        }
        public double Fahrtkosten
        {
            get {  return fahrtkosten; }
        }
        
        public void Fahren(int km, bool autobahn)
        {
            double preis = 1.70;
            if (km<=0)
            {
                throw new Exception("Die Kilometer müssen über 0 sein.");
            }
            else
            {
                if(tankinhalt<verbrauch*km/100)
                    throw new Exception("Zu wenig Tankinhalt im Tank!");
                else
                {
                    tankinhalt -= km * verbrauch / 100;
                    fahrtkosten += km * verbrauch / 100 + preis;
                }
            }
        }

        public virtual void Tuev()
        {
            Console.WriteLine("Das Fahrzeug konnte vom TüF nicht zugeordnet werden.");
        }


    }
}
