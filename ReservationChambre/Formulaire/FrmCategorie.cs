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
    public partial class FrmCategorie : Form
    {
        public FrmCategorie()
        {
            InitializeComponent();
        }

        ClsCategorisation cat = new ClsCategorisation();
        private void InsertUpdateDelete(int a)
        {
            cat.DesignationCat = TxtDesCat.Text;

            if (a == 1)
            {
                cat.Id = -1;
                ClsDictionnaire.GetInstance().SaveCategorie(cat);
                dgvCat.DataSource = ClsDictionnaire.GetInstance().loadData("tCategorisation");

            }
            else if (a == 2)
            {
                cat.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().SaveCategorie(cat);
                dgvCat.DataSource = ClsDictionnaire.GetInstance().loadData("tCategorisation");
            }
            else if (a == 3)
            {
                cat.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().deleteData("tCategorisation", "id", int.Parse(TxtId.Text));
                dgvCat.DataSource = ClsDictionnaire.GetInstance().loadData("tCategorisation");
            }
        }

        private void FrmCategorie_Load(object sender, EventArgs e)
        {
            dgvCat.DataSource = ClsDictionnaire.GetInstance().loadData("tCategorisation");
        }

        private void btnEnr_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(1);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(2);
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            InsertUpdateDelete(3);
        }

        private void btnActu_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtDesCat.Text = "";
        }
    }
}
