using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBednarzLab1ZadDom
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Tworzenie okna
            FormMain form1 = new FormMain();
            // Ustawienie rozmiaru okna
            form1.Size = new Size(1050, 800);
            // Wyœwietlenie na œrodku ekranu
            form1.StartPosition = FormStartPosition.CenterScreen;
            Application.Run(form1);
        }
    }
}
