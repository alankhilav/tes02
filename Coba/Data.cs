using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coba
{
    class Data
    {
        private string[] myData = { "Hai Jugaaaaa", "Cecil Kak", "17 Tahun kak", "lagi mikirin kakak. Cieeee :)" };
        private string final;

        public string proses(string text)
        {
            string[] words = text.Split(' ');
            
            for (int i=0; i<words.Length; i++)
            {
                if (words[i] == "hai" ||
                    words[i] == "hey" ||
                    words[i] == "hay"
                    )
                {
                    final = "hai";
                    break;
                }
                else if(words[i] == "halo" ||
                        words[i] == "hello" ||
                        words[i] == "hallo"
                        )
                {
                    final = "hello";
                }
                else if (words[i] == "namamu" ||
                   (words[i] == "nama" && (words[i+1]=="kamu" || words[i + 1] == "kau" || words[i + 1] == "km" || words[i + 1] == "engkau"))
                   )
                {
                    final = "namaBot";
                    break;
                }
                else if (words[i] == "umurmu" ||
                    (words[i] == "umur" && (words[i + 1] == "kamu" || words[i + 1] == "kau" || words[i + 1] == "km" || words[i + 1] == "engkau" || words[i + 1] == "dikau" || words[i + 1] == "dirimu"))
                    )

                {
                    final = "umurBot";
                    break;
                }
                else if (words[i] == "ngapain" ||
                        (words[i] == "bikin" && words[i+1] == "apa" )
                        )
                {
                    final = "ngapain";
                    break;
                }
                else
                {
                    final = "entahlah";
                }
            }
            return pindah(final);
        }



        public String pindah(string text)
        {
            if (text == "hai")
            {
                return "Hai juga kak";
            }
            else if (text == "hello")
            {
                return "Haloo kak";
            }
            else if (text == "namaBot")
            {
                return myData[1];
            }
            else if (text == "umurBot")
            {
                return myData[2];
            }
            else if ( text == "ngapain")
            {
                return myData[3];
            }
            else
            {
                return "Maaf kak, aku gak paham maksud kakak apa";
            }
        }
    }
}
