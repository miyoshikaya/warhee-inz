using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.GameModel
{
    public class GameWarriant
    {
        string gameTypeName; // 1 - wygrana 2 - przegrana 3 - remis, 4 - nieuczciwa
        string opponentGenderName; //0 - mezczyzna, 1- kobieta
        int gameType;
        
        int opponentGender;
        int winCount, loseCount, drawCount;
        public int GameType { get => gameType; set => gameType = value; }
        public int OpponentGender { get => opponentGender; set => opponentGender = value; }
        public string GameTypeName { get => gameTypeName; set => gameTypeName = value; }
        public string OpponentGenderName { get => opponentGenderName; set => opponentGenderName = value; }
        public int WinCount { get => winCount; set => winCount = value; }
        public int LoseCount { get => loseCount; set => loseCount = value; }
        public int DrawCount { get => drawCount; set => drawCount = value; }
       

        public GameWarriant(string gameTypeName, string sex)
        {
            this.gameTypeName = gameTypeName;
            this.opponentGenderName = sex;
            switch (gameTypeName)
            {
                case "Wariant wygranej":
                    {
                        
                        gameType = 1;
                        winCount = 6;
                        loseCount = 2;
                        drawCount = 2;
                        
                        break;
                    }
                case "Wariant przegranej":
                    {
                        gameType = 2;
                        winCount = 2;
                        drawCount = 2;
                        loseCount = 6;
                        gameType = 2;
                        break;
                    }
                case "Wariant remisu":
                    {
                        gameType = 3;
                        winCount = 3;
                        loseCount = 3;
                        drawCount = 4;
                    
                        break;
                    }
                case "Wariant nieuczciwy":
                    {
                        gameType = 4;
                        drawCount = 4;
                        winCount = 3;
                        loseCount = 3;
                      
                        break;
                    }
                   
            }

            switch(sex)
            {
                case "Kobieta":
                    {
                        opponentGender = 1;
                        break;
                    }
                case "Mężczyzna":
                    {
                        opponentGender = 0;
                        break;
                    }
            }
        }
    }
}
