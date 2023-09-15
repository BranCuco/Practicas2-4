using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacFibMCD 
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightGreen; // Cambia al color que prefieras
            ShowInitialControls();
        }

        private void ShowInitialControls()
        {
            labelTitulo.Visible = true;
            buttonCalcular.Visible = false;
            radioButtonFactorial.Visible = true;
            radioButtonFibonacci.Visible = true;
            radioButtonMCD.Visible = true;
            HideAllCalculationControls();
        }

        private void HideAllCalculationControls()
        {
            textBoxNumero.Visible = false;
            labelNumero.Visible = false;
            textBoxNumero1.Visible = false;
            textBoxNumero2.Visible = false;
            labelNumero1.Visible = false;
            labelNumero2.Visible = false;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            HideAllCalculationControls();
            buttonCalcular.Visible = true;

            if (radioButtonFactorial.Checked)
            {
                labelNumero.Visible = true;
                textBoxNumero.Visible = true;
            }
            else if (radioButtonFibonacci.Checked)
            {
                labelNumero.Visible = true;
                textBoxNumero.Visible = true;
            }
            else if (radioButtonMCD.Checked)
            {
                labelNumero1.Visible = true;
                labelNumero2.Visible = true;
                textBoxNumero1.Visible = true;
                textBoxNumero2.Visible = true;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (radioButtonFactorial.Checked)
            {
                int numero;
                if (int.TryParse(textBoxNumero.Text, out numero))
                {
                    if (numero >= 0)
                    {
                        int resultado = CalcularFactorial(numero);
                        MessageBox.Show("El factorial de " + numero + " es: " + resultado);
                    }
                    else
                    {
                        MessageBox.Show("El número debe ser mayor o igual a cero.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
            else if (radioButtonFibonacci.Checked)
            {
                int numero;
                if (int.TryParse(textBoxNumero.Text, out numero))
                {
                    if (numero >= 0)
                    {
                        int resultado = CalcularFibonacci(numero);
                        MessageBox.Show("El término " + numero + " de la serie Fibonacci es: " + resultado);
                    }
                    else
                    {
                        MessageBox.Show("El número debe ser mayor o igual a cero.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un número válido.");
                }
            }
            else if (radioButtonMCD.Checked)
            {
                int numero1, numero2;
                if (int.TryParse(textBoxNumero1.Text, out numero1) && int.TryParse(textBoxNumero2.Text, out numero2))
                {
                    int resultado = CalcularMCD(numero1, numero2);
                    MessageBox.Show("El Máximo Común Divisor de " + numero1 + " y " + numero2 + " es: " + resultado);
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese números válidos en ambos campos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una opción de cálculo.");
            }
        }

        private int CalcularFactorial(int n)
        {
            if (n == 0)
                return 1;
            return n * CalcularFactorial(n - 1);
        }

        private int CalcularFibonacci(int n)
        {
            if (n <= 1)
                return n;
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }

        private int CalcularMCD(int a, int b)
        {
            if (b == 0)
                return a;
            return CalcularMCD(b, a % b);
        }
    }
}
