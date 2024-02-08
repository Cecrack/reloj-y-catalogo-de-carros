namespace reloj
{
    partial class Historial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpsalida = new System.Windows.Forms.DateTimePicker();
            this.dtpentrega = new System.Windows.Forms.DateTimePicker();
            this.btnCG = new System.Windows.Forms.Button();
            this.txtSuma = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(0, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1379, 575);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 75);
            this.button3.TabIndex = 3;
            this.button3.Text = "consultar por fechas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(476, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(371, 28);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpsalida
            // 
            this.dtpsalida.Location = new System.Drawing.Point(214, 122);
            this.dtpsalida.Name = "dtpsalida";
            this.dtpsalida.Size = new System.Drawing.Size(200, 26);
            this.dtpsalida.TabIndex = 5;
            // 
            // dtpentrega
            // 
            this.dtpentrega.Location = new System.Drawing.Point(214, 154);
            this.dtpentrega.Name = "dtpentrega";
            this.dtpentrega.Size = new System.Drawing.Size(200, 26);
            this.dtpentrega.TabIndex = 6;
            this.dtpentrega.Value = new System.DateTime(2023, 5, 7, 0, 18, 0, 0);
            // 
            // btnCG
            // 
            this.btnCG.Location = new System.Drawing.Point(56, 21);
            this.btnCG.Name = "btnCG";
            this.btnCG.Size = new System.Drawing.Size(112, 75);
            this.btnCG.TabIndex = 7;
            this.btnCG.Text = "Consulta general";
            this.btnCG.UseVisualStyleBackColor = true;
            this.btnCG.Click += new System.EventHandler(this.btnCG_Click);
            // 
            // txtSuma
            // 
            this.txtSuma.Location = new System.Drawing.Point(582, 154);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 26);
            this.txtSuma.TabIndex = 8;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 844);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.btnCG);
            this.Controls.Add(this.dtpentrega);
            this.Controls.Add(this.dtpsalida);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpsalida;
        private System.Windows.Forms.DateTimePicker dtpentrega;
        private System.Windows.Forms.Button btnCG;
        private System.Windows.Forms.TextBox txtSuma;
    }
}