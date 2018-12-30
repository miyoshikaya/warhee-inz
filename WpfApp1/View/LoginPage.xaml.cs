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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.GameModel;
using WpfApp1.Controller;

namespace WpfApp1.View
{
    /// <summary>
    /// Logika interakcji dla klasy LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {

        StartingWindow menu;
        MainWindow prepareMenu;
        LoginPageController controller;
        string opponentSex;

        public MainWindow PrepareMenu { get => prepareMenu; set => prepareMenu = value; }

        public LoginPage(GameWarriant currentWarriant,StartingWindow menu, MainWindow main)
        {
            this.menu = menu;
            this.prepareMenu = main;
            InitializeComponent();
            controller = new LoginPageController();
            opponentSex = currentWarriant.OpponentGenderName;
            controller.setPatientGameWarriant(currentWarriant.GameTypeName);
        }

        private void loginBox_TextChanged(object sender, TextChangedEventArgs e)
        {
             
          
        }

        private void ageBox_TextChanged(object sender, TextChangedEventArgs e)
        {
     
        }

        private void ageBox_LostFocus(object sender, RoutedEventArgs e)
        {
            //if (!Int32.TryParse(ageBox.Text, out int succed))
            //{
            //    MessageBox.Show("podaj liczbe");
            //}
        }

        private void ToGameButton_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!Int32.TryParse(ageBox.Text, out int succed) && ageBox.Text != "")
            {
                MessageBox.Show("wiek musi być liczbą");
            }
        }

        private void ToGameButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginBox.Text != RepeatLoginBox.Text)
            {
                MessageBox.Show("podane loginy nie zgadzają się");
                return;
            }
        
            if (loginBox.Text != "" && ageBox.Text != "" && SexSelector.Text != "")
            {
                controller.SetSex(SexSelector.Text);
                controller.SetPatient(loginBox.Text, Int32.Parse(ageBox.Text), controller.Sex, controller.Warriant);
                menu.Content = new GamePage(controller.GetPatient(), opponentSex, menu, prepareMenu);

            }
            else 

                MessageBox.Show("uzupełnij brakujące dane");
           
            
        }
    }
}
