
namespace Raktarkezelo.boundary
{
    partial class EladasForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTermeknev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTermekHozzaad = new System.Windows.Forms.Button();
            this.btnEladasVeglegesit = new System.Windows.Forms.Button();
            this.btnkilepes = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DGVAktualisRaktar = new System.Windows.Forms.DataGridView();
            this.DGVKosar = new System.Windows.Forms.DataGridView();
            this.nudEladasAzonosito = new System.Windows.Forms.NumericUpDown();
            this.nudTermekar = new System.Windows.Forms.NumericUpDown();
            this.nudMennyiseg = new System.Windows.Forms.NumericUpDown();
            this.btnMennyisegModosit = new System.Windows.Forms.Button();
            this.lblReszosszeg = new System.Windows.Forms.Label();
            this.btnTorlesOszbol = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFejlec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAktualisRaktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKosar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasAzonosito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermekar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFejlec
            // 
            this.panelFejlec.BackColor = System.Drawing.Color.Gray;
            this.panelFejlec.Controls.Add(this.label1);
            this.panelFejlec.Controls.Add(this.pictureBox2);
            this.panelFejlec.Location = new System.Drawing.Point(0, 0);
            this.panelFejlec.Name = "panelFejlec";
            this.panelFejlec.Size = new System.Drawing.Size(1091, 47);
            this.panelFejlec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(460, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eladási Felület";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Eladás azonosító:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(717, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Terméknév:";
            // 
            // txbTermeknev
            // 
            this.txbTermeknev.Location = new System.Drawing.Point(843, 345);
            this.txbTermeknev.Name = "txbTermeknev";
            this.txbTermeknev.Size = new System.Drawing.Size(232, 22);
            this.txbTermeknev.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Termékár:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mennyiség:";
            // 
            // btnTermekHozzaad
            // 
            this.btnTermekHozzaad.Location = new System.Drawing.Point(712, 511);
            this.btnTermekHozzaad.Name = "btnTermekHozzaad";
            this.btnTermekHozzaad.Size = new System.Drawing.Size(172, 47);
            this.btnTermekHozzaad.TabIndex = 14;
            this.btnTermekHozzaad.Text = "Termék hozzáadása";
            this.btnTermekHozzaad.UseVisualStyleBackColor = true;
            this.btnTermekHozzaad.Click += new System.EventHandler(this.btnTermekHozzaad_Click);
            // 
            // btnEladasVeglegesit
            // 
            this.btnEladasVeglegesit.Location = new System.Drawing.Point(906, 564);
            this.btnEladasVeglegesit.Name = "btnEladasVeglegesit";
            this.btnEladasVeglegesit.Size = new System.Drawing.Size(172, 47);
            this.btnEladasVeglegesit.TabIndex = 15;
            this.btnEladasVeglegesit.Text = "Eladás véglegesítése";
            this.btnEladasVeglegesit.UseVisualStyleBackColor = true;
            this.btnEladasVeglegesit.Click += new System.EventHandler(this.btnEladasVeglegesit_Click);
            // 
            // btnkilepes
            // 
            this.btnkilepes.Location = new System.Drawing.Point(903, 618);
            this.btnkilepes.Name = "btnkilepes";
            this.btnkilepes.Size = new System.Drawing.Size(172, 47);
            this.btnkilepes.TabIndex = 17;
            this.btnkilepes.Text = "Kilépés a főmenübe";
            this.btnkilepes.UseVisualStyleBackColor = true;
            this.btnkilepes.Click += new System.EventHandler(this.btnkilepes_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Termék iválasztása:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(12, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Termékek összesítése:";
            // 
            // DGVAktualisRaktar
            // 
            this.DGVAktualisRaktar.AllowUserToAddRows = false;
            this.DGVAktualisRaktar.AllowUserToDeleteRows = false;
            this.DGVAktualisRaktar.AllowUserToResizeColumns = false;
            this.DGVAktualisRaktar.AllowUserToResizeRows = false;
            this.DGVAktualisRaktar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVAktualisRaktar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVAktualisRaktar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAktualisRaktar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVAktualisRaktar.Location = new System.Drawing.Point(16, 79);
            this.DGVAktualisRaktar.Name = "DGVAktualisRaktar";
            this.DGVAktualisRaktar.ReadOnly = true;
            this.DGVAktualisRaktar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVAktualisRaktar.RowHeadersVisible = false;
            this.DGVAktualisRaktar.RowHeadersWidth = 51;
            this.DGVAktualisRaktar.RowTemplate.Height = 24;
            this.DGVAktualisRaktar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVAktualisRaktar.Size = new System.Drawing.Size(598, 274);
            this.DGVAktualisRaktar.TabIndex = 31;
            this.DGVAktualisRaktar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAktualirRaktar_CellContentClick);
            // 
            // DGVKosar
            // 
            this.DGVKosar.AllowUserToAddRows = false;
            this.DGVKosar.AllowUserToDeleteRows = false;
            this.DGVKosar.AllowUserToResizeColumns = false;
            this.DGVKosar.AllowUserToResizeRows = false;
            this.DGVKosar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVKosar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGVKosar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVKosar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVKosar.Location = new System.Drawing.Point(12, 391);
            this.DGVKosar.Name = "DGVKosar";
            this.DGVKosar.ReadOnly = true;
            this.DGVKosar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DGVKosar.RowHeadersVisible = false;
            this.DGVKosar.RowHeadersWidth = 51;
            this.DGVKosar.RowTemplate.Height = 24;
            this.DGVKosar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVKosar.Size = new System.Drawing.Size(602, 274);
            this.DGVKosar.TabIndex = 33;
            this.DGVKosar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVKosar_CellContentClick);
            // 
            // nudEladasAzonosito
            // 
            this.nudEladasAzonosito.Location = new System.Drawing.Point(843, 302);
            this.nudEladasAzonosito.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudEladasAzonosito.Name = "nudEladasAzonosito";
            this.nudEladasAzonosito.Size = new System.Drawing.Size(235, 22);
            this.nudEladasAzonosito.TabIndex = 34;
            // 
            // nudTermekar
            // 
            this.nudTermekar.Location = new System.Drawing.Point(843, 388);
            this.nudTermekar.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTermekar.Name = "nudTermekar";
            this.nudTermekar.Size = new System.Drawing.Size(235, 22);
            this.nudTermekar.TabIndex = 35;
            // 
            // nudMennyiseg
            // 
            this.nudMennyiseg.Location = new System.Drawing.Point(843, 432);
            this.nudMennyiseg.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudMennyiseg.Name = "nudMennyiseg";
            this.nudMennyiseg.Size = new System.Drawing.Size(235, 22);
            this.nudMennyiseg.TabIndex = 36;
            // 
            // btnMennyisegModosit
            // 
            this.btnMennyisegModosit.Location = new System.Drawing.Point(712, 564);
            this.btnMennyisegModosit.Name = "btnMennyisegModosit";
            this.btnMennyisegModosit.Size = new System.Drawing.Size(172, 47);
            this.btnMennyisegModosit.TabIndex = 37;
            this.btnMennyisegModosit.Text = "Mennyiség módosítása";
            this.btnMennyisegModosit.UseVisualStyleBackColor = true;
            this.btnMennyisegModosit.Click += new System.EventHandler(this.btnMennyisegModosit_Click);
            // 
            // lblReszosszeg
            // 
            this.lblReszosszeg.AutoSize = true;
            this.lblReszosszeg.Location = new System.Drawing.Point(511, 371);
            this.lblReszosszeg.Name = "lblReszosszeg";
            this.lblReszosszeg.Size = new System.Drawing.Size(46, 17);
            this.lblReszosszeg.TabIndex = 38;
            this.lblReszosszeg.Text = "label9";
            // 
            // btnTorlesOszbol
            // 
            this.btnTorlesOszbol.Location = new System.Drawing.Point(906, 511);
            this.btnTorlesOszbol.Name = "btnTorlesOszbol";
            this.btnTorlesOszbol.Size = new System.Drawing.Size(172, 47);
            this.btnTorlesOszbol.TabIndex = 39;
            this.btnTorlesOszbol.Text = "Kiválasztott elem törlése";
            this.btnTorlesOszbol.UseVisualStyleBackColor = true;
            this.btnTorlesOszbol.Click += new System.EventHandler(this.btnTorlesOszbol_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Raktarkezelo.Properties.Resources.Bejelentkezes_612x436;
            this.pictureBox1.Location = new System.Drawing.Point(782, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // eladasForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1090, 677);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTorlesOszbol);
            this.Controls.Add(this.lblReszosszeg);
            this.Controls.Add(this.btnMennyisegModosit);
            this.Controls.Add(this.nudMennyiseg);
            this.Controls.Add(this.nudTermekar);
            this.Controls.Add(this.nudEladasAzonosito);
            this.Controls.Add(this.DGVKosar);
            this.Controls.Add(this.DGVAktualisRaktar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnkilepes);
            this.Controls.Add(this.btnEladasVeglegesit);
            this.Controls.Add(this.btnTermekHozzaad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTermeknev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "eladasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelFejlec.ResumeLayout(false);
            this.panelFejlec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVAktualisRaktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVKosar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEladasAzonosito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermekar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMennyiseg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFejlec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTermeknev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTermekHozzaad;
        private System.Windows.Forms.Button btnEladasVeglegesit;
        private System.Windows.Forms.Button btnkilepes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVAktualisRaktar;
        private System.Windows.Forms.DataGridView DGVKosar;
        private System.Windows.Forms.NumericUpDown nudEladasAzonosito;
        private System.Windows.Forms.NumericUpDown nudTermekar;
        private System.Windows.Forms.NumericUpDown nudMennyiseg;
        private System.Windows.Forms.Button btnMennyisegModosit;
        private System.Windows.Forms.Label lblReszosszeg;
        private System.Windows.Forms.Button btnTorlesOszbol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}