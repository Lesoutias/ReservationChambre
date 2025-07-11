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
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        ClsClient cl = new ClsClient();
        private void InsertUpdateDelete(int a)
        {
            cl.Noms = TxtNoms.Text;
            cl.Contact = TxtContact.Text;
            cl.Adresse = TxtAdd.Text;
            cl.RefCategorie = int.Parse(ClsDictionnaire.GetInstance().getcode_Combo("tCategorisation", "id", "designationCategorisation", CmbCat.Text));

            if (a == 1)
            {
                cl.Id = -1;
                ClsDictionnaire.GetInstance().SaveClient(cl);
                dgvClient.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Client");

            }
            else if (a == 2)
            {
                cl.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().SaveClient(cl);
                dgvClient.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Client");
            }
            else if (a == 3)
            {
                cl.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().deleteData("tClient", "id", int.Parse(TxtId.Text));
                dgvClient.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_client");
            }
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            dgvClient.DataSource = ClsDictionnaire.GetInstance().loadData("Afficher_Client");
            ClsDictionnaire.GetInstance().loadCombo("tCategorisation", "designationCategorisation", CmbCat);
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            TxtAdd.Text = "";
            TxtContact.Text = "";
            TxtId.Text = "";
            TxtNoms.Text = "";
            CmbCat.Text = "";
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(1);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(2);
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(3);
        }
    }
}
