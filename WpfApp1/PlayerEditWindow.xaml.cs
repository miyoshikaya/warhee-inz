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
    /// Logika interakcji dla klasy PlayerEditWindow.xaml
    /// </summary>
    public partial class PlayerEditWindow : Window
    { GametoDatabase controller;
        
        int ID;
        public PlayerEditWindow(int ID)
        {
            controller = new GametoDatabase();
            InitializeComponent();
            this.Background = new SolidColorBrush(Colors.Beige);
            this.ID = ID;
        }

        private void AcceptBox_Click(object sender, RoutedEventArgs e)
        {
            if (NewLoginTextBox.Text != RepeatNewLoginBox.Text)
                MessageBox.Show("Podane loginy się różnią");
            else
                if (RepeatNewLoginBox.Text == "" && NewLoginTextBox.Text != "")
                MessageBox.Show("potwierdz nowy login");
            else
                if (NewLoginTextBox.Text == "" && RepeatNewLoginBox.Text == "")
                this.Close();
            else
            {
                controller.EditExistingPlayer(ID, NewLoginTextBox.Text);
                this.Close();
            }


        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
