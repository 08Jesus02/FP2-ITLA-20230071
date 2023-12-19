namespace JuegoAtrapaMonedas
{
    public partial class Form1 : Form
    {
        List<PictureBox>
        GrupoFichasUno = new List<PictureBox>(),
        GrupoFichasDos = new List<PictureBox>(),
        GrupoFichasTres = new List<PictureBox>();

        int MovimientoY = 0, PosicionSiguiente, LongitudFicha, posicionEjeX = 3;
        bool Indicador1 = false, Indicador2 = false, Indicador3 = false;

        String NombreFicha1 = "", NombreFicha2 = "", NombreFicha3 = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();


        }

        public List<PictureBox> CrearImagenes(List<PictureBox> Lista, Panel panel, String NombreTag)
        {
            LongitudFicha = 100;
            for (int i = 0; i < 10; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("btnone" + (i + 1));
                pb.Size = new Size(LongitudFicha, LongitudFicha);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Name = string.Format("{0}", i + NombreTag);
                pb.Tag = NombreTag + "_" + i;
                int Mov = pb.Location.Y;
                pb.Location = new Point(posicionEjeX, i * LongitudFicha);
                Lista.Add(pb);
                panel.Controls.Add(Lista[i]);

            }
            return Lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CrearImagenes(GrupoFichasUno, panel1, "Uno");
            CrearImagenes(GrupoFichasDos, panel2, "Dos");
            CrearImagenes(GrupoFichasTres, panel3, "Tres");
        }

        public String GirarFichas(List<PictureBox> Lista, Panel panel, System.Windows.Forms.Timer timer, bool bandera)
        {
            String FichaSeleccionada = "";

            int posicionDeDetencion = -10; // Establece la posición de detención deseada

            for (int i = 0; i < Lista.Count; i++)
            {
                MovimientoY = Lista[i].Location.Y;
                Lista[i].Location = new Point(posicionEjeX, MovimientoY - 10);

                if (Lista[i].Location.Y <= -LongitudFicha)
                {
                    PosicionSiguiente = Lista[((Lista.Count) - 1)].Location.Y;
                    Lista[i].Location = new Point(posicionEjeX, PosicionSiguiente + LongitudFicha);
                    Lista.Add(Lista[i]);
                    panel.Controls.Add(Lista[i]);
                    Lista.RemoveAt(i);
                }

                if (bandera)
                {
                    if (Lista[i].Location.Y == posicionDeDetencion)
                    {
                        timer.Stop();
                        FichaSeleccionada = Lista[i].Tag.ToString();
                    }
                }
                else
                {
                    FichaSeleccionada = "";
                }
            }
            return FichaSeleccionada;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            NombreFicha1 = GirarFichas(GrupoFichasUno, panel1, timer1, Indicador1);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Indicador1 = false;
            Indicador2 = false;
            Indicador3 = false;
            timer1.Start();
            pictureBox4.Image = Properties.Resources.btnStop;
            pictureBox1.Image = Properties.Resources.btnPararAzul;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            NombreFicha2 = GirarFichas(GrupoFichasDos, panel2, timer2, Indicador2);

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            NombreFicha3 = GirarFichas(GrupoFichasTres, panel3, timer3, Indicador3);
            if (NombreFicha3 != "")
            {
                pictureBox4.Image = Properties.Resources.btnStart;

                if ((NumeroFicha(NombreFicha1) == NumeroFicha(NombreFicha2)) && (NumeroFicha(NombreFicha2) == NumeroFicha(NombreFicha3)))
                {
                    MessageBox.Show("Ganaste");
                }

                else
                {
                    MessageBox.Show("Perdiste");
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Indicador1 = true;
            timer2.Start();
            pictureBox1.Image = Properties.Resources.btnPararAzulDesactio;
            pictureBox2.Image = Properties.Resources.btnPararRojo;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Indicador2 = true;
            timer3.Start();
            pictureBox2.Image = Properties.Resources.btnPararRojoDesactio;
            pictureBox3.Image = Properties.Resources.btnPararVerde;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Indicador3 = true;
            pictureBox3.Image = Properties.Resources.btnPararVerdeDesactio;


        }

        public int NumeroFicha(String Nombre)
        {
            string[] Posicion = Nombre.Split("_".ToCharArray());
            return Convert.ToInt32(Posicion[1]);
        }
    }
}