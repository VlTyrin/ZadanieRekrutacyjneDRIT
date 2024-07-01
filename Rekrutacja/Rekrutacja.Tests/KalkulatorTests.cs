using NUnit.Framework;
using Rekrutacja.Enums;
using Rekrutacja.Kalkulator;
using System;

namespace Rekrutacja.Tests
{
    [TestFixture]
    public class KalkulatorTests
    {
        [Test]
        [TestCase(1, 1, 2)]
        [TestCase(10, 20, 30)]
        [TestCase(-5, 5, 0)]
        [TestCase(1.25, 2.5, 3.75)]
        public void Dodaj_Test(double a, double b, double expectedResult)
        {
            var actualResult = KalkulatorEngine.WykonajOpercje(a, b, OperacjaMatematyczna.Dodaj);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(5, 3, 2)]
        [TestCase(10, 5, 5)]
        [TestCase(-5, -3, -2)]
        [TestCase(1.5, 0.5, 1)]
        public void Odejmij_Test(double a, double b, double expectedResult)
        {
            var actualResult = KalkulatorEngine.WykonajOpercje(a, b, OperacjaMatematyczna.Odejmij);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(2, 3, 6)]
        [TestCase(-4, 5, -20)]
        [TestCase(0.5, 0.5, 0.25)]
        [TestCase(0, 100, 0)]
        public void Pomnoz_Test(double a, double b, double expectedResult)
        {
            var actualResult = KalkulatorEngine.WykonajOpercje(a, b, OperacjaMatematyczna.Pomnoz);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        [TestCase(6, 3, 2)]
        [TestCase(10, 2, 5)]
        [TestCase(-10, 5, -2)]
        [TestCase(1.5, 0.5, 3)]
        public void Podziel_Test(double a, double b, double expectedResult)
        {
            var actualResult = KalkulatorEngine.WykonajOpercje(a, b, OperacjaMatematyczna.Podziel);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Podziel_By_Zero_Test()
        {
            Assert.Throws<DivideByZeroException>(() => KalkulatorEngine.WykonajOpercje(6, 0, OperacjaMatematyczna.Podziel));
        }

        [Test]
        public void Nieprawidlowa_Operacja_Test()
        {
            Assert.Throws<InvalidOperationException>(() => KalkulatorEngine.WykonajOpercje(5, 3, (OperacjaMatematyczna)10));
        }
    }
}
