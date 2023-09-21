using System.Globalization;

namespace Calculadora_de_Raiz_Cuadrada
{
    public partial class Form1 : Form
    {
        double Numero = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtCuadro.Text == "0")
                txtCuadro.Text = "";

            txtCuadro.Text += boton.Text;
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            
            // Obtener el número ingresado por el usuario desde el cuadro de texto
            if (double.TryParse(txtCuadro.Text, out Numero))
            {
                if (Numero < 0)
                {
                    txtCuadro.Text = "Error";
                }

                else
                {
                    // Calcular la raíz cuadrada llamando a la funsion CalcularRaizCuadrada
                    double raizCuadrada = CalcularRaizCuadrada();

                    string resultadoFormateado = raizCuadrada.ToString("0.00", CultureInfo.InvariantCulture);

                    // Mostrar el resultado en el cuadro de texto
                    txtCuadro.Text = resultadoFormateado;
                }

            }
        }

        private double CalcularRaizCuadrada()
        {

            // Algoritmo de Newton-Raphson para calcular la raíz cuadrada
            double estimacion = Numero / 2;
            double tolerancia = 0.00001;

            while (Math.Abs(estimacion * estimacion - Numero) > tolerancia)
            {
                estimacion = (estimacion + Numero / estimacion) / 2;
            }
            return estimacion;
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero = 0;
            txtCuadro.Text = "0";
        }

        private void btnBorrarUno_Click(object sender, EventArgs e)
        {
            if (txtCuadro.Text.Length > 1)
            {
                txtCuadro.Text = txtCuadro.Text.Substring(0, txtCuadro.Text.Length - 1);
            }
            else
            {
                txtCuadro.Text = "0";
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtCuadro.Text.Contains("."))
            {
                txtCuadro.Text += ".";
            }
        }

        private void btnCambioDeSigno_Click(object sender, EventArgs e)
        {
            Numero = Convert.ToDouble(txtCuadro.Text);

            Numero *= -1;
            txtCuadro.Text = Numero.ToString();
        }
    }
}
