using System;
using System.Drawing;
using System.Windows.Forms;
using Raktarkezelo.control;

namespace Raktarkezelo.boundary
{
    public partial class EladasiElozmenyek : Form
    {
        //-------------------------------------------SQL----------------------------------------------------------------

        public string lekerdezesDGV1 = "SELECT eladasTbl.eladasId, eladasTbl.datum, eladasTbl.mennyiseg, UserTbl.nev FROM eladasTbl,userTbl WHERE eladasTbl.userId = userTbl.userId";
        public string lekerdezesDGV2 = "SELECT kosarTbl.eladasId, raktarTbl.nev, kosarTbl.mennyiseg FROM kosarTbl, raktarTbl WHERE kosarTbl.aruId = raktarTbl.aruId";

        //-------------------------------------------VÁLTOZÓK-----------------------------------------------------------

        int index1 = 0;
        int x = 30;
        int y = 150;

        public EladasiElozmenyek()
        {
            InitializeComponent();

            SplitContainer splitContainer1 = new SplitContainer();
            ABKezelo.MasterDetailFeltolt(DGV1, DGV2, lekerdezesDGV1, lekerdezesDGV2);

            DGV1.Columns[0].HeaderText = "Azonosító";
            DGV1.Columns[1].HeaderText = "Dátum";
            DGV1.Columns[2].HeaderText = "Eladott áruk";
            DGV1.Columns[3].HeaderText = "Eladó neve";

            DGV2.Columns[0].HeaderText = "Azonosító";
            DGV2.Columns[1].HeaderText = "Áru Neve";
            DGV2.Columns[2].HeaderText = "Mennyiség";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnNyomtatas_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count != 0 && DGV2.Rows.Count > 0)
            {


                if (index1 != -1)
                {
                    try
                    {
                        printPreviewDialog1.Document = printDocument1;
                        if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                        {
                            printDocument1.Print();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hiba történt! " + "\n" + ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    x = 30;
                    y = 150;
                }
                else if (index1 == -1)
                {
                    MessageBox.Show("Nincs kiválasztott elem!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                x = 30;
                y = 150;
            }
            else
            {
                MessageBox.Show("Nincs kiválasztott adat!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            
                e.Graphics.DrawString("Számla", new Font("Arial", 25, FontStyle.Bold), Brushes.Black, new Point(350));
                e.Graphics.DrawString("Zöld Eleség Kft.", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(320, 50));
                e.Graphics.DrawString("Eladás adatai :" + " Eladás azonosító: " + DGV1.Rows[index1].Cells[0].Value.ToString() + " Dátuma: " + DGV1.Rows[index1].Cells[1].Value.ToString()
                            + " Eladó neve: " + DGV1.Rows[index1].Cells[3].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 90));
                e.Graphics.DrawString("Eladás adatai:", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(30, 120));
                for (int i = 0; i < DGV2.Rows.Count; i++)
                {
                    e.Graphics.DrawString("Eladás azonosító: " + DGV2.Rows[i].Cells[0].Value.ToString() + "     Árú neve: " + DGV2.Rows[i].Cells[1].Value.ToString() + "     Eladott mennyiség: "
                            + DGV2.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(x, y));

                    y += 25;
                }
                e.Graphics.DrawString("Aláírás: -----------------------------", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(400, 1115));
            
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV1.SelectedRows.Count != 0)
            {
                index1 = DGV1.CurrentCell.RowIndex;
            }
        }
    }
}
