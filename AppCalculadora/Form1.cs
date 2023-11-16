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
    public partial class Form1 : Form
    {
        public Double num1;
        public Double num2 = 0;
        public string varOperador = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNum0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "0";
            }
            else
            {
                txtPantalla.Text += "0";
            }
        }

        private void btNum1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "1";
            }
            else
            {
                txtPantalla.Text += "1";
            }
        }

        private void btNum2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "2";
            }
            else
            {
                txtPantalla.Text += "2";
            }
        }

        private void btNum3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "3";
            }
            else
            {
                txtPantalla.Text += "3";
            }
        }

        private void btNum4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "4";
            }
            else
            {
                txtPantalla.Text += "4";
            }
        }

        private void btNum5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "5";
            }
            else
            {
                txtPantalla.Text += "5";
            }
        }

        private void btNum6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "6";
            }
            else
            {
                txtPantalla.Text += "6";
            }
        }

        private void btNum7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "7";
            }
            else
            {
                txtPantalla.Text += "7";
            }
        }

        private void btNum8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "8";
            }
            else
            {
                txtPantalla.Text += "8";
            }
        }

        private void btNum9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "9";
            }
            else
            {
                txtPantalla.Text += "9";
            }
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

        private void btSum_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            //txtPantalla.Text = "Ingrese la otra cantidad";
            varOperador = "+";
        }

        private void btRest_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            varOperador = "-";
        }

        private void btMult_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            varOperador = "*";
        }

        private void btDiv_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Clear();
            varOperador = "/";
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
            // Manejar división por cero
            if (num2 != 0)
            {
                txtPantalla.Text = Convert.ToString(num1 / num2);
            }
            else
            {
                MessageBox.Show("No se puede dividir por cero.");
                //LimpiarDatos();
            }
            break;
            }
            // Double VarResultado = btNum1 
        }
    }
}
