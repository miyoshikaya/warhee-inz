using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using WpfApp1.GameModel;

namespace WpfApp1.Querry
{
    class Inserts
    {
        private static Inserts instance;
        private static string connectionString = "Server=localhost;Database=HotCombatGame;Trusted_Connection=true";
        private static SqlConnection connection = new SqlConnection(connectionString);

        private Inserts()
        {
            connection.Open();
        }

        public static Inserts Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Inserts();
                }
                return instance;
            }
        }

        public static SqlConnection Connection { get => connection; set => connection = value; }

        public  void InsertPlayerToDB(string login, string plec, int wiek)
        { bool nowy;
          nowy =  Selects.CheckIfNew(login,connection);
            if (nowy)
            {
                SqlCommand command = new SqlCommand("INSERT INTO Gracz(LoginGracza,Wiek,Plec) VALUES ('" + login + "'," + wiek + ",'" + plec[0] + "')", connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            else
                return;
        }
        
        internal void EditResearcherSurname(string text, int iD)
        {
            SqlCommand command = new SqlCommand("Update Badacz Set Badacz.Imie = '" + text + "' Where  Badacz.IdBadacza = '" + iD + "'", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        internal void EditResearcherName(string text, int iD)
        {
            SqlCommand command = new SqlCommand("Update Badacz Set Badacz.Nazwisko = '" + text + "' Where Badacz.IdBadacza = '" + iD + "'", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        internal void EditPlayer(int iD, string text)
        {
            SqlCommand command = new SqlCommand("Update Gracz Set Gracz.LoginGracza = '" + text + "' Where Gracz.IdGracza = '" + iD + "'", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        internal void AddResearcher(Reasearcher researcher)
        {
            bool exists;
            exists = Selects.CheckIfResearcherExists(researcher,connection);
            if (exists)
                return;
            else
                AddResearcherToDb(researcher);
        }

        private void AddResearcherToDb(Reasearcher researcher)
        {
            SqlCommand command = new SqlCommand("Insert into Badacz(imie,Nazwisko) VALUES ('" + researcher.Name + "', '" + researcher.Surname + "')", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        //TODO najpierw wybeirmay id gracz, potem date dzisiejsza i sprawdzamy czy dzisiaj bylo przeprowadzane badanie, jesli tak to dodajemy gre jesli nie tworzymy nowe badanie i dodajemy gre. sprawdzic tez czy zgadza sie badacz przeprowadzajacy badania jesli tak to np, jesli nie to nowe badanie.
        public void InsertGameToDB(Patient player, GameWarriant warriant,Reasearcher researcher)
        {
            int playerID;
            playerID = Selects.SelectPlayerId(player.Login,connection);
            int researcherID;
            researcherID = Selects.SelectResearcherId(researcher.Name, researcher.Surname,connection);
            DateTime data = DateTime.UtcNow.ToLocalTime();
            string sdata;
            sdata = data.ToString("yyyy-MM-dd"); 
            bool addToResearch = false;
            int researchcount = Selects.checkIfResearchExist(playerID, researcherID, sdata, connection) ;
            int researchID;
            if(researchcount > 0)
            {
                addToResearch = true;
            }
            if (addToResearch)
            {
                 researchID = Selects.GetResearchID(playerID, researcherID, sdata, connection);
                Inserts.AddNewGameToExistingResearch(researchID, warriant.GameType, warriant.OpponentGenderName);
             //   researchID = Selects.SelectResearchId(playerID, researcherID, sdata, connection);
            }
            else
              researchID =  Inserts.AddNewGameAndNewResearch(playerID, researcherID, sdata, warriant.GameType, warriant.OpponentGenderName);
            
            int gameID = Selects.SelectGameId(researchID,connection); //wyszukanie ostatniej gry
            Inserts.AddResultsToGame(gameID, player);
            
        }

        private static void AddResultsToGame(int gameID, Patient player)
        { int etap = 1;

            for(int i =0; i<10; i++)
            {
                int nrRundy = i + 1;
                SqlCommand command = new SqlCommand("Insert into Wynik(IdGry,NrEtapu,Wynik,NrRundy) VALUES ('" + gameID + "', '" + etap + "','" + player.PreMatchResults[i] + "', '" + nrRundy + "')" , connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
            etap = 2;
            for (int i = 0; i < 10; i++)
            {
                int nrRundy = i + 1;
                SqlCommand command = new SqlCommand("Insert into Wynik(IdGry,NrEtapu,Wynik,PoziomBolu,PoziomPrzyjemnosci,NrRundy) VALUES ('" + gameID + "', '" + etap + "','" + player.MainRoundResults[i] + "', '" + (int)(Math.Round(player.PainLevel[i])) + "','" +(int)(Math.Round( player.PleasureLevel[i])) + "', '" + nrRundy + "')", connection);
                command.ExecuteNonQuery();
                command.Dispose();
            }
        }

        private static int AddNewGameAndNewResearch(int playerID, int researcherID, string sdata, int warriant, string sex)
        {
            
            Inserts.AddNewResearch(playerID,researcherID,sdata);
            int researchID = Selects.SelectResearchId(playerID, researcherID, sdata, connection);
            Inserts.AddNewGame(researchID,warriant,sex[0]);
            return researchID;
        }

        private static void AddNewGame(int researchID, int cwarriant, char sex )
        {
            string warriant = cwarriant.ToString();
            SqlCommand command = new SqlCommand("INSERT INTO Gra(Wariant,IdBadania,PlecPrzeciwnika) VALUES ('" + warriant[0] + "', '" + researchID + "', '" + sex + "')", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        private static void AddNewResearch(int playerID, int researcherID, string sdata)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Badanie(IdGracza,IdBadacza,DataBadania) VALUES ('" + playerID + "', '" + researcherID + "', '" + sdata + "')", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }

        private static void AddNewGameToExistingResearch(int researchID, int cwarriant, string plec)
        {
            string warriant = cwarriant.ToString();
            SqlCommand command = new SqlCommand("INSERT INTO Gra(Wariant,IdBadania,PlecPrzeciwnika) VALUES ('" + warriant[0] + "', '" + researchID + "', '" + plec[0] + "')", connection);
            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
