using System;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class Arufelvitel : Form
    {
        //------------------------SQL Lekérdezések---------------------------------------------------------------------------

        public string DGVFeltoltes = "SELECT raktarTbl.aruId, raktarTbl.nev, raktarTbl.mennyEgyseg, raktarTbl.mennyiseg, raktarTbl.darabar, kategoriaTbl.nev FROM raktarTbl,kategoriaTbl WHERE raktarTbl.kategoriaId = kategoriaTbl.kategoriaId";
        public string CboxFeltolt = "SELECT kategoriaId,nev FROM KategoriaTbl";

        //----------------------------------------------Változók-------------------------------------------------------------
        int Id = -1;
        string nevEllenorzes;
        public Arufelvitel()
        {
            InitializeComponent();
            ABKezelo.DGVFeltoltes(DGVAruFelvitel, DGVFeltoltes);
            ABKezelo.cboxfeltoltAru(cboxAruKategoria, CboxFeltolt);
            if (DGVAruFelvitel.Rows.Count != 0)
            {
                DGVAruFelvitel.Columns[0].HeaderText = "Azonosító";
                DGVAruFelvitel.Columns[1].HeaderText = "Név";
                DGVAruFelvitel.Columns[2].HeaderText = "M.E.";
                DGVAruFelvitel.Columns[3].HeaderText = "Mennyiség";
                DGVAruFelvitel.Columns[4].HeaderText = "Darabár";
                DGVAruFelvitel.Columns[5].HeaderText = "Kategória";
            }
        }
        public void Frissit()
        {
            txbAruNev.Text = "";
            nudAruDarabar.Value = 0;
            txbAruME.Text = "";
            nudAruMennyiseg.Value = 0;
            cboxAruKategoria.SelectedIndex = -1;
            Id = -1;
            ABKezelo.cboxfeltoltAru(cboxAruKategoria, CboxFeltolt);
            ABKezelo.DGVFeltoltes(DGVAruFelvitel, DGVFeltoltes);
            if (DGVAruFelvitel.Rows.Count != 0)
            {
                DGVAruFelvitel.Columns[0].HeaderText = "Azonosító";
                DGVAruFelvitel.Columns[1].HeaderText = "Név";
                DGVAruFelvitel.Columns[2].HeaderText = "M.E.";
                DGVAruFelvitel.Columns[3].HeaderText = "Mennyiség";
                DGVAruFelvitel.Columns[4].HeaderText = "Darabár";
                DGVAruFelvitel.Columns[5].HeaderText = "Kategória";
            }
        }

        #region Új kategória felvitele
        private void btnAruUjKategoria_Click(object sender, EventArgs e)
        {
            UjKategoriaFelvitelForm ujKatForm = new UjKategoriaFelvitelForm();
            this.Hide();
            if (ujKatForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                Frissit();
            }
        }
        #endregion

        #region Árufelvitel
        private void btnAruHozzaad_Click(object sender, EventArgs e)
        {
            if (cboxAruKategoria.Text != "")
            {
                AruFelvitelAdatbazisba ujArufelvitel = new AruFelvitelAdatbazisba();
                this.Hide();
                if (ujArufelvitel.ShowDialog() == DialogResult.OK)
                {
                    this.Show();
                    Frissit();
                }
            }
            else
            {
                MessageBox.Show("Nincs megjelenítendő kategória!, kérem hozon létre kategóriát mielött árut visz fel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void DGVAruFelvitel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVAruFelvitel.SelectedRows.Count != 0)
            {
                try
                {
                    Id = (int)DGVAruFelvitel.SelectedRows[0].Cells[0].Value;
                    txbAruNev.Text = DGVAruFelvitel.SelectedRows[0].Cells[1].Value.ToString();
                    nevEllenorzes = DGVAruFelvitel.SelectedRows[0].Cells[1].Value.ToString();
                    txbAruME.Text = DGVAruFelvitel.SelectedRows[0].Cells[2].Value.ToString();
                    nudAruMennyiseg.Value = (int)DGVAruFelvitel.SelectedRows[0].Cells[3].Value;
                    nudAruDarabar.Value = (int)DGVAruFelvitel.SelectedRows[0].Cells[4].Value;
                    cboxAruKategoria.Text = DGVAruFelvitel.SelectedRows[0].Cells[5].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnAruModositas_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (Id != -1 && txbAruNev.Text != "" && txbAruME.Text != "" && (int)nudAruMennyiseg.Value != -1 && (int)nudAruDarabar.Value != -1 && (int)cboxAruKategoria.SelectedValue != -1)
            {
                dr = MessageBox.Show("Biztosan módosítani kívánja az adatokat?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool siker = ABKezelo.UjAru(new RaktarAruk(txbAruNev.Text, txbAruME.Text, (int)nudAruMennyiseg.Value, (int)nudAruDarabar.Value, (int)cboxAruKategoria.SelectedValue), "modositas", Id);
                    if (siker == true)
                    {
                        MessageBox.Show("Sikeres módosítás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frissit();
                    }
                    else
                    {
                        MessageBox.Show("Sikertelen adatfelvitel!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if(Id == -1)
            {
                MessageBox.Show("Nincs a módosításra kiválasztott elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Az összes adat kitöltése kötelező!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAruKilepes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void btnAruTorles_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (Id != -1)
            {
                dr = MessageBox.Show("Biztosan törölni kívánja a(z) kiválasztott adatot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    bool siker = ABKezelo.aruTorles(Id);
                    if (siker == true)
                    {
                        MessageBox.Show("Sikeres törlés!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frissit();
                    }
                    else
                    {
                        MessageBox.Show("Az adattörlés sikertelen!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (Id == -1)
            {
                MessageBox.Show("Nincs kiválasztott elem!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Hiba a törlés során!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Frissit();
        } 
    }
}
