using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WpfApp1.GameModel;
using System.Data;
using System.Collections;

namespace WpfApp1.Querry
{
    class Selects
    {
        public static bool CheckIfNew(string login,SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select count (*) FROM Gracz Where LoginGracza = '" + login + "'", connection);
            int exist = (int)command.ExecuteScalar();
            if (exist == 0)
                return true;
            else
                return false;
        }

        internal static DataTable GetPlayersTable(SqlConnection connection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Gracz", connection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Players");

            sda.Fill(dt);
            return dt;
        }

        public static int SelectPlayerId(string login, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Gracz.IdGracza FROM Gracz Where LoginGracza = '" + login + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }

        internal static int GetAvaragePainMvM(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomBolu From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'M' and Gracz.Plec = 'M' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum=0, counter=0;
            foreach(int item in list)
            {
               sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;
                
        }

        internal static int GetAvaragePainMvF(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomBolu From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'K' and Gracz.Plec = 'M' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;

        }

        internal static int GetAvaragePleasureMvF(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomPrzyjemnosci From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'K' and Gracz.Plec = 'M' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;
        }

        internal static int GetAvaragePleasureFvM(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomPrzyjemnosci From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'M' and Gracz.Plec = 'K' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;
        }

        internal static int GetAvaragePleasureMvM(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomPrzyjemnosci From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'M' and Gracz.Plec = 'M' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
             if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;
        }

        internal static int GetAvaragePainFvM(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomBolu From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'M' and Gracz.Plec = 'K' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;

        }

        internal static int GetAvaragePleasureFvF(int warriant, SqlConnection dbConnection)
        {
            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("Select Wynik.PoziomPrzyjemnosci From Wynik,Gracz,Badanie,Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania and Gra.IdGry = Wynik.IdGry and Gra.PlecPrzeciwnika = 'K' and Gracz.Plec = 'K' and Wynik.NrEtapu = '2' and Gra.Wariant = '" + warriant + "'", dbConnection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                list.Add((int)reader[0]);
            reader.Close();
            int sum = 0, counter = 0;
            foreach (int item in list)
            {
                sum += item;
                counter++;
            }
            if (counter == 0) return 0;
            int avg = sum / counter;
            return avg;

        }

        internal static List<string> GetResearchersTableNamesList(SqlConnection dbConnection)
        {
            List<string> researchersTab = new List<string>();
            string name;
            SqlCommand command =
                 new SqlCommand("Select Imie, Nazwisko From Badacz", dbConnection);
          

            SqlDataReader reader = command.ExecuteReader();

            // Call Read before accessing data.
            while (reader.Read())
            {
                name = reader[0].ToString() +" " +  reader[1].ToString();
                researchersTab.Add(name);
            }

            // Call Close when done reading.
            reader.Close();
            return researchersTab;
        }
        internal static List<string> GetCSVlist(SqlConnection dbConnection)
        {
            List<string> tab = new List<string>();
            string row;
            int idrow;
            int j = 0;
            List<int> Idtab = new List<int>();
            SqlCommand firstCommand = new SqlCommand("Select Gra.IdGry, Gracz.LoginGracza, Gracz.Plec,Gracz.Wiek Gracza From Gracz, Badanie, Gra Where Gracz.IdGracza = Badanie.IdGracza and Badanie.IdBadania = Gra.IdBadania",dbConnection);
            SqlDataReader reader = firstCommand.ExecuteReader();
            while(reader.Read())
            {
                idrow = (int)reader[0];
                row = reader[1].ToString() + ",";
                row += reader[2].ToString() + ",";
                row += reader[3].ToString() + ",";
                tab.Add(row);
                Idtab.Add(idrow);
                j++;
            }
            reader.Close();
            SqlCommand secondCommand = new SqlCommand("Select Gra.IdGry, Wynik.Wynik From Gra,Wynik Where Gra.IdGry = Wynik.IdGry and Wynik.NrEtapu = 1",dbConnection);
            SqlDataReader secReader = secondCommand.ExecuteReader();
            int i = 0;
            int k = 0;
            while(secReader.Read())
            {
               

                    if (i < 10)
                {

                        tab[k] += secReader[1] + ",";
                    i++;
                }
                    if(i == 10)
                {
                    k++;
                    i = 0;
                }
                


            }
            secReader.Close();
            SqlCommand thirdCommand = new SqlCommand("Select Gra.IdGry, Gra.Wariant, Gra.PlecPrzeciwnika From Gra", dbConnection);
            SqlDataReader thirdReader = thirdCommand.ExecuteReader();
            i = 0;
            while (thirdReader.Read())
            {
                tab[i] += thirdReader[1] + ",";
                tab[i] += thirdReader[2] + ",";
                i++;
            }
            thirdReader.Close();
            SqlCommand lastCommand = new SqlCommand("Select Gra.IdGry, Wynik.Wynik, Wynik.PoziomBolu, Wynik.PoziomPrzyjemnosci From Gra,Wynik Where Gra.IdGry = Wynik.IdGry and Wynik.NrEtapu = 2", dbConnection);
            SqlDataReader lastReader = lastCommand.ExecuteReader();
            i = 0;
            k = 0;
            while(lastReader.Read())
            {
                if (i < 10)
                {
                    tab[k] += lastReader[1] + "," + lastReader[2] + "," + lastReader[3] + ",";
                    i++;
                   
                }
                    
                if (i == 10)
                {
                    k++;
                    i = 0;
                }
            }
            lastReader.Close();
            return tab;
        }
        internal static DataTable GetResearchesTable(SqlConnection dbConnection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Badanie", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researches");

            sda.Fill(dt);
            return dt;
        }

        internal static DataTable GetGameTable(int selectedId, SqlConnection dbConnection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Gra Where IdBadania = '" + selectedId + "'", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researches");

            sda.Fill(dt);
            return dt;
        }

        internal static DataTable GetResearchesTableByResearcherId(int selectedId, SqlConnection dbConnection)
        {
            
            SqlCommand cmd = new SqlCommand("Select * From Badanie where IdBadacza = '" + selectedId + "'", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researches");

            sda.Fill(dt);
            return dt;
        }

        internal static int GetResearchID(int playerID, int researcherID, string sdata, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Badanie.IdBadania FROM Badanie Where IdGracza = '" + playerID + "' and IdBadacza = '" + researcherID + "' and DataBadania = '" + sdata + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }

        internal static DataTable GetResultTableByGameId(int selectedId, SqlConnection dbConnection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Wynik Where IdGry = '" + selectedId + "'", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researches");

            sda.Fill(dt);
            return dt;
        }

        internal static DataTable GetResearchesTable(int selectedId, SqlConnection dbConnection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Badanie Where IdGracza = '" + selectedId + "'", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researches");

            sda.Fill(dt);
            return dt;
        }

        internal static DataTable GetResearchersTable(SqlConnection dbConnection)
        {
            SqlCommand cmd = new SqlCommand("Select * From Badacz", dbConnection);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Researchers");

            sda.Fill(dt);
            return dt;
        }

        internal static int SelectResearcherId(string name, string surname, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Badacz.IdBadacza FROM Badacz Where Imie = '" + name + "' and Nazwisko = '"+ surname +"'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }

        internal static int SelectResearchId(int playerID, int researcherID, string sdata, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Badanie.IdBadania FROM Badanie Where IdBadacza = '" + researcherID + "' and IdGracza = '" + playerID + "' and DataBadania = '" + sdata + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }

        internal static bool CheckIfResearcherExists(Reasearcher researcher, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Count(*) From Badacz Where Badacz.Imie = '" + researcher.Name + "' and Badacz.Nazwisko = '" + researcher.Surname + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int count = (int)reader[0];
            reader.Close();
            if (count == 0)
                return false;
            else return true;
        }

        internal static int SelectGameId(int researchID, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select MAX(Gra.IdGry) FROM Gra Where Gra.IdBadania = '" + researchID + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }

        internal static int checkIfResearchExist(int playerID, int researcherID, string sdata, SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("Select Count(*) FROM Badanie Where IdBadacza = '" + researcherID + "' and IdGracza = '" + playerID + "' and DataBadania = '" + sdata + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int ID = (int)reader[0];
            reader.Close();
            return ID;
        }
       
    }
}
