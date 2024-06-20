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
            // Change the color of the link text by setting LinkVisited
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser
            //with a URL:
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
                    MessageBox.Show("Unable to open link that was clicked.");
                }
            }

            
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
