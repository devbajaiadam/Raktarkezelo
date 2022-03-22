using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raktarkezelo.boundary;
using Raktarkezelo.control;

namespace Raktarkezelo
{
    class UserClass
    {
        #region Valtozok
        string felhnevPK;
        string nev;
        string jelszo;
        int szerepId;
        int aktiv;
        #endregion

        #region Getter-Setter
        public string FelhnevPK
        {
            get => felhnevPK;
            set
            {
                if(felhnevPK == null)
                {
                    felhnevPK = value;  
                }
                else
                {
                    throw new InvalidCastException("A felhasználónevet csak egyszer lehet megadni!");
                }
                
            }
        }
        public string Nev { get => nev; /*set => nev = value;*/ }
        public string Jelszo
        {
            get => jelszo;
            set
            {
                if (JelszoMuveletek.ErosJelszo(value))
                {
                    jelszo = JelszoMuveletek.Titkosit(value);
                }
                else
                {
                    throw new ArgumentException("A jelszónak legalább 8 karakteresnek kell lennie, illetve kis/nagybetűket és számokat is tartalmaznia kell ");
                }        
            }
        }
        public int SzerepId { get => szerepId; /*set => szerepId = value; */}
        public int Aktiv { get => aktiv; /*set => aktiv = value; */}
        #endregion

        #region Konstruktor
        public UserClass(string felhnevPK, string nev, string jelszo, int szerep, int aktiv )
        {
            FelhnevPK = felhnevPK;
            this.nev = nev;
            Jelszo = jelszo;
            this.szerepId = szerep;
            this.aktiv = aktiv;

        }

        public UserClass(string nev, int szerepId, int aktiv, string felhnevPK, string jelszo)
        {
            this.nev = nev;
            this.szerepId = szerepId;
            this.aktiv = aktiv;
            FelhnevPK = felhnevPK;
            this.jelszo = jelszo;
        }
        #endregion

        #region Alprogramok
        public override string ToString()
        {
            return $" Felhasználónév: {FelhnevPK}   |   Teljes Név: {Nev}";
        }
        #endregion

    }
}
