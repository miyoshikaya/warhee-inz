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
using WpfApp1.Controller;
using WpfApp1.View;
using WpfApp1.GameModel;
namespace WpfApp1
{
   
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        StartingWindow main;
        Reasearcher researcher;
        MainWindowController controller;

        internal MainWindowController Controller { get => controller; set => controller = value; }
        public Reasearcher Researcher { get => researcher; set => researcher = value; }

        public MainWindow(StartingWindow main,Reasearcher researcher)
        {
            this.researcher = researcher;
            this.main = main;
          InitializeComponent();
            
        }
       

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            
            controller = new MainWindowController(GameTypeSelector.Text, SexSelector.Text);
            if (GameTypeSelector.Text != "" && SexSelector.Text != "")
                main.Content = new LoginPage(controller.CurrentWarriant, main,this);
            else
                MessageBox.Show("uzupełnij brakujące dane");

        }

        private void GameTypeSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SexSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
