using System;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class AlkalmazottKezeles : Form
    {
        //------------------------SQL Lekérdezések---------------------------------------------------------------------------

        string DGVFeltoltes = "SELECT userTbl.userId, userTbl.nev, szerepTbl.megnevezes FROM userTbl,szerepTbl WHERE szerepTbl.szerepId = userTbl.szerepId";
        string CboxFeltoltes = "SELECT szerepId, megnevezes FROM szerepTbl";

        //----------------------------------------------Változók-------------------------------------------------------------

        string nevEllenorzes;
        string cboxEllenorzes;
        string kivalasztottFelhasznalo;
        string szerep;

        //---------------------------------------------Inicializálás + Form load---------------------------------------------

        public AlkalmazottKezeles()
        {
            InitializeComponent();
            Tisztit();
            btnTisztit.Visible = false;
            ABKezelo.DGVFeltoltes(DGVAlkalmazottFelvitel, DGVFeltoltes);
            ABKezelo.cboxfeltolt(cboxJogosultsag, CboxFeltoltes);
            if (DGVAlkalmazottFelvitel.Rows.Count != 0)
            {
                DGVAlkalmazottFelvitel.Columns[0].HeaderText = "Azonosító";
                DGVAlkalmazottFelvitel.Columns[1].HeaderText = "Név";
                DGVAlkalmazottFelvitel.Columns[2].HeaderText = "Jogosultsága";
            }
        }

        //----------------------------------------------------VOIDOK----------------------------------------------------------------

        public void Tisztit()
        {
            txbFelhNev.Text = "";
            txbJelszo.Text = "";
            txbNev.Text = "";
            nevEllenorzes = "";
            cboxEllenorzes = "";
            kivalasztottFelhasznalo = "";
            ABKezelo.DGVFeltoltes(DGVAlkalmazottFelvitel, DGVFeltoltes);
            cboxJogosultsag.SelectedIndex = -1;
            txbFelhNev.Enabled = true;
            txbNev.Enabled = true;
            txbJelszo.Enabled = true;
            DGVAlkalmazottFelvitel.ClearSelection();
            if (DGVAlkalmazottFelvitel.Rows.Count != 0)
            {
                DGVAlkalmazottFelvitel.Columns[0].HeaderText = "Azonosító";
                DGVAlkalmazottFelvitel.Columns[1].HeaderText = "Név";
                DGVAlkalmazottFelvitel.Columns[2].HeaderText = "Jogosultsága";
            }

        }
        //---------------------------------------------------------------------------------------------------------------------------

        private void btnFelvitel_Click(object sender, EventArgs e)
        {
            int aktiv = 1;
            try
            {
                //Ellenőrzés hogy ne legyen kiválasztott elem
                if (txbFelhNev.Text != "" && txbFelhNev.Text != nevEllenorzes && txbNev.Text != "" && txbJelszo.Text != "(Nem módosítható!)" && cboxJogosultsag.SelectedIndex != -1)
                {

                    bool siker = ABKezelo.UjFelhasznaloLetrehozasa(
                            new UserClass(txbFelhNev.Text, txbNev.Text, txbJelszo.Text, (int)cboxJogosultsag.SelectedValue, aktiv));

                    if (siker == true)
                    {
                        MessageBox.Show("A felvitel sikeresen megtörtént", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Tisztit();
                }
                else if (txbJelszo.Text == "(Nem módosítható!)")
                {
                    MessageBox.Show("Jelenleg ki van választva egy adat, kérem nyomja meg a frissítés gombot, ha új adatot kíván felvinni!",
                                "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Az összes adat kitöltése kötelező!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DGVAlkalmazottFelvitel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVAlkalmazottFelvitel.SelectedRows.Count != 0)
            {
                btnTisztit.Visible = true;
                nevEllenorzes = null;
                try
                {
                    txbFelhNev.Text = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[0].Value.ToString();
                    kivalasztottFelhasznalo = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[0].Value.ToString();
                    txbNev.Text = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[1].Value.ToString();
                    nevEllenorzes = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[1].Value.ToString();
                    szerep = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[2].Value.ToString();
                    cboxJogosultsag.Text = szerep;
                    cboxEllenorzes = szerep;
                    txbJelszo.Text = "(Nem módosítható!)";
                    txbFelhNev.Enabled = false;
                    txbJelszo.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnTisztit_Click(object sender, EventArgs e)
        {
            Tisztit();
        }
        private void btnModositas_Click(object sender, EventArgs e)
        {
            if (DGVAlkalmazottFelvitel.SelectedRows.Count == 1)
            {
                if (DialogResult.Yes == MessageBox.Show("Biztosan módosítani kívánja az adatokat?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    try
                    {
                        if (txbNev.Text != "" && txbNev.Text != nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes != cboxJogosultsag.Text)
                        {
                            //Módosítás mintkét adat megváltoztatása esetén
                            ABKezelo.NevEsJogModosit(txbFelhNev.Text, (int)cboxJogosultsag.SelectedValue, txbNev.Text);
                            MessageBox.Show("A név és jogosultság módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (txbNev.Text != "" && txbNev.Text == nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes != cboxJogosultsag.Text)
                        {
                            //Módosítás csak a comboBox megvátozása esetén
                            ABKezelo.JogModosit(txbFelhNev.Text, (int)cboxJogosultsag.SelectedValue);
                            MessageBox.Show("A jogosultság módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else if (txbNev.Text != "" && txbNev.Text != nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes == cboxJogosultsag.Text)
                        {
                            //Módosítás csak a Név megváltozása esetén
                            ABKezelo.NevModosit(txbFelhNev.Text, txbNev.Text);
                            MessageBox.Show("A név módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Tisztit();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("A módosítás sikertelen, kérem ellenőrizze az adatokat!" + "\n" + ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott adat!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnTorles_Click(object sender, EventArgs e)
        {
            if (DGVAlkalmazottFelvitel.SelectedRows.Count == 1)
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Biztosan törölni kívánja a kiválasztott adatot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ABKezelo.FelhasznaloTorles(txbFelhNev.Text);
                        MessageBox.Show("A kiválasztott elem törlésre került!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tisztit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A törlés sikertelen!" + "\n" + ex.Message, "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vállasszon ki egy sort!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void lblJelszoMegjelenit_Click(object sender, EventArgs e)
        {
            if (txbJelszo.PasswordChar == '*')
            {
                txbJelszo.PasswordChar = default;
            }
            else if (txbJelszo.PasswordChar == default)
            {
                txbJelszo.PasswordChar = '*';
            }
        }
    }
}




