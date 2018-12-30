using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.GameModel
{
    public class Reasearcher
    {
        string name, surname;

        public Reasearcher (string name, string surname)
            {
            this.name = name;
            this.surname = surname;
            }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
    }
}
