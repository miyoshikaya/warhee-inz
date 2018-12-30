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
using System.IO;

using Path = System.IO.Path;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy StatsViewWindow.xaml
    /// </summary>
    public partial class StatsViewWindow : Window
    {
        List<String> imagesPathList;
        int currentPic;
        //string path = System.IO.Directory.GetCurrentDirectory() + "/charts/";
        public StatsViewWindow()
        {
            currentPic = 0;
            InitializeComponent();
            imagesPathList = new List<String>();
            imagesPathList = GetImagesPath("charts");
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            var path = Path.Combine(Environment.CurrentDirectory, "charts", imagesPathList[0]);
            image.UriSource = new Uri(path);
            image.EndInit();
            ChartPic.Source = image;
         
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public List<String> GetImagesPath(String folderName)
        {

            DirectoryInfo Folder;
            FileInfo[] Images;

            Folder = new DirectoryInfo(folderName);
            Images = Folder.GetFiles("*.png");
            List<String> imagesList = new List<String>();

            for (int i = 0; i < Images.Length; i++)
            {
                imagesList.Add(String.Format(Images[i].Name));
              
            }


            return imagesList;
        }

        private void NextPicButton_Click(object sender, RoutedEventArgs e)
        {
            int itemCountInList = imagesPathList.Count;
            if (currentPic == itemCountInList - 1)
                currentPic = 0;
            else
                currentPic++;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            var path = Path.Combine(Environment.CurrentDirectory, "charts", imagesPathList[currentPic]);
            image.UriSource = new Uri(path);
            image.EndInit();
            ChartPic.Source = image;
        }

        private void PreviousPicButton_Click(object sender, RoutedEventArgs e)
        {
            int itemCountInList = imagesPathList.Count;
            if (currentPic == 0)
                currentPic = itemCountInList - 1;
            else
                currentPic--;
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            var path = Path.Combine(Environment.CurrentDirectory, "charts", imagesPathList[currentPic]);
            image.UriSource = new Uri(path);
            image.EndInit();
            ChartPic.Source = image;
        }
    }
}
