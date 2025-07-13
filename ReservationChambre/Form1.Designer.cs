namespace ReservationChambre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnClient = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(40, 73);
            button1.Name = "button1";
            button1.Size = new Size(182, 89);
            button1.TabIndex = 0;
            button1.Text = "Categorisation Client";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(281, 73);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(128, 89);
            btnClient.TabIndex = 1;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // button2
            // 
            button2.Location = new Point(486, 73);
            button2.Name = "button2";
            button2.Size = new Size(157, 89);
            button2.TabIndex = 2;
            button2.Text = "Classe de Chambre";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(713, 73);
            button3.Name = "button3";
            button3.Size = new Size(151, 89);
            button3.TabIndex = 3;
            button3.Text = "Chambre";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(940, 73);
            button4.Name = "button4";
            button4.Size = new Size(161, 89);
            button4.TabIndex = 4;
            button4.Text = "Reservation des chambres";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnClient);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnClient;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
