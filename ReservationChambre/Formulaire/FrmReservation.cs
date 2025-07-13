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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ReservationChambre.Formulaire
{
    public partial class FrmReservation : Form
    {
        public FrmReservation()
        {
            InitializeComponent();
        }

        ClsReservation res = new ClsReservation();
        private void InsertUpdateDelete(int a)
        {
            res.RefClient = int.Parse(ClsDictionnaire.GetInstance().getcode_Combo("tClient", "id", "noms", cmbClient1.Text));
            res.RefChambre = int.Parse(ClsDictionnaire.GetInstance().getcode_Combo("tChambre", "id", "numChambre", cmbChambre.Text));
            res.DateEntree = DateTime.Parse(dtpEntree.Text);
            res.DateSortie = DateTime.Parse(dtpSortie.Text);
            if (a == 1)
            {
                res.Id = -1;
                ClsDictionnaire.GetInstance().SaveReservation(res);
                dgvReservation.DataSource = ClsDictionnaire.GetInstance().loadData("tReservation");
            }
            else if (a == 2)
            {
                res.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().SaveReservation(res);
                dgvReservation.DataSource = ClsDictionnaire.GetInstance().loadData("tReservation");
            }
            else if (a == 3)
            {
                res.Id = int.Parse(TxtId.Text);
                ClsDictionnaire.GetInstance().deleteData("tClasse", "id", int.Parse(TxtId.Text));
                dgvReservation.DataSource = ClsDictionnaire.GetInstance().loadData("tReservation");
            }
        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            dgvReservation.DataSource = ClsDictionnaire.GetInstance().loadData("tReservation");
            ClsDictionnaire.GetInstance().loadCombo("tClient", "noms", cmbClient1);
            ClsDictionnaire.GetInstance().loadCombo("tChambre", "numChambre", cmbChambre);
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

        private void BtnPrixTot_Click(object sender, EventArgs e)
        {
            ClsReservation res = new ClsReservation();
            res.Id = int.Parse(TxtId.Text);
            MessageBox.Show($"Le prix total est de {ClsDictionnaire.GetInstance().Afficher_Prix(res)}");
        }
    }
}
