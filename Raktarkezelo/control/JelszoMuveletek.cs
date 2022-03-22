using System;
using System.Text;
using System.Security.Cryptography;

namespace Raktarkezelo
{
    static class JelszoMuveletek
    {
        public static string Titkosit(string jelszo)
        {
            return BitConverter.ToString(new SHA256CryptoServiceProvider().ComputeHash(Encoding.UTF8.GetBytes(jelszo))).Replace("-", "").ToLower();
        }


        // minimum 8 karakter, legalább 1-1 kisbetű, nagybetű és szám
        public static bool ErosJelszo(string jelszo)
        {
            if (jelszo.Length >= 8 && jelszo.ToLower() != jelszo && jelszo.ToUpper() != jelszo)
            {
                for (int i = 0; i <= 9; i++)
                {
                    if (jelszo.Contains(i.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
