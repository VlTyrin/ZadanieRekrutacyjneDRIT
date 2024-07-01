using Rekrutacja.Enums;
using System;

namespace Rekrutacja.Kalkulator
{
    public static class KalkulatorEngine
    {
        public static double WykonajOpercje(double a, double b, OperacjaMatematyczna operacja)
        {
            switch (operacja)
            {
                case OperacjaMatematyczna.Dodaj:
                    return a + b;
                case OperacjaMatematyczna.Odejmij:
                    return a - b;
                case OperacjaMatematyczna.Pomnoz:
                    return a * b;
                case OperacjaMatematyczna.Podziel:
                    if (b == 0)
                        throw new DivideByZeroException("Podział przez zero.");
                    return a / b;
                default:
                    throw new InvalidOperationException("Nieprawidłowa operacja.");
            }
        }
    }
}
