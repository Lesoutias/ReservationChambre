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
    }
}
