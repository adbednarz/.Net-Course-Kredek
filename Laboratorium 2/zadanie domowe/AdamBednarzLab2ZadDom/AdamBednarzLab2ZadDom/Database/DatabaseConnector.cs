using System.Data;
using System.Data.SqlClient;

namespace AdamBednarzLab2ZadDom.Database
{
    class DatabaseConnector
    {
        // połączenie z bazą danych
        private readonly SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);

        /// <summary>
        /// Metoda zwracająca wszystkie góry z tabeli Mountains
        /// </summary>
        /// <returns></returns>
        public DataTable GetMountains()
        {
            string query = "SELECT Mountains.Name, Peaks.Name, Mountains.Orogeny, Mountains.LengthInKm FROM Mountains JOIN Peaks ON Mountains.HighestPeak = Peaks.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie pasma z tabeli MountainRanges
        /// </summary>
        /// <returns></returns>
        public DataTable GetMountainRanges()
        {
            string query = "SELECT MountainRanges.Name, Peaks.Name, Mountains.Name FROM MountainRanges JOIN Mountains ON MountainRanges.Mountain = Mountains.Id JOIN Peaks ON MountainRanges.HighestPeak = Peaks.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie szczyty z tabeli Peaks
        /// </summary>
        /// <returns></returns>
        public DataTable GetPeaks()
        {
            string query = "SELECT Peaks.Name, Peaks.HeightInMeters, Peaks.AerialLift FROM Peaks;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie źródła z tabeli RiverSprings
        /// </summary>
        /// <returns></returns>
        public DataTable GetRiverSprings()
        {
            string query = "SELECT RiverSprings.Name, RiverSprings.Tributary, MountainRanges.Name FROM RiverSprings JOIN MountainRanges ON RiverSprings.MountainRange = MountainRanges.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie źródła z tabeli RiverSprings
        /// </summary>
        /// <returns></returns>
        public DataTable GetLocalities()
        {
            string query = "SELECT Localities.Id, Localities.Name, Localities.Population, MountainRanges.Name FROM Localities JOIN MountainRanges ON Localities.MountainRange = MountainRanges.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie parki z tabeli NationalParks
        /// </summary>
        /// <returns></returns>
        public DataTable GetNationalParks()
        {
            string query = "SELECT NationalParks.Name, MountainRanges.Name, NationalParks.YearOfFoundation FROM NationalParks JOIN MountainRanges ON NationalParks.MountainRange = MountainRanges.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie atrakcje z tabeli TouristAttractions
        /// </summary>
        /// <returns></returns>
        public DataTable GetTouristAttractions()
        {
            string query = "SELECT TouristAttractions.Name, TouristAttractions.Description, MountainRanges.Name FROM TouristAttractions JOIN MountainRanges ON TouristAttractions.MountainRange = MountainRanges.Id;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda zwracająca wszystkie minerały z tabeli TouristAttractions
        /// </summary>
        /// <returns></returns>
        public DataTable GetMinerals()
        {
            string query = "SELECT Minerals.Name, Minerals.Color, Minerals.Classification FROM Minerals;";
            DataTable table = ExecuteMyQuery(query);

            return table;
        }

        /// <summary>
        /// Metoda wykonująca moje zapytanie
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteMyQuery(string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Metoda dodająca nową miejscowość do tabeli Localities
        /// </summary>
        /// <param name="name"></param>
        /// <param name="mountainRange"></param>
        /// <param name="population"></param>
        public void AddLocality(string name, string mountainRange, int population)
        {
            string queryGetMountainRangeId = "SELECT Id FROM MountainRanges WHERE Name='" + mountainRange + "';";

            connection.Open();

            SqlCommand commandGetMountainRangeId = new SqlCommand(queryGetMountainRangeId, connection);
            object mountainRId = commandGetMountainRangeId.ExecuteScalar();
            if (!(mountainRId is null))
            {
                int mountainRangeId = (int)mountainRId;
                string insertLocalityQuery = "INSERT INTO Localities VALUES ('" + name + "'," + population + "," + mountainRangeId + ");";
                SqlCommand commandInsertLocality = new SqlCommand(insertLocalityQuery, connection);
                commandInsertLocality.ExecuteNonQuery();
            }

            connection.Close();
        }

        /// <summary>
        /// Metoda usuwająca miejscowość z tabeli Localities na podstawie Id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteLocality(int id)
        {
            string queryDeleteLocality = "DELETE FROM Localities WHERE Id=" + id + ";";

            connection.Open();

            SqlCommand commandDeleteBook = new SqlCommand(queryDeleteLocality, connection);
            commandDeleteBook.ExecuteNonQuery();

            connection.Close();
        }

        /// <summary>
        /// Metoda edytująca miejscowość z tabeli Localities
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="population"></param>
        /// <param name="mountainRange"></param>
        public void EditLocality(int id, string name, string mountainRange, int population)
        {
            string queryGetMountainRangeId = "SELECT Id FROM MountainRanges WHERE Name='" + mountainRange + "';";

            connection.Open();

            SqlCommand commandGetMountainRangeId = new SqlCommand(queryGetMountainRangeId, connection);
            object mountainRId = commandGetMountainRangeId.ExecuteScalar();
            if (!(mountainRId is null))
            {
                int mountainRangeId = (int)mountainRId;
                string updateLocalityQuery = "UPDATE Localities SET Name='" + name + "', Population=" + population + ", MountainRange=" + mountainRangeId + " WHERE Id=" + id + ";";
                SqlCommand commandInsertLocality = new SqlCommand(updateLocalityQuery, connection);
                commandInsertLocality.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}
