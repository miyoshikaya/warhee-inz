using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WpfApp1.GameModel;
using WpfApp1.Controller;
using WpfApp1.Querry;
namespace WpfApp1.Database
{
     class GametoDatabase
    {
        Inserts querry;
        public GametoDatabase()
        {
            querry = Inserts.Instance;
        }

        public void PutPlayerInDB(Patient player)
        {
            querry.InsertPlayerToDB(player.Login,player.SetSexToChar(),player.Age);
        }
        public void PutGameInDB(Patient player, GameWarriant warriant, Reasearcher researcher)
        {
            querry.InsertGameToDB(player,  warriant, researcher);
        }
        
         public bool CheckIfResearcherExist()
        {
            bool exists = false;
           // exists = Selects.CheckIfResearcherInDB();
            return exists;
        }
      
        internal void AddNewResearcher(Reasearcher researcher)
        {
            querry.AddResearcher(researcher);
        }

        internal void EditExistingPlayer(int iD, string text)
        {
            querry.EditPlayer(iD, text);
        }

        internal void EditResearcherName(string text, int iD)
        {
            querry.EditResearcherName(text, iD);
        }

        internal void EditResearcherSurname(string text, int iD)
        {
            querry.EditResearcherSurname(text, iD);
        }
    }
}
