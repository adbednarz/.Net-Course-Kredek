using AdamBednarzLab2ZadDom.Database;
using System;
using System.Data;
using System.Windows.Forms;

namespace AdamBednarzLab2ZadDom
{
    /// <summary>
    /// Klasa okna głównego aplikacji
    /// </summary>
    public partial class FormMain : Form
    {
        // klasa łącząca z bazą danych
        private readonly DatabaseConnector database = new DatabaseConnector();
       
        /// <summary>
        /// Konstruktor okna głównego aplikacji
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

            //Ustawienie okna, żeby pojawiało się na środku ekranu
            StartPosition = FormStartPosition.CenterScreen;

            // roziąga kolumny na całą dostępną przestrzeń
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // niweluje pasek szarości na końcu, gdy pojawia się suwak
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        /// <summary>
        /// Inicjalizacja okna głownego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            // przy ładowaniu okna wyświetlenie wszystkich gór
            buttonMountains.PerformClick();
        }


        /// <summary>
        /// Wyświetl wszystkie góry w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMountains_Click(object sender, EventArgs e)
        {
            //pobierz wszystkie góry z bazy danych
            DataTable mountains = database.GetMountains();

            //przypisz wszystkie góry do DatagridView
            dataGridView.DataSource = mountains;

            //ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Name1"].HeaderText = "Najwyższy szczyt";
            dataGridView.Columns["Orogeny"].HeaderText = "Orogeneza";
            dataGridView.Columns["LengthInKm"].HeaderText = "Długość gór (km)";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie pasma w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMountainRanges_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie pasma z bazy danych
            DataTable mountainsRanges = database.GetMountainRanges();

            // przypisz wszystkie pasma do DatagridView
            dataGridView.DataSource = mountainsRanges;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Name1"].HeaderText = "Najwyższy szczyt";
            dataGridView.Columns["Name2"].HeaderText = "Góry";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie szczyty w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPeaks_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie szczyty z bazy danych
            DataTable peaks = database.GetPeaks();

            // przypisz wszystkie szczyty do DatagridView
            dataGridView.DataSource = peaks;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["HeightInMeters"].HeaderText = "Wysokość (m)";
            dataGridView.Columns["AerialLift"].HeaderText = "Wyciąg";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie źródła w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRiverSprings_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie źródła z bazy danych
            DataTable riverSprings = database.GetRiverSprings();

            // przypisz wszystkie źródła do DatagridView
            dataGridView.DataSource = riverSprings;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Tributary"].HeaderText = "Dorzecze";
            dataGridView.Columns["Name1"].HeaderText = "Pasmo";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie miejscowości w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLocalities_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie miejscowości z bazy danych
            DataTable localities = database.GetLocalities();

            // przypisz wszystkie miejscowości do DatagridView
            dataGridView.DataSource = localities;

            // ustaw widoczność kolumny Id na niewidoczne
            dataGridView.Columns["Id"].Visible = false;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Population"].HeaderText = "Populacja";
            dataGridView.Columns["Name1"].HeaderText = "Pasmo";

            // wyświetlenie interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(true);
        }

        /// <summary>
        /// Wyświetl wszystkie parki narodowe w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNationalParks_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie parki z bazy danych
            DataTable nationalParks = database.GetNationalParks();

            // przypisz wszystkie parki do DatagridView
            dataGridView.DataSource = nationalParks;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Name1"].HeaderText = "Pasmo";
            dataGridView.Columns["YearOfFoundation"].HeaderText = "Rok założenia";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie atrakcje turystyczne w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonTouristAttractions_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie atrakcje z bazy danych
            DataTable touristAttractions = database.GetTouristAttractions();

            // przypisz wszystkie atrakcje do DatagridView
            dataGridView.DataSource = touristAttractions;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Description"].HeaderText = "Opis";
            dataGridView.Columns["Name1"].HeaderText = "Pasmo";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetl wszystkie minerały w DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonMinerals_Click(object sender, EventArgs e)
        {
            // pobierz wszystkie minerały z bazy danych
            DataTable minerals = database.GetMinerals();

            // przypisz wszystkie minerały do DatagridView
            dataGridView.DataSource = minerals;

            // ustaw nazwy kolumn na polskie
            dataGridView.Columns["Name"].HeaderText = "Nazwa";
            dataGridView.Columns["Color"].HeaderText = "Kolor";
            dataGridView.Columns["Classification"].HeaderText = "Kwalifikacja";

            // brak wyświetlenia interfejsu do modyfikacji wierszy
            DisplayPanelOfModifications(false);
        }

        /// <summary>
        /// Wyświetla panel do modyfikacji wierszy w tabeli Localities
        /// </summary>
        /// <param name="flag"></param>
        private void DisplayPanelOfModifications(Boolean flag)
        {
            labelId.Visible = flag;
            labelName.Visible = flag;
            labelMountainRange.Visible = flag;
            labelPopulation.Visible = flag;

            textBoxId.Visible = flag;
            textBoxName.Visible = flag;
            textBoxMountainRange.Visible = flag;
            textBoxPopulation.Visible = flag;

            buttonDelete.Visible = flag;
            buttonEdit.Visible = flag;
            buttonEraseFields.Visible = flag;
            buttonAdd.Visible = flag;
        }

        /// <summary>
        /// Metoda wykonywana za każdym razem gdy użytkownik zmieni zaznaczenie wiersza w DataGridViewBook
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // jeśli żadnen wiersz nie jest zaznaczony lub jest zaznaczonych więcej niż jeden to nic nie rób (return)
            int rowsCount = dataGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1 || labelId.Visible == false)
                return;

            // weź pierwszy zaznaczony wiersz
            DataGridViewRow row = dataGridView.SelectedRows[0];

            // wyciągnij dane z zaznaczonego wiersza
            int id = int.Parse(row.Cells[0].Value.ToString());
            string name = row.Cells[1].Value.ToString();
            int population = int.Parse(row.Cells[2].Value.ToString());
            string mountainRange = row.Cells[3].Value.ToString();
            
            // poustawiaj dane w textboxach wybranej książki
            textBoxId.Text = id.ToString();
            textBoxName.Text = name;
            textBoxMountainRange.Text = mountainRange.ToString();
            textBoxPopulation.Text = population.ToString();
        }

        /// <summary>
        /// Usuwanie wybranego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (!String.Equals(textBoxId.Text, "") && !String.Equals(textBoxId.Text, "Puste pole"))
            {
                // wyciągnięcie id z textboxu
                int id = int.Parse(textBoxId.Text);

                // usunięcie miejscowości z bazy danych
                database.DeleteLocality(id);
                // odświeżenie dataGridView
                buttonLocalities.PerformClick();
                // usunięcie wartości w textBoxach
                buttonEraseFields.PerformClick();
            }
            else
            {
                textBoxId.Text = "Puste pole";
            }
        }

        /// <summary>
        /// Edytowanie wybranego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (!String.Equals(textBoxName.Text, "") && !String.Equals(textBoxMountainRange.Text, "") && !String.Equals(textBoxPopulation.Text, ""))
            {
                // wyciągnięcie danych z textboxów
                int id = int.Parse(textBoxId.Text);
                string name = textBoxName.Text;
                string mountainRange = textBoxMountainRange.Text;
                int population = int.Parse(textBoxPopulation.Text);

                // zedytowanie miejscowości w bazie danych
                database.EditLocality(id, name, mountainRange, population);
                // odświeżenie dataGridView
                buttonLocalities.PerformClick();
                // usunięcie wartości w textBoxach
                buttonEraseFields.PerformClick();
            }
            else
            {
                textBoxId.Text = "Puste pole";
            }
        }

        /// <summary>
        /// Wyczyszczenie wszystkich textBoxów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEraseFields_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxMountainRange.Text = "";
            textBoxPopulation.Text = "";
        }

        /// <summary>
        /// Dodanie nowego wiersza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (!String.Equals(textBoxName.Text, "") && !String.Equals(textBoxMountainRange.Text, "") && !String.Equals(textBoxPopulation.Text, ""))
            {
                // wyciągnięcie danych z textboxów
                string name = textBoxName.Text;
                string mountainRange = textBoxMountainRange.Text;
                int population = int.Parse(textBoxPopulation.Text);

                // dodanie miejscowości w bazie danych
                database.AddLocality(name, mountainRange, population);
                // odświeżenie dataGridView
                buttonLocalities.PerformClick();
                // usunięcie wartości w textBoxach
                buttonEraseFields.PerformClick();
            } 
            else
            {
                textBoxId.Text = "Puste pole";
            }
        }
    }
}
