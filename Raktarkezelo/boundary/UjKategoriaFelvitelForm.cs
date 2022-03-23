using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class UjKategoriaFelvitelForm : Form
    {
        //------------------------SQL Lekérdezések---------------------------------------------------------------------------

        string DGVFeltoltes = "SELECT * FROM kategoriaTbl";

        //----------------------------------------------Változók-------------------------------------------------------------

        string nevEllenorzes;
        int kijeloltId;

        public UjKategoriaFelvitelForm()
        {
            InitializeComponent();
            ABKezelo.DGVFeltoltes(dgvKat, DGVFeltoltes);
            dgvKat.AutoResizeColumns();
            if (dgvKat.Rows.Count != 0)
            {
                dgvKat.Columns[0].HeaderText = "Azonosító";
                dgvKat.Columns[1].HeaderText = "Név";
                dgvKat.Columns[2].HeaderText = "Leírás";
            }
        }

        public void Frissit()
        {
            txbKatNeve.Text = "";
            txbKatLeiras.Text = "";
            ABKezelo.DGVFeltoltes(dgvKat, DGVFeltoltes);
            if (dgvKat.Rows.Count != 0)
            {
                dgvKat.Columns[0].HeaderText = "Azonosító";
                dgvKat.Columns[1].HeaderText = "Név";
                dgvKat.Columns[2].HeaderText = "Leírás";
            }
        }

        private void dgvKat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKat.SelectedRows.Count != 0)
            {
                try
                {
                    kijeloltId = (int)dgvKat.SelectedRows[0].Cells[0].Value;
                    txbKatNeve.Text = dgvKat.SelectedRows[0].Cells[1].Value.ToString();
                    nevEllenorzes = dgvKat.SelectedRows[0].Cells[1].Value.ToString();
                    txbKatLeiras.Text = dgvKat.SelectedRows[0].Cells[2].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if (txbKatNeve.Text != nevEllenorzes && txbKatNeve.Text != "")
            {
                Tuple<string, string> kategoria = Tuple.Create(txbKatNeve.Text, txbKatLeiras.Text);
                try
                {
                    bool siker = ABKezelo.KatVagyAruFelvitel(kategoria);
                    if (siker == true)
                    {
                        MessageBox.Show("Sikeres adatfelvitel!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frissit();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Sikertelen adatfelvitel!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (txbKatNeve.Text == nevEllenorzes)
            {
                MessageBox.Show("A kiválasztott név már létezik!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sikertelen adatfelvitel!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFrissit_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (txbKatNeve.Text == nevEllenorzes && txbKatNeve.Text != "")
            {
                DialogResult dr;
                dr = MessageBox.Show("Biztosan törölni kívánja a kiválasztott adatot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ABKezelo.KategoriaTorles(kijeloltId);
                        MessageBox.Show("A kiválasztott elem törlésre került!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Frissit();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Hiba a törlés során!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
