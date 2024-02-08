namespace reloj
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblRdV = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFdS = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.lblFdE = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblcaarros = new System.Windows.Forms.Label();
            this.dtpInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFinal = new System.Windows.Forms.DateTimePicker();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pctreloj = new System.Windows.Forms.PictureBox();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblFolio = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctreloj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRdV
            // 
            this.lblRdV.AutoSize = true;
            this.lblRdV.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRdV.Location = new System.Drawing.Point(12, 9);
            this.lblRdV.Name = "lblRdV";
            this.lblRdV.Size = new System.Drawing.Size(385, 52);
            this.lblRdV.TabIndex = 1;
            this.lblRdV.Text = "Registro de ventas";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(134, 603);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 26);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 662);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(296, 26);
            this.textBox4.TabIndex = 5;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(160, 724);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(296, 26);
            this.textBox5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monto$:";
            // 
            // lblFdS
            // 
            this.lblFdS.AutoSize = true;
            this.lblFdS.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdS.Location = new System.Drawing.Point(2, 311);
            this.lblFdS.Name = "lblFdS";
            this.lblFdS.Size = new System.Drawing.Size(245, 36);
            this.lblFdS.TabIndex = 9;
            this.lblFdS.Text = "Fecha de salida:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 593);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(122, 36);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(-2, 652);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(142, 36);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefeno:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(2, 714);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(152, 36);
            this.lblDomicilio.TabIndex = 12;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCatalogo.Font = new System.Drawing.Font("Arial", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatalogo.Location = new System.Drawing.Point(8, 96);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(645, 97);
            this.btnCatalogo.TabIndex = 13;
            this.btnCatalogo.Text = "Catalogo de Autos";
            this.btnCatalogo.UseVisualStyleBackColor = false;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // lblFdE
            // 
            this.lblFdE.AutoSize = true;
            this.lblFdE.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFdE.Location = new System.Drawing.Point(2, 358);
            this.lblFdE.Name = "lblFdE";
            this.lblFdE.Size = new System.Drawing.Size(270, 36);
            this.lblFdE.TabIndex = 14;
            this.lblFdE.Text = "Fecha de entrega:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(154, 410);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 41);
            this.lblTotal.TabIndex = 15;
            // 
            // lblcaarros
            // 
            this.lblcaarros.AutoSize = true;
            this.lblcaarros.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaarros.Location = new System.Drawing.Point(31, 212);
            this.lblcaarros.Name = "lblcaarros";
            this.lblcaarros.Size = new System.Drawing.Size(0, 41);
            this.lblcaarros.TabIndex = 18;
            // 
            // dtpInicial
            // 
            this.dtpInicial.Location = new System.Drawing.Point(253, 332);
            this.dtpInicial.MinDate = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            this.dtpInicial.Name = "dtpInicial";
            this.dtpInicial.Size = new System.Drawing.Size(326, 26);
            this.dtpInicial.TabIndex = 19;
            this.dtpInicial.ValueChanged += new System.EventHandler(this.dtpInicial_ValueChanged);
            // 
            // dtpFinal
            // 
            this.dtpFinal.Location = new System.Drawing.Point(278, 368);
            this.dtpFinal.MinDate = new System.DateTime(2023, 5, 3, 0, 0, 0, 0);
            this.dtpFinal.Name = "dtpFinal";
            this.dtpFinal.Size = new System.Drawing.Size(316, 26);
            this.dtpFinal.TabIndex = 20;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(4, 467);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(160, 66);
            this.btnTotal.TabIndex = 21;
            this.btnTotal.Text = "Calcular el total a pagar";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(541, 635);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 80);
            this.btnGuardar.TabIndex = 22;
            this.btnGuardar.Text = "guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 635);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 80);
            this.button1.TabIndex = 25;
            this.button1.Text = "Historial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pctreloj
            // 
            this.pctreloj.Image = ((System.Drawing.Image)(resources.GetObject("pctreloj.Image")));
            this.pctreloj.Location = new System.Drawing.Point(952, 9);
            this.pctreloj.Name = "pctreloj";
            this.pctreloj.Size = new System.Drawing.Size(338, 324);
            this.pctreloj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctreloj.TabIndex = 24;
            this.pctreloj.TabStop = false;
            this.pctreloj.Click += new System.EventHandler(this.pctreloj_Click);
            this.pctreloj.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // txtfolio
            // 
            this.txtfolio.Location = new System.Drawing.Point(101, 546);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(100, 26);
            this.txtfolio.TabIndex = 26;
            this.txtfolio.TextChanged += new System.EventHandler(this.txtfolio_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(12, 536);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(83, 36);
            this.lblFolio.TabIndex = 28;
            this.lblFolio.Text = "Folio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(217, 528);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(84, 44);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1302, 783);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pctreloj);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.dtpFinal);
            this.Controls.Add(this.dtpInicial);
            this.Controls.Add(this.lblcaarros);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFdE);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblFdS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblRdV);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctreloj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRdV;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFdS;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Label lblFdE;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblcaarros;
        private System.Windows.Forms.DateTimePicker dtpInicial;
        private System.Windows.Forms.DateTimePicker dtpFinal;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pctreloj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Button btnBuscar;
    }
}

