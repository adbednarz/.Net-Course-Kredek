using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdamBednarzLab1
{
    public partial class FormNew : Form
    {
        // zmienna publiczna pozwalająca na dostęp do jej wartości z poziomu innych obiektów
        public string mainWindowValue = "brak wartości";

        public FormNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Funkcja wywoływana podczas wczytywania okienka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormNew_Load(object sender, EventArgs e)
        {
            //przypisanie wartości ze zmiennej do obiektu label
            labelFromMainValue.Text = mainWindowValue;
        }
    }
}
