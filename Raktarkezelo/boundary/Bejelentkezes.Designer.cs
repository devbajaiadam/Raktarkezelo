
namespace Raktarkezelo.boundary
{
    partial class Bejelentkezes
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bejelentkezesbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txbjelszo = new System.Windows.Forms.TextBox();
            this.txbfelhNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(188, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bejelentkezés";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bejelentkezesbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbjelszo);
            this.panel1.Controls.Add(this.txbfelhNev);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(1, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 249);
            this.panel1.TabIndex = 2;
            // 
            // bejelentkezesbtn
            // 
            this.bejelentkezesbtn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.bejelentkezesbtn.Location = new System.Drawing.Point(193, 215);
            this.bejelentkezesbtn.Name = "bejelentkezesbtn";
            this.bejelentkezesbtn.Size = new System.Drawing.Size(132, 34);
            this.bejelentkezesbtn.TabIndex = 5;
            this.bejelentkezesbtn.Text = "Bejelentkezés";
            this.bejelentkezesbtn.UseVisualStyleBackColor = false;
            this.bejelentkezesbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(66, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jelszó:";
            // 
            // txbjelszo
            // 
            this.txbjelszo.Location = new System.Drawing.Point(222, 164);
            this.txbjelszo.Name = "txbjelszo";
            this.txbjelszo.PasswordChar = '*';
            this.txbjelszo.Size = new System.Drawing.Size(215, 22);
            this.txbjelszo.TabIndex = 3;
            this.txbjelszo.UseSystemPasswordChar = true;
            // 
            // txbfelhNev
            // 
            this.txbfelhNev.Location = new System.Drawing.Point(222, 97);
            this.txbfelhNev.Name = "txbfelhNev";
            this.txbfelhNev.Size = new System.Drawing.Size(215, 22);
            this.txbfelhNev.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Felhasználónév:";
            // 
            // btnKilepes
            // 
            this.btnKilepes.BackColor = System.Drawing.Color.Transparent;
            this.btnKilepes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKilepes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKilepes.Location = new System.Drawing.Point(481, -2);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(32, 29);
            this.btnKilepes.TabIndex = 4;
            this.btnKilepes.Text = "X";
            this.btnKilepes.UseVisualStyleBackColor = false;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // Bejelentkezes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = global::Raktarkezelo.Properties.Resources.organic_food;
            this.ClientSize = new System.Drawing.Size(512, 512);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bejelentkezes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbjelszo;
        private System.Windows.Forms.TextBox txbfelhNev;
        private System.Windows.Forms.Button bejelentkezesbtn;
        private System.Windows.Forms.Button btnKilepes;
    }
}