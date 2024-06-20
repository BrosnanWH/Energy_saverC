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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void VisitLink()
        {
            
            linkLabel1.LinkVisited = true;
            //Llamar metodo para abrir link en el navegador
            System.Diagnostics.Process.Start("https://github.com/BrosnanWH/Energy_saverC");
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            {
                try
                {
                    VisitLink();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir este enlace.");
                }
            }

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
