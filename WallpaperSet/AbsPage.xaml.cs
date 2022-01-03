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

namespace WallpaperSet
{
    /// <summary>
    /// Логика взаимодействия для AbsPage.xaml
    /// </summary>
    public partial class AbsPage : Page
    {
        public AbsPage()
        {
            InitializeComponent();
            Image[] absImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker absWorker = new PictureWorker();
            absWorker.UpdatePicture(absUrls, absImages);
        }
        
        String[] absUrls = {    "https://images.wallpaperscraft.ru/image/single/derevo_svet_temnyy_82372_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/abstraktsiya_forma_ostrie_figurka_101902_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/treugolnik_forma_temnyy_figurka_88540_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kraska_voda_zhidkost_85058_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/oblaka_nebo_abstrakciya_88538_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/nebo_svet_abstrakciya_85064_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/pyatna_fon_linii_abstrakciya_66994_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/fon_nebo_tochki_svet_83482_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/abstrakciya_3d_art_85489_1920x1080.jpg",};

        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[0], "00", "Abs");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[1], "10", "Abs");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[2], "20", "Abs");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[3], "01", "Abs");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[4], "11", "Abs");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[5], "21", "Abs");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[6], "02", "Abs");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[7], "12", "Abs");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(absUrls[8], "22", "Abs");
        }
    }
}
