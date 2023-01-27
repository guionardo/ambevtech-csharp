using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;

namespace Aula3_OOP.TDD
{
    public class SomaVogais
    {
        public static int Soma(string texto)
        {
            int soma = 0;

            texto = RemoveAcentos(texto);
            foreach (var c in texto.ToUpperInvariant())
            {
                if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    soma++;
                }
            }
            return soma;
        }

        public static string RemoveAcentos(string texto)
        {
            string withDiacritics = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string withoutDiacritics = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";
            for (int i = 0; i < withDiacritics.Length; i++)
            {
                texto = texto.Replace(withDiacritics[i].ToString(), withoutDiacritics[i].ToString());
            }
            return texto;
        }
    }
}
