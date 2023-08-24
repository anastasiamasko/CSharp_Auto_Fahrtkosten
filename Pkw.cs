using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Pkw : Auto
    {
        private bool vignette;

        public Pkw(string model, double verbrauch, double tankinhalt, bool vignette)
            :base (model, verbrauch, tankinhalt)
        {
            this.vignette = vignette;
        }

        public Pkw(string model, double verbrauch, double tankinhalt)
            : base(model, verbrauch, tankinhalt)
        {
            this.vignette = false;
        }

        public new void Fahren (int km, bool autobahn)
        {
            base.Fahren(km, autobahn); 

            if (autobahn== true && vignette==false)
            {
                fahrtkosten += 100;
                vignette = true;
            }
        }

        public override void Tuev()
        {
            Console.WriteLine($"Das PKW_Model {model} war beim TüV");
        }



    }
}
