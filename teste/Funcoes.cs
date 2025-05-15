using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    public class Funcoes
    {
         public static int Lenght(string[][] papaveis)
        {
            int i = 0;
            while (papaveis[i] != null)
            {
                i++;
            }
            return i;
        }
        public static int Buscar(string[][] vetor, string nome)
        {
            int i = 0;
            for (i = 0; i < Lenght(vetor) && vetor[i][0] != nome; i++) ;

            if (i < Lenght(vetor)) return i;

            return -1;
        }
    }
}
