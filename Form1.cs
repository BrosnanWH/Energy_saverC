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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.Text = "Calculadora de Energía";
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide(); 
            form2.ShowDialog(); 
            this.Close(); 
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();         
            form3.ShowDialog();
            
        }
    }
}
