using ReservationChambre.Classes;

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
            ClsDictionnaire.GetInstance().OpenConnection();
            MessageBox.Show("Connexion r�ussie !", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
