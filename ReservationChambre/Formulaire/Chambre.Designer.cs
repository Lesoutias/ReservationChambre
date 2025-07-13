namespace ReservationChambre.Formulaire
{
    partial class Chambre
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
            BtnSupp = new Button();
            BtnMod = new Button();
            btnEnre = new Button();
            btnActu = new Button();
            dgvChambre = new DataGridView();
            txtContact = new TextBox();
            txtNumCh = new TextBox();
            txtId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            cmbClass = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvChambre).BeginInit();
            SuspendLayout();
            // 
            // BtnSupp
            // 
            BtnSupp.Location = new Point(477, 386);
            BtnSupp.Name = "BtnSupp";
            BtnSupp.Size = new Size(112, 34);
            BtnSupp.TabIndex = 21;
            BtnSupp.Text = "Supprimer";
            BtnSupp.UseVisualStyleBackColor = true;
            BtnSupp.Click += BtnSupp_Click;
            // 
            // BtnMod
            // 
            BtnMod.Location = new Point(325, 386);
            BtnMod.Name = "BtnMod";
            BtnMod.Size = new Size(112, 34);
            BtnMod.TabIndex = 20;
            BtnMod.Text = "Modifier";
            BtnMod.UseVisualStyleBackColor = true;
            BtnMod.Click += BtnMod_Click;
            // 
            // btnEnre
            // 
            btnEnre.Location = new Point(178, 386);
            btnEnre.Name = "btnEnre";
            btnEnre.Size = new Size(112, 34);
            btnEnre.TabIndex = 19;
            btnEnre.Text = "Enregister";
            btnEnre.UseVisualStyleBackColor = true;
            btnEnre.Click += btnEnre_Click;
            // 
            // btnActu
            // 
            btnActu.Location = new Point(29, 386);
            btnActu.Name = "btnActu";
            btnActu.Size = new Size(112, 34);
            btnActu.TabIndex = 18;
            btnActu.Text = "Actualiser";
            btnActu.UseVisualStyleBackColor = true;
            btnActu.Click += btnActu_Click;
            // 
            // dgvChambre
            // 
            dgvChambre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChambre.Location = new Point(691, 97);
            dgvChambre.Name = "dgvChambre";
            dgvChambre.RowHeadersWidth = 62;
            dgvChambre.Size = new Size(700, 323);
            dgvChambre.TabIndex = 17;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(205, 237);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(386, 31);
            txtContact.TabIndex = 16;
            // 
            // txtNumCh
            // 
            txtNumCh.Location = new Point(205, 168);
            txtNumCh.Name = "txtNumCh";
            txtNumCh.Size = new Size(386, 31);
            txtNumCh.TabIndex = 15;
            // 
            // txtId
            // 
            txtId.Location = new Point(205, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(386, 31);
            txtId.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 237);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 13;
            label3.Text = "Contacts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 171);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 12;
            label2.Text = "Numero";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 96);
            label1.Name = "label1";
            label1.Size = new Size(28, 25);
            label1.TabIndex = 11;
            label1.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 308);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 22;
            label4.Text = "Classe";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(208, 301);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(383, 33);
            cmbClass.TabIndex = 23;
            // 
            // Chambre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 663);
            Controls.Add(cmbClass);
            Controls.Add(label4);
            Controls.Add(BtnSupp);
            Controls.Add(BtnMod);
            Controls.Add(btnEnre);
            Controls.Add(btnActu);
            Controls.Add(dgvChambre);
            Controls.Add(txtContact);
            Controls.Add(txtNumCh);
            Controls.Add(txtId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Chambre";
            Text = "Chambre";
            Load += Chambre_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChambre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnSupp;
        private Button BtnMod;
        private Button btnEnre;
        private Button btnActu;
        private DataGridView dgvChambre;
        private TextBox txtContact;
        private TextBox txtNumCh;
        private TextBox txtId;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private ComboBox cmbClass;
    }
}