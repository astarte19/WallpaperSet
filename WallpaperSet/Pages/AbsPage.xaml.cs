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
        
        String[] absUrls = {    "https://images.wallpaperscraft.ru/image/single/kristally_oskolki_vzryv_svet_46568_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/polosy_raznotsvetnyj_abstraktsiia_197369_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/tumannost_bliki_svet_150410_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/chernyj_temnyj_fraktal_149686_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kraska_razvody_puzyri_139829_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/abstraktsiya_linii_volnistyj_113046_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/abstrakciya_fon_linii_yarkiy_blesk_76304_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/low_poly_mnogougolnik_pejzazh_abstraktsiya_103765_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kraska_tekstura_poverkhnost_116913_3840x2160.jpg",};

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
