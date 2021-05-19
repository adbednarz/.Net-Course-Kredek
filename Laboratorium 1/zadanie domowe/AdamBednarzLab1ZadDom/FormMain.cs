using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdamBednarzLab1ZadDom
{
    public partial class FormMain : Form
    {
        // definowanie domyślnej czcionki w grze
        static readonly FontFamily fontFamily = new FontFamily("Lucida Handwriting");
        readonly SolidBrush solidBrush = new SolidBrush(Color.Black);

        // klasa random
        Random rnd = new Random();

        // napis pojawiający się na zwisającej tabliczce
        string title = "Gospodarstwo";
        // opis rzeczy, na którą klikniemy; początkowo opis gry
        List<String> description = new List<String>();
        // zbiór komunikatów
        List<String> messages = new List<String>();

        // licznik pieniążków
        int money = 0;

        // liczba poszczególnych zasobów w grze
        int hens = 0;
        int cows = 0;
        int bees = 0;
        int eggs = 0;
        int milk = 0;
        double honey = 0;
        int grains = 1000;

        // nazwy zasobów pierwszego i drugiego
        string resource;
        string resource2;

        // liczba zasobów pierwszego i drugiego
        string amount;
        string amount2;

        // zmienne wskazujące na poziom głodu kur i krów
        int hensFeed = 0;
        int cowsFeed = 0;

        // flagi katastrof, jeśli są true to ich negatywny efekt działa
        bool disasterFlag1 = false;     // wścibski sąsiad
        bool disasterFlag2 = false;     // ludzie z miasta
        // true w przypadku trzeciej flagi powoduje, że zdarzenie przestaje występować
        bool disasterFlag3 = false;     // lisy

        // flagi boosterów, jeśli są true to można kupić dany booster
        public bool boosterOrganic = true;      // nawóz
        public bool boosterSprayer = true;      // oprysk
        public bool boosterMedicaments = true;  // lekarstwa
        public bool boosterVitamins = true;     // witaminy

        // poziomy boosterów
        // poziom 6 nie zmienia nic, niższe poziomy zmniejszają czas timerów
        // są dostępne poziomy 5, 4, 3
        // booster lekarstwa, zmniejszający wystąpienie śmierci jest tylko jeden
        public int boosterOrganicValue = 6;
        public int boosterSprayerValue = 6;
        public int boosterVitaminsValue = 6;

        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Początek gry, umieszczenie tekstu powitalnego na tablicy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            description.Add("Witaj w symulatorze");
            description.Add("gospodarstwa! Opiekujesz");
            description.Add("się swoimi zwierzętami,");
            description.Add("dzięki którym możesz");
            description.Add("się wzbogacić! Ale uważaj");
            description.Add("czycha tutaj pełno");
            description.Add("niebezpieczeństw!");
        }

        #region Powiększanie i zmniejszanie obrazka w zależności czy kursor najeżdza na obrazek, czy zjeżdża

        /// <summary>
        /// Zwiększenie obrazka spichlerza, gdy najedziemy myszką
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxBarn_MouseEnter(object sender, EventArgs e)
        {
            // zmienia lokalizację lewego górnego rogu
            pictureBoxBarn.Location = new Point(pictureBoxBarn.Location.X - 10, pictureBoxBarn.Location.Y - 10);
            // zwiększa rozmiar pictureBox
            pictureBoxBarn.Size = new Size(pictureBoxBarn.Size.Width + 20, pictureBoxBarn.Size.Height + 20);

        }

        /// <summary>
        /// Powrót obrazka spichlerza do normalnego rozmiaru, gdy już myszka nie jest na nim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxBarn_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBarn.Location = new Point(pictureBoxBarn.Location.X + 10, pictureBoxBarn.Location.Y + 10);
            pictureBoxBarn.Size = new Size(pictureBoxBarn.Size.Width - 20, pictureBoxBarn.Size.Height - 20);
        }

        /// <summary>
        /// Zwiększenie obrazka kurnika, gdy najedziemy myszką
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHenHouse_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHenHouse.Location = new Point(pictureBoxHenHouse.Location.X - 10, pictureBoxHenHouse.Location.Y - 10);
            pictureBoxHenHouse.Size = new Size(pictureBoxHenHouse.Size.Width + 20, pictureBoxHenHouse.Size.Height + 20);
        }

        /// <summary>
        /// Powrót obrazka kurnika do normalnego rozmiaru, gdy już myszka nie jest na nim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHenHouse_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHenHouse.Location = new Point(pictureBoxHenHouse.Location.X + 10, pictureBoxHenHouse.Location.Y + 10);
            pictureBoxHenHouse.Size = new Size(pictureBoxHenHouse.Size.Width - 20, pictureBoxHenHouse.Size.Height - 20);
        }

        /// <summary>
        /// Zwiększenie obrazka obory, gdy najedziemy myszką
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxCowShed_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxCowShed.Location = new Point(pictureBoxCowShed.Location.X - 10, pictureBoxCowShed.Location.Y - 10);
            pictureBoxCowShed.Size = new Size(pictureBoxCowShed.Size.Width + 20, pictureBoxCowShed.Size.Height + 20);
        }

        /// <summary>
        /// Powrót obrazka obory do normalnego rozmiaru, gdy już myszka nie jest na nim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxCowShed_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxCowShed.Location = new Point(pictureBoxCowShed.Location.X + 10, pictureBoxCowShed.Location.Y + 10);
            pictureBoxCowShed.Size = new Size(pictureBoxCowShed.Size.Width - 20, pictureBoxCowShed.Size.Height - 20);
        }

        /// <summary>
        /// Zwiększenie obrazka ula, gdy najedziemy myszką
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHive_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxHive.Location = new Point(pictureBoxHive.Location.X - 10, pictureBoxHive.Location.Y - 10);
            pictureBoxHive.Size = new Size(pictureBoxHive.Size.Width + 20, pictureBoxHive.Size.Height + 20);
        }

        /// <summary>
        /// Powrót obrazka ula do normalnego rozmiaru, gdy już myszka nie jest na nim
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHive_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxHive.Location = new Point(pictureBoxHive.Location.X + 10, pictureBoxHive.Location.Y + 10);
            pictureBoxHive.Size = new Size(pictureBoxHive.Size.Width - 20, pictureBoxHive.Size.Height - 20);
        }
        #endregion

        /// <summary>
        /// Po kliknięciu w kurnik wyświetli nam się nazwa, opis, liczba kur i jajek oraz możliwe akcje z nim związane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHenHouse_Click(object sender, EventArgs e)
        {
            title = "Kurnik";
            // stworzenie opisu do wyświetlenia
            description = new List<String>
            {
                "Tutaj znajdują się Twoje",
                "kury. Jeśli będziesz",
                "sumiennie o nie dbał,",
                "zniosą Ci wiele jaj.",
                "Lecz uważaj, lisy czają",
                "się o każdej porze."
            };
            // nazwanie dostępnych zasobów
            resource = "Kury:";
            resource2 = "Jajka:";
            // przypisanie liczby/ilości zasobów
            amount = hens.ToString();
            amount2 = eggs.ToString();
            // przypisywanie jakie elementy mają się pojawić
            pictureBoxDeskResource.Visible = true;
            pictureBoxDeskResource2.Visible = true;
            pictureBoxSell2.Visible = true;
            pictureBoxSell.Visible = true;
            // odświeżenie elementów graficznych
            pictureBoxBoard.Invalidate();
            pictureBoxPlate.Invalidate();
            pictureBoxDeskResource.Invalidate();
            pictureBoxDeskResource2.Invalidate();
            pictureBoxSell2.Invalidate();
            pictureBoxSell.Invalidate();
            // pojawienie się akcji nakarmienia kur, w przypadku gdy są głodne
            if (hensFeed > 0)
            {
                pictureBoxFeed.Visible = true;
                pictureBoxFeed.Invalidate();
            } else
                pictureBoxFeed.Visible = false;
        }

        /// <summary>
        /// Po kliknięciu w spichlerz wyświetli nam się nazwa, opis, ilość zboża oraz możliwa akcja z nim związana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxBarn_Click(object sender, EventArgs e)
        {
            title = "Spichlerz";
            // stworzenie opisu do wyświetlenia
            description = new List<String>
            {
                "Tutaj przechowujesz",
                "swoje zebrane plony.",
                "To podstawa żywniościowa",
                "Twojego gospodarstwa.",
                "Ale także potencjalny",
                "zastrzyk gotówki w",
                "trudnych chwilach."
            };
            // nazwanie pierwszego źródła
            resource = "Zboże:";
            // przypisanie ilości źródła
            amount = grains.ToString() + " kg";
            // ustawienie odpowiedniego interfejsu
            pictureBoxDeskResource.Visible = true;
            pictureBoxDeskResource2.Visible = false;
            pictureBoxSell2.Visible = false;
            pictureBoxSell.Visible = true;
            pictureBoxFeed.Visible = false;
            // odświeżenie elementów graficznych
            pictureBoxBoard.Invalidate();
            pictureBoxPlate.Invalidate();
            pictureBoxDeskResource.Invalidate();
            pictureBoxSell.Invalidate();
        }

        /// <summary>
        /// Po kliknięciu w oborę wyświetli nam się nazwa, opis, liczba krów i ilość mleka oraz możliwe akcje z nią związane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxCowShed_Click(object sender, EventArgs e)
        {
            title = "Obora";
            // stworzenie opisu lokacji do wyświetlenia
            description = new List<String>
            {
                "Tutaj znajdują się Twoje",
                "Krowy, które produkują",
                "białe złoto, jakim jest",
                "mleko. Dbaj o nie!"
            };
            // nazwanie dostępnych źródeł w tej lokacji
            resource = "Krowy:";
            resource2 = "Mleko:";
            // przypisanie żródłom ich wartości
            amount = cows.ToString();
            amount2 = milk.ToString() + " l";
            // odpowiednie ustawienie interfejsu
            pictureBoxDeskResource.Visible = true;
            pictureBoxDeskResource2.Visible = true;
            pictureBoxSell2.Visible = true;
            pictureBoxSell.Visible = true;
            // odświeżenie elementów graficznych
            pictureBoxBoard.Invalidate();
            pictureBoxPlate.Invalidate();
            pictureBoxDeskResource.Invalidate();
            pictureBoxDeskResource2.Invalidate();
            pictureBoxSell2.Invalidate();
            pictureBoxSell.Invalidate();
            // jeśli krowy są głode pojawia się akcja ich nakarmienia
            if (cowsFeed > 0)
            {
                pictureBoxFeed.Visible = true;
                pictureBoxFeed.Invalidate();
            } else
                pictureBoxFeed.Visible = false;
        }

        /// <summary>
        /// Po kliknięciu w ul wyświetli nam się nazwa, opis, liczba pszczół i miodu oraz możliwe akcje z nim związane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxHive_Click(object sender, EventArgs e)
        {
            title = "Ul";
            // stworzenie opisu lokacji do wyświetlenia
            description = new List<String>
            {
                "Tutaj znajdują się Twoje",
                "pszczoły. Najbardziej",
                "pożyteczne dla natury",
                "zwierzęta. Dla człowieka",
                "trochę niebezpieczne.",
                "Jednak miód całkowicie",
                "wynagradza użądlenia."
            };
            // nazwanie dostępnych źródeł
            resource = "Pszczoły:";
            resource2 = "Miód:";
            // przypisanie źródłom ich wartości
            amount = bees.ToString();
            amount2 = honey.ToString() + " l";
            // odpowiednia konfiguracja interfejsu
            pictureBoxDeskResource.Visible = true;
            pictureBoxDeskResource2.Visible = true;
            pictureBoxSell2.Visible = true;
            pictureBoxSell.Visible = false;
            pictureBoxFeed.Visible = false;
            // odświeżenie elementów graficznych
            pictureBoxBoard.Invalidate();
            pictureBoxPlate.Invalidate();
            pictureBoxDeskResource.Invalidate();
            pictureBoxDeskResource2.Invalidate();
            pictureBoxSell2.Invalidate();
        }

        /// <summary>
        /// Akcja, która pozwala sprzedać pierwszy zasób w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSell_Click(object sender, EventArgs e)
        {
            // sprawdzamy lokację, w któej została wciśnięta akcja
            if (title == "Spichlerz")
            {
                if (grains < 25)
                {
                    AddMessage("Za mało zboża, żeby srzedać! Worek zboża ma 25kg");
                    return;
                }   
                // odjęcie sprzedanego zboża od zasobów
                grains -= 25;
                // powiększenie zasobu pieniędzy o cenę 25kg zboża
                money += 100;
                // przypisanie nowej wartości zasobu
                amount = grains.ToString() + " kg";
                // odswieżenie interfejsu
                pictureBoxDeskResource.Invalidate();
                pictureBoxMoney.Invalidate();
            } 
            else if (title == "Kurnik")
            {
                if (hens < 2)
                {
                    AddMessage("Nie mozesz sprzedać wszystkich kur!");
                    return;
                }   
                // odjęcie sprzedanej kury od całej puli
                hens -= 1;
                // powiększenie puli pieniędzy
                money += 100;
                // przypisanie nowej wartości zasobu
                amount = hens.ToString();
                // odświeżenie grafiki
                pictureBoxDeskResource.Invalidate();
                pictureBoxMoney.Invalidate();
            }
            else if (title == "Obora")
            {
                if (cows < 2)
                {
                    AddMessage("Nie mozesz sprzedać wszystkich krów!");
                    return;
                }
                // odjęcie krowy od całej puli
                cows -= 1;
                // powiększenie zasobu pieniędzy
                money += 1000;
                // przypisanie nowej wartości zasobu
                amount = cows.ToString();
                // odświeżenie grafiki
                pictureBoxDeskResource.Invalidate();
                pictureBoxMoney.Invalidate();
            }
        }

        /// <summary>
        /// Akcja, która pozwala sprzedać drugi zasób w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSell2_Click(object sender, EventArgs e)
        {
            // analogicznie jak wyżej przy sprzedawaniu pierwszego zasobu
            if (title == "Kurnik")
            {
                if (eggs < 1)
                {
                    AddMessage("Nie masz jajek!");
                    return;
                }
                money += eggs;
                eggs = 0;
                amount2 = "0";
                pictureBoxDeskResource2.Invalidate();
                pictureBoxMoney.Invalidate();
            }
            else if (title == "Obora")
            {
                if (milk < 1)
                {
                    AddMessage("Nie masz mleka!");
                    return;
                }
                money += milk*2;
                milk = 0;
                amount2 = "0 l";
                pictureBoxDeskResource2.Invalidate();
                pictureBoxMoney.Invalidate();
            }
            else if (title == "Ul")
            {
                if (honey < 1)
                {
                    AddMessage("Musisz mieć chociaż litr miodu, by móc go sprzedać!");
                    return;
                }
                money += (int)(honey * 10);
                honey = 0;
                amount2 = "0 l";
                pictureBoxDeskResource2.Invalidate();
                pictureBoxMoney.Invalidate();
            }
        }

        /// <summary>
        /// Akcja za pomocą, której możemy nakarmić zwięrzeta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxFeed_Click(object sender, EventArgs e)
        {
            // sprawdzenie w jakiej lokacji została wywołana akcja
            if (title == "Kurnik")
            {   
                // pomniejszenie zasobu ziarna
                if (TakeGrains(1*hens))
                {
                    // likwidacja głodu
                    hensFeed = 0;
                    // zniknięcie przyciska nakarm
                    pictureBoxFeed.Visible = false;
                    // produkcja zasobów wraca do normy sprzed głodu
                    timerHens.Interval = 5000;
                    timerEggs.Interval = 3000;
                }
            }
            else if (title == "Obora")
            {
                // analogicznie jak wyżej
                if (TakeGrains(5 * cows))
                {
                    cowsFeed = 0;
                    pictureBoxFeed.Visible = false;
                    timerCows.Interval = 5000;
                    timerMilk.Interval = 3000;
                }
            }
        }

        /// <summary>
        /// Akcja, która otwiera nowe okno ze sklepem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxShop_Click(object sender, EventArgs e)
        {
            // Tworzenie okna
            Shop shop = new Shop(this, boosterOrganic, boosterSprayer, boosterMedicaments, boosterVitamins)
            {
                // Ustawienie rozmiaru okna
                Size = new Size(600, 800),
                // Wyświetlenie na środku ekranu
                StartPosition = FormStartPosition.CenterScreen
            };
            // pokazanie okna
            shop.Show();
            // if wywoła się gdy booster został kupiony, by go jednorazowo uruchomić
            if (!boosterOrganic && !timerBoosterOrganic.Enabled)
            {
                // włączenie timera, odlicza czas działania boostera
                timerBoosterOrganic.Enabled = true;
                // przyspieszenie produkcji jaj w zależności od poziomu zakupionego boostera
                timerGrains.Interval = (int)(timerGrains.Interval * boosterOrganicValue / 6);
            }
            // Poniższe ify analogicznie jak ten powyższy
            if (!boosterSprayer && !timerBoosterSprayer.Enabled)
            {
                timerBoosterSprayer.Enabled = true;
                timerGrains.Interval = (int)(timerGrains.Interval * boosterSprayerValue / 6);
            }
            if (!boosterMedicaments && !timerBoosterMedicaments.Enabled)
            {
                timerBoosterMedicaments.Enabled = true;
                timerDeath.Interval = (int)(timerDeath.Interval * 1.5);
            }
            if (!boosterVitamins && !timerBoosterVitamins.Enabled)
            {
                timerBoosterVitamins.Enabled = true;
                timerEggs.Interval = (int)(timerEggs.Interval * boosterVitaminsValue / 6);
                timerMilk.Interval = (int)(timerMilk.Interval * boosterVitaminsValue / 6);
                timerHoney.Interval = (int)(timerHoney.Interval * boosterVitaminsValue / 6);
            }
        }    
        
        /// <summary>
        /// Napisanie miejsca, w którym się znajdujemy w grze
        /// </summary>
        /// <param name="e"></param>
        private void PictureBoxPlate_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 18, FontStyle.Regular, GraphicsUnit.Pixel);
            // długością dopasowujemy lokalizację różnych wyrazów na ekranie
            int length = title.Length * 5;
            e.Graphics.DrawString(title, font, solidBrush, new PointF(100-length, 90));
        }

        /// <summary>
        /// Napisanie, krótkiego podsumowania miejsca, w którym się znajdujemy w grze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxBoard_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 13, FontStyle.Regular, GraphicsUnit.Pixel);
            // wypisanie całego stworzonego opisu lokacji
            for (var i = 0; i < description.Count; i++)
            {
                e.Graphics.DrawString(description[i], font, solidBrush, new PointF(16, 25 + i*25));
            }
        }

        /// <summary>
        /// Napisanie pierwszego dostępnego zasobu w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxDeskResource_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 18, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString(resource, font, solidBrush, new PointF(16, 35));
            int width = 100;
            // w przypadku ula wyraz musi być trochę dalej, bo się nie mieści
            if (title == "Ul")
                width = 110;
            e.Graphics.DrawString(amount, font, solidBrush, new PointF(width, 35));
        }

        /// <summary>
        /// Napisanie drugiego zasobu w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxDeskResource2_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 18, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString(resource2, font, solidBrush, new PointF(16, 35));
            e.Graphics.DrawString(amount2, font, solidBrush, new PointF(100, 35));
        }

        /// <summary>
        /// Wyświetlenie stanu posiadania pieniędzy gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxMoney_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 18, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Pieniążki:", font, solidBrush, new PointF(16, 35));
            e.Graphics.DrawString(money.ToString(), font, solidBrush, new PointF(125, 35));
        }

        /// <summary>
        /// Wyświetlanie bieżących komunikatów w grze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxMessageBoard_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 10, FontStyle.Regular, GraphicsUnit.Pixel);
            // wyświetla kolejno wiadomości na panelu informacyjnym
            for (var i = 0; i < messages.Count; i++)
            {
                e.Graphics.DrawString(messages[i], font, solidBrush, new PointF(60, 16 + i * 19));
            }
        }

        /// <summary>
        /// Wyświetlenie napisu akcji związanej ze sprzedaniem drugiego zasobu w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSell2_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            string name = resource2.ToLower().Remove(resource2.Length - 1, 1);
            e.Graphics.DrawString("Sprzedaj " + name, font, solidBrush, new PointF(20, 35));
        }

        /// <summary>
        /// Wyświetlenie napisu akcji związanej ze sprzedaniem pierwszego zasobu w danej lokacji
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxSell_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            string name = resource.ToLower().Remove(resource.Length - 1, 1);
            e.Graphics.DrawString("Sprzedaj " + name, font, solidBrush, new PointF(30, 35));
        }

        /// <summary>
        /// Wyświetlenie napisu akcji karmienia zwierząt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxFeed_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Nakarm", font, solidBrush, new PointF(30, 35));
        }

        /// <summary>
        /// Wyświetlenie napisu akcji przejścia do sklepu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBoxShop_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(fontFamily, 20, FontStyle.Regular, GraphicsUnit.Pixel);
            e.Graphics.DrawString("Idż na zakupy", font, solidBrush, new PointF(30, 35));
        }

        /// <summary>
        /// Dodaje wiadomość do wyświetlenia na interfejsie
        /// </summary>
        /// <param name="message"></param>
        private void AddMessage(string message)
        {
            // maksymalnie można wyświetlić 5 ostatnich wiadomości
            if (messages.Count == 5)
                messages.RemoveAt(0);
            messages.Add(message);
            pictureBoxMessageBoard.Invalidate();
        }
      
        /// <summary>
        /// Obsługuje transakcję kupna; zwraca fałsz, gdy jest za mało pieniędzy
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public bool TakeMoney(int sum)
        {
            if (money < sum)
            {
                AddMessage("Nie masz wystarczająco pieniędzy!");
                return false;
            }
            // odjęcie od całej puli pieniędzy
            money -= sum;
            // odświeżenie wyświetlania ilości pieniędzy
            pictureBoxMoney.Invalidate();
            return true;
        }

        /// <summary>
        /// Obsługuję akcję sprzedania zboża; zwraca fałsz w przypadku jego braku
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        private bool TakeGrains(int sum)
        {
            if (grains < sum)
            {
                AddMessage("Nie masz wystarczająco zboża!");
                return false;
            }
            grains -= sum;
            return true;
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania jaj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerEggs_Tick(object sender, EventArgs e)
        {
            eggs += 1 * hens;
            // jeślli wybrana lokacja to kurnik, odświeżaj wyświetlanie liczby jaj
            if (title == "Kurnik")
            {
                amount2 = eggs.ToString();
                pictureBoxDeskResource2.Invalidate();
            }    
        }        
        
        /// <summary>
        /// Licznik, który wzkazuje porę karmienia kur i krów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerFeed_Tick(object sender, EventArgs e)
        {
            // gdy nie ma zwierząt, nic się nie dzieje
            if (hens == 0 && cows == 0)
                return;
            AddMessage("Czas nakarmić zwierzęta!");
            // pokazanie się przycisku karmienia, jeśli w tej chwili jest wybrana dana lokacja
            if ((title == "Obora" && cows > 0) || (title == "Kurnik" && hens > 0))
                pictureBoxFeed.Visible = true;
            // zwiększenie poziomu głodu kur
            if (hens > 0)
                hensFeed += 1;
            // zwiększenie poziomu głodu krów
            if (cows > 0)
                cowsFeed += 1;
            // zmniejszanie efektywności produkcji zasobów w zależności od poziomu głodu
            timerCows.Interval = 5000 * (cowsFeed + 1);
            timerMilk.Interval = 3000 * (cowsFeed + 1);
            timerHens.Interval = 5000 * (hensFeed + 1);
            timerEggs.Interval = 3000 * (hensFeed + 1);
            
            // dopuszczalny poziom głodu to 5 (6 pełnych cykli timera feed)
            if (cowsFeed > 5)
            {
                AddMessage("Krowy zdechły z głodu. Zakładasz stado od nowa");
                cows = 0;
                // odświeżenie liczby krów, jeśli jest widoczna lokacja obory
                if (title == "Obora")
                    amount = "0";
                // reset licznika głodu
                cowsFeed = 0;
                pictureBoxDeskResource.Invalidate();
            }

            if (hensFeed > 5)
            {
                AddMessage("Kury zdechły z głodu. Zakładasz stado od nowa");
                hens = 0;
                // odświeżenie liczby kur, jeśli jest widoczna lokacja kurnika
                if (title == "Kurnik")
                    amount = "0";
                // reset licznika głodu
                hensFeed = 0;
                pictureBoxDeskResource.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania zboża
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerGrains_Tick(object sender, EventArgs e)
        {
            grains += 1;
            // aktualizacja ilości ziarna, jeśli obecna lokacja w grze to spichlerz
            if (title == "Spichlerz")
            {
                amount = grains.ToString() + " kg";
                pictureBoxDeskResource.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania kur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerHens_Tick(object sender, EventArgs e)
        {
            hens += 1;
            // aktualizacja liczby kur, jeśli obecna lokacja w grze to kurnik
            if (title == "Kurnik")
            {
                amount = hens.ToString();
                pictureBoxDeskResource.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania krów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerCows_Tick(object sender, EventArgs e)
        {
            cows += 1;
            // aktualizacja liczby krów, jeśli obecna lokacja w grze to obora
            if (title == "Obora")
            {
                amount = cows.ToString();
                pictureBoxDeskResource.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania mleka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerMilk_Tick(object sender, EventArgs e)
        {
            milk += 1 * cows;
            // aktualizacja ilości mleka, jeśli obecna lokacja w grze to obora
            if (title == "Obora")
            {
                amount2 = milk.ToString() + " l";
                pictureBoxDeskResource2.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania pszczół
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBees_Tick(object sender, EventArgs e)
        {
            bees += 1;
            // aktualizacja liczby pszczół, jeśli obecna lokacja w grze to ul
            if (title == "Ul")
            {
                amount = bees.ToString();
                pictureBoxDeskResource.Invalidate();
            }
        }

        /// <summary>
        /// Licznik zwiększający stan posiadania miodu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerHoney_Tick(object sender, EventArgs e)
        {
            // przyjęto, że pszczoła wytwarza mililitr miodu w cyklu timera
            honey += 0.001 * bees;
            // zaokrąglenie do dwóch miejsc po przecinku
            honey = Math.Round(honey, 2);
            // aktualizacja ilości miodu, jeśli obecna lokacja w grze to ul
            if (title == "Ul")
            {
                amount2 = honey.ToString() + " l";
                pictureBoxDeskResource2.Invalidate();
            }
        }

        /// <summary>
        /// Licznik przypadkowej śmierci w gospodarstwie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerDeath_Tick(object sender, EventArgs e)
        {
            // wybieramy zwierzę do uśmiercenia przypadkowego, albo żadne
            // w małych stadach losowa śmierć jeszcze nie grasuje
            int num = rnd.Next(4);
            if (num == 0 && hens > 3)
            {
                AddMessage("Zdechła kura");
                hens -= 1;
                pictureBoxDeskResource.Invalidate();
            }
            else if (num == 1 && cows > 3)
            {
                AddMessage("Zdechła krowa");
                cows -= 1;
                pictureBoxDeskResource.Invalidate();
            }
            else if (num == 2 && bees > 15)
            {
                // pszczoły giną w większych grupach od 5 do 15
                int i = rnd.Next(11);
                string str = (i + 5).ToString();
                AddMessage("Zginęło " + str + " pszczół");
                bees -= i;
                pictureBoxDeskResource.Invalidate();
            }
            // w przypadku gdy num == 4 nikt nie ginie 
        }

        /// <summary>
        /// Licznik pojawienia się negatywnego zdarzenia w gospodartwie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerDisaster_Tick(object sender, EventArgs e)
        {
            // Po upływie minuty flagi się resetują, zły wpływ zdarzeń przestaje działać
            if (disasterFlag1)
                timerGrains.Interval += (int)(timerGrains.Interval * 3 / 2);
            if (disasterFlag2)
                timerHoney.Interval += (int)(timerHoney.Interval * 3 / 2);
            // wybieramy losowo negatywne zdarzenie
            int i = rnd.Next(4);
            if (i == 0)
            {
                // wyświetlenie komunikatu
                DialogResult res = MessageBox.Show("Wiejski gang grasuje po okolicy. Nocą otwieriają obory i wypuszczają bydło. Jeśli zostawisz im 60 jajek jako poczestunek, " +
                    "darują Tobie psikus.", "Zdarzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // po kliknięciu przycisku OK
                if (res == DialogResult.OK)
                {
                    // gdy spełniony warunek uniknięcia zdarzenia
                    if (eggs >= 60)
                    {
                        MessageBox.Show("Zadowoleni poszli w dalszą drogę, a Twoje stado nadal jest w oborze.");
                        eggs -= 60;
                        if (title == "Kurnik")
                        {
                            amount2 = "0";
                            pictureBoxDeskResource2.Invalidate();
                        }
                    }
                    // nieuniknięcie negatywnego zdarzenia
                    else
                    {
                        MessageBox.Show("Nie masz wystarczająco jajek. Twoje bydło umknęło w siną dal");
                        cows = 0;
                        if (title == "Obora")
                        {
                            amount = "0";
                            pictureBoxDeskResource.Invalidate();
                        }
                    }

                }
            }
            // poniższe else ify analogicznie do pierwszego
            else if (i == 1)
            {
                {
                    DialogResult res = MessageBox.Show("Wścibski sąsiad zazdrości Tobie plonów. Zamierza zniszczyć część Twoich upraw. Dobrze byłoby go udobruchać " +
                        "dając 10 worków zboża w czasie sąsiedzkich odwiedzin", "Zdarzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        if (grains >= 25 * 10)
                        {
                            MessageBox.Show("Sąsiad częstuje Cię kawą i ciastem. Może mniej wartościowe, ale plony masz całe.");
                            grains -= 25 * 10;
                            if (title == "Spichlerz")
                            {
                                amount = grains.ToString() + " kg";
                                pictureBoxDeskResource.Invalidate();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Najwidoczniej Twój spichlerz świeci pustkami. Zatem Twoje plony będą słabsze przez pewien czas.");
                            timerGrains.Interval += (int)(timerGrains.Interval * 1.5);
                            disasterFlag1 = true;
                        }

                    }
                }
            }
            else if (i == 2)
            {
                {
                    {
                        DialogResult res = MessageBox.Show("Ludzie z miasta przyjechali na wieś odpocząć. W kręgu ich zainteresowania znalazły się Twoje ule. " +
                            "Podaruj im litrowy słoik miodu w ramach staropolskiej gościnności, w przeciwnym razie produkcja miodu będzie zagrożona."
                            , "Zdarzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            if (honey >= 1)
                            {
                                MessageBox.Show("Z uśmiechem dziecka miastowi przyjęli miód i płacą Ci połowę za jego wartość.");
                                honey -= 1;
                                money += 2;
                                pictureBoxMoney.Invalidate();
                                if (title == "Ul")
                                {
                                    amount2 = honey.ToString() + " l";
                                    pictureBoxDeskResource2.Invalidate();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Miastowi obeszli się smakiem, więc wysuneli korpusy uli. Ulewa wyrządziła szkody, a twoja produkcja miodu się zmiejsza.");
                                timerHoney.Interval += (int)(timerHoney.Interval * 1.5);
                                disasterFlag2 = true;
                            }

                        }
                    }
                }
            }
            else if (i == 3 && !disasterFlag3)
            {
                {
                    {
                        DialogResult res = MessageBox.Show("Lisy pod osłoną nocy wpadły do Twojego kurnika i zadusiły połowę kur. Jedynie solidny remont " +
                            "kurnika wraz z jego ogrodzeniem uchroni Cię przed ponowną szarżą lisów. Koszt remontu 20 000."
                            , "Zdarzenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            if (money >= 20000)
                            {
                                MessageBox.Show("Ekipa budowlana rozpoczeła pracę, a Ty możesz zapomnieć o lisach.");
                                disasterFlag3 = true;
                            }
                            else
                                MessageBox.Show("Nie masz wystarczająco pieniędzy na remont. Lisy już nie mogą się doczekać na kolejną ucztę.");
                            hens /= 2;
                            if (title == "Kurnik")
                            {
                                amount = "0";
                                pictureBoxDeskResource.Invalidate();
                            }
                        }
                    }
                }
            }
        }

        #region liczniki boosterów

        /// <summary>
        /// Licznik trwania zwiększonej produkcji zboża ze względu na nawóz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBoosterOrganic_Tick(object sender, EventArgs e)
        {
            // po pełnym cyklu booster przestaje działać
            timerBoosterOrganic.Enabled = false;
            // flaga mówiąca, że można ponownie kupić booster
            boosterOrganic = true;
            // właściwość, którą zmienia wraca do stanu początkowego
            timerGrains.Interval = 2000;
        }

        // dalsze boostery analogicznie do tego pierwszego

        /// <summary>
        /// Licznik trwania zwiększonej produkcji zboża ze względu na oprysk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBoosterSprayer_Tick(object sender, EventArgs e)
        {
            timerBoosterSprayer.Enabled = false;
            boosterSprayer = true;
            timerGrains.Interval = 2000;
        }

        /// <summary>
        /// Licznik trwania opóźnienia w pojawieniu się przypadkowej śmierci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBoosterMedicaments_Tick(object sender, EventArgs e)
        {
            timerBoosterMedicaments.Enabled = false;
            boosterMedicaments = true;
            timerDeath.Interval = 100000;
        }

        /// <summary>
        /// Licznik trwania zwiększonej produkcji jaj, mleka, miodu ze względu na witaminy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerBoosterVitamins_Tick(object sender, EventArgs e)
        {
            timerBoosterVitamins.Enabled = false;
            boosterVitamins = true;
            timerEggs.Interval = 3000;
            timerMilk.Interval = 3000;
            timerHoney.Interval = 4000;
        }
        #endregion
    }
}

