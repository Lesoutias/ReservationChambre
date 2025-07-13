namespace ReservationChambre.Formulaire
{
    partial class FrmReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvReservation = new DataGridView();
            BtnSupp = new Button();
            btnMod = new Button();
            btnEnr = new Button();
            btnActu = new Button();
            TxtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbChambre = new ComboBox();
            dtpSortie = new DateTimePicker();
            dtpEntree = new DateTimePicker();
            cmbClient1 = new ComboBox();
            BtnPrixTot = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReservation).BeginInit();
            SuspendLayout();
            // 
            // dgvReservation
            // 
            dgvReservation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservation.Location = new Point(636, 110);
            dgvReservation.Name = "dgvReservation";
            dgvReservation.RowHeadersWidth = 62;
            dgvReservation.Size = new Size(777, 348);
            dgvReservation.TabIndex = 29;
            // 
            // BtnSupp
            // 
            BtnSupp.Location = new Point(492, 424);
            BtnSupp.Name = "BtnSupp";
            BtnSupp.Size = new Size(112, 34);
            BtnSupp.TabIndex = 28;
            BtnSupp.Text = "Supprimer";
            BtnSupp.UseVisualStyleBackColor = true;
            BtnSupp.Click += BtnSupp_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(345, 424);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(112, 34);
            btnMod.TabIndex = 27;
            btnMod.Text = "Modifier";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnEnr
            // 
            btnEnr.Location = new Point(204, 424);
            btnEnr.Name = "btnEnr";
            btnEnr.Size = new Size(112, 34);
            btnEnr.TabIndex = 26;
            btnEnr.Text = "Enregistrer";
            btnEnr.UseVisualStyleBackColor = true;
            btnEnr.Click += btnEnr_Click;
            // 
            // btnActu
            // 
            btnActu.Location = new Point(62, 424);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(112, 34);
            btnActu.TabIndex = 23;
            btnActu.Text = "Actualiser";
            btnActu.UseVisualStyleBackColor = true;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(199, 110);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(408, 31);
            TxtId.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 349);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 19;
            label5.Text = "Date Sortie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 296);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 18;
            label4.Text = "Date Entree";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 242);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 17;
            label3.Text = "Num Chambre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 182);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 16;
            label2.Text = "Nom Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 116);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // cmbChambre
            // 
            cmbChambre.FormattingEnabled = true;
            cmbChambre.Location = new Point(199, 234);
            cmbChambre.Name = "cmbChambre";
            cmbChambre.Size = new Size(405, 33);
            cmbChambre.TabIndex = 31;
            // 
            // dtpSortie
            // 
            dtpSortie.Location = new Point(199, 349);
            dtpSortie.Name = "dtpSortie";
            dtpSortie.Size = new Size(405, 31);
            dtpSortie.TabIndex = 32;
            // 
            // dtpEntree
            // 
            dtpEntree.Location = new Point(199, 291);
            dtpEntree.Name = "dtpEntree";
            dtpEntree.Size = new Size(405, 31);
            dtpEntree.TabIndex = 33;
            // 
            // cmbClient1
            // 
            cmbClient1.FormattingEnabled = true;
            cmbClient1.Location = new Point(199, 174);
            cmbClient1.Name = "cmbClient1";
            cmbClient1.Size = new Size(405, 33);
            cmbClient1.TabIndex = 34;
            // 
            // BtnPrixTot
            // 
            BtnPrixTot.Location = new Point(307, 497);
            BtnPrixTot.Name = "BtnPrixTot";
            BtnPrixTot.Size = new Size(112, 34);
            BtnPrixTot.TabIndex = 35;
            BtnPrixTot.Text = "Prix Total";
            BtnPrixTot.UseVisualStyleBackColor = true;
            BtnPrixTot.Click += BtnPrixTot_Click;
            // 
            // FrmReservation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 569);
            Controls.Add(BtnPrixTot);
            Controls.Add(cmbClient1);
            Controls.Add(dtpEntree);
            Controls.Add(dtpSortie);
            Controls.Add(cmbChambre);
            Controls.Add(dgvReservation);
            Controls.Add(BtnSupp);
            Controls.Add(btnMod);
            Controls.Add(btnEnr);
            Controls.Add(btnActu);
            Controls.Add(TxtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmReservation";
            Text = "FrmReservation";
            Load += FrmReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReservation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReservation;
        private Button BtnSupp;
        private Button btnMod;
        private Button btnEnr;
        private TextBox TxtContact;
        private Button btnActu;
        private TextBox TxtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox cmbChambre;
        private DateTimePicker dtpSortie;
        private DateTimePicker dtpEntree;
        private ComboBox cmbClient1;
        private Button BtnPrixTot;
    }
}