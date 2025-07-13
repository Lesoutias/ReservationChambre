using ReservationChambre.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationChambre.Formulaire
{
    public partial class Chambre : Form
    {
        public Chambre()
        {
            InitializeComponent();
        }

        ClsChambre chambre = new ClsChambre();

        private void InsertUpdateDelete(int a)
        {
            try
            {
                
                chambre.NumChambre = int.Parse(txtNumCh.Text);
                chambre.Contact1 = txtContact.Text;
                chambre.RefClasse = int.Parse(ClsDictionnaire.GetInstance().getcode_Combo("tClasse", "id", "designationClasse", cmbClass.Text));
                if (a == 1)
                {
                    chambre.Id = -1;
                    ClsDictionnaire.GetInstance().SaveChambre(chambre);
                    dgvChambre.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Chambre"); ;
                }
                else if (a == 2)
                {
                    chambre.Id = int.Parse(txtId.Text);
                    ClsDictionnaire.GetInstance().SaveChambre(chambre);
                    dgvChambre.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Chambre");
                }
                else if (a == 3)
                {
                    ClsDictionnaire.GetInstance().deleteData("tChambre", "id", int.Parse(txtId.Text));
                    MessageBox.Show("Suppression reussie");
                    dgvChambre.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Chambre");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void Chambre_Load(object sender, EventArgs e)
        {
            dgvChambre.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Chambre");
            ClsDictionnaire.GetInstance().loadCombo("tClasse", "designationClasse", cmbClass);
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNumCh.Text = "";
            txtContact.Text = "";
            cmbClass.Text = "";
        }

        private void btnEnre_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(1);
        }

        private void BtnMod_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(2);
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(3);
        }
    }
}
