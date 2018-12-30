using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.GameModel
{
    class Opponent
    {
        string sex;
        int score = 0;

        public Opponent(string sex)
        {
            this.sex = sex;
        }

        public int Score { get => score; set => score = value; }
    }
}
