namespace ReservationChambre.Formulaire
{
    partial class FrmCategorie
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
            dgvCat = new DataGridView();
            btnSupp = new Button();
            btnMod = new Button();
            btnEnr = new Button();
            btnActu = new Button();
            TxtDesCat = new TextBox();
            TxtId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCat).BeginInit();
            SuspendLayout();
            // 
            // dgvCat
            // 
            dgvCat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCat.Location = new Point(584, 51);
            dgvCat.Name = "dgvCat";
            dgvCat.RowHeadersWidth = 62;
            dgvCat.Size = new Size(777, 348);
            dgvCat.TabIndex = 29;
            // 
            // btnSupp
            // 
            btnSupp.Location = new Point(440, 365);
            btnSupp.Name = "btnSupp";
            btnSupp.Size = new Size(112, 34);
            btnSupp.TabIndex = 28;
            btnSupp.Text = "Supprimer";
            btnSupp.UseVisualStyleBackColor = true;
            btnSupp.Click += btnSupp_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(293, 365);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(112, 34);
            btnMod.TabIndex = 27;
            btnMod.Text = "Modifier";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnEnr
            // 
            btnEnr.Location = new Point(152, 365);
            btnEnr.Name = "btnEnr";
            btnEnr.Size = new Size(112, 34);
            btnEnr.TabIndex = 26;
            btnEnr.Text = "Enregistrer";
            btnEnr.UseVisualStyleBackColor = true;
            btnEnr.Click += btnEnr_Click;
            // 
            // btnActu
            // 
            btnActu.Location = new Point(10, 365);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(112, 34);
            btnActu.TabIndex = 23;
            btnActu.Text = "Actualiser";
            btnActu.UseVisualStyleBackColor = true;
            btnActu.Click += btnActu_Click;
            // 
            // TxtDesCat
            // 
            TxtDesCat.Location = new Point(147, 189);
            TxtDesCat.Name = "TxtDesCat";
            TxtDesCat.Size = new Size(408, 31);
            TxtDesCat.TabIndex = 21;
            // 
            // TxtId
            // 
            TxtId.Location = new Point(147, 51);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(408, 31);
            TxtId.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 195);
            label2.Name = "label2";
            label2.Size = new Size(107, 25);
            label2.TabIndex = 16;
            label2.Text = "Designation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 57);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // FrmCategorie
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 450);
            Controls.Add(dgvCat);
            Controls.Add(btnSupp);
            Controls.Add(btnMod);
            Controls.Add(btnEnr);
            Controls.Add(btnActu);
            Controls.Add(TxtDesCat);
            Controls.Add(TxtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmCategorie";
            Text = "FrmCategorie";
            Load += FrmCategorie_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCat;
        private Button btnSupp;
        private Button btnMod;
        private Button btnEnr;
        private Button btnActu;
        private TextBox TxtDesCat;
        private TextBox TxtId;
        private Label label2;
        private Label label1;
    }
}