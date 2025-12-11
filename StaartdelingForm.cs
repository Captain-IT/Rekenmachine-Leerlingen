using System.Drawing;
using System.Windows.Forms;

namespace RekenmachineStaartdeling
{
    /// <summary>
    /// Dit venster laat de staartdeling stap voor stap zien in tekstvorm.
    /// De tekst komt uit Staartdeling.GenereerVisueleStaartdeling.
    /// </summary>
    public class StaartdelingForm : Form
    {
        private TextBox tekstVakUitvoer = null!;

        public StaartdelingForm(int deeltal, int deler, int aantalDecimalen = 10)
        {
            Text = $"Staartdeling: {deeltal} ÷ {deler}";
            Width = 650;
            Height = 750;
            StartPosition = FormStartPosition.CenterParent;

            tekstVakUitvoer = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Dock = DockStyle.Fill,
                ScrollBars = ScrollBars.Vertical,
                Font = new Font(FontFamily.GenericMonospace, 11f)
            };

            Controls.Add(tekstVakUitvoer);

            // NU is de methode nog niet ingevuld, dus dit gooit een NotImplementedException
            // totdat de leerlingen Staartdeling.GenereerVisueleStaartdeling hebben afgemaakt.
            try
            {
                tekstVakUitvoer.Text = Staartdeling.GenereerVisueleStaartdeling(deeltal, deler, aantalDecimalen);
            }
            catch (System.NotImplementedException ex)
            {
                tekstVakUitvoer.Text = "Staartdeling is nog niet geïmplementeerd.\r\n\r\n" + ex.Message;
            }
        }
    }
}