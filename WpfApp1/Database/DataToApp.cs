using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Querry;
using System.Data;
using System.Data.SqlClient;

namespace WpfApp1.Database
{
    class DataToApp
    {


        private static DataToApp instance;
        private static string connectionString = "Server=localhost;Database=HotCombatGame;Trusted_Connection=true";
        private static SqlConnection dbConnection = new SqlConnection(connectionString);

        private DataToApp()
        {
            dbConnection.Open();
        }

        public static DataToApp Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DataToApp();
                }
                return instance;
            }
        }

        public DataTable GetPlayersTable()
        {
            
            DataTable dt = Selects.GetPlayersTable(dbConnection);
            return dt;
        }

        internal int GetAvaragePainMvM(int warriant)
        {
            return Selects.GetAvaragePainMvM(warriant, dbConnection);
        }

        internal List<string> GetResearchersNamesList()
        {
            List<string> researchersTab = Selects.GetResearchersTableNamesList(dbConnection);
            return researchersTab;

        }

        internal DataTable GetResearchersTable()
        {
            DataTable dt = Selects.GetResearchersTable(dbConnection);
            return dt;
        }

        internal DataTable GetResearchesTable()
        {
            DataTable dt = Selects.GetResearchesTable(dbConnection);
            return dt;
        }

        internal DataTable GetResearchesTable(int selectedId)
        {
            DataTable dt = Selects.GetResearchesTable(selectedId,dbConnection);
            return dt;
        }

        internal int GetAvaragePainFvF(int warriant)
        {
            return Selects.GetAvaragePleasureFvF(warriant, dbConnection);
        }

        internal int GerAvaragePainFvM(int warriant)
        {
            return Selects.GetAvaragePainFvM(warriant, dbConnection);
        }

        internal int GetAvaragePainMvF(int warriant)
        {
            return Selects.GetAvaragePainMvF(warriant, dbConnection);
        }

        internal DataTable GetGameTable(int selectedId)
        {
            DataTable dt = Selects.GetGameTable(selectedId, dbConnection);
            return dt;
        }

        internal DataTable GetResearchesTableByResearcherID(int selectedId)
        {
            DataTable dt = Selects.GetResearchesTableByResearcherId(selectedId, dbConnection);
            return dt;
        }

        internal DataTable GetResultTableByGameId(int selectedId)
        {
            DataTable dt = Selects.GetResultTableByGameId(selectedId, dbConnection);
            return dt;
        }

        internal int GetAvaragePleasureMvM(int warriant)
        {
            return Selects.GetAvaragePleasureMvM(warriant, dbConnection);
        }

        internal int GetAvaragePleasureMvF(int warriant)
        {
            return Selects.GetAvaragePleasureMvF(warriant, dbConnection);
        }

        internal int GetAvaragePleasureFvM(int warriant)
        {
            return Selects.GetAvaragePleasureFvM(warriant, dbConnection);
        }

        internal int GetAvaragePleasureFvF(int warriant)
        {
            return Selects.GetAvaragePleasureFvF(warriant, dbConnection);
        }

        public List<string> getDataForCsvFile()
        {
            List<string> tab;
           return tab = Selects.GetCSVlist(dbConnection);
        }
    }
}
