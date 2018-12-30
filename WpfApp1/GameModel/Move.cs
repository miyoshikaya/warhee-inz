using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.GameModel
{
    class Move
    {
        string name;
        string counter;
        public Move(string name)
        {
            switch (name)
            {
                case "Kamień":
                    this.name = name;
                    counter = "Papier";
                    break;
                case "Papier":
                    this.name = name;
                    counter = "Nożyce";
                    break;
                case "Nożyce":
                    this.name = name;
                    counter = "Kamień";
                    break;
                default:
                    break;
            }

        }

        public string Name { get => name; set => name = value; }
        public string Counter { get => counter; set => counter = value; }

        public static int CheckWhoWin(Move playerMove,Move opponentMove)
        {
           
                    if (opponentMove.name == playerMove.counter)
                        return -1;
                    else
                    if(opponentMove.name == playerMove.name)
                        return 0;
                    else
                    return 1;
            
        }
    }
}
