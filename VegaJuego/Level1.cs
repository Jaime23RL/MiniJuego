using System.Diagnostics;

namespace VegaJuego
{
    public partial class Level1 : Form
    {
        Link Player;
        Broncas Enemigo1;
        public Level1()
        {
            InitializeComponent();
            IniciarPersonajes();
            IniciarOpcionesDelMapa();
        }

        private void IniciarOpcionesDelMapa()
        {
            labelVida.Text = "Salud " + Player.Salud;
            labelEscudo.Text = "Escudo " + Player.Escudo;
            labelArma.Text = "Arma " + Player.Arma;
        }

        private void IniciarPersonajes()
        {
            Player = new Link(this, 0, 0, 30, 0, 0);
            Enemigo1 = new Broncas(this, 0, 300);
        }

        private void Level1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Player.mover(e);
            Debug.WriteLine("[x" + Player.Caja.Location.X + ",Y" + Player.Caja.Location.Y + "]");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Enemigo1.mover();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MovEnemigos_Tick(object sender, EventArgs e)
        {

        }
    }
}