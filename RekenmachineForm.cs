using System;
using System.Drawing;
using System.Windows.Forms;

namespace RekenmachineStaartdeling
{
    /// <summary>
    /// Dit is het hoofdscherm van de rekenmachine.
    /// De leerlingen zien hier het scherm (display) en de knoppen.
    /// Zij gaan zelf de reken-logica invullen.
    /// </summary>
    public class RekenmachineForm : Form
    {
        // Dit is het tekstvak bovenaan waar het getal en het antwoord in staan.
        private TextBox tekstVakScherm = null!;

        // Hier onthouden we de vorige ingevoerde waarde (bijvoorbeeld 12 + 3 -> 12 wordt opgeslagen).
        private double huidigeWaarde = 0;

        // Hier onthouden we welk reken-teken is gekozen: +, -, * of /
        private string huidigeOperator = string.Empty;

        // Als deze true is, begint de gebruiker met een nieuw getal typen.
        private bool nieuwGetal = true;

        public RekenmachineForm()
        {
            Text = "Rekenmachine met staartdeling (starter)";
            Width = 320;
            Height = 420;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;

            InitialiseerComponenten();
        }

        /// <summary>
        /// Maakt het scherm (display) en de knoppen aan en zet ze netjes in een rooster.
        /// Deze code mag je laten staan.
        /// </summary>
        private void InitialiseerComponenten()
        {
            // Hoofd-layout: 2 rijen
            // Rij 0: display
            // Rij 1: knoppen
            var hoofdLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };

            // Bovenste rij heeft een vaste hoogte (60 pixels) voor het display.
            hoofdLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));
            // Onderste rij gebruikt de rest van de ruimte voor de knoppen.
            hoofdLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            hoofdLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            Controls.Add(hoofdLayout);

            // Het display waar de getallen in komen te staan.
            tekstVakScherm = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Right,
                ReadOnly = true,
                Text = "0"
            };
            hoofdLayout.Controls.Add(tekstVakScherm, 0, 0);

            // Layout voor de knoppen (4 kolommen, 4 rijen).
            var knoppenLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 4
            };

            for (int i = 0; i < 4; i++)
                knoppenLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
            for (int i = 0; i < 4; i++)
                knoppenLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25f));

            hoofdLayout.Controls.Add(knoppenLayout, 0, 1);

            // Bovenste rij: 7 8 9 /
            VoegKnopToe(knoppenLayout, "7", 0, 0, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "8", 0, 1, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "9", 0, 2, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "/", 0, 3, KnopOperatorKlik);

            // Tweede rij: 4 5 6 *
            VoegKnopToe(knoppenLayout, "4", 1, 0, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "5", 1, 1, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "6", 1, 2, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "*", 1, 3, KnopOperatorKlik);

            // Derde rij: 1 2 3 -
            VoegKnopToe(knoppenLayout, "1", 2, 0, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "2", 2, 1, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "3", 2, 2, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "-", 2, 3, KnopOperatorKlik);

            // Vierde rij: C 0 = +
            VoegKnopToe(knoppenLayout, "C", 3, 0, KnopWissenKlik);
            VoegKnopToe(knoppenLayout, "0", 3, 1, KnopCijferKlik);
            VoegKnopToe(knoppenLayout, "=", 3, 2, KnopIsKlik);
            VoegKnopToe(knoppenLayout, "+", 3, 3, KnopOperatorKlik);
        }

        /// <summary>
        /// Hulpmethode om een knop aan de layout toe te voegen.
        /// </summary>
        private void VoegKnopToe(TableLayoutPanel layout, string tekst, int rij, int kolom, EventHandler klikHandler)
        {
            var knop = new Button
            {
                Text = tekst,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16, FontStyle.Bold)
            };
            knop.Click += klikHandler;
            layout.Controls.Add(knop, kolom, rij);
        }

        /// <summary>
        /// Wordt uitgevoerd als de gebruiker op een cijfer-knop drukt.
        /// LEERLING-OPDRACHT:
        ///  - Zorg dat het aangeklikte cijfer goed op het scherm komt.
        /// </summary>
        private void KnopCijferKlik(object? afzender, EventArgs e)
        {
            if (afzender is not Button knop) return;

            string cijfer = knop.Text;

            // TODO: Als nieuwGetal true is of het scherm nu "0" is,
            //       moet je het scherm vervangen door het nieuwe cijfer.
            //       Anders plak je het cijfer achter het bestaande getal.

            // Voorbeeld in woorden:
            // als (nieuwGetal == true OF tekstVakScherm.Text == "0")
            //    tekstVakScherm.Text = cijfer;
            //    nieuwGetal = false;
            // anders
            //    tekstVakScherm.Text = tekstVakScherm.Text + cijfer;
        }

        /// <summary>
        /// Wordt uitgevoerd als de gebruiker op +, -, * of / drukt.
        ///  - Sla de huidige waarde op.
        ///  - Onthoud welke operator is gekozen.
        ///  - Zorg dat bij een tweede operator eerst de vorige berekening wordt gedaan.
        /// </summary>
        private void KnopOperatorKlik(object? afzender, EventArgs e)
        {
            if (afzender is not Button knop) return;

            if (!double.TryParse(tekstVakScherm.Text, out double invoer))
                return;

            // TODO:
            // Als er nog GEEN vorige operator is (huidigeOperator is leeg):
            //   - sla invoer op in huidigeWaarde.
            // Anders:
            //   - reken eerst de vorige som uit met RekenLogica.Bereken(huidigeWaarde, invoer, huidigeOperator)
            //   - toon het resultaat in tekstVakScherm
            //   - sla de nieuwe waarde op in huidigeWaarde

            // Onthoud daarna de NIEUWE operator:
            //   huidigeOperator = knop.Text;
            //   nieuwGetal = true;
        }

        /// <summary>
        /// Wordt uitgevoerd als de gebruiker op = drukt.
        ///  - Gebruik RekenLogica.Bereken om de som af te maken.
        ///  - Laat bij deling (/) ook de staartdeling zien in een apart venster.
        /// </summary>
        private void KnopIsKlik(object? afzender, EventArgs e)
        {
            if (string.IsNullOrEmpty(huidigeOperator))
                return;

            if (!double.TryParse(tekstVakScherm.Text, out double invoer))
                return;

            double oudeWaarde = huidigeWaarde;
            double nieuweInvoer = invoer;

            // TODO:
            // 1. Roep RekenLogica.Bereken aan met oudeWaarde, nieuweInvoer en huidigeOperator.
            //    Bijvoorbeeld:
            //      string resultaatTekst = RekenLogica.Bereken(oudeWaarde, nieuweInvoer, huidigeOperator);
            //
            // 2. Toon het resultaat op het scherm:
            //      tekstVakScherm.Text = resultaatTekst;
            //
            // 3. Als huidigeOperator gelijk is aan "/" EN resultaatTekst is NIET "Fout":
            //      - maak een nieuw StaartdelingForm aan:
            //          var venster = new StaartdelingForm((int)oudeWaarde, (int)nieuweInvoer, 10);
            //      - laat dit venster zien met venster.Show();

            huidigeOperator = string.Empty;
            nieuwGetal = true;
        }

        /// <summary>
        /// Wordt uitgevoerd als de gebruiker op C (clear) drukt.
        /// Dit wist de huidige berekening.
        /// </summary>
        private void KnopWissenKlik(object? afzender, EventArgs e)
        {
            huidigeWaarde = 0;
            huidigeOperator = string.Empty;
            nieuwGetal = true;
            tekstVakScherm.Text = "0";
        }
    }
}