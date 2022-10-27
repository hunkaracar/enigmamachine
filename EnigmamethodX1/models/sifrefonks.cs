using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmamethodX1.models
{
    public  class sifrefonks
    {
        public string Sifrele(string value)
        {
            string Sonuc = null;
            char[] _value = value.ToCharArray();
            
            foreach (char tane in _value)
            {

                Sonuc += Convert.ToChar(tane - 7).ToString();

            }
            return Sonuc;

        }
        public string Cozumle(string sifrelenmisvalue)
        {
            string deger = null;
            char[] _sifrelenmisdeger = sifrelenmisvalue.ToCharArray();  

            foreach(char tane in _sifrelenmisdeger)
            {

                deger += Convert.ToChar(tane + 7).ToString();

            }
            return deger;


        }
    }
}
