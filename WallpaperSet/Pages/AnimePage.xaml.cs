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
    /// Логика взаимодействия для AnimePage.xaml
    /// </summary>
    public partial class AnimePage : Page
    {
        public AnimePage()
        {
            InitializeComponent();
            Image[] animeImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker animeWorker = new PictureWorker();
            animeWorker.UpdatePicture(animeUrls, animeImages);
        }
        
        String[] animeUrls = {"https://images.wallpaperscraft.ru/image/single/siluet_noch_zvezdnoe_nebo_137292_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_zontik_anime_141156_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/roial_siluet_kosmos_156662_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_trava_gorod_213102_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_noch_zvezdnoe_nebo_160928_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/paren_pisatel_knigi_209785_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_telefon_sneg_213067_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/hudozhnik_holst_kisti_213344_3840x2160.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_gitara_anime_141048_3840x2160.jpg" };
        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[0], "00", "Anime");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[1], "10", "Anime");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[2], "20", "Anime");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[3], "01", "Anime");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[4], "11", "Anime");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[5], "21", "Anime");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[6], "02", "Anime");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[7], "12", "Anime");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animeUrls[8], "22", "Anime");
        }
    }
}
