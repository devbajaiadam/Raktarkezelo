using System;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class Bejelentkezes : Form
    {
        public Bejelentkezes()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool sikeresBelepes = ABKezelo.Belepteto(txbfelhNev.Text, JelszoMuveletek.Titkosit(txbjelszo.Text));
                
                if (!sikeresBelepes)
                {
                    MessageBox.Show("Hibás felhasználónév vagy jelszó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnKilepes_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Biztosan ki akar lépni?", "Kérdés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ABKezelo.KapcsolatBontas();
                Application.Exit();
            }
        }
  
    }
}
