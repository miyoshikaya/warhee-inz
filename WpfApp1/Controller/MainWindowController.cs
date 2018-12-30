using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.GameModel;
namespace WpfApp1.Controller
{
    class MainWindowController
    {
        GameWarriant currentWarriant;
        public MainWindowController(string gameTypeName,string sex)
        {
            currentWarriant = new GameWarriant(gameTypeName, sex);
        }
        public GameWarriant CurrentWarriant { get => currentWarriant; set => currentWarriant = value; }
    }
}
