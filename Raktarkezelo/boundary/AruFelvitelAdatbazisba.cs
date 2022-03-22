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
using Raktarkezelo.boundary;

namespace Raktarkezelo.boundary
{
    public partial class AruFelvitelAdatbazisba : Form
    {
        public string CboxFeltolt = "SELECT kategoriaId,nev FROM KategoriaTbl";
        public AruFelvitelAdatbazisba()
        {
            InitializeComponent();
            ABKezelo.cboxfeltoltAru(cboxAruKategoria, CboxFeltolt);
        }
        private void btnAruHozzaad_Click(object sender, EventArgs e)
        {
            if (txbAruNev.Text != "" && nudAruMennyiseg.Value !=0 && txbAruME.Text != "" && nudAruDarabar.Value != 0)
            {
                
                bool siker = ABKezelo.UjAru(new RaktarAruk(txbAruNev.Text, txbAruME.Text, (int)nudAruMennyiseg.Value, (int)nudAruDarabar.Value, (int)cboxAruKategoria.SelectedValue),"felvitel",0);
                if (siker == true)
                {
                    MessageBox.Show("A felvitel sikeresen megtörtént!", "Információ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show("Sikertelen adatfelvitel!", "Figyelmeztetés", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void txbAruME_TextChanged(object sender, EventArgs e)
        {
            if (txbAruME.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txbAruME.Text, "^[a-zA-Z ]"))
                {
                    MessageBox.Show("Ez a mező nem tartalmazhat számot!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbAruME.Text = "";
                }
            }
        }
      
    }
}
