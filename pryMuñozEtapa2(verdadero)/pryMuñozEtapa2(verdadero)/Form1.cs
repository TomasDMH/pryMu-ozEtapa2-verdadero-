using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMuñozEtapa2_verdadero_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculo Auto = new Vehiculo();
            pctAuto.Image = Auto.ImagenAuto;
            Vehiculo Barco = new Vehiculo();
            pctBarco.Image = Barco.ImagenBarco;
            Vehiculo Avion = new Vehiculo();
            pctAvion.Image = Avion.ImagenAvion;
        }
    }
}
