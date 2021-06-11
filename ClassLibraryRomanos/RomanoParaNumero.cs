using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRomanos
{
    public class RomanoParaNumero
    {
        private readonly Dictionary<char, int> valoresConversao = new()
        {      
            { 'm', 1000000 },
            { 'd', 500000 },
            { 'c', 100000},
            { 'l', 50000},
            { 'x', 10000 },
            { 'v', 5000 },
            { 'i', 1000 },
            { 'M', 1000 },
            { 'D', 500 },
            { 'C', 100 },
            { 'L', 50 },
            { 'X', 10},
            { 'V', 5},
            { 'I', 1},
        };

        private readonly List<string> combinacoesQueSubtrai = new()
        {
            "IV",
            "IX",
            "IC",
            "XC",
            "XM",
            "CM",
            "iv",
            "ix",
            "ic",
            "xc",
            "xm",
            "cm"
        };
        public int Converter(string numeroRomano)
        {
            numeroRomano = ConverteMacrons(numeroRomano);
            int resultado = 0;
            bool continueFor = false;
            List<int> indicesCombinacoesQueSubtrai = new();
            foreach (string s in combinacoesQueSubtrai)
                if (numeroRomano.Contains(s))
                    indicesCombinacoesQueSubtrai.Add(numeroRomano.IndexOf(s));
            for (int i=0; i<numeroRomano.Length; i++)
            {
                foreach (int y in indicesCombinacoesQueSubtrai)
                {
                    if (i == y)
                    {
                        resultado += NumeroComAntecessorMenor(numeroRomano.Substring(y, 2));
                        indicesCombinacoesQueSubtrai.Remove(y);
                        i++;
                        continueFor = true;
                        break;
                    }
                }
                if (continueFor)
                {
                    continueFor = false;
                    continue;
                }
                resultado += valoresConversao[numeroRomano[i]];
            }
            return resultado;
        }


        private int NumeroComAntecessorMenor(string numerais)
        {
            return valoresConversao[numerais[1]] - valoresConversao[numerais[0]];
        }

        private string ConverteMacrons(string romano)
        {
            //"ĪV̄X̄L̄C̄D̄M̄"
            romano = romano.Replace("Ī", "i");
            romano = romano.Replace("V̄", "v");
            romano = romano.Replace("X̄", "x");
            romano = romano.Replace("L̄", "l");
            romano = romano.Replace("C̄", "c");
            romano = romano.Replace("D̄", "d");
            romano = romano.Replace("M̄", "m");

            return romano;
        }
    }
}
