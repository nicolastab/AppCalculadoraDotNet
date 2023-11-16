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
    public partial class FormCalculadora : Form
    {
        public Double num1;
        public Double num2 = 0;
        public string varOperador = "";
        public string varTexto = "";
        public string varResultado = "";

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BotonNumero(string numero)
        {
            if (txtPantalla.Text == "0" || txtPantalla.Text == "Ingrese otro número")
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
            bool varPunto = txtPantalla.Text.Contains(".");
            if (!varPunto)
            {
                txtPantalla.Text += ".";
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
        }
        private void SignoCalcular()
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            txtPantalla.Text = "Ingrese otro número";
        }
        private void btSum_Click(object sender, EventArgs e)
        {
            varOperador = "+";
            SignoCalcular();
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            varOperador = "-";
            SignoCalcular();
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            varOperador = "*";
            SignoCalcular();
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            varOperador = "/";
            SignoCalcular();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            Convert.ToString(txtPantalla.Text);
            double num2 = Convert.ToDouble(txtPantalla.Text);
            switch (varOperador)
            {
                case "+":
                    txtPantalla.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    txtPantalla.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    txtPantalla.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    // Alerta al dividir por cero
                    if (num2 != 0)
                    {
                        txtPantalla.Text = Convert.ToString(num1 / num2);
                    }
                    else
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                    }
                    break;
            }
            varTexto = txtPantalla.Text;
            // Double VarResultado = btNum1
            DialogResult result = MessageBox.Show("¿Desea continuar realizando operaciones?", "Continuar", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                txtPantalla.Text = "Presione un Operador";
            }
            else
            {
                Close();
            }
        }
    }
}
