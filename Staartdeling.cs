using System;
using System.Text;

namespace RekenmachineStaartdeling
{
    /// <summary>
    /// Deze klasse bevat de logica voor staartdeling.
    /// De leerlingen gaan hier stap voor stap de deling maken zonder de / operator.
    /// </summary>
    public static class Staartdeling
    {
        /// <summary>
        /// Deelt twee gehele getallen en maakt er een decimale tekst van.
        /// Bijvoorbeeld: deeltal = 7, deler = 3, aantalDecimalen = 5 → "2.33333".
        /// BELANGRIJK: gebruik hier NIET de gewone / operator voor a / b.
        /// </summary>
        public static string DeelNaarDecimaleTekst(int deeltal, int deler, int aantalDecimalen = 10)
        {
            // TODO: Als deler 0 is → return "Fout".

            // TODO: Bepaal of het antwoord negatief moet zijn.
            //       Dit is zo als precies één van de twee getallen negatief is:
            //       bool negatief = (deeltal < 0) ^ (deler < 0);

            // TODO: Werk verder met de absolute waardes van deeltal en deler.
            //       Tip: gebruik Math.Abs(...).

            // TODO: Bereken eerst het GEHELE deel:
            //       - Zet rest = deeltal (als long).
            //       - Zolang rest >= deler:
            //             rest -= deler;
            //             tel hoe vaak dit lukt (geheelDeel++).
            //
            // TODO: Zet het geheel deel als tekst in een StringBuilder.
            //       Als het antwoord negatief moet zijn: zet eerst een '-' in de StringBuilder.
            //
            // TODO: Als rest 0 is of aantalDecimalen <= 0:
            //          geef de string uit de StringBuilder terug (sb.ToString()).
            //
            // TODO: Anders:
            //       - plak een '.' achter het geheel deel.
            //       - Herhaal aantalDecimalen keer (for-lus):
            //           * rest *= 10;
            //           * tel hoe vaak deler in rest past (while (rest >= deler)) → dit is 1 decimaal cijfer.
            //           * haal steeds deler eraf en tel op in een lokale variabele 'cijfer'.
            //           * voeg dit cijfer toe aan de StringBuilder.
            //           * als rest 0 wordt, kun je stoppen.

            throw new NotImplementedException("Staartdeling (decimaal) is nog niet geïmplementeerd. Maak de TODO's af.");
        }

        /// <summary>
        /// Maakt een duidelijke uitleg-tekst met alle stappen van de staartdeling.
        /// Dit gebruiken we in het aparte staartdeling-venster.
        /// </summary>
        public static string GenereerVisueleStaartdeling(int deeltal, int deler, int aantalDecimalen = 10)
        {
            // TODO (uitdagender):
            //  - Maak een StringBuilder.
            //  - Schrijf eerst een titelregel, bijvoorbeeld: "Staartdeling voor: 7 ÷ 3".
            //  - Schrijf een rij met '='-tekens eronder.
            //  - Doe daarna ongeveer dezelfde stappen als in DeelNaarDecimaleTekst,
            //    maar schrijf bij elke stap op wat je doet.
            //
            //  Voor het GEHELE deel kun je bijvoorbeeld per stap schrijven:
            //    "Stap 1: neem 7 → 7 ÷ 3 = 2, rest 1"
            //
            //  Voor de DECIMALEN kun je schrijven:
            //    "Decimaal 1: 10 ÷ 3 = 3, rest 1"
            //
            //  Eindig met een regel:
            //    "Volledige uitkomst als decimaal: 2.33333"


            throw new NotImplementedException("Visuele staartdeling is nog niet geïmplementeerd. Maak de TODO's af.");
        }
    }
}