using System;
using System.Windows.Forms;

namespace RekenmachineStaartdeling
{
    internal static class Programma
    {
        [STAThread]
        static void Main()
        {
            // Deze code start de Windows Forms applicatie.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Hier starten we het hoofdscherm van de rekenmachine.
            Application.Run(new RekenmachineForm());
        }
    }
}