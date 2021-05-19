using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AdamBednarzLab1ZadDom
{
    public partial class Shop : Form
    {
        // możliwość odwołania do publicznych zmiennych i metod klasy FormMain
        FormMain parent; 

        /// <summary>
        /// Konstruktor klasy shop, w którym ustalamy aktywność przycisków kupowania
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="organic"></param>
        /// <param name="sprayer"></param>
        /// <param name="medicaments"></param>
        /// <param name="vitamins"></param>
        public Shop(FormMain parent, bool organic, bool sprayer, bool medicaments, bool vitamins)
        {
            InitializeComponent();
            this.parent = parent;
            // aktywny booster nie może być kolejny raz aktywowywany
            // przycisk jest aktywny w zależności od przesłanej do klasy wartości z FormMain
            button1Buy.Enabled = organic;
            button1BuyPremiun.Enabled = organic;
            button2Buy.Enabled = sprayer;
            button2BuyPremium.Enabled = sprayer;
            button3Buy.Enabled = medicaments;
            button4Buy.Enabled = vitamins;
            button4BuyMedium.Enabled = vitamins;
            button4BuyPremium.Enabled = vitamins;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            
        }

        #region Funkcje obsługujące kupno danego przedmiotu w sklepie

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego nawóz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Buy_Click(object sender, EventArgs e)
        {
            // wywołanie metody głównego okna, która obsługuje transakcję kupna 
            if (parent.TakeMoney(5000))
            {
                // przekazanie rodzicowi informację, który booster został aktywowany
                parent.boosterOrganic = false;
                // nadanie temu boosterowi odpowiednią wagę, im mniejsza tym opóźnienia są mniejsze
                parent.boosterOrganicValue = 5;
                // wyłączenie okna sklepu
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego nawóz premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1BuyPremium_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(8000))
            {
                parent.boosterOrganic = false;
                parent.boosterOrganicValue = 4;
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego oprysk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2Buy_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(2000))
            {
                parent.boosterSprayer = false;
                parent.boosterSprayerValue = 5;
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego oprysk premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2BuyPremium_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(5000))
            {
                parent.boosterSprayer = false;
                parent.boosterSprayerValue = 4;
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego lekarstwa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3Buy_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(500))
            {
                parent.boosterMedicaments = false;
                // ten booster nie posiada poziomowania mocy
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego witaminy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4Buy_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(300))
            {
                parent.boosterVitamins = false;
                parent.boosterVitaminsValue = 5;
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego witaminy medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4BuyMedium_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(400))
            {
                parent.boosterVitamins = false;
                parent.boosterVitaminsValue = 4;
                this.Dispose(true);
            }
        }

        /// <summary>
        /// Akcja związana z naciśnięciem przycisku wybierającego witaminy premium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button4BuyPremium_Click(object sender, EventArgs e)
        {
            if (parent.TakeMoney(500))
            {
                parent.boosterVitamins = false;
                parent.boosterVitaminsValue = 3;
                this.Dispose(true);
            }
        }
        #endregion
    }
}
