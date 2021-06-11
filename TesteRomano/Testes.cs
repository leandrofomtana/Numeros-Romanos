using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryRomanos;
namespace TesteRomano
{
    [TestClass]
    public class Testes
    {
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        [DataRow("MMMDCCXXIV", 3724)]
        [DataRow("C̄L̄ĪV̄CCLII", 154252)]
        [DataRow("M̄M̄M̄C̄M̄X̄C̄ĪX̄CMXCIX", 3999999)]
        public void DeveConverterNumeroRomanoParaComum(string romano, int numero)
        {
            RomanoParaNumero teste = new();
            Assert.AreEqual(numero, teste.Converter(romano));
        }

         [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        [DataRow("MMMDCCXXIV", 3724)]
        [DataRow("C̄L̄ĪV̄CCLII", 154252)]
        [DataRow("M̄M̄M̄C̄M̄X̄C̄ĪX̄CMXCIX", 3999999)]
        public void DeveConverterNumeroComumParaRomano(string romano, int numero)
        {
            NumeroParaRomano teste = new();
            Assert.AreEqual(romano, teste.Converter(numero));
        }
    }
}
