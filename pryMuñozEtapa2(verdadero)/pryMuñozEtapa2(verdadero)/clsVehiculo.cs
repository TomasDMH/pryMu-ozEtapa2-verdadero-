using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace pryMuñozEtapa2_verdadero_
{
    public class Vehiculo
    {
        public string Auto { get; set; }
        public Image ImagenAuto { get; set; }
        public string Avion { get; set; }
        public Image ImagenAvion { get; set; }
        public string Barco { get; set; }
        public Image ImagenBarco { get; set; }

        public Vehiculo()
        {
            ImagenAuto = Properties.Resources.auto1;
            ImagenAvion = Properties.Resources.avion1;
            ImagenBarco = Properties.Resources.barco1;
        }
    }

}
