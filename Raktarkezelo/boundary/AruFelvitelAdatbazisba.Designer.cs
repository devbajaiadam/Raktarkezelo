
namespace Raktarkezelo.boundary
{
    partial class AruFelvitelAdatbazisba
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxAruKategoria = new System.Windows.Forms.ComboBox();
            this.txbAruME = new System.Windows.Forms.TextBox();
            this.txbAruNev = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAruHozzaad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.nudAruMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.nudAruDarabar = new System.Windows.Forms.NumericUpDown();
            this.panelFejlec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruDarabar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFejlec
            // 
            this.panelFejlec.BackColor = System.Drawing.Color.Gray;
            this.panelFejlec.Controls.Add(this.label1);
            this.panelFejlec.Controls.Add(this.pictureBox2);
            this.panelFejlec.Location = new System.Drawing.Point(-1, 0);
            this.panelFejlec.Name = "panelFejlec";
            this.panelFejlec.Size = new System.Drawing.Size(466, 46);
            this.panelFejlec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Felvitel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Raktarkezelo.Properties.Resources.Appe_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mennyisegi egyseg";
            // 
            // cboxAruKategoria
            // 
            this.cboxAruKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAruKategoria.FormattingEnabled = true;
            this.cboxAruKategoria.Location = new System.Drawing.Point(172, 287);
            this.cboxAruKategoria.Name = "cboxAruKategoria";
            this.cboxAruKategoria.Size = new System.Drawing.Size(255, 24);
            this.cboxAruKategoria.TabIndex = 42;
            // 
            // txbAruME
            // 
            this.txbAruME.Location = new System.Drawing.Point(172, 183);
            this.txbAruME.Name = "txbAruME";
            this.txbAruME.Size = new System.Drawing.Size(255, 22);
            this.txbAruME.TabIndex = 41;
            this.txbAruME.TextChanged += new System.EventHandler(this.txbAruME_TextChanged);
            // 
            // txbAruNev
            // 
            this.txbAruNev.Location = new System.Drawing.Point(172, 71);
            this.txbAruNev.Name = "txbAruNev";
            this.txbAruNev.Size = new System.Drawing.Size(255, 22);
            this.txbAruNev.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Kategória";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Darabár";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Mennyiség";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Név";
            // 
            // btnAruHozzaad
            // 
            this.btnAruHozzaad.Location = new System.Drawing.Point(12, 365);
            this.btnAruHozzaad.Name = "btnAruHozzaad";
            this.btnAruHozzaad.Size = new System.Drawing.Size(208, 35);
            this.btnAruHozzaad.TabIndex = 45;
            this.btnAruHozzaad.Text = "Árú hozzáadása";
            this.btnAruHozzaad.UseVisualStyleBackColor = true;
            this.btnAruHozzaad.Click += new System.EventHandler(this.btnAruHozzaad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 35);
            this.button1.TabIndex = 46;
            this.button1.Text = "Kilépés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nudAruMennyiseg
            // 
            this.nudAruMennyiseg.Location = new System.Drawing.Point(172, 126);
            this.nudAruMennyiseg.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAruMennyiseg.Name = "nudAruMennyiseg";
            this.nudAruMennyiseg.Size = new System.Drawing.Size(255, 22);
            this.nudAruMennyiseg.TabIndex = 47;
            // 
            // nudAruDarabar
            // 
            this.nudAruDarabar.Location = new System.Drawing.Point(172, 235);
            this.nudAruDarabar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAruDarabar.Name = "nudAruDarabar";
            this.nudAruDarabar.Size = new System.Drawing.Size(255, 22);
            this.nudAruDarabar.TabIndex = 48;
            // 
            // AruFelvitelAdatbazisba
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(464, 412);
            this.Controls.Add(this.nudAruDarabar);
            this.Controls.Add(this.nudAruMennyiseg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAruHozzaad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxAruKategoria);
            this.Controls.Add(this.txbAruME);
            this.Controls.Add(this.txbAruNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AruFelvitelAdatbazisba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AruFelvitelAdatbazisba";
            this.panelFejlec.ResumeLayout(false);
            this.panelFejlec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruDarabar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFejlec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxAruKategoria;
        private System.Windows.Forms.TextBox txbAruME;
        private System.Windows.Forms.TextBox txbAruNev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAruHozzaad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nudAruMennyiseg;
        private System.Windows.Forms.NumericUpDown nudAruDarabar;
    }
}