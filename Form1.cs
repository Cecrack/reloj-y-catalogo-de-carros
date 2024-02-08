using DevExpress.Utils.About;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;    
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using libreriaSqL_;
using DevExpress.XtraDashboardLayout;

namespace reloj
{
    public partial class Form1 : Form
    {
        private Thread clockThread; // hilo del reloj


        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            DateTime horaActual = DateTime.Now;
            // calcular los ángulos de las manecillas del reloj
            float anguloSegundos = horaActual.Second * 6;
            float anguloMinutos = (horaActual.Minute * 6) + (horaActual.Second
           * 0.1f);
            float anguloHoras = (horaActual.Hour * 30) + (horaActual.Minute *
           0.5f);
            // Dibujamos las manecillas del reloj
            int xCentro = pctreloj.Width / 2;
            int yCentro = pctreloj.Height / 2;
            int longitudSegundos = Math.Min(xCentro, yCentro) - 10;
            int longitudMinutos = longitudSegundos - 40;
            int longitudHoras = longitudMinutos - 25;
            int grosorSegundos = 1;
            int grosorMinutos = 3;
            int grosorHoras = 3;
            Pen lapizSegundos = new Pen(Color.Red, grosorSegundos);
            Pen lapizMinutos = new Pen(Color.Black, grosorMinutos);
            Pen lapizHoras = new Pen(Color.Black, grosorHoras);
            e.Graphics.TranslateTransform(xCentro, yCentro);
            e.Graphics.RotateTransform(anguloSegundos);
            e.Graphics.DrawLine(lapizSegundos, 0, 0, 0, -longitudSegundos);
            e.Graphics.RotateTransform(-anguloSegundos);
            e.Graphics.RotateTransform(anguloMinutos);
            e.Graphics.DrawLine(lapizMinutos, 0, 0, 0, -longitudMinutos);
            e.Graphics.RotateTransform(-anguloMinutos);
            e.Graphics.RotateTransform(anguloHoras);
            e.Graphics.DrawLine(lapizHoras, 0, 0, 0, -longitudHoras);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            clockThread.Abort();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {

            Libros objeto = new Libros();
            if (string.IsNullOrEmpty(txtfolio.Text)) // Insertar nuevo registro
            {
                if (objeto.InsertDatos(0, textBox3.Text, textBox4.Text, textBox5.Text, dtpInicial.Value, dtpFinal.Value, lblcaarros.Text, lblTotal.Text))
                {
                    MessageBox.Show("Los datos se han insertado correctamente en la base de datos.");
                    lblFolio.Visible = true;
                    txtfolio.Visible = true;
                    btnBuscar.Visible = true;
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }
                else
                {
                    MessageBox.Show(objeto.Error);
                }
            }
            else // Modificar registro existente
            {
                int folio;
                if (int.TryParse(txtfolio.Text, out folio))
                {
                    if (objeto.InsertDatos(folio, textBox3.Text, textBox4.Text, textBox5.Text, dtpInicial.Value, dtpFinal.Value, lblcaarros.Text, lblTotal.Text))
                    {
                        MessageBox.Show("Los datos se han modificado correctamente en la base de datos.");

                        // Restablecemos los valores originales de la renta
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        dtpInicial.MinDate = DateTime.Now;
                        dtpFinal.MaxDate = DateTime.MaxValue;
                        lblcaarros.Text = "";
                        lblTotal.Text = "";

                        // Cambiamos el texto del botón guardar para que indique que se va a agregar una nueva renta
                        btnGuardar.Text = "Guardar";
                    }
                    else
                    {
                        MessageBox.Show(objeto.Error);
                    }
                }
            }


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
            else
                if (char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }



        private void btnTotal_Click(object sender, EventArgs e)
        {
            calcularDifdDia();
            int total1;
            if (dias <= 0)
            {
                lblTotal.Text = "";
                MessageBox.Show(" no es posible calcularlo ");

            }
            else
            {


                if (lblcaarros.Text == " Mameitor 2020 color negro con luces azules ")
                {
                    total1 = 10000;
                    dias *= total1;
                    lblTotal.Text = "" + dias;
                }
                else if (lblcaarros.Text == " Ford-mustang 2015 color Naranja ")
                {
                    total1 = 500;
                    dias *= total1;
                    lblTotal.Text = "" + dias;
                }
                else if (lblcaarros.Text == " Kia 2013 color azul ")
                {
                    total1 = 300;
                    dias *= total1;
                    lblTotal.Text = "" + dias;
                }
            }



        }



        private void Form1_Load(object sender, EventArgs e)
        {

            // Iniciamos el hilo del reloj al cargar el formulario
            clockThread = new Thread(new ThreadStart(UpdateClock));
            clockThread.Start();
            lblFolio.Visible = false;
            txtfolio.Visible = false;
            btnBuscar.Visible = false;

        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            carros carros = new carros();
            carros.modelos += new carros.pasar(model);
            carros.ShowDialog();
        }
        public void model(string info)
        {
            lblcaarros.Text = info;
        }

        int dias;
        void calcularDifdDia()
        {
            DateTime fechaInicial = dtpInicial.Value.Date;
            DateTime fechaFinal = dtpFinal.Value.Date;

            TimeSpan tspam = fechaFinal - fechaInicial;

            dias = tspam.Days;
            lblTotal.Text = dias.ToString();

        }

        private void UpdateClock()
        {
            while (true)
            {
                pctreloj.Invalidate(); // Invalidamos la imagen para que se repinte
                Thread.Sleep(1000); // Esperamos un segundo antes de volver a dibujar el reloj
            }
        }

        private void pctreloj_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Historial historal = new Historial();
            historal.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Libros consulta = new Libros();
            int folio;
            if (int.TryParse(txtfolio.Text, out folio))
            {
                string cliente, telefono, domicilio, carro, monto;
                DateTime fechaSalida, fechaEntrega;

                if (consulta.ConsultarRenta(folio, out cliente, out telefono, out domicilio, out fechaSalida, out fechaEntrega, out carro, out monto))
                {
                    textBox3.Text = cliente;
                    textBox4.Text = telefono;
                    textBox5.Text = domicilio;
                    dtpInicial.MinDate = fechaSalida;
                    dtpFinal.MinDate = fechaEntrega;
                    lblcaarros.Text = carro;
                    lblTotal.Text = monto;



                    // Habilitamos los campos para poder editar la renta
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    dtpInicial.Enabled = true;
                    dtpFinal.Enabled = true;
                    lblcaarros.Enabled = true;
                    lblcaarros.Enabled = true;
                   

                    // Preguntamos al usuario si desea modificar la renta
                    DialogResult result = MessageBox.Show("¿Desea modificar esta renta?", "Modificar Renta", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Cambiamos el texto del botón guardar para que indique que se va a modificar la renta existente
                        btnGuardar.Text = "Guardar nueva renta";
                        lblFolio.Visible = false;
                        txtfolio.Visible = false;
                        btnBuscar.Visible = false;
                    }
                    else
                    {
                        

                        // Restablecemos los valores originales de la renta
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                        dtpInicial.MinDate = DateTime.Now;
                        dtpFinal.MaxDate = DateTime.MaxValue;
                        lblcaarros.Text = "";
                        lblTotal.Text = "";

                        // Cambiamos el texto del botón guardar para que indique que se va a agregar una nueva renta
                        btnGuardar.Text = "Guardar";
                    }
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna renta con ese número de folio.", "Renta no encontrada");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número de folio válido.", "Folio inválido");
            }


        }

        private void txtfolio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpInicial_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
