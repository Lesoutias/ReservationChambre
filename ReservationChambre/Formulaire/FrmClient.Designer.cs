namespace ReservationChambre.Formulaire
{
    partial class FrmClient
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
            label4 = new Label();
            label5 = new Label();
            TxtId = new TextBox();
            TxtNoms = new TextBox();
            TxtAdd = new TextBox();
            btnActu = new Button();
            TxtContact = new TextBox();
            CmbCat = new ComboBox();
            btnEnr = new Button();
            btnMod = new Button();
            BtnSupp = new Button();
            dgvClient = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvClient).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 51);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 117);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 1;
            label2.Text = "Noms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 177);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 2;
            label3.Text = "Adresse";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 231);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 284);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Categorie";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(201, 45);
            TxtId.Name = "TxtId";
            TxtId.Size = new Size(408, 31);
            TxtId.TabIndex = 5;
            // 
            // TxtNoms
            // 
            TxtNoms.Location = new Point(201, 111);
            TxtNoms.Name = "TxtNoms";
            TxtNoms.Size = new Size(408, 31);
            TxtNoms.TabIndex = 6;
            // 
            // TxtAdd
            // 
            TxtAdd.Location = new Point(201, 171);
            TxtAdd.Name = "TxtAdd";
            TxtAdd.Size = new Size(408, 31);
            TxtAdd.TabIndex = 7;
            // 
            // btnActu
            // 
            btnActu.Location = new Point(64, 359);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(112, 34);
            btnActu.TabIndex = 8;
            btnActu.Text = "Actualiser";
            btnActu.UseVisualStyleBackColor = true;
            btnActu.Click += btnActu_Click;
            // 
            // TxtContact
            // 
            TxtContact.Location = new Point(201, 228);
            TxtContact.Name = "TxtContact";
            TxtContact.Size = new Size(408, 31);
            TxtContact.TabIndex = 9;
            // 
            // CmbCat
            // 
            CmbCat.FormattingEnabled = true;
            CmbCat.Location = new Point(201, 284);
            CmbCat.Name = "CmbCat";
            CmbCat.Size = new Size(408, 33);
            CmbCat.TabIndex = 10;
            // 
            // btnEnr
            // 
            btnEnr.Location = new Point(206, 359);
            btnEnr.Name = "btnEnr";
            btnEnr.Size = new Size(112, 34);
            btnEnr.TabIndex = 11;
            btnEnr.Text = "Enregistrer";
            btnEnr.UseVisualStyleBackColor = true;
            btnEnr.Click += btnEnr_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(347, 359);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(112, 34);
            btnMod.TabIndex = 12;
            btnMod.Text = "Modifier";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // BtnSupp
            // 
            BtnSupp.Location = new Point(494, 359);
            BtnSupp.Name = "BtnSupp";
            BtnSupp.Size = new Size(112, 34);
            BtnSupp.TabIndex = 13;
            BtnSupp.Text = "Supprimer";
            BtnSupp.UseVisualStyleBackColor = true;
            BtnSupp.Click += BtnSupp_Click;
            // 
            // dgvClient
            // 
            dgvClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClient.Location = new Point(638, 45);
            dgvClient.Name = "dgvClient";
            dgvClient.RowHeadersWidth = 62;
            dgvClient.Size = new Size(777, 348);
            dgvClient.TabIndex = 14;
            // 
            // FrmClient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1439, 649);
            Controls.Add(dgvClient);
            Controls.Add(BtnSupp);
            Controls.Add(btnMod);
            Controls.Add(btnEnr);
            Controls.Add(CmbCat);
            Controls.Add(TxtContact);
            Controls.Add(btnActu);
            Controls.Add(TxtAdd);
            Controls.Add(TxtNoms);
            Controls.Add(TxtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmClient";
            Text = "FrmClient";
            Load += FrmClient_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox TxtId;
        private TextBox TxtNoms;
        private TextBox TxtAdd;
        private Button btnActu;
        private TextBox TxtContact;
        private ComboBox CmbCat;
        private Button btnEnr;
        private Button btnMod;
        private Button BtnSupp;
        private DataGridView dgvClient;
    }
}