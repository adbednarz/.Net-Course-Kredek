using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBednarzLab1
{
    public partial class Form1 : Form
    {
        #region zmienne dotyczące zarządzania testboxów

        /// <summary>
        /// zmienna przechowująca wartość pola textBoxAdd
        /// </summary>
        int number = 1;
        int number2 = 1;
        int counter = 1;
        /// <summary>
        /// zmienna przechowująca referencje do nowego okna
        /// </summary>
        FormNew formNew;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Przycisk zmieniający kolor tła i elementów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColor_Click(object sender, EventArgs e)
        {
            //zmiana koloru tła
            BackColor = Color.Green;
            //zmiana koloru przycisku
            buttonColor2.BackColor = Color.Pink;
            buttonColor.Enabled = false;
        }

        private void buttonColor2_Click(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Green;
            buttonColor2.Enabled = false;
        }

        /// <summary>
        /// Przycisk zwiekszający wartosć textBoxAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //parsowanie elementu tekstowego na liczbę
            number = Int32.Parse(textBoxAdd.Text);
            //dodanie wartości liczbowej
            number += 7;
            //zamiana wartości  liczbowej na zmienną typu string
            textBoxAdd.Text = number.ToString();
            //dodanie warunku
            if(number>20) MessageBox.Show("Uwaga przekroczono próg 20!");


        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            number2 *= number;
            textBoxTimer.Text = number2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //uruchomienie zegara
            timerCounter.Start();
        }

        /// <summary>
        /// wywołanie funkcji obsługiwanej przez wątek elementu timerCounter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {
            //zwiększanie zmiennej counter
            counter++;
            //odświeżenie zawartosci textBoxa
            textBoxAdd.Text = counter.ToString();
            if(counter==5)
            {
                buttonColor.Enabled = false;
                buttonAdd.Enabled = false;
                buttonStart.Enabled = false;

            }
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            //utworzenie nowego obiektu okna
            formNew = new FormNew();
            // przypisanie wartości do innego okna
            formNew.mainWindowValue = "Adam Bednarz";
            //otworzenie okna obiektu formNew
            formNew.Show();
        }
    }
}
