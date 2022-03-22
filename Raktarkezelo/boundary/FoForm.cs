using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Raktarkezelo.boundary;
using Raktarkezelo.control;

namespace Raktarkezelo
{



    // Form1- ként lehet rá hivatkozni 
    public partial class Form1 : Form
    {
        public string raktarTblLekerdezes = "SELECT raktarTbl.aruId, raktarTbl.nev, raktarTbl.mennyEgyseg, raktarTbl.mennyiseg, raktarTbl.darabar, kategoriaTbl.nev FROM raktarTbl,kategoriaTbl WHERE raktarTbl.kategoriaId = kategoriaTbl.kategoriaId AND raktarTbl.mennyiseg > 0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ABKezelo.Csatlakozas();
            }
            catch (ABKivetel ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            Bejelentkezes Bej = new Bejelentkezes();

            if (Bej.ShowDialog() == DialogResult.OK)
            {
                lblAktivNeve.Text = ABKezelo.belepoNev + " !";
                if (ABKezelo.jog == ABKezelo.ADMIN_SZEREP)
                {
                    picsBoxAdmin.Show();
                    picsBoxSeller.Hide();
                    lblFejlec.Text = "Raktárkezelő Adminisztrátor Felület";
                }
                else
                {
                    picsBoxAdmin.Hide();
                    picsBoxSeller.Show();
                    btnUjFelhasznalo.Enabled = false;
                    lblFejlec.Text = "Raktárkezelő Eladó Felület";
                }

                ABKezelo.DGVFeltoltes(dgvFoForm, raktarTblLekerdezes);
                dgvFoForm.Columns[0].HeaderText = "Azonosító";
                dgvFoForm.Columns[1].HeaderText = "Név";
                dgvFoForm.Columns[2].HeaderText = "M.E.";
                dgvFoForm.Columns[3].HeaderText = "Mennyiség";
                dgvFoForm.Columns[4].HeaderText = "Darabár";
                dgvFoForm.Columns[5].HeaderText = "Kategória";
            }
        }
        private void btnUjFelhasznalo_Click(object sender, EventArgs e)
        {
            AlkalmazottKezeles alkKezeles = new AlkalmazottKezeles();
            this.Hide();
            if (alkKezeles.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JelszoModositas jelszomodositas = new JelszoModositas();
            this.Hide();
            if (jelszomodositas.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Bejelentkezes Bej = new Bejelentkezes();
            this.Hide();
            if (Bej.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblAktivNeve.Text = ABKezelo.belepoNev + " !";
                if (ABKezelo.jog == ABKezelo.ADMIN_SZEREP)
                {
                    picsBoxAdmin.Show();
                    picsBoxSeller.Hide();
                    btnUjFelhasznalo.Enabled = true;
                    lblFejlec.Text = "Raktárkezelő Adminisztrátor Felület";
                }
                else
                {
                    picsBoxAdmin.Hide();
                    picsBoxSeller.Show();
                    btnUjFelhasznalo.Enabled = false;
                    lblFejlec.Text = "Raktárkezelő Eladó Felület";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            EladasiElozmenyek elozmenyek = new EladasiElozmenyek();
            this.Hide();
            if (elozmenyek.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ABKezelo.DGVFeltoltes(dgvFoForm, raktarTblLekerdezes);

                dgvFoForm.Columns[0].HeaderText = "Azonosító";
                dgvFoForm.Columns[1].HeaderText = "Név";
                dgvFoForm.Columns[2].HeaderText = "M.E.";
                dgvFoForm.Columns[3].HeaderText = "Mennyiség";
                dgvFoForm.Columns[4].HeaderText = "Darabár";
                dgvFoForm.Columns[5].HeaderText = "Kategória";
        }
        private void btnArufelvitel_Click(object sender, EventArgs e)
        {
            Arufelvitel aruFelvitel = new Arufelvitel();
            this.Hide();
            if (aruFelvitel.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Biztosan ki akar lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnEladas_Click(object sender, EventArgs e)
        {
            EladasForm eladas = new EladasForm();
            this.Hide();
            if (eladas.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
