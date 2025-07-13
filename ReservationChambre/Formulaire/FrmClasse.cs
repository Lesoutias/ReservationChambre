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
    public partial class FrmClasse : Form
    {
        public FrmClasse()
        {
            InitializeComponent();
        }

        ClsClasse classe = new ClsClasse();

        private void InsertUpdateDelete(int a)
        {
            classe.DesignationClasse = txtDesignation.Text;
            classe.Prix = double.Parse(txtPrix.Text);
            if (a == 1)
            {
                classe.Id = -1;
                ClsDictionnaire.GetInstance().SaveClasse(classe);
                dgvClasse.DataSource = ClsDictionnaire.GetInstance().loadData("tClasse");
            }
            else if (a == 2)
            {
                classe.Id = int.Parse(txtId.Text);
                ClsDictionnaire.GetInstance().SaveClasse(classe);
                dgvClasse.DataSource = ClsDictionnaire.GetInstance().loadData("tClasse");
            }
            else if (a == 3)
            {
                classe.Id = int.Parse(txtId.Text);
                ClsDictionnaire.GetInstance().deleteData("tClasse", "id", int.Parse(txtId.Text));
                dgvClasse.DataSource = ClsDictionnaire.GetInstance().loadData("tClasse");
            }
        }

        private void FrmClasse_Load(object sender, EventArgs e)
        {
            dgvClasse.DataSource = ClsDictionnaire.GetInstance().loadData("tClasse");
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            txtPrix.Text = "";
            txtDesignation.Text = "";
            txtId.Text = "";
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
