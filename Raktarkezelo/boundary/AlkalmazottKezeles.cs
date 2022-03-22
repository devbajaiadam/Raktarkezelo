using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raktarkezelo.boundary;
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
        string fnevEllenorzes;
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
            nevEllenorzes ="";
            cboxEllenorzes="";
            fnevEllenorzes="";
            ABKezelo.DGVFeltoltes(DGVAlkalmazottFelvitel, DGVFeltoltes);
            cboxJogosultsag.SelectedIndex = -1;
            txbFelhNev.Enabled = true;
            txbNev.Enabled = true;
            txbJelszo.Enabled = true;
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
                        MessageBox.Show("A felvitel sikeresen megtörtént", "Információ",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    Tisztit();
                }
                else if(txbJelszo.Text == "(Nem módosítható!)")
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
                    fnevEllenorzes = DGVAlkalmazottFelvitel.SelectedRows[0].Cells[0].Value.ToString();
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
            if (txbFelhNev.Text == fnevEllenorzes)
            {
                List<string> felhAdatokModosit = new List<string>();
                DialogResult dr;
                dr = MessageBox.Show("Biztosan módosítani kívánja az adatokat?", "Kérdés", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    felhAdatokModosit.Add(txbFelhNev.Text);
                    felhAdatokModosit.Add(txbNev.Text);
                    felhAdatokModosit.Add(Convert.ToString(cboxJogosultsag.SelectedValue));

                    if (txbNev.Text != "" && txbNev.Text != nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes != cboxJogosultsag.Text)
                    //Módosítás mintkét adat megváltoztatása esetén
                    {      
                        bool megtortent = ABKezelo.AdatMódosításVagyAdattörlés(felhAdatokModosit, "nevEsJogModosit");
                        if (megtortent == true)
                        {
                            MessageBox.Show("A név és jogosultság módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Tisztit();
                        }
                        else
                        {
                            MessageBox.Show("A művelet sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (txbNev.Text != "" && txbNev.Text == nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes != cboxJogosultsag.Text)
                    //Módosítás csak a comboBox megvátozása esetén
                    {
                        bool megtortent = ABKezelo.AdatMódosításVagyAdattörlés(felhAdatokModosit, "jogModosit");
                        if (megtortent == true)
                        {
                            MessageBox.Show("A jogosultság módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Tisztit();
                        }
                        else
                        {
                            MessageBox.Show("Hiba!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else if (txbNev.Text != "" && txbNev.Text != nevEllenorzes && cboxJogosultsag.SelectedIndex != -1 && cboxEllenorzes == cboxJogosultsag.Text)
                    //Módosítás csak a Név megváltozása esetén
                    {
                        bool megtortent = ABKezelo.AdatMódosításVagyAdattörlés(felhAdatokModosit, "nevModosit");
                        if (megtortent == true)
                        {
                            MessageBox.Show("A név módosítása sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Tisztit();
                        }
                        else
                        {
                            MessageBox.Show("Hiba!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("A módosítás sikertelen, kérem ellenőrizze az adatokat!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Válassza ki a módosítani kívánt elemet!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (DGVAlkalmazottFelvitel.Rows.Count > 1)
            {
                List<string> torles = new List<string>();
                if (txbFelhNev.Text == fnevEllenorzes && fnevEllenorzes != "")
                {
                    DialogResult dr;
                    dr = MessageBox.Show("Biztosan törölni kívánja a kiválasztott adatot?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        torles.Add(txbFelhNev.Text);
                        bool sikerultvagynem = ABKezelo.AdatMódosításVagyAdattörlés(torles, "torles");
                        if (sikerultvagynem == true)
                        {
                            MessageBox.Show("A kiválasztott elem törlésre került!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Hiba a törlés során!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Tisztit();
                    }
                }
                else if (nevEllenorzes == "")
                {
                    MessageBox.Show("Nincs kiválasztott elem!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("A törlés sikertelen!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Egy felhasználónak kötelező maradnia az adatbázisban!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    

    

