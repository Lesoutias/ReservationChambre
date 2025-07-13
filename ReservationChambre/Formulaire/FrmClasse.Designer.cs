namespace ReservationChambre.Formulaire
{
    partial class FrmClasse
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtId = new TextBox();
            txtDesignation = new TextBox();
            txtPrix = new TextBox();
            dgvClasse = new DataGridView();
            btnActu = new Button();
            btnEnre = new Button();
            BtnMod = new Button();
            BtnSupp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClasse).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 69);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 144);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 1;
            label2.Text = "Designation";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 210);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 2;
            label3.Text = "Prix";
            // 
            // txtId
            // 
            txtId.Location = new Point(215, 71);
            txtId.Name = "txtId";
            txtId.Size = new Size(386, 31);
            txtId.TabIndex = 3;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(215, 141);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(386, 31);
            txtDesignation.TabIndex = 4;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(215, 210);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(386, 31);
            txtPrix.TabIndex = 5;
            // 
            // dgvClasse
            // 
            dgvClasse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasse.Location = new Point(701, 70);
            dgvClasse.Name = "dgvClasse";
            dgvClasse.RowHeadersWidth = 62;
            dgvClasse.Size = new Size(700, 323);
            dgvClasse.TabIndex = 6;
            // 
            // btnActu
            // 
            btnActu.Location = new Point(39, 359);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(112, 34);
            btnActu.TabIndex = 7;
            btnActu.Text = "Actualiser";
            btnActu.UseVisualStyleBackColor = true;
            btnActu.Click += btnActu_Click;
            // 
            // btnEnre
            // 
            btnEnre.Location = new Point(188, 359);
            btnEnre.Name = "btnEnre";
            btnEnre.Size = new Size(112, 34);
            btnEnre.TabIndex = 8;
            btnEnre.Text = "Enregister";
            btnEnre.UseVisualStyleBackColor = true;
            btnEnre.Click += btnEnre_Click;
            // 
            // BtnMod
            // 
            BtnMod.Location = new Point(335, 359);
            BtnMod.Name = "BtnMod";
            BtnMod.Size = new Size(112, 34);
            BtnMod.TabIndex = 9;
            BtnMod.Text = "Modifier";
            BtnMod.UseVisualStyleBackColor = true;
            BtnMod.Click += BtnMod_Click;
            // 
            // BtnSupp
            // 
            BtnSupp.Location = new Point(487, 359);
            BtnSupp.Name = "BtnSupp";
            BtnSupp.Size = new Size(112, 34);
            BtnSupp.TabIndex = 10;
            BtnSupp.Text = "Supprimer";
            BtnSupp.UseVisualStyleBackColor = true;
            BtnSupp.Click += BtnSupp_Click;
            // 
            // FrmClasse
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 712);
            Controls.Add(BtnSupp);
            Controls.Add(BtnMod);
            Controls.Add(btnEnre);
            Controls.Add(btnActu);
            Controls.Add(dgvClasse);
            Controls.Add(txtPrix);
            Controls.Add(txtDesignation);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmClasse";
            Text = "FrmClasse";
            Load += FrmClasse_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClasse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtId;
        private TextBox txtDesignation;
        private TextBox txtPrix;
        private DataGridView dgvClasse;
        private Button btnActu;
        private Button btnEnre;
        private Button BtnMod;
        private Button BtnSupp;
    }
}