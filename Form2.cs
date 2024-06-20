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
    public partial class Form2 : Form
    {

        private BindingList<Electrodomestico> electrodomesticos = new BindingList<Electrodomestico>();

        public Form2()
        {
            InitializeComponent();

            // Llenar el ComboBox
            cbLugares.Items.Add("Baño");
            cbLugares.Items.Add("Sala");
            cbLugares.Items.Add("Lavanderia");
            cbLugares.Items.Add("Dormitorio");
            cbLugares.Items.Add("Cocina");

            // Configurar el evento SelectedIndexChanged
            cbLugares.SelectedIndexChanged += cbLugares_SelectedIndexChanged;
            lblTotalCosto.Text = "Total: C$ 0.00";

            // Suscribir todos los botones al evento Click
            SuscribirEventosDeBotones();

            // Inicialmente ocultar todos los botones
            OcultarTodosLosBotones();

            // Configurar el DataGridView
            ConfigurarDataGridView();

            // Asignar la fuente de datos al DataGridView
            dataGridView1.DataSource = electrodomesticos;
        }

        private void ActualizarTotalCosto()
        {
            double totalCosto = electrodomesticos.Sum(e => e.CostoMensual);
            lblTotalCosto.Text = $"Total: C{totalCosto:C} Cordobas";
        }

        private void ConfigurarDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ConsumoDiario",
                HeaderText = "Consumo Diario (kWh)"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ConsumoMensual",
                HeaderText = "Consumo Mensual (kWh)"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CostoMensual",
                HeaderText = "Costo Mensual (C$)"
            });
        }

        private void SuscribirEventosDeBotones()
        {
            btnDuchaElectrica.Click += btnElectrodomestico_Click;
            btnRasuradora.Click += btnElectrodomestico_Click;
            btnSecadorPelo.Click += btnElectrodomestico_Click;
            btnDvd.Click += btnElectrodomestico_Click;
            btnModem.Click += btnElectrodomestico_Click;
            btnRegleta.Click += btnElectrodomestico_Click;
            btnLaptop.Click += btnElectrodomestico_Click;
            btnAbanico.Click += btnElectrodomestico_Click;
            btnBujia.Click += btnElectrodomestico_Click;
            btnEquipoSonido.Click += btnElectrodomestico_Click;
            btnConsolaJuegos.Click += btnElectrodomestico_Click;
            btnAireCondicionado.Click += btnElectrodomestico_Click;
            btnTv.Click += btnElectrodomestico_Click;
            btnHorno.Click += btnElectrodomestico_Click;
            btnLicuadora.Click += btnElectrodomestico_Click;
            btnCocina.Click += btnElectrodomestico_Click;
            btnCafetera.Click += btnElectrodomestico_Click;
            btnWafflera.Click += btnElectrodomestico_Click;
            btnTetera.Click += btnElectrodomestico_Click;
            btnCampana.Click += btnElectrodomestico_Click;
            btnArrocera.Click += btnElectrodomestico_Click;
            btnTostadora.Click += btnElectrodomestico_Click;
            btnMicroonda.Click += btnElectrodomestico_Click;
            btnRefri.Click += btnElectrodomestico_Click;
            btnBatidora.Click += btnElectrodomestico_Click;
            btnCargador.Click += btnElectrodomestico_Click;
            btnEscritorio_lamp.Click += btnElectrodomestico_Click;
            btnPc.Click += btnElectrodomestico_Click;
            btnPulidor.Click += btnElectrodomestico_Click;
            btnSecadoraRopa.Click += btnElectrodomestico_Click;
            btnAspiradora.Click += btnElectrodomestico_Click;
            btnLavadora.Click += btnElectrodomestico_Click;
            btnPlancha.Click += btnElectrodomestico_Click;
        }

        private void btnElectrodomestico_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string nombre = button.Text;

            using (FormDatos formDatos = new FormDatos())
            {
                formDatos.Nombre = nombre;

                if (formDatos.ShowDialog() == DialogResult.OK)
                {
                    int cantidad = formDatos.Cantidad;
                    double potencia = formDatos.Potencia;
                    double horas = formDatos.Horas;
                    double minutos = formDatos.Minutos;
                    int dias = formDatos.Dias;

                    double consumoDiario = (potencia / 1000) * (horas + (minutos / 60));
                    double consumoMensual = consumoDiario * dias;

                    double costoMensual = CalcularCosto(consumoMensual);

                    Electrodomestico electrodomestico = new Electrodomestico
                    {
                        Nombre = formDatos.Nombre,
                        ConsumoDiario = consumoDiario,
                        ConsumoMensual = consumoMensual,
                        CostoMensual = costoMensual
                    };

                    electrodomesticos.Add(electrodomestico);
                    ActualizarTotalCosto(); // Llama al método para actualizar el Label
                }
            }
        }

        private double CalcularCosto(double consumo)
        {
            if (consumo <= 25)
                return consumo * 3.80;
            else if (consumo <= 50)
                return 25 * 3.80 + (consumo - 25) * 5.30;
            else if (consumo <= 150)
                return 25 * 3.80 + 25 * 5.30 + (consumo - 50) * 6.70;
            else
                return 25 * 3.80 + 25 * 5.30 + 100 * 6.70 + (consumo - 150) * 8.30;
        }

        private void cbLugares_SelectedIndexChanged(object sender, EventArgs e)
        {
            OcultarTodosLosBotones();

            switch (cbLugares.SelectedItem.ToString())
            {
                case "Baño":
                    btnDuchaElectrica.Visible = true;
                    btnRasuradora.Visible = true;
                    btnSecadorPelo.Visible = true;
                    break;

                case "Sala":
                    btnDvd.Visible = true;
                    btnModem.Visible = true;
                    btnRegleta.Visible = true;
                    btnLaptop.Visible = true;
                    btnAbanico.Visible = true;
                    btnBujia.Visible = true;
                    btnEquipoSonido.Visible = true;
                    btnConsolaJuegos.Visible = true;
                    btnAireCondicionado.Visible = true;
                    btnTv.Visible = true;
                    break;

                case "Cocina":
                    btnHorno.Visible = true;
                    btnLicuadora.Visible = true;
                    btnCocina.Visible = true;
                    btnCafetera.Visible = true;
                    btnWafflera.Visible = true;
                    btnTetera.Visible = true;
                    btnCampana.Visible = true;
                    btnArrocera.Visible = true;
                    btnTostadora.Visible = true;
                    btnMicroonda.Visible = true;
                    btnRefri.Visible = true;
                    btnBatidora.Visible = true;
                    break;

                case "Dormitorio":
                    btnCargador.Visible = true;
                    btnEscritorio_lamp.Visible = true;
                    btnPc.Visible = true;
                    btnBujia.Visible = true;
                    break;

                case "Lavanderia":
                    btnPulidor.Visible = true;
                    btnSecadoraRopa.Visible = true;
                    btnAspiradora.Visible = true;
                    btnLavadora.Visible = true;
                    btnPlancha.Visible = true;
                    break;
            }
        }

        private void OcultarTodosLosBotones()
        {
            btnDuchaElectrica.Visible = false;
            btnRasuradora.Visible = false;
            btnSecadorPelo.Visible = false;
            btnDvd.Visible = false;
            btnModem.Visible = false;
            btnRegleta.Visible = false;
            btnLaptop.Visible = false;
            btnAbanico.Visible = false;
            btnBujia.Visible = false;
            btnEquipoSonido.Visible = false;
            btnConsolaJuegos.Visible = false;
            btnAireCondicionado.Visible = false;
            btnTv.Visible = false;
            btnHorno.Visible = false;
            btnLicuadora.Visible = false;
            btnCocina.Visible = false;
            btnCafetera.Visible = false;
            btnWafflera.Visible = false;
            btnTetera.Visible = false;
            btnCampana.Visible = false;
            btnArrocera.Visible = false;
            btnTostadora.Visible = false;
            btnMicroonda.Visible = false;
            btnRefri.Visible = false;
            btnBatidora.Visible = false;
            btnCargador.Visible = false;
            btnEscritorio_lamp.Visible = false;
            btnPc.Visible = false;
            btnPulidor.Visible = false;
            btnSecadoraRopa.Visible = false;
            btnAspiradora.Visible = false;
            btnLavadora.Visible = false;
            btnPlancha.Visible = false;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            electrodomesticos.Clear();
            lblTotalCosto.Text = string.Format("Total: C$ 0.00");
        }

        private void lblTotalCosto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEscritorio_lamp_Click(object sender, EventArgs e)
        {

        }
    }

    public class Electrodomestico
    {
        public string Nombre { get; set; }
        public double ConsumoDiario { get; set; }
        public double ConsumoMensual { get; set; }
        public double CostoMensual { get; set; }
    }
}