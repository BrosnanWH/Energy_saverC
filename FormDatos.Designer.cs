namespace calculadora_energia
{
    partial class FormDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            this.numericPotencia = new System.Windows.Forms.NumericUpDown();
            this.numericHoras = new System.Windows.Forms.NumericUpDown();
            this.numericMinutos = new System.Windows.Forms.NumericUpDown();
            this.numericDias = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPotencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad (0 - 10) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Potencia en Watts :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horas :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Minutos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dias :";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnAceptar.Location = new System.Drawing.Point(100, 213);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "OK!";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numericCantidad
            // 
            this.numericCantidad.BackColor = System.Drawing.Color.BurlyWood;
            this.numericCantidad.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericCantidad.Location = new System.Drawing.Point(191, 53);
            this.numericCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.numericCantidad.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(72, 23);
            this.numericCantidad.TabIndex = 6;
            this.numericCantidad.ValueChanged += new System.EventHandler(this.numericCantidad_ValueChanged);
            // 
            // numericPotencia
            // 
            this.numericPotencia.BackColor = System.Drawing.Color.BurlyWood;
            this.numericPotencia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericPotencia.Location = new System.Drawing.Point(191, 89);
            this.numericPotencia.Margin = new System.Windows.Forms.Padding(2);
            this.numericPotencia.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.numericPotencia.Name = "numericPotencia";
            this.numericPotencia.Size = new System.Drawing.Size(72, 23);
            this.numericPotencia.TabIndex = 7;
            // 
            // numericHoras
            // 
            this.numericHoras.BackColor = System.Drawing.Color.BurlyWood;
            this.numericHoras.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericHoras.Location = new System.Drawing.Point(191, 120);
            this.numericHoras.Margin = new System.Windows.Forms.Padding(2);
            this.numericHoras.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericHoras.Name = "numericHoras";
            this.numericHoras.Size = new System.Drawing.Size(72, 23);
            this.numericHoras.TabIndex = 8;
            // 
            // numericMinutos
            // 
            this.numericMinutos.BackColor = System.Drawing.Color.BurlyWood;
            this.numericMinutos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericMinutos.Location = new System.Drawing.Point(191, 151);
            this.numericMinutos.Margin = new System.Windows.Forms.Padding(2);
            this.numericMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericMinutos.Name = "numericMinutos";
            this.numericMinutos.Size = new System.Drawing.Size(72, 23);
            this.numericMinutos.TabIndex = 9;
            // 
            // numericDias
            // 
            this.numericDias.BackColor = System.Drawing.Color.BurlyWood;
            this.numericDias.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericDias.Location = new System.Drawing.Point(191, 182);
            this.numericDias.Margin = new System.Windows.Forms.Padding(2);
            this.numericDias.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numericDias.Name = "numericDias";
            this.numericDias.Size = new System.Drawing.Size(72, 23);
            this.numericDias.TabIndex = 10;
            this.numericDias.ValueChanged += new System.EventHandler(this.numericDias_ValueChanged);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculadora_energia.Properties.Resources.logo_icon;
            this.ClientSize = new System.Drawing.Size(277, 256);
            this.Controls.Add(this.numericDias);
            this.Controls.Add(this.numericMinutos);
            this.Controls.Add(this.numericHoras);
            this.Controls.Add(this.numericPotencia);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Values";
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPotencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericHoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinutos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown numericCantidad;
        private System.Windows.Forms.NumericUpDown numericPotencia;
        private System.Windows.Forms.NumericUpDown numericHoras;
        private System.Windows.Forms.NumericUpDown numericMinutos;
        private System.Windows.Forms.NumericUpDown numericDias;
    }
}