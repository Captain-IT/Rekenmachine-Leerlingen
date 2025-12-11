using System;

namespace RekenmachineStaartdeling
{
    /// <summary>
    /// In deze klasse schrijven de leerlingen de basis-rekenlogica:
    /// plus, min, keer en delen (met staartdeling).
    /// </summary>
    public static class RekenLogica
    {
        /// <summary>
        /// Voert één som uit: a (op) b.
        /// Voorbeelden:
        ///   Bereken(7, 3, "+") → "10"
        ///   Bereken(7, 3, "-") → "4"
        ///   Bereken(7, 3, "*") → "21"
        ///   Bereken(7, 3, "/") → gebruikt staartdeling → "2.3333333333"
        /// </summary>
        public static string Bereken(double a, double b, string op)
        {
            // TODO 1: Als op gelijk is aan "+", geef dan a + b terug als string.
            //         Tip: (a + b).ToString()
            //
            // TODO 2: Als op gelijk is aan "-", geef dan a - b terug als string.
            //
            // TODO 3: Als op gelijk is aan "*", geef dan a * b terug als string.
            //
            // TODO 4: Als op gelijk is aan "/", gebruik dan staartdeling.
            //         Gebruik de methode Staartdeling.DeelNaarDecimaleTekst:
            //           return Staartdeling.DeelNaarDecimaleTekst((int)a, (int)b, 10);
            //
            // TODO 5: In alle andere gevallen: geef gewoon b terug als string.

            throw new NotImplementedException("Bereken is nog niet geïmplementeerd. Maak de TODO's af.");
        }
    }
}