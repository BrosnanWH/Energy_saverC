using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_energia
{
    public partial class FormDatos : Form
    {

        public string Nombre { get; set; }
        public int Cantidad { get; private set; }
        public double Potencia { get; private set; }
        public double Horas { get; private set; }
        public double Minutos { get; private set; }
        public int Dias { get; private set; }

        public FormDatos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Cantidad = (int)numericCantidad.Value;
            Potencia = (double)numericPotencia.Value;
            Horas = (double)numericHoras.Value;
            Minutos = (double)numericMinutos.Value;
            Dias = (int)numericDias.Value;

            

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormDatos_Load(object sender, EventArgs e)
        {

        }

        private void numericDias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}