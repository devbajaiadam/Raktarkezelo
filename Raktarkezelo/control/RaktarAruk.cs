using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raktarkezelo.boundary;
using Raktarkezelo.control;

namespace Raktarkezelo
{
    class RaktarAruk
    {
        #region Valtozok
        string nev;
        string mennyEgyseg;
        int mennyiseg;
        int darabar;
        int kategoriaId;
        #endregion

        #region Getter-Setter
        public string Nev
        {
            get => nev;
            set
            {
                if(Nev == null)
                {
                    nev = value;
                }
                
            }
        }
        public string MenyEgyseg
        {
            get => mennyEgyseg;
            set
            {
               if(mennyEgyseg==null)
                {
                    mennyEgyseg = value;
                }
                
            }
        }
        public int Mennyiseg
        {
            get => mennyiseg;
            set
            {
                if(mennyiseg >= 0)
                {
                    mennyiseg = value;
                }
                
            }
        }
        public int Darabar
        {
            get => darabar;
            set
            {
                if(darabar >= 0)
                {
                    darabar = value;
                }
                
            }
        }
        public int KategoriaId
        {
            get => kategoriaId;
            set
            {
                if(kategoriaId >= 0)
                {
                    kategoriaId = value;
                }
               
            }
        }
        #endregion

        #region Konstruktor
        public RaktarAruk( string nev, string menyEgyseg, int mennyiseg, int darabar, int kategoriaId)
        {
            Nev = nev;
            MenyEgyseg = menyEgyseg;
            Mennyiseg = mennyiseg;
            Darabar = darabar;
            KategoriaId = kategoriaId;
        }
        #endregion


    }
}
