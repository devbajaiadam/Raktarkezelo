
namespace Raktarkezelo.boundary
{
    partial class Arufelvitel
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnAruHozzaad = new System.Windows.Forms.Button();
            this.btnAruModositas = new System.Windows.Forms.Button();
            this.btnAruTorles = new System.Windows.Forms.Button();
            this.btnAruKilepes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbAruNev = new System.Windows.Forms.TextBox();
            this.cboxAruKategoria = new System.Windows.Forms.ComboBox();
            this.btnAruUjKategoria = new System.Windows.Forms.Button();
            this.DGVAruFelvitel = new System.Windows.Forms.DataGridView();
            this.txbAruME = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAruMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.nudAruDarabar = new System.Windows.Forms.NumericUpDown();
            this.panelFejlec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAruFelvitel)).BeginInit();
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
            this.panelFejlec.Size = new System.Drawing.Size(1090, 46);
            this.panelFejlec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(477, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Árukezelés";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(912, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Frissítés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAruHozzaad
            // 
            this.btnAruHozzaad.Location = new System.Drawing.Point(657, 452);
            this.btnAruHozzaad.Name = "btnAruHozzaad";
            this.btnAruHozzaad.Size = new System.Drawing.Size(208, 35);
            this.btnAruHozzaad.TabIndex = 17;
            this.btnAruHozzaad.Text = "Új áru hozzáadása";
            this.btnAruHozzaad.UseVisualStyleBackColor = true;
            this.btnAruHozzaad.Click += new System.EventHandler(this.btnAruHozzaad_Click);
            // 
            // btnAruModositas
            // 
            this.btnAruModositas.Location = new System.Drawing.Point(443, 452);
            this.btnAruModositas.Name = "btnAruModositas";
            this.btnAruModositas.Size = new System.Drawing.Size(208, 35);
            this.btnAruModositas.TabIndex = 18;
            this.btnAruModositas.Text = "Árú Módosítás";
            this.btnAruModositas.UseVisualStyleBackColor = true;
            this.btnAruModositas.Click += new System.EventHandler(this.btnAruModositas_Click);
            // 
            // btnAruTorles
            // 
            this.btnAruTorles.Location = new System.Drawing.Point(226, 452);
            this.btnAruTorles.Name = "btnAruTorles";
            this.btnAruTorles.Size = new System.Drawing.Size(208, 35);
            this.btnAruTorles.TabIndex = 19;
            this.btnAruTorles.Text = "Árú törlése";
            this.btnAruTorles.UseVisualStyleBackColor = true;
            this.btnAruTorles.Click += new System.EventHandler(this.btnAruTorles_Click);
            // 
            // btnAruKilepes
            // 
            this.btnAruKilepes.Location = new System.Drawing.Point(12, 452);
            this.btnAruKilepes.Name = "btnAruKilepes";
            this.btnAruKilepes.Size = new System.Drawing.Size(208, 35);
            this.btnAruKilepes.TabIndex = 20;
            this.btnAruKilepes.Text = "Kilépés a főmenübe";
            this.btnAruKilepes.UseVisualStyleBackColor = true;
            this.btnAruKilepes.Click += new System.EventHandler(this.btnAruKilepes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mennyiség";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Darabár";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kategória";
            // 
            // txbAruNev
            // 
            this.txbAruNev.Location = new System.Drawing.Point(807, 147);
            this.txbAruNev.Name = "txbAruNev";
            this.txbAruNev.Size = new System.Drawing.Size(255, 22);
            this.txbAruNev.TabIndex = 25;
            // 
            // cboxAruKategoria
            // 
            this.cboxAruKategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxAruKategoria.FormattingEnabled = true;
            this.cboxAruKategoria.Location = new System.Drawing.Point(807, 363);
            this.cboxAruKategoria.Name = "cboxAruKategoria";
            this.cboxAruKategoria.Size = new System.Drawing.Size(255, 24);
            this.cboxAruKategoria.TabIndex = 28;
            // 
            // btnAruUjKategoria
            // 
            this.btnAruUjKategoria.Location = new System.Drawing.Point(871, 452);
            this.btnAruUjKategoria.Name = "btnAruUjKategoria";
            this.btnAruUjKategoria.Size = new System.Drawing.Size(208, 35);
            this.btnAruUjKategoria.TabIndex = 31;
            this.btnAruUjKategoria.Text = "Új kategória felvitele";
            this.btnAruUjKategoria.UseVisualStyleBackColor = true;
            this.btnAruUjKategoria.Click += new System.EventHandler(this.btnAruUjKategoria_Click);
            // 
            // DGVAruFelvitel
            // 
            this.DGVAruFelvitel.AllowUserToAddRows = false;
            this.DGVAruFelvitel.AllowUserToDeleteRows = false;
            this.DGVAruFelvitel.AllowUserToResizeColumns = false;
            this.DGVAruFelvitel.AllowUserToResizeRows = false;
            this.DGVAruFelvitel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAruFelvitel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAruFelvitel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAruFelvitel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAruFelvitel.Location = new System.Drawing.Point(12, 67);
            this.DGVAruFelvitel.Name = "DGVAruFelvitel";
            this.DGVAruFelvitel.ReadOnly = true;
            this.DGVAruFelvitel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAruFelvitel.RowHeadersVisible = false;
            this.DGVAruFelvitel.RowHeadersWidth = 51;
            this.DGVAruFelvitel.RowTemplate.Height = 24;
            this.DGVAruFelvitel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAruFelvitel.Size = new System.Drawing.Size(639, 365);
            this.DGVAruFelvitel.TabIndex = 32;
            this.DGVAruFelvitel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAruFelvitel_CellContentClick);
            // 
            // txbAruME
            // 
            this.txbAruME.Location = new System.Drawing.Point(807, 259);
            this.txbAruME.Name = "txbAruME";
            this.txbAruME.Size = new System.Drawing.Size(255, 22);
            this.txbAruME.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(672, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 34;
            this.label6.Text = "Mennyisegi egyseg";
            // 
            // nudAruMennyiseg
            // 
            this.nudAruMennyiseg.Location = new System.Drawing.Point(807, 202);
            this.nudAruMennyiseg.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAruMennyiseg.Name = "nudAruMennyiseg";
            this.nudAruMennyiseg.Size = new System.Drawing.Size(255, 22);
            this.nudAruMennyiseg.TabIndex = 48;
            // 
            // nudAruDarabar
            // 
            this.nudAruDarabar.Location = new System.Drawing.Point(807, 311);
            this.nudAruDarabar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudAruDarabar.Name = "nudAruDarabar";
            this.nudAruDarabar.Size = new System.Drawing.Size(255, 22);
            this.nudAruDarabar.TabIndex = 49;
            // 
            // arufelvitelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1089, 503);
            this.Controls.Add(this.nudAruDarabar);
            this.Controls.Add(this.nudAruMennyiseg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGVAruFelvitel);
            this.Controls.Add(this.btnAruUjKategoria);
            this.Controls.Add(this.cboxAruKategoria);
            this.Controls.Add(this.txbAruME);
            this.Controls.Add(this.txbAruNev);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAruKilepes);
            this.Controls.Add(this.btnAruTorles);
            this.Controls.Add(this.btnAruModositas);
            this.Controls.Add(this.btnAruHozzaad);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelFejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "arufelvitelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "arufelvitelForm";
            this.panelFejlec.ResumeLayout(false);
            this.panelFejlec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAruFelvitel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAruDarabar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFejlec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAruHozzaad;
        private System.Windows.Forms.Button btnAruModositas;
        private System.Windows.Forms.Button btnAruTorles;
        private System.Windows.Forms.Button btnAruKilepes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbAruNev;
        private System.Windows.Forms.ComboBox cboxAruKategoria;
        private System.Windows.Forms.Button btnAruUjKategoria;
        private System.Windows.Forms.DataGridView DGVAruFelvitel;
        private System.Windows.Forms.TextBox txbAruME;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAruMennyiseg;
        private System.Windows.Forms.NumericUpDown nudAruDarabar;
    }
}