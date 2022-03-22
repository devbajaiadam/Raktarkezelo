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
using System.Data.SqlClient;

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
                UserClass User = ABKezelo.Belepteto(txbfelhNev.Text, JelszoMuveletek.Titkosit(txbjelszo.Text));
                
                if (User == null)
                {
                    MessageBox.Show("Hibás felhasználónév és/vagy jelszó!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Application.Exit();
            }
        }
  
    }
}
