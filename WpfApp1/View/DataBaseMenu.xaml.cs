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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WpfApp1.Database;
using WpfApp1.GameModel;
using WpfApp1.Controller;
using WpfApp1.Statistics;

namespace WpfApp1.View
{
   
    /// <summary>
    /// Logika interakcji dla klasy DataBaseMenu.xaml
    /// </summary>
    public partial class DataBaseMenu : Page
    {
        ImportToCSV import;
        Reasearcher researcher;
        DataToApp dbController;
        Stats statController;
        enum list { player,research,researcher,game,result,menu};
        StartingWindow main;
        int dataShow;
        public DataBaseMenu(StartingWindow main,Reasearcher researcher)
        {
            this.researcher = researcher;
         //   dbController = DataToApp.Instance;
            InitializeComponent();
            EditButton.IsEnabled = false;
            this.main = main;
            dataShow = (int)list.menu;
         //   import = new ImportToCSV();
         //   statController = new Stats();
        }

        private void ShowPlayersButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = dbController.GetPlayersTable();
            MainGrid.ItemsSource = dt.DefaultView;
            dataShow = (int)list.player;
            EditButton.IsEnabled = true;


        }

        private void ShowResearchersButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = dbController.GetResearchersTable();
            MainGrid.ItemsSource = dt.DefaultView;
            dataShow = (int)list.researcher;

            EditButton.IsEnabled = true;

        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new MenuWindow(main, researcher);
            
        }

        private void ShowResearchButton_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = dbController.GetResearchesTable();
            MainGrid.ItemsSource = dt.DefaultView;

            dataShow = (int)list.research;
            EditButton.IsEnabled = false;
        }
        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType == typeof(System.DateTime))
                (e.Column as DataGridTextColumn).Binding.StringFormat = "dd/MM/yyyy";
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = MainGrid.SelectedItem as DataRowView;
          
            int selectedId = (int)row.Row.ItemArray[0];

                if(dataShow == (int)list.player)
            {
                DataTable dt = dbController.GetResearchesTable( selectedId);
                MainGrid.ItemsSource = dt.DefaultView;
                dataShow = (int)list.research;
                EditButton.IsEnabled = false;

            }
            else
                if(dataShow == (int)list.research)
            {
                DataTable dt = dbController.GetGameTable(selectedId);
                MainGrid.ItemsSource = dt.DefaultView;
                dataShow = (int)list.game;
                EditButton.IsEnabled = false;

            }
                else
                if(dataShow == (int)list.researcher)
            {
                DataTable dt = dbController.GetResearchesTableByResearcherID(selectedId);
                foreach (DataRow dr in dt.Rows)
                {
                    dr["DataBadania"] = DateTime.Parse((dr["DataBadania"].ToString())).ToString("dd/MM/yyyy");
                }
                MainGrid.ItemsSource = dt.DefaultView;
                dataShow = (int)list.research;
                EditButton.IsEnabled = true;

            }
            else
                if(dataShow == (int)list.game)
            {
                DataTable dt = dbController.GetResultTableByGameId(selectedId);
                MainGrid.ItemsSource = dt.DefaultView;
                dataShow = (int)list.result;
                EditButton.IsEnabled = false;
            }
        }

        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {
            // ImportToCSV.StartNewFile();
           // import.fillFileWithData();
          //  statController.MakeStatistics();
            StatsViewWindow window = new StatsViewWindow();
            window.Show();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = MainGrid.SelectedItem as DataRowView;
            int selectedId;
            if (row != null)
                selectedId = (int)row.Row.ItemArray[0];
            else
                return;
            if (dataShow == (int)list.player)
            {
                PlayerEditWindow playerEditWindow = new PlayerEditWindow(selectedId);
                playerEditWindow.Show();
            }
            if(dataShow == (int)list.researcher)
            {
                Window researcherEditWindow = new Window();
                researcherEditWindow.Show();
            }
        }
    }
}
