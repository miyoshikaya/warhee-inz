using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.GameModel;
using WpfApp1.Database;
namespace WpfApp1.Controller
{
    class GamePageController
    {
        Patient patient;
        Opponent opponent;
        int roundCounter=1;
        GametoDatabase dbContr;

        int currentRoundResult;
        GameWarriant warriant;
        public int RoundCounter { get => roundCounter; set => roundCounter = value; }
        public GameWarriant Warriant { get => warriant; set => warriant = value; }
        internal GametoDatabase DbContr { get => dbContr; set => dbContr = value; }
        public Patient Patient { get => patient; set => patient = value; }

        public GamePageController(Patient patient, string opponentSex,GameWarriant warriant)
        {
            
            this.patient = patient;
            this.warriant = warriant;
            opponent = new Opponent(opponentSex);
            dbContr = new GametoDatabase();
        }
         public void PrepareNextRound()
        {
            roundCounter = 1;
            patient.Score = 0;
            opponent.Score = 0;
        
        }
        public void WinRound(string playerMoveName)
        {
            Move playerMove = new Move(playerMoveName);
            if (roundCounter == 1)
            {
               
                Move opponentMove;
                switch (playerMoveName)
                {
                    
                    case "Kamień":
                        opponentMove = new Move("Nożyce");
                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                        warriant.WinCount--;
                        break;
                    case "Papier":
                        opponentMove = new Move("Kamień");
                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                        warriant.WinCount--;
                        break;
                    case "Nożyce":
                        opponentMove = new Move("Papier");
                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
              
                        warriant.WinCount--;
                        break;
                }
                
            }
            else
            {
                Random rnd = new Random();
                int opponentMoveNumber;
                    bool found = false;
                string opponentMoveName;
                do
                {
                    opponentMoveNumber = rnd.Next(-1, 2);
                    switch (opponentMoveNumber)
                    {
                        case -1:
                            if (warriant.LoseCount != 0)
                            {

                                warriant.LoseCount--;
                                found = true;
                                opponentMoveName = playerMove.Counter;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            }
                            break;
                        case 0:
                            if (warriant.DrawCount != 0)
                            {

                                warriant.DrawCount--;
                                found = true;
                                opponentMoveName = playerMove.Name;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                            }
                            break;
                        case 1:
                            if (warriant.WinCount != 0)
                            {
                                warriant.WinCount--;
                                found = true;
                                Move opponentMove;
                                switch (playerMoveName)
                                {
                                    case "Kamień":
                                        opponentMoveName = "Nożyce";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                    case "Papier":
                                        opponentMoveName = "Kamień";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;

                                    case "Nożyce":
                                        opponentMoveName = "Papier";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                }

                            }
                            break;
                        default:
                            opponentMoveName = "error";
                            break;

                    }
                } while (!found);


            }
                switch (currentRoundResult)
                {
                    case -1:
                    patient.MainRoundResults[roundCounter - 1] = 'P';
                    opponent.Score++;
                        break;
                    case 0:
                    patient.MainRoundResults[roundCounter - 1] = 'D';
                    break;
                    case 1:
                    patient.MainRoundResults[roundCounter - 1] = 'W';
                    patient.Score++;
                        break;
                }
            


        }
        public void LoseRound(string playerMoveName)
        {
            Move playerMove = new Move(playerMoveName);
            if (roundCounter == 1)
            {
                switch (playerMoveName)
                {
                    case "Kamień":
                        {
                            Move opponentMove = new Move("Papier");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                            
                            warriant.LoseCount--;
                            break;
                        }
                    case "Papier":
                        {
                            Move opponentMove = new Move("Nożyce");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                            
                            warriant.LoseCount--;
                            break;
                        }
                    case "Nożyce":
                        {
                            Move opponentMove = new Move("Kamień");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                           
                            warriant.LoseCount--;
                            break;
                        }
                }


            }
            else
            {
                Random rnd = new Random();
                int opponentMoveNumber;
                bool found = false;
                string opponentMoveName;
                do
                {
                    opponentMoveNumber = rnd.Next(-1, 2);
                    switch (opponentMoveNumber)
                    {
                        case -1:
                            if (warriant.LoseCount != 0)
                            {

                                warriant.LoseCount--;
                                found = true;
                                opponentMoveName = playerMove.Counter;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            }
                            break;
                        case 0:
                            if (warriant.DrawCount != 0)
                            {

                                warriant.DrawCount--;
                                found = true;
                                opponentMoveName = playerMove.Name;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                            }
                            break;
                        case 1:
                            if (warriant.WinCount != 0)
                            {
                                warriant.WinCount--;
                                found = true;
                                Move opponentMove;
                                switch (playerMoveName)
                                {
                                    case "Kamień":
                                        opponentMoveName = "Nożyce";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                    case "Papier":
                                        opponentMoveName = "Kamień";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;

                                    case "Nożyce":
                                        opponentMoveName = "Papier";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                }
                                
                            }
                            break;
                        default:
                            opponentMoveName = "error";
                            break;

                    }
                } while (!found);

              
            }
            switch (currentRoundResult)
            {
                case -1:
                    opponent.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'P';
                    break;
                case 0:
                    patient.MainRoundResults[roundCounter - 1] = 'D';
                    break;
                case 1:
                    patient.MainRoundResults[roundCounter - 1] = 'W';
                    patient.Score++;
                    break;
            }




        }

        public void DrawRound(string playerMoveName)
        {
            Move playerMove = new Move(playerMoveName);
            if (roundCounter == 1)
            {
                Move opponentMove = new Move(playerMoveName);
                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                
                warriant.DrawCount--;
            }
            else
            {
                Random rnd = new Random();
                int opponentMoveNumber;
                bool found = false;
                string opponentMoveName;
                do
                {
                    opponentMoveNumber = rnd.Next(-1, 2);
                    switch (opponentMoveNumber)
                    {
                        case -1:
                            if (warriant.LoseCount != 0)
                            {

                                warriant.LoseCount--;
                                found = true;
                                opponentMoveName = playerMove.Counter;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            }
                            break;
                        case 0:
                            if (warriant.DrawCount != 0)
                            {

                                warriant.DrawCount--;
                                found = true;
                                opponentMoveName = playerMove.Name;
                                Move opponentMove = new Move(opponentMoveName);
                                currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                            }
                            break;
                        case 1:
                            if (warriant.WinCount != 0)
                            {
                                warriant.WinCount--;
                                found = true;
                                Move opponentMove;
                                switch (playerMoveName)
                                {
                                    case "Kamień":
                                        opponentMoveName = "Nożyce";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                    case "Papier":
                                        opponentMoveName = "Kamień";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;

                                    case "Nożyce":
                                        opponentMoveName = "Papier";
                                        opponentMove = new Move(opponentMoveName);
                                        currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                                        break;


                                }

                            }
                            break;
                        default:
                            opponentMoveName = "error";
                            break;

                    }
                } while (!found);


            }
            switch (currentRoundResult)
            {
                case -1:
                    opponent.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'P';
                    break;
                case 0:
                    opponent.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'R';
                    break;
                case 1:
                    patient.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'W';
                    break;
            }




        }

        public void UnfairRound(string playerMoveName)
        {
            char[] tab = { 'W', 'W', 'P', 'W', 'P', 'R', 'R', 'W', 'R', 'R' };
            Move playerMove = new Move(playerMoveName);
            Move opponentMove;
            switch (tab[roundCounter-1])
            {
                case 'W':
                    switch (playerMoveName)
                    {

                        case "Kamień":
                            opponentMove = new Move("Nożyce");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            warriant.WinCount--;
                            break;
                        case "Papier":
                            opponentMove = new Move("Kamień");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            warriant.WinCount--;
                            break;
                        case "Nożyce":
                            opponentMove = new Move("Papier");
                            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);

                            warriant.WinCount--;
                            break;
                    }
                    break;
                case 'P':
                    opponentMove = new Move(playerMove.Counter);
                    currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                    warriant.LoseCount--;
                    break;
                case 'R':
                     opponentMove = new Move(playerMoveName);
                    currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
                    warriant.DrawCount--;
                    break;
            }
            switch (currentRoundResult)
            {
                case -1:
                    opponent.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'P';
                    break;
                case 0:
                    opponent.Score++;
                    patient.MainRoundResults[roundCounter - 1] = 'R';
                    break;
                case 1:
                    patient.MainRoundResults[roundCounter - 1] = 'W';
                    patient.Score++;
                    break;
            }
        }
        public void Round(string playerMoveName)
        {
            
            Move playerMove = new Move(playerMoveName);
            Random rnd = new Random();
            int opponentMoveNumber = rnd.Next(0, 3);
            string opponentMoveName;
            switch (opponentMoveNumber)
            {
                case 0:
                    opponentMoveName = "Kamień";
                    break;
                case 1:
                    opponentMoveName = "Papier";
                    break;
                case 2:
                    opponentMoveName = "Nożyce";
                    break;
                default:
                    opponentMoveName = "Kamień";
                    break;
            }
            Move opponentMove = new Move(opponentMoveName);
            currentRoundResult = Move.CheckWhoWin(playerMove, opponentMove);
            
            switch (currentRoundResult)
            {
                case -1:
                    patient.PreMatchResults[roundCounter - 1] = 'P';
                    opponent.Score++;
                    break;
                case 0:
                    patient.PreMatchResults[roundCounter - 1] = 'R';
                    break;
                case 1:
                    patient.PreMatchResults[roundCounter - 1] = 'W';
                    patient.Score++;
                    break;
            }
           
        }
        public int returnPlayerScore()
        {
            return patient.Score;
        }
        public int returnOpponetScore()
        {
            return opponent.Score;
        }
        public int returnResult()
        {
            return currentRoundResult;
        }
        public void setPleasureAndPainLevels(double pain, double pleasure,int round)
        {
            patient.PainLevel[round] = pain;
            patient.PleasureLevel[round] = pleasure;
        }
    }
}
