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
using WpfApp1.Database;
using System.IO;
using WpfAnimatedGif;
using Path = System.IO.Path;
using System.Windows.Media.Animation;

namespace WpfApp1.View
{
    /// <summary>
    /// Logika interakcji dla klasy GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        
        MainWindow prepareMenu;
        StartingWindow menu;
        bool mainRound = false;
        bool endGame = false;
       
        private void Kamień_Click(object sender, RoutedEventArgs e)
        {

            if (!mainRound)
                controller.Round(Kamień.Content.ToString());
            else
            {
                switch (prepareMenu.Controller.CurrentWarriant.GameType)
                {
                    case 1:
                        controller.WinRound(Kamień.Content.ToString());
                        break;
                    case 2:
                        controller.LoseRound(Kamień.Content.ToString());
                        break;
                    case 3:
                        controller.DrawRound(Kamień.Content.ToString());
                        break;
                    case 4:
                        controller.UnfairRound(Kamień.Content.ToString());
                        break;

                }
                PleasureLevelSlider1.IsEnabled = true;
                PainLevelSlider.IsEnabled = true;
            }

            Score.Text = controller.returnPlayerScore() + ":" + controller.returnOpponetScore();
            Kamień.IsEnabled = false;
            Nożyce.IsEnabled = false;
            Papier.IsEnabled = false;
            NextRoundButton.IsEnabled = true;

            switch (controller.returnResult())
            {
                case -1:
                    RoundResult.Text = "Przegrana!";
                    break;
                case 1:
                    RoundResult.Text = "Wygrana!";
                    break;
                case 0:
                    if (controller.Warriant.GameType == 4)
                        RoundResult.Text = "Remis niemożliwy, punkt przyznany osobie, która wcześniej się zgłosiła na badanie";
                    else
                    RoundResult.Text = "Remis!";
                    break;
            }
            

        }

        private void Papier_Click(object sender, RoutedEventArgs e)
        {
            if (!mainRound)
                controller.Round(Papier.Content.ToString());
            else
            {
                switch (prepareMenu.Controller.CurrentWarriant.GameType)
                {
                    case 1:
                        controller.WinRound(Papier.Content.ToString());
                        break;
                    case 2:
                        controller.LoseRound(Papier.Content.ToString());
                        break;
                    case 3:
                        controller.DrawRound(Papier.Content.ToString());
                        break;
                    case 4:
                        controller.UnfairRound(Papier.Content.ToString());
                        break;

                }
                PleasureLevelSlider1.IsEnabled = true;
                PainLevelSlider.IsEnabled = true;
            }
            Score.Text = controller.returnPlayerScore() + ":" + controller.returnOpponetScore();
            Kamień.IsEnabled = false;
            Nożyce.IsEnabled = false;
            Papier.IsEnabled = false;
            NextRoundButton.IsEnabled = true;

            switch (controller.returnResult())
            {
                case -1:
                    RoundResult.Text = "Przegrana!";
                    break;
                case 1:
                    RoundResult.Text = "Wygrana!";
                    break;
                case 0:
                    RoundResult.Text = "Remis!";
                    break;
            }

        }

        private void Nożyce_Click(object sender, RoutedEventArgs e)
        {
            if (!mainRound)
                controller.Round(Nożyce.Content.ToString());
            else
            {
                switch (prepareMenu.Controller.CurrentWarriant.GameType)
                {
                    case 1:
                        controller.WinRound(Nożyce.Content.ToString());
                        break;
                    case 2:
                        controller.LoseRound(Nożyce.Content.ToString());
                        break;
                    case 3:
                        controller.DrawRound(Nożyce.Content.ToString());
                        break;
                    case 4:
                        controller.UnfairRound(Nożyce.Content.ToString());
                        break;

                }

                PleasureLevelSlider1.IsEnabled = true;
                PainLevelSlider.IsEnabled = true;
            }
            Score.Text = controller.returnPlayerScore() + ":" + controller.returnOpponetScore();
            Kamień.IsEnabled = false;
            Nożyce.IsEnabled = false;
            Papier.IsEnabled = false;
            NextRoundButton.IsEnabled = true;

            switch (controller.returnResult())
            {
                case -1:
                    RoundResult.Text = "Przegrana!";
                    break;
                case 1:
                    RoundResult.Text = "Wygrana!";
                    break;
                case 0:
                    RoundResult.Text = "Remis!";
                    break;
            }


        }

        private void NextRoundButton_Click(object sender, RoutedEventArgs e)
        {
            if(!mainRound )
            {
                if (controller.RoundCounter < 11)
                {
                    Kamień.IsEnabled = true;
                    Nożyce.IsEnabled = true;
                    Papier.IsEnabled = true;
                    NextRoundButton.IsEnabled = false;
                    controller.RoundCounter++;
                    RoundCounter.Text = controller.RoundCounter.ToString();
                    if (controller.RoundCounter == 10)
                        NextRoundButton.Content = "Następna rozgrywka?";
                }
                if(controller.RoundCounter == 11)
                {
                    mainRound = true;
                    Kamień.IsEnabled = true;
                    Nożyce.IsEnabled = true;
                    Papier.IsEnabled = true;
                    NextRoundButton.IsEnabled = false;
                    controller.PrepareNextRound();
                    RoundCounter.Text = "1";
                    Score.Text = "0:0";
                    NextRoundButton.Content = "Następna Runda?";
                }


            }
            else
            if(mainRound)
            { 
                if(controller.RoundCounter < 11)
                {
                    Kamień.IsEnabled = true;
                    Nożyce.IsEnabled = true;
                    Papier.IsEnabled = true;
                    NextRoundButton.IsEnabled = false;
                    controller.setPleasureAndPainLevels(PainLevelSlider.Value, PleasureLevelSlider1.Value, controller.RoundCounter-1);
                        controller.RoundCounter++;
                    RoundCounter.Text = controller.RoundCounter.ToString();
                    PleasureLevelSlider1.IsEnabled = false;
                    PainLevelSlider.IsEnabled = false;
                    if (controller.RoundCounter == 10)
                        NextRoundButton.Content = "Koniec gry";
                    if(controller.RoundCounter == 11)
                    {
                        endGame = true;
                        RoundResult.Text = "Koniec Gry";
                        controller.DbContr.PutPlayerInDB(controller.Patient);
                       // controller.Patient.MainRoundResults[9] = 'P'; //usunac
                        controller.DbContr.AddNewResearcher(prepareMenu.Researcher);
                        controller.DbContr.PutGameInDB(controller.Patient, controller.Warriant, prepareMenu.Researcher);
                        //dodac zapis do CSV
                        menu.Content = new MenuWindow(menu, prepareMenu.Researcher);
                    }
                }
            }
      






        }

        GamePageController controller;
        public GamePage(Patient patient,string opponentSex, StartingWindow menu, MainWindow main)
        {   
            this.menu = menu;
            this.prepareMenu = main;
            InitializeComponent();
            controller = new GamePageController(patient, opponentSex, main.Controller.CurrentWarriant);
            RoundCounter.Text = controller.RoundCounter.ToString();
            var image = new BitmapImage();
            var path = Path.Combine(Environment.CurrentDirectory, "gifs","eyes.gif");
            image.BeginInit();
            image.UriSource = new Uri(path);
            image.EndInit();
            ImageBehavior.SetAnimatedSource(EyesGif, image);
            ImageBehavior.SetRepeatBehavior(EyesGif, RepeatBehavior.Forever);
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
           
            menu.Content = new MenuWindow(this,menu);
        }
    }
}
