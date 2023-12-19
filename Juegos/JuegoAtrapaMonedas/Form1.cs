namespace JuegoAtrapaMonedas
{
    public partial class Form1 : Form
    {
        List<PictureBox>
        GrupoFichasUno = new List<PictureBox>(),
        GrupoFichasDos = new List<PictureBox>(),
        GrupoFichasTres = new List<PictureBox>();

        int MovimientoY = 0, PosicionSiguiente, LongitudFicha, posicionEjeX = 3;
        bool indicador1 = false, indicador2 = false, indicador3 = false;

        String nombreFicha1 = "", nombreFicha2 = "", nombreFicha3 = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();


        }

        public List<PictureBox> CrearImagenes(List<PictureBox> Lista, Panel panel, String Nombretag)
        {

        }

    }
}