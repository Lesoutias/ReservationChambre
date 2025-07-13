using ReservationChambre.Classes;
using ReservationChambre.Formulaire;

namespace ReservationChambre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategorie frmCategorie = new FrmCategorie();
            frmCategorie.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FrmClient frmClient = new FrmClient();
            frmClient.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmClasse frmClasse = new FrmClasse();
            frmClasse.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chambre frmChambre = new Chambre();
            frmChambre.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmReservation frmReservation = new FrmReservation();
            frmReservation.Show();
        }
    }
}
