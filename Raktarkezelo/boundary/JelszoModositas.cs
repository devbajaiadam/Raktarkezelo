using System;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class JelszoModositas : Form
    {
        public string Sqlutasitas = "UPDATE userTbl SET jelszo = @jelszo WHERE userId = @userId";
        public JelszoModositas()
        {
            InitializeComponent();
            lblRegiJelszo.Enabled = false;
            lblUjJelszo.Enabled = false;
            lblUJelszoUjra.Enabled = false;
        }
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void txbRegiJelszo_TextChanged(object sender, EventArgs e)
        {
            if (txbRegiJelszo.Text != "")
            {
                lblRegiJelszo.Enabled = true;
            }
            else
            {
                lblRegiJelszo.Enabled = false;
            }
        }

        private void txbUjJelszo_TextChanged(object sender, EventArgs e)
        {
            if (txbUjJelszo.Text != "")
            {
                lblUjJelszo.Enabled = true;
            }
            else
            {
                lblUjJelszo.Enabled = false;
            }
        }
        private void txbUjJelszoUjra_TextChanged(object sender, EventArgs e)
        {
            if (txbUjJelszoUjra.Text != "")
            {
                lblUJelszoUjra.Enabled = true;
            }
            else
            {
                lblUJelszoUjra.Enabled = false;
            }
        }
        private void lblRegiJelszo_Click(object sender, EventArgs e)
        {
            if (txbRegiJelszo.PasswordChar == '*')
            {
                txbRegiJelszo.PasswordChar = default;
            }
            else if (txbRegiJelszo.PasswordChar == default)
            {
                txbRegiJelszo.PasswordChar = '*';
            }
        }

        private void lblUjJelszo_Click(object sender, EventArgs e)
        {
            if (txbUjJelszo.PasswordChar == '*')
            {
                txbUjJelszo.PasswordChar = default;
            }
            else if (txbUjJelszo.PasswordChar == default)
            {
                txbUjJelszo.PasswordChar = '*';
            }
        }
        private void lblUJelszoUjra_Click(object sender, EventArgs e)
        {
            if (txbUjJelszoUjra.PasswordChar == '*')
            {
                txbUjJelszoUjra.PasswordChar = default;
            }
            else if (txbUjJelszoUjra.PasswordChar == default)
            {
                txbUjJelszoUjra.PasswordChar = '*';
            }
        }
        private void btnJelszoModosit_Click(object sender, EventArgs e)
        {
            if (txbUjJelszo.Text == txbUjJelszoUjra.Text && txbUjJelszo.Text != "" && txbUjJelszoUjra.Text != "")
            {
                string regiJelszo = JelszoMuveletek.Titkosit(txbRegiJelszo.Text);
                if (regiJelszo == ABKezelo.belepo.Jelszo)
                {
                    string titkositott = "";
                    bool eros = JelszoMuveletek.ErosJelszo(txbUjJelszo.Text);

                    if (eros == true)
                    {
                        titkositott = JelszoMuveletek.Titkosit(txbUjJelszo.Text);
                        bool eredmeny = ABKezelo.UjJelszoFeltoltese(titkositott, ABKezelo.belepo.FelhnevPK, Sqlutasitas);
                        if (eredmeny == true)
                        {
                            MessageBox.Show("Sikeres módosítás!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        MessageBox.Show("A megadott új jelszó gyenge!" + "\n" + "A jelszónak legalább 8 karakteresnek kell lennie, illetve kis, nagybetűket és számokat is tartalmaznia kell!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hibásan megadott régi jelszó!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Az új jelszavak nem egyeznek egymással!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
