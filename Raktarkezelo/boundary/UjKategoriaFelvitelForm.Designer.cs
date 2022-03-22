
namespace Raktarkezelo.boundary
{
    partial class UjKategoriaFelvitelForm
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
            this.dgvKat = new System.Windows.Forms.DataGridView();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.txbKatNeve = new System.Windows.Forms.TextBox();
            this.txbKatLeiras = new System.Windows.Forms.TextBox();
            this.btnFrissit = new System.Windows.Forms.Button();
            this.panelFejlec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFejlec
            // 
            this.panelFejlec.BackColor = System.Drawing.Color.Gray;
            this.panelFejlec.Controls.Add(this.label1);
            this.panelFejlec.Controls.Add(this.pictureBox2);
            this.panelFejlec.Location = new System.Drawing.Point(0, 0);
            this.panelFejlec.Name = "panelFejlec";
            this.panelFejlec.Size = new System.Drawing.Size(518, 42);
            this.panelFejlec.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Új Kategória Felvitele";
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
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Leírás:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategória Neve:";
            // 
            // dgvKat
            // 
            this.dgvKat.AllowUserToAddRows = false;
            this.dgvKat.AllowUserToDeleteRows = false;
            this.dgvKat.AllowUserToResizeColumns = false;
            this.dgvKat.AllowUserToResizeRows = false;
            this.dgvKat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvKat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKat.Location = new System.Drawing.Point(12, 138);
            this.dgvKat.Name = "dgvKat";
            this.dgvKat.ReadOnly = true;
            this.dgvKat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKat.RowHeadersVisible = false;
            this.dgvKat.RowHeadersWidth = 51;
            this.dgvKat.RowTemplate.Height = 24;
            this.dgvKat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKat.Size = new System.Drawing.Size(335, 170);
            this.dgvKat.TabIndex = 5;
            this.dgvKat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKat_CellContentClick);
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(353, 182);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(155, 38);
            this.btnHozzaad.TabIndex = 6;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(353, 226);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(155, 38);
            this.btnTorles.TabIndex = 7;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(353, 270);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(155, 38);
            this.btnKilepes.TabIndex = 8;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // txbKatNeve
            // 
            this.txbKatNeve.Location = new System.Drawing.Point(124, 58);
            this.txbKatNeve.Name = "txbKatNeve";
            this.txbKatNeve.Size = new System.Drawing.Size(382, 22);
            this.txbKatNeve.TabIndex = 9;
            // 
            // txbKatLeiras
            // 
            this.txbKatLeiras.Location = new System.Drawing.Point(124, 96);
            this.txbKatLeiras.Multiline = true;
            this.txbKatLeiras.Name = "txbKatLeiras";
            this.txbKatLeiras.Size = new System.Drawing.Size(382, 22);
            this.txbKatLeiras.TabIndex = 10;
            // 
            // btnFrissit
            // 
            this.btnFrissit.Location = new System.Drawing.Point(353, 138);
            this.btnFrissit.Name = "btnFrissit";
            this.btnFrissit.Size = new System.Drawing.Size(155, 38);
            this.btnFrissit.TabIndex = 11;
            this.btnFrissit.Text = "Frissítés";
            this.btnFrissit.UseVisualStyleBackColor = true;
            this.btnFrissit.Click += new System.EventHandler(this.btnFrissit_Click);
            // 
            // ujKategoriaFelvitelForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(518, 323);
            this.Controls.Add(this.btnFrissit);
            this.Controls.Add(this.txbKatLeiras);
            this.Controls.Add(this.txbKatNeve);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.dgvKat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelFejlec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ujKategoriaFelvitelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelFejlec.ResumeLayout(false);
            this.panelFejlec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelFejlec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvKat;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnKilepes;
        private System.Windows.Forms.TextBox txbKatNeve;
        private System.Windows.Forms.TextBox txbKatLeiras;
        private System.Windows.Forms.Button btnFrissit;
    }
}