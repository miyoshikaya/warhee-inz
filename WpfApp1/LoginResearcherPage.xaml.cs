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
using WpfApp1.GameModel;
using WpfApp1.Database;
namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy LoginPage.xaml
    /// </summary>
    public partial class LoginResearcherPage : Page
    {
        
        Reasearcher researcher;
        StartingWindow main;
        DataToApp dbController;
        public LoginResearcherPage(StartingWindow main)
        {
            this.main = main;
          //  dbController = DataToApp.Instance;
            InitializeComponent();
            List<string> researchersTab;
         //   researchersTab = dbController.GetResearchersNamesList();
         //   foreach (string i in researchersTab)
          //      ResearcherList.Items.Add(i);
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (ResearcherList.Text != "" )
            {
                string[] selectedItem = ResearcherList.Text.Split(' ');
                researcher = new Reasearcher(selectedItem[0], selectedItem[1]);
                
                main.Content = new MenuWindow(main, researcher);
            }
            else
                MessageBox.Show("podaj imie i nazwisko");

        }

        private void NewLoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginBox.Text != "" && NazwiskoBox.Text != "")
            {
                researcher = new Reasearcher(LoginBox.Text, NazwiskoBox.Text);

                main.Content = new MenuWindow(main, researcher);
            }
            else
                MessageBox.Show("podaj imie i nazwisko");
        }
    }
}
