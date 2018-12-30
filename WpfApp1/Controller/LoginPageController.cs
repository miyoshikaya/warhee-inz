using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.GameModel;

namespace WpfApp1.Controller
{
    public class LoginPageController
    {
        string login, warriant;
        int age, sex;
        Patient patient;
      //  Opponent opponent;
        public string Login { get => login; set => login = value; }
        public int Age { get => age; set => age = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Warriant { get => warriant; set => warriant = value; }

        public void SetSex(string ssex)
        {
            if (ssex == "Kobieta")
                sex = 0;
            else sex = 1;
        }
        public void SetPatient(string login, int age, int sex,string gameWarriant)
        {
            patient = new Patient(login, sex, age, setPatientGameWarriant(gameWarriant));
        }
        public Patient GetPatient()
        {
            return patient;
        }
        public int setPatientGameWarriant(string gameWarriant)
        {
            Warriant = gameWarriant;
           switch(gameWarriant)
            {
                case "Wariant wygranej":
                    return 1;
                case "Wariant przegranej":
                    return 2;
                case "Wariant remisu":
                    return 3;
                case "Wariant nieuczciwy":
                    return 4;
                default:
                    return 0;
            }
        }
    }
}
