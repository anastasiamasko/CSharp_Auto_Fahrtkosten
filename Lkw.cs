using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    sealed class Lkw:Auto
    {
        private int anzahlAchsen;
        public Lkw(string model, double verbrauch, double tankinhalt, int anzahlAchsen)
           : base(model, verbrauch, tankinhalt)
        {
            this.anzahlAchsen = anzahlAchsen;
        }

        public Lkw(string model, double verbrauch, double tankinhalt)
          : base(model, verbrauch, tankinhalt)
        {
            this.anzahlAchsen = 2;
        }

        public new void Fahren(int km, bool autobahn)
        {
            base.Fahren(km, autobahn);

            if (autobahn==true)
            {
                switch (anzahlAchsen)
                {
                    case 2:fahrtkosten += km * 0.13; break;
                    case 3:fahrtkosten += km * 0.21; break;
                    default: fahrtkosten += km * 0.312; break;
                }
            }

        }

        public override void Tuev()
        {
            Console.WriteLine($"Das LKW_Model {model} war beim TüV");
        }



    }
}
