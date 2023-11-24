using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculadora
{
    public partial class FormCalculadora : System.Windows.Forms.Form
    {
        public string varResultado = "";
        public string varFormula = "";
        public string varTexto = "";

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BotonNumero(string numero)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = Convert.ToString(numero);
            }
            else
            {
                txtPantalla.Text += Convert.ToString(numero);
            }
        }
        private void btNum0_Click(object sender, EventArgs e)
        {
            BotonNumero("0");
        }

        private void btNum1_Click(object sender, EventArgs e)
        {
            BotonNumero("1");
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            BotonNumero("2");
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            BotonNumero("3");
        }

        private void btNum4_Click(object sender, EventArgs e)
        {
            BotonNumero("4");
        }

        private void btNum5_Click(object sender, EventArgs e)
        {
            BotonNumero("5");
        }

        private void btNum6_Click(object sender, EventArgs e)
        {
            BotonNumero("6");
        }

        private void btNum7_Click(object sender, EventArgs e)
        {
            BotonNumero("7");
        }

        private void btNum8_Click(object sender, EventArgs e)
        {
            BotonNumero("8");
        }

        private void btNum9_Click(object sender, EventArgs e)
        {
            BotonNumero("9");
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ".";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            txtPantalla.Text = "0";
        }

        private void Operador(string operador)
        {
            if (txtPantalla.Text.Contains("Presione"))
            {
                txtPantalla.Text = "";
            }
            txtPantalla.Text += $" {operador} ";
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            Operador("+");
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            Operador("-");
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            Operador("*");
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            Operador("/");
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            try
            {
                string expresion = txtPantalla.Text;
                expresion = $"{varResultado} {expresion}";
                double resultado = Convert.ToDouble(new System.Data.DataTable().Compute(expresion, ""));
                varFormula = txtPantalla.Text;
                varResultado = Convert.ToString(resultado);
                txtPantalla.Text = $"{varFormula}\r\n Resultado: {varResultado}";               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la operación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


                               
            DialogResult result = MessageBox.Show("¿Desea continuar realizando operaciones?", "Continuar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txtPantalla.Text = "Presione un Operador";
                varTexto += $"{varFormula} = {varResultado}\r\n";
            }
                else
                {
                varTexto += $"{varFormula} = {varResultado}\r\n";
                txtResultados.Visible = true;
                txtResultados.Text = varTexto;
                }
        }
    }
}
