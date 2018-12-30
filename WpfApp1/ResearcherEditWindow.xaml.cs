using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using WpfApp1.Database;
namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy ResearcherEditWindow.xaml
    /// </summary>
    public partial class ResearcherEditWindow : Window
    {
        GametoDatabase controller;
        int ID;
        public ResearcherEditWindow(int ID)
        {
            controller = new GametoDatabase();
            this.ID = ID;
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameBox.Text == "" && SurnameBox.Text == "")
                this.Close();
            else
            {
                if(NameBox.Text != "")
                {
                    controller.EditResearcherName(NameBox.Text,ID);
                }
                if(SurnameBox.Text != "")
                {
                    controller.EditResearcherSurname(SurnameBox.Text,ID);

                }
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
