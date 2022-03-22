
namespace Raktarkezelo.boundary
{
    partial class JelszoModositas
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
            this.panelFejlec = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.btnJelszoModosit = new System.Windows.Forms.Button();
            this.txbRegiJelszo = new System.Windows.Forms.TextBox();
            this.txbUjJelszo = new System.Windows.Forms.TextBox();
            this.txbUjJelszoUjra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRegiJelszo = new System.Windows.Forms.Label();
            this.lblUjJelszo = new System.Windows.Forms.Label();
            this.lblUJelszoUjra = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFejlec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFejlec
            // 
            this.panelFejlec.BackColor = System.Drawing.Color.Gray;
            this.panelFejlec.Controls.Add(this.pictureBox2);
            this.panelFejlec.Controls.Add(this.label1);
            this.panelFejlec.Location = new System.Drawing.Point(0, 0);
            this.panelFejlec.Name = "panelFejlec";
            this.panelFejlec.Size = new System.Drawing.Size(564, 45);
            this.panelFejlec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jelszómódosítás";
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(381, 307);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(172, 47);
            this.btnKilepes.TabIndex = 40;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // btnJelszoModosit
            // 
            this.btnJelszoModosit.Location = new System.Drawing.Point(12, 307);
            this.btnJelszoModosit.Name = "btnJelszoModosit";
            this.btnJelszoModosit.Size = new System.Drawing.Size(172, 47);
            this.btnJelszoModosit.TabIndex = 41;
            this.btnJelszoModosit.Text = "Jelszó Módosítása";
            this.btnJelszoModosit.UseVisualStyleBackColor = true;
            this.btnJelszoModosit.Click += new System.EventHandler(this.btnJelszoModosit_Click);
            // 
            // txbRegiJelszo
            // 
            this.txbRegiJelszo.Location = new System.Drawing.Point(201, 86);
            this.txbRegiJelszo.Name = "txbRegiJelszo";
            this.txbRegiJelszo.PasswordChar = '*';
            this.txbRegiJelszo.Size = new System.Drawing.Size(352, 22);
            this.txbRegiJelszo.TabIndex = 42;
            this.txbRegiJelszo.TextChanged += new System.EventHandler(this.txbRegiJelszo_TextChanged);
            // 
            // txbUjJelszo
            // 
            this.txbUjJelszo.Location = new System.Drawing.Point(201, 156);
            this.txbUjJelszo.Name = "txbUjJelszo";
            this.txbUjJelszo.PasswordChar = '*';
            this.txbUjJelszo.Size = new System.Drawing.Size(352, 22);
            this.txbUjJelszo.TabIndex = 43;
            this.txbUjJelszo.TextChanged += new System.EventHandler(this.txbUjJelszo_TextChanged);
            // 
            // txbUjJelszoUjra
            // 
            this.txbUjJelszoUjra.Location = new System.Drawing.Point(201, 226);
            this.txbUjJelszoUjra.Name = "txbUjJelszoUjra";
            this.txbUjJelszoUjra.PasswordChar = '*';
            this.txbUjJelszoUjra.Size = new System.Drawing.Size(352, 22);
            this.txbUjJelszoUjra.TabIndex = 44;
            this.txbUjJelszoUjra.TextChanged += new System.EventHandler(this.txbUjJelszoUjra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Régi jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 46;
            this.label3.Text = "Új jelszó:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Új jelszó mégegyszer:";
            // 
            // lblRegiJelszo
            // 
            this.lblRegiJelszo.AutoSize = true;
            this.lblRegiJelszo.Location = new System.Drawing.Point(481, 111);
            this.lblRegiJelszo.Name = "lblRegiJelszo";
            this.lblRegiJelszo.Size = new System.Drawing.Size(72, 17);
            this.lblRegiJelszo.TabIndex = 48;
            this.lblRegiJelszo.Text = "Megjelenít";
            this.lblRegiJelszo.Click += new System.EventHandler(this.lblRegiJelszo_Click);
            // 
            // lblUjJelszo
            // 
            this.lblUjJelszo.AutoSize = true;
            this.lblUjJelszo.Location = new System.Drawing.Point(481, 181);
            this.lblUjJelszo.Name = "lblUjJelszo";
            this.lblUjJelszo.Size = new System.Drawing.Size(72, 17);
            this.lblUjJelszo.TabIndex = 49;
            this.lblUjJelszo.Text = "Megjelenít";
            this.lblUjJelszo.Click += new System.EventHandler(this.lblUjJelszo_Click);
            // 
            // lblUJelszoUjra
            // 
            this.lblUJelszoUjra.AutoSize = true;
            this.lblUJelszoUjra.Location = new System.Drawing.Point(481, 251);
            this.lblUJelszoUjra.Name = "lblUJelszoUjra";
            this.lblUJelszoUjra.Size = new System.Drawing.Size(72, 17);
            this.lblUJelszoUjra.TabIndex = 50;
            this.lblUJelszoUjra.Text = "Megjelenít";
            this.lblUJelszoUjra.Click += new System.EventHandler(this.lblUJelszoUjra_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Raktarkezelo.Properties.Resources.Appe_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(47, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // jelszoModositas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 366);
            this.Controls.Add(this.lblUJelszoUjra);
            this.Controls.Add(this.lblUjJelszo);
            this.Controls.Add(this.lblRegiJelszo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUjJelszoUjra);
            this.Controls.Add(this.txbUjJelszo);
            this.Controls.Add(this.txbRegiJelszo);
            this.Controls.Add(this.btnJelszoModosit);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.panelFejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "jelszoModositas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgalomStatisztika";
            this.panelFejlec.ResumeLayout(false);
            this.panelFejlec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFejlec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.Button btnJelszoModosit;
        private System.Windows.Forms.TextBox txbRegiJelszo;
        private System.Windows.Forms.TextBox txbUjJelszo;
        private System.Windows.Forms.TextBox txbUjJelszoUjra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRegiJelszo;
        private System.Windows.Forms.Label lblUjJelszo;
        private System.Windows.Forms.Label lblUJelszoUjra;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}