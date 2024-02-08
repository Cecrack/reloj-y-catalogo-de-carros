using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reloj
{
    public partial class carros : Form
    {
        public carros()
        {
            InitializeComponent();
        }

        public delegate void pasar(string info);
        public event pasar modelos; 

        private void btnSeleccionarMameitor_Click(object sender, EventArgs e)
        {
            modelos(" Mameitor 2020 color negro con luces azules ");
            this.Dispose();
        }

        private void btnSeleccionarFord_Click(object sender, EventArgs e)
        {
            modelos(" Ford-mustang 2015 color Naranja ");
            this.Dispose();
        }

        private void btnSeleccionarKia_Click(object sender, EventArgs e)
        {
            modelos(" Kia 2013 color azul ");
            this.Dispose();
        }

    }
}
