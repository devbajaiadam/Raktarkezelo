using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Raktarkezelo.control
{
    static class ABKezelo
    {
        //----------------------------SQL Commands (alkalmazottFelvitel műveletek)--------------------------------

        public static string beleptetoLekerdezes = "SELECT * FROM [userTbl] WHERE [userId] = @felh AND [jelszo] = @jelszo";
        public static string ujFelhasznaloFelvitel = "INSERT INTO [userTbl](userId, nev, jelszo, szerepId, aktiv) VALUES (@userId, @nev, @jelszo, @szerepId, @aktiv)";
        public static string felhasznaloFelolvasas = "SELECT * FROM [userTbl]";
        public static string nevModosit = "UPDATE userTbl SET nev=@nev WHERE userId=@userId";
        public static string jogModosit = "UPDATE userTbl SET szerepId=@szerepId WHERE userId=@userId";
        public static string nevEsJogModosit = "UPDATE userTbl SET szerepId=@szerepId, nev=@nev WHERE userId=@userId";
        public static string felhasznaloTorles = "DELETE FROM userTbl WHERE userId=@userId";

        //----------------------------SQL Commands (kategória, árufelvitel műveletek)--------------------------------

        public static string kategoriaFelvitel = "INSERT INTO [kategoriaTbl](nev,leiras) VALUES (@nev,@leiras)";
        public static string torlesKategoriabol = "DELETE FROM kategoriaTbl WHERE kategoriaId=@kategoriaId";
        public static string aruFelvitel = "INSERT INTO [raktarTbl](nev,mennyEgyseg,mennyiseg,darabar,kategoriaId) VALUES (@nev,@mennyEgyseg,@mennyiseg,@darabar,@kategoriaId)";
        public static string aruNevModosit = "UPDATE raktarTbl SET nev=@nev, mennyEgyseg=@mennyEgyseg, mennyiseg=@mennyiseg, darabar=@darabar, kategoriaId=@kategoriaId WHERE aruId=@aruId";
        public static string torlesArukbol = "DELETE FROM raktarTbl WHERE aruId=@aruId";

        //----------------------------SQL Commands (Eladás, Eladás kezelés)-----------------------------------------

        public static string updateArukeszlet = "UPDATE raktarTbl SET mennyiseg=@mennyiseg WHERE aruId=@aruId";

        //----------------------------------------------------------------------------------------------------------
        static SqlConnection connection;
        static SqlCommand command;
        public static string belepoFnev;
        public static string belepoNev;
        public static int jog;
        public static UserClass belepo;
        public static int ADMIN_SZEREP = 0;

        public static void Csatlakozas()
        {
            try
            {
                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["raktarConStr"].ConnectionString;
                connection.Open();
                command = new SqlCommand();
                command.Connection = connection;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen csatlakozás az adatbázishoz!", ex);
            }
        }

        public static void KapcsolatBontas()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                throw new ABKivetel("A kapcsolat bontása sikertelen!", ex);
            }
        }


        #region Beléptető
        public static UserClass Belepteto(string fnev, string jelszo)
        {
            belepo = null;
            try
            {
                command.Parameters.Clear();
                command.CommandText = beleptetoLekerdezes;
                command.Parameters.AddWithValue("@felh", fnev);
                command.Parameters.AddWithValue("@jelszo", jelszo);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        belepo = (new UserClass(reader["nev"].ToString(), (int)reader["szerepId"], (int)reader["aktiv"], reader["userId"].ToString(), reader["jelszo"].ToString()));
                        reader.Close();
                        belepoFnev = belepo.FelhnevPK.ToString();
                        belepoNev = belepo.Nev.ToString();
                        jog = belepo.SzerepId;
                        return belepo;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen belépés, kritikus hiba!", ex);
            }
        }

        #endregion

        #region ÚjFelhasználó
        public static bool UjFelhasznaloLetrehozasa(UserClass uj)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = ujFelhasznaloFelvitel;
                command.Parameters.AddWithValue("@userId", uj.FelhnevPK);
                command.Parameters.AddWithValue("@nev", uj.Nev);
                command.Parameters.AddWithValue("@jelszo", uj.Jelszo);
                command.Parameters.AddWithValue("@szerepId", uj.SzerepId);
                command.Parameters.AddWithValue("@aktiv", uj.Aktiv);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                string hiba = "A felhasználó felvitele sikertelen!";
                MessageBox.Show(hiba + "\n" + ex.Message, "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Felolvasás
        public static List<UserClass> FelhasznalokFelolvasasa()
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = felhasznaloFelolvasas;
                List<UserClass> felhasznalok = new List<UserClass>();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        felhasznalok.Add(new UserClass(reader["nev"].ToString(),
                        (int)reader["szerepId"],
                        (int)reader["aktiv"],
                        reader["userId"].ToString(),
                        reader["jelszo"].ToString()));
                    }
                    reader.Close();
                }
                return felhasznalok;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("A felhasználók beolvasása sikertelen", ex);
            }
        }
        #endregion

        #region DataGridVievFeltölt
        public static void DGVFeltoltes(DataGridView dgv, string utasitas)
        {
            dgv.DataSource = null;
            dgv.AllowUserToAddRows = false;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            try
            {
                DataTable tb = new DataTable("aktualisAru");
                command.Parameters.Clear();
                command.CommandText = utasitas;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tb);
                dgv.DataSource = tb;
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Sikertelen adatbetöltés!", ex);
            }
        }
        #endregion

        #region ComboBoxFeltöltés (Alkalmazott felvitel)
        public static void cboxfeltolt(ComboBox feltolt, string utasitas)
        {
            try
            {
                DataTable tb = new DataTable("szerep");
                command.Parameters.Clear();
                command.CommandText = utasitas;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tb.Load(reader);
                    feltolt.DisplayMember = "megnevezes";
                    feltolt.ValueMember = "szerepId";
                    feltolt.DataSource = tb;
                }
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Cbox feltöltése sikertelen!", ex);
            }
        }
        #endregion

        #region DatabaseUpdate
        public static bool AdatMódosításVagyAdattörlés(List<string> adatok, string torlesVagyModosias)
        {
            if (torlesVagyModosias == "nevModosit")
            {
                string fnev = adatok[0];
                string nev = adatok[1];
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = nevModosit;
                    command.Parameters.AddWithValue("@nev", nev);
                    command.Parameters.AddWithValue("@userId", fnev);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                    throw new ABKivetel("Az adatmódosítás sikertelen!", ex);
                }
                return true;
            }
            else if (torlesVagyModosias == "jogModosit")
            {
                string fnev = adatok[0];
                int jog = Convert.ToInt32(adatok[2]);
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = jogModosit;
                    command.Parameters.AddWithValue("@szerepId", jog);
                    command.Parameters.AddWithValue("@userId", fnev);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                    throw new ABKivetel("Az adatmódosítás sikertelen!", ex);
                }
                return true;
            }
            else if (torlesVagyModosias == "nevEsJogModosit")
            {
                string fnev = adatok[0];
                string nev = adatok[1];
                int jog = Convert.ToInt32(adatok[2]);
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = nevEsJogModosit;
                    command.Parameters.AddWithValue("@szerepId", jog);
                    command.Parameters.AddWithValue("@userId", fnev);
                    command.Parameters.AddWithValue("@nev", nev);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                    throw new ABKivetel("Az adatmódosítás sikertelen!", ex);
                }
                return true;
            }
            else if (torlesVagyModosias == "torles")
            {
                string torles = adatok[0];
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = felhasznaloTorles;
                    command.Parameters.AddWithValue("@userId", torles);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    return false;
                    throw new ABKivetel("Az adatmódosítás sikertelen!", ex);
                }
                return true;

            }
            else if (torlesVagyModosias == "torlesKategoriabol")
            {
                int Id = Convert.ToInt32(adatok[0]);
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = torlesKategoriabol;
                    command.Parameters.AddWithValue("@kategoriaId", Id);
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Az adat törlése sikertelen, használatban lévő referenciaadat törlése nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                   
                }
               
            }
            return false;
        }
        #endregion

        #region KategóriaFelvitel
        public static bool KatVagyAruFelvitel(Tuple<string, string> kapottAdatok)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = kategoriaFelvitel;
                command.Parameters.AddWithValue("@nev", kapottAdatok.Item1);
                command.Parameters.AddWithValue("@leiras", kapottAdatok.Item2);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt!" + "\n" + ex.Message, "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region Cbox Feltolt Aru formon
        public static void cboxfeltoltAru(ComboBox feltolt, string utasitas)
        {
            try
            {
                DataTable tb = new DataTable("kategoria");
                command.Parameters.Clear();
                command.CommandText = utasitas;
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    tb.Load(reader);
                    feltolt.DisplayMember = "nev";
                    feltolt.ValueMember = "kategoriaId";
                    feltolt.DataSource = tb;
                }
            }
            catch (Exception ex)
            {
                throw new ABKivetel("Cbox feltöltése sikertelen!", ex);
            }
        }
        #endregion

        #region Új Aru felviel és Aru Modositas
        public static bool UjAru(RaktarAruk uj, string ellenorzes, int iD)
        {
            if (ellenorzes == "felvitel")
            {
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = aruFelvitel;
                    command.Parameters.AddWithValue("@nev", uj.Nev);
                    command.Parameters.AddWithValue("@mennyEgyseg", uj.MenyEgyseg);
                    command.Parameters.AddWithValue("@mennyiseg", uj.Mennyiseg);
                    command.Parameters.AddWithValue("@darabar", uj.Darabar);
                    command.Parameters.AddWithValue("@kategoriaId", uj.KategoriaId);
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    string hiba = "A felhasználó felvitele sikertelen!";
                    MessageBox.Show(hiba + "\n" + ex.Message, "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            else if (ellenorzes == "modositas")
            {
                try
                {
                    command.Parameters.Clear();
                    command.CommandText = aruNevModosit;
                    command.Parameters.AddWithValue("@aruId", iD);
                    command.Parameters.AddWithValue("@nev", uj.Nev);
                    command.Parameters.AddWithValue("@mennyEgyseg", uj.MenyEgyseg);
                    command.Parameters.AddWithValue("@mennyiseg", uj.Mennyiseg);
                    command.Parameters.AddWithValue("@darabar", uj.Darabar);
                    command.Parameters.AddWithValue("@kategoriaId", uj.KategoriaId);
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    string hiba = "A módosítás sikertelen!";
                    MessageBox.Show(hiba + "\n" + ex.Message, "Figyelmeztetés!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            return false;
        }
        #endregion

        #region AruTorles
        public static bool aruTorles(int Id)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = torlesArukbol;
                command.Parameters.AddWithValue("@aruId", Id);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Az adat törlése sikertelen, használatban lévő referenciaadat törlése nem lehetséges!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }
        #endregion

        #region ELADÁS KEZELÉS
        public static DataTable EladasDGVFeltolt(DataGridView feltolt, string utasitas)
        {
            feltolt.DataSource = null;
            try
            {
                DataTable tb = new DataTable("aktualisAru");
                command.Parameters.Clear();
                command.CommandText = utasitas;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(tb);
                feltolt.DataSource = tb;
                return tb;
            }
            catch (Exception ex)
            {

                throw new ABKivetel("Az eladás   feltöltése sikertelen!", ex);
            }
        }
        #endregion

        #region EladottAruFelvitel
        public static bool EladottAruFelvitel(DataTable aktualisAru, DataTable felvitel, string utasitasEladashoz, string utasitasKosarKapcsoloTablahoz)
        {
            int eladasId = 0;
            try
            {
                command.CommandText = utasitasEladashoz;
                command.Parameters.AddWithValue("@datum", DateTime.Now);
                command.Parameters.AddWithValue("@mennyiseg", felvitel.Rows.Count);
                command.Parameters.AddWithValue("@userId", ABKezelo.belepo.FelhnevPK);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        eladasId = (int)reader["eladasId"];
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            {

                SqlTransaction transaction = connection.BeginTransaction();
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    if (eladasId != -1)
                    {
                        for (int i = 0; i < felvitel.Rows.Count; i++)
                        {
                            // KosarKapcsolotablaFeltoltes
                            command.Parameters.Clear();
                            command.CommandText = utasitasKosarKapcsoloTablahoz;
                            command.Parameters.AddWithValue("@eladasId", eladasId);
                            command.Parameters.AddWithValue("@aruId", felvitel.Rows[i][1]);
                            command.Parameters.AddWithValue("@mennyiseg", felvitel.Rows[i][4]);
                            command.ExecuteNonQuery();

                            //AktualisRaktarModositas
                            command.Parameters.Clear();
                            command.CommandText = updateArukeszlet;
                            command.Parameters.AddWithValue("@aruId", felvitel.Rows[i][1]);
                            int rowIndex = (int)felvitel.Rows[i][1];
                            int id = 0;
                            for (int j = 0; j < aktualisAru.Rows.Count; j++)
                            {
                                if ((int)aktualisAru.Rows[j][0] == rowIndex)
                                {
                                    id = j;
                                }
                            }

                            command.Parameters.AddWithValue("@mennyiseg", aktualisAru.Rows[id][3]);
                            command.ExecuteNonQuery();

                        }
                        transaction.Commit();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                    return false;
                }
                return true;
            }

        }
        #endregion

        #region MASTER/DETAIL DGV feltoltes

        public static void MasterDetailFeltolt(DataGridView DGV1, DataGridView DGV2, string feltoltes1, string feltoltes2)
        {
            try
            {
                BindingSource masterBindingSource = new BindingSource();
                BindingSource detailsBindingSource = new BindingSource();
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                SqlDataAdapter masterDataAdapter = new SqlDataAdapter(feltoltes1, connection);
                masterDataAdapter.Fill(data, "Eladas");

                SqlDataAdapter detailsDataAdapter = new SqlDataAdapter(feltoltes2, connection);
                detailsDataAdapter.Fill(data, "Kosar");

                DataRelation relation = new DataRelation("EladasKosar",
                    data.Tables["Eladas"].Columns["eladasId"],
                    data.Tables["Kosar"].Columns["eladasId"]);
                data.Relations.Add(relation);

                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Eladas";

                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "EladasKosar";
                DGV1.DataSource = masterBindingSource;
                DGV2.DataSource = detailsBindingSource;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hiba történt!" + "\n" + ex.Message, "Kritikus hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region új jelszó feltoltese
        public static bool UjJelszoFeltoltese(string ujJelszo, string felhasznaloId, string utasitas)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = utasitas;
                command.Parameters.AddWithValue("@userId", felhasznaloId);
                command.Parameters.AddWithValue("@jelszo", ujJelszo);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sikertelen jelszó felvitele!" + "\n" + ex.Message, "Kritikus hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        #endregion
    }
}
