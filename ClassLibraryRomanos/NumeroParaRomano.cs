using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibraryRomanos
{

    public class NumeroParaRomano
    {
        public int Numero { get; private set; }
        public string NumeroRomano { get; set; }

        private readonly Dictionary<int, string> valoresConversao = new()
        {
            { 1000000, "M̄" },
            { 900000, "C̄M̄" },
            { 500000, "D̄" },
            { 400000, "C̄D̄" },
            { 100000, "C̄" },
            { 90000, "X̄C̄" },
            { 50000, "L̄" },
            { 40000, "X̄L̄" },
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 8000, "V̄ĪĪĪ" },
            { 7000, "V̄ĪĪ" },
            { 6000, "V̄Ī" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" },
        };

        public string Converter(int numeroComum)
        {
            StringBuilder resultado = new();
            int valorTotal = numeroComum;
            foreach (int valor in valoresConversao.Keys)
            {
                while (valorTotal >= valor)
                {
                    resultado.Append(valoresConversao[valor]);
                    valorTotal -= valor;
                }
            }
            return resultado.ToString();
        }

    }
}
