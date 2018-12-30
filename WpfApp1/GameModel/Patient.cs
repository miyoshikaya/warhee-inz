using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.GameModel
{
    public class Patient
    {
        string login;
        int sex, age, warriant; //0 - kobieta 1 - mezczyzna
        int score = 0;
        double[] pleasureLevel, painLevel;
        char[] preMatchResults, mainRoundResults;

        public Patient(string login, int sex, int age, int warriant)
        {
            this.login = login;
            this.age = age;
            this.sex = sex;
            this.warriant = warriant;
            pleasureLevel = new double[10];
            painLevel = new double[10];
            preMatchResults = new char[10];
            mainRoundResults = new char[10];
        }
        public string SetSexToChar()
        {
            if (sex == 1)
                return "M";
            else
                return "K";
        }

        public int Score { get => score; set => score = value; }
        public double[] PleasureLevel { get => pleasureLevel; set => pleasureLevel = value; }
        public double[] PainLevel { get => painLevel; set => painLevel = value; }
        public string Login { get => login; set => login = value; }
        public int Sex { get => sex; set => sex = value; }
        public int Age { get => age; set => age = value; }
        public int Warriant { get => warriant; set => warriant = value; }
        public char[] PreMatchResults { get => preMatchResults; set => preMatchResults = value; }
        public char[] MainRoundResults { get => mainRoundResults; set => mainRoundResults = value; }
    }
}
