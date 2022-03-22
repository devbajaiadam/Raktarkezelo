using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class EladasForm : Form
    {
        //-------------------------------------------SQL----------------------------------------------------------------

        public string aktualisRaktarLekerdezes = "SELECT aruId, nev, mennyEgyseg, mennyiseg, darabar FROM raktarTbl WHERE mennyiseg > 0";
        public string kosarInserCommand = "INSERT INTO [eladasTbl](datum, mennyiseg, userId) OUTPUT INSERTED.eladasId VALUES ( @datum, @mennyiseg, @userId)";
        public string kosarKapcsoloTablaCommand = "INSERT INTO [kosarTbl](eladasId, aruId, mennyiseg) VALUES (@eladasId, @aruId, @mennyiseg)";

        //-------------------------------------------DGV AKTUALIS RAKTAR VALTOZOK----------------------------------------

        DataTable dataTableAktualisArukeszlet;
        DataTable dataTableKosar = new DataTable();
        public string nevEllenorzes;
        public string mennyEgysegEllenorzes;
        public int rendelkezesreAlloMennyiseg;
        public int IdEllenorzes;
        public int darabarEllenorzes;
        public int novekmeny = 1;
        int aktualisSorRaktarDGV;
        int sorszám = 1;
        //----------------------------------------- DGV ÖSSZESÍTETT VALTOZÓK----------------------------------------------
        public int osszSorszam;
        public string osszNevEllenorzes;
        public string osszEgysegEllenorzes;
        public int osszMennyisegEllenorzes;
        public int osszIdEllenorzes;
        public int osszDarabarEllenorzes;
        public int aktSor;
        public int selectedIndex = 0;
        public void DGVFrissit()
        {
            DGVAktualisRaktar.DataSource = dataTableAktualisArukeszlet;
            DGVKosar.DataSource = dataTableKosar;
            DGVAktualisRaktar.Refresh();
            DGVKosar.Refresh();
            if (DGVAktualisRaktar.Rows.Count != 0)
            {
                DGVAktualisRaktar.Columns[0].HeaderText = "Azonosító";
                DGVAktualisRaktar.Columns[1].HeaderText = "Név";
                DGVAktualisRaktar.Columns[2].HeaderText = "M.E.";
                DGVAktualisRaktar.Columns[3].HeaderText = "Mennyiség";
                DGVAktualisRaktar.Columns[4].HeaderText = "Darabár";
            }

        }
        public EladasForm()
        {
            InitializeComponent();
            DGVKosar.DataSource = dataTableKosar;
            DGVKosar.ClearSelection();
            btnTorlesOszbol.Enabled = false;
            nudEladasAzonosito.Enabled = false;
            txbTermeknev.Enabled = false;
            nudTermekar.Enabled = false;
            btnMennyisegModosit.Enabled = false;
            dataTableKosar.Columns.Add("Sorszám", typeof(int));
            dataTableKosar.Columns.Add("Áru azonosító", typeof(int));
            dataTableKosar.Columns.Add("Termék neve", typeof(string));
            dataTableKosar.Columns.Add("M.e.", typeof(string));
            dataTableKosar.Columns.Add("Eladandó mennyiség", typeof(int));
            dataTableKosar.Columns.Add("Darabára (Ft)", typeof(int));
            dataTableAktualisArukeszlet = ABKezelo.EladasDGVFeltolt(DGVAktualisRaktar, aktualisRaktarLekerdezes);
            DGVAktualisRaktar.ClearSelection();

            DGVAktualisRaktar.Columns[0].HeaderText = "Azonosító";
            DGVAktualisRaktar.Columns[1].HeaderText = "Név";
            DGVAktualisRaktar.Columns[2].HeaderText = "M.E.";
            DGVAktualisRaktar.Columns[3].HeaderText = "Mennyiség";
            DGVAktualisRaktar.Columns[4].HeaderText = "Darabár";
        }

        public void inputBoxReset()
        {
            nudMennyiseg.Value = 1;
            nudTermekar.Value = 0;
            txbTermeknev.Text = "";
        }
        public void txbesNudTisztit()
        {
            nudEladasAzonosito.Value = 0;
            nudMennyiseg.Value = 0;
            nudTermekar.Value = 0;
            txbTermeknev.Text = "Nincs kijelölt elem!";
        }
        private void DGVAktualirRaktar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVAktualisRaktar.SelectedRows.Count != 0)
            {
                btnTorlesOszbol.Enabled = false;
                btnMennyisegModosit.Enabled = false;
                btnTermekHozzaad.Enabled = true;
                DGVKosar.ClearSelection();
                try
                {
                    nudEladasAzonosito.Value = (int)DGVAktualisRaktar.SelectedRows[0].Cells[0].Value;
                    IdEllenorzes = (int)DGVAktualisRaktar.SelectedRows[0].Cells[0].Value;
                    txbTermeknev.Text = DGVAktualisRaktar.SelectedRows[0].Cells[1].Value.ToString();
                    nevEllenorzes = DGVAktualisRaktar.SelectedRows[0].Cells[1].Value.ToString();
                    mennyEgysegEllenorzes = DGVAktualisRaktar.SelectedRows[0].Cells[2].Value.ToString();
                    rendelkezesreAlloMennyiseg = (int)DGVAktualisRaktar.SelectedRows[0].Cells[3].Value;
                    nudTermekar.Value = (int)DGVAktualisRaktar.SelectedRows[0].Cells[4].Value;
                    darabarEllenorzes = (int)DGVAktualisRaktar.SelectedRows[0].Cells[4].Value;
                    aktSor = DGVAktualisRaktar.CurrentCell.RowIndex;
                    aktualisSorRaktarDGV = (int)DGVAktualisRaktar.SelectedRows[0].Cells[0].Value;
                    nudMennyiseg.Value = 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnTermekHozzaad_Click(object sender, EventArgs e)
        {
            // A termék hozzá lett - e már adva vagy nem
            if (DGVAktualisRaktar.Rows.Count > 0)
            {
                if (nudMennyiseg.Value > 0)
                {
                    bool KosarhozAdott = false;
                    for (int i = 0; i < dataTableKosar.Rows.Count; i++)
                    {
                        if ((int)dataTableKosar.Rows[i][1] == IdEllenorzes)
                        {
                            KosarhozAdott = true;
                        }
                    }

                    if (KosarhozAdott == false)
                    {
                        if (nudMennyiseg.Value > rendelkezesreAlloMennyiseg)
                        {
                            MessageBox.Show("A megaott mennyiség nem lehet nagyobb a készletnél!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nudMennyiseg.Value = 1;
                        }
                        else
                        {
                            DataRow newrow = dataTableKosar.NewRow();
                            newrow[0] = sorszám;
                            newrow[1] = IdEllenorzes;
                            newrow[2] = nevEllenorzes;
                            newrow[3] = mennyEgysegEllenorzes;
                            newrow[4] = nudMennyiseg.Value;
                            newrow[5] = darabarEllenorzes;
                            dataTableKosar.Rows.Add(newrow);
                            dataTableAktualisArukeszlet.Rows[aktSor][3] = rendelkezesreAlloMennyiseg - (int)nudMennyiseg.Value;
                            int vegosszeg = 0;
                            for (int i = 0; i < dataTableKosar.Rows.Count; i++)
                            {
                                vegosszeg += (int)dataTableKosar.Rows[i][4] * (int)dataTableKosar.Rows[i][5];
                            }
                            lblReszosszeg.Text = "Jelenleg fizetendő:  " + vegosszeg + " t";
                            sorszám++;
                            DGVKosar.ClearSelection();
                            DGVAktualisRaktar.ClearSelection();
                            btnTermekHozzaad.Enabled = false;
                            txbesNudTisztit();
                        }
                    }
                    else if (KosarhozAdott == true)
                    {
                        MessageBox.Show("A kiválasztott árucikk már hozzá lett adva!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (nudMennyiseg.Value == 0)
                {
                    MessageBox.Show("Nincs megadva mennyiség!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("A kosár üres!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DGVKosar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVKosar.SelectedRows.Count != 0)
            {
                btnMennyisegModosit.Enabled = true;
                btnTorlesOszbol.Enabled = true;
                btnMennyisegModosit.Enabled = true;
                btnTermekHozzaad.Enabled = false;
                DGVAktualisRaktar.ClearSelection();
                inputBoxReset();

                osszSorszam = (int)DGVKosar.SelectedRows[0].Cells[0].Value;
                osszIdEllenorzes = (int)DGVKosar.SelectedRows[0].Cells[1].Value;
                nudEladasAzonosito.Value = (int)DGVKosar.SelectedRows[0].Cells[1].Value;
                osszNevEllenorzes = (string)DGVKosar.SelectedRows[0].Cells[2].Value;
                txbTermeknev.Text = (string)DGVKosar.SelectedRows[0].Cells[2].Value;
                osszEgysegEllenorzes = (string)DGVKosar.SelectedRows[0].Cells[3].Value;
                nudMennyiseg.Value = (int)DGVKosar.SelectedRows[0].Cells[4].Value;
                osszMennyisegEllenorzes = (int)DGVKosar.SelectedRows[0].Cells[4].Value;
                darabarEllenorzes = (int)DGVKosar.SelectedRows[0].Cells[5].Value;
                selectedIndex = DGVKosar.CurrentCell.RowIndex;
                nudTermekar.Value = 1;
            }
        }

        private void btnTorlesOszbol_Click(object sender, EventArgs e)
        {
            if (dataTableKosar.Rows.Count != -1)
            {
                DialogResult dr;
                dr = MessageBox.Show("Biztosan törli a kiválasztott elemet?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    int dtkosarIndex = 0;
                    int dtAktAru = 0;
                    for (int i = 0; i < dataTableKosar.Rows.Count; i++)
                    {
                        if ((int)dataTableKosar.Rows[i][1] == osszIdEllenorzes)
                        {
                            dtkosarIndex = i;
                        }
                    }

                    for (int j = 0; j < dataTableAktualisArukeszlet.Rows.Count; j++)
                    {
                        if ((int)dataTableAktualisArukeszlet.Rows[j][0] == osszIdEllenorzes)
                        {
                            dtAktAru = j;
                        }
                    }

                    int mennyisegbolKivonas = (int)dataTableAktualisArukeszlet.Rows[dtAktAru][3];
                    dataTableAktualisArukeszlet.Rows[dtAktAru][3] = mennyisegbolKivonas + osszMennyisegEllenorzes;
                    dataTableKosar.Rows[dtkosarIndex].Delete();
                    txbesNudTisztit();
                    btnTorlesOszbol.Enabled = false;
                    btnMennyisegModosit.Enabled = false;
                    DGVFrissit();
                    MessageBox.Show("A törlés sikeresen megtörtént!", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("A kosár üres!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMennyisegModosit_Click(object sender, EventArgs e)
        {
            if (DGVKosar.SelectedRows.Count != 0)
            {
                if (nudMennyiseg.Value > (int)DGVAktualisRaktar.Rows[selectedIndex].Cells[3].Value && nudMennyiseg.Value != osszMennyisegEllenorzes)
                {
                    btnTorlesOszbol.Enabled = false;
                    int dtkosarIndex = 0;
                    int dtAktAru = 0;
                    for (int i = 0; i < dataTableKosar.Rows.Count; i++)
                    {
                        if ((int)dataTableKosar.Rows[i][1] == osszIdEllenorzes)
                        {
                            dtkosarIndex = i;
                        }
                    }

                    for (int j = 0; j < dataTableAktualisArukeszlet.Rows.Count; j++)
                    {
                        if ((int)dataTableAktualisArukeszlet.Rows[j][0] == osszIdEllenorzes)
                        {
                            dtAktAru = j;
                        }
                    }

                    int index = (int)DGVKosar.SelectedRows[0].Cells[0].Value;
                    index += -1;
                    if (index != -1 && nudMennyiseg.Value != 0)
                    {
                        if (nudMennyiseg.Value <= (int)dataTableAktualisArukeszlet.Rows[dtAktAru][3] + (int)dataTableKosar.Rows[dtkosarIndex][4])
                        {
                            int aktualisErtek = (int)dataTableKosar.Rows[dtkosarIndex][4];
                            int kosarErtek = (int)dataTableAktualisArukeszlet.Rows[dtAktAru][3];
                            dataTableAktualisArukeszlet.Rows[dtAktAru][3] = kosarErtek + aktualisErtek;
                            dataTableKosar.Rows[dtkosarIndex][4] = (int)nudMennyiseg.Value;
                            int kitevo = (int)dataTableAktualisArukeszlet.Rows[dtAktAru][3];
                            dataTableAktualisArukeszlet.Rows[dtAktAru][3] = kitevo - (int)nudMennyiseg.Value;
                            int vegosszeg = 0;
                            int[] reszosszeg = new int[dataTableKosar.Rows.Count];

                            for (int i = 0; i < dataTableKosar.Rows.Count; i++)
                            {
                                vegosszeg += (int)dataTableKosar.Rows[i][4] * (int)dataTableKosar.Rows[i][5];
                            }
                            osszMennyisegEllenorzes = (int)nudMennyiseg.Value;
                            lblReszosszeg.Text = "Jelenleg fizetendő:  " + vegosszeg + " ft";
                            DGVAktualisRaktar.ClearSelection();
                            DGVKosar.ClearSelection();
                            txbesNudTisztit();
                            DGVFrissit();
                            btnMennyisegModosit.Enabled = false;
                            MessageBox.Show("A módosítás sikeres!", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else if (index == -1)
                    {
                        MessageBox.Show("Nincs kiválasztott elem!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (nudMennyiseg.Value == 0)
                    {
                        MessageBox.Show("A megadott mennyiség nem lehet nulla!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (nudMennyiseg.Value == osszMennyisegEllenorzes)
                {
                    MessageBox.Show("Sikertelen módosítás!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A megadott mennyiség nem lehet nagyobb az aktuális raktárkészletnél!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnEladasVeglegesit_Click(object sender, EventArgs e)
        {
            if (dataTableKosar.Rows.Count > 0)
            {
                DialogResult dr;
                dr = MessageBox.Show("Biztosan véglegesíti a vásárlást?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ABKezelo.EladottAruFelvitel(dataTableAktualisArukeszlet, dataTableKosar, kosarInserCommand, kosarKapcsoloTablaCommand);
                    dataTableAktualisArukeszlet = ABKezelo.EladasDGVFeltolt(DGVAktualisRaktar, aktualisRaktarLekerdezes);
                    dataTableKosar.Clear();
                    DGVFrissit();
                    btnMennyisegModosit.Enabled = false;
                    lblReszosszeg.Text = "Jelenleg fizetendő:  " + 0 + " ft";
                    MessageBox.Show("A vásárlás sikeresen megtörtént!", "Információ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("A koár tartalma üres!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnMennyisegModosit.Enabled = false;
            }
        }

        private void btnkilepes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
