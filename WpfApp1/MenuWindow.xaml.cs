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
using WpfApp1.View;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Page
    {
        Page previousPage;
        StartingWindow main;
        Reasearcher researcher;
        bool savedGame = false;
        public Page PreviousPage { get => previousPage; set => previousPage = value; }

        public MenuWindow(Page page, StartingWindow main)
        {
            this.main = main;
            previousPage = page;
            savedGame = true;
            InitializeComponent();
        
        }
    
        public MenuWindow(StartingWindow main,Reasearcher researcher)
        {
            this.main = main;
            this.researcher = researcher;
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            if(savedGame)
            main.Content = previousPage;
        }

        private void NewGamebutton_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new MainWindow(main,researcher);
        }

        private void DataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new DataBaseMenu(main,researcher);
        }
    }
}
