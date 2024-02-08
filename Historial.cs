using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using libreriaSqL_;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace reloj
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] {
        "Mameitor 2020 color negro con luces azules",
        "Ford-mustang 2015 color Naranja",
        "Kia 2013 color azul"
        }
            
          );



        }




        private void button3_Click(object sender, EventArgs e)
        {
            Libros cadena = new Libros();
            
            DateTime fecha_de_salida = dtpsalida.Value;
            DateTime fecha_de_entrega = dtpentrega.Value;

     
            DataTable tablaFiltrada = cadena.FiltrarPorFechas(fecha_de_salida, fecha_de_entrega);

            dataGridView1.DataSource = tablaFiltrada;

           
            decimal suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += Convert.ToDecimal(fila.Cells["monto"].Value);
            }

            // Mostrar la suma en la caja de texto
            txtSuma.Text = suma.ToString();



        }

        private void btnCG_Click(object sender, EventArgs e)
        {
            Libros abrir=new Libros();
        
            DataTable tablaDatos = abrir.ObtenerDatos();

           
            dataGridView1.DataSource = tablaDatos;

            // Calcular la suma
            decimal suma = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                suma += Convert.ToDecimal(fila.Cells["monto"].Value);
            }
            txtSuma.Text = suma.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Libros valor = new Libros();
            // Obtener el valor seleccionado del ComboBox
           // string valorSeleccionado = comboBox1.SelectedItem.ToString();

            dataGridView1.DataSource = valor.FiltrarPorCarro(comboBox1.Text);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la fila seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(row);
                }
            }
        }

   
    }
}
