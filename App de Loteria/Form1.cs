using System;
using System.Windows.Forms;

namespace App_de_Loteria
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        double Numero1, Numero2, Numero3, Apostado, Ganado;
        private const double Primera = 100;
        private const double Segunda = 50;
        private const double Tercera = 10;

        double Random1, Random2, Random3;

        public Form1()
        {
            InitializeComponent();
        }

        public double GenerarNumeroAleatorio()
        {
            return random.Next(100);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (EsNumeroValido(textBox1.Text) && EsNumeroValido(textBox2.Text) && EsNumeroValido(textBox3.Text) && EsNumeroValido(txtBoxApostado.Text) && EsNumeroValido(txtBoxGanado.Text))
            {
                Numero1 = Convert.ToDouble(textBox1.Text);
                Numero2 = Convert.ToDouble(textBox2.Text);
                Numero3 = Convert.ToDouble(textBox3.Text);
                Apostado = Convert.ToDouble(txtBoxApostado.Text);
                Ganado = Convert.ToDouble(txtBoxGanado.Text);

                Random1 = GenerarNumeroAleatorio();
                Random2 = GenerarNumeroAleatorio();
                Random3 = GenerarNumeroAleatorio();

                labelResultado1.Text = Random1.ToString();
                labelResultado2.Text = Random2.ToString();
                labelResultado3.Text = Random3.ToString();

                if (rdbtnPale.Checked == true)
                {
                    if (Numero1 == Random1)
                    {
                        Apostado *= Primera;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Numero1 == Random2)
                    {
                        Apostado *= Segunda;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Numero1 == Random3)
                    {
                        Apostado *= Tercera;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Random1 != Numero1)
                    {
                        txtBoxGanado.Text = "0";
                    }


                }
                else if (rdbtnPaleDoble.Checked == true)
                {
                    if (Numero2 == Random2 || Numero3 == Random3)
                    {
                        Apostado *= Primera;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Numero2 == Random3 || Numero3 == Random2)
                    {
                        Apostado *= Segunda;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Numero2 == Random1 || Numero3 == Random1) //aqui seria como si Random1 fuera el Random3 para seguir con el orden de que lo apostado se multiplica segun que tan cerca de donde apostaste salga el numero */
                    {   
                        Apostado *= Tercera;
                        Ganado = Apostado;
                        txtBoxGanado.Text = Ganado.ToString();
                    }
                    else if (Numero2 != Random1 || Numero2 != Random2 || Numero2 != Random3) 
                    {
                        txtBoxGanado.Text = "0";
                    }



                }
            }
        }

        // Función para verificar si una cadena puede convertirse en número double
        private bool EsNumeroValido(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                return false;
            }

            if (double.TryParse(valor, out _))
            {
                return true;
            }

            return false;
        }
    }
}
