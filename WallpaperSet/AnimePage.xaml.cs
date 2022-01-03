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
        
        String[] animeUrls = {"https://images.wallpaperscraft.ru/image/single/devushka_zontik_dozhd_151317_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_kotenok_tsvetok_141058_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_zontik_anime_141156_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/anime_devushka_art_zont_tsvety_rozovyj_98729_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_trava_gorod_213102_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_noutbuk_komnata_sidet_90444_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/paren_anime_kompyuter_slezy_grust_komnata_96990_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/devushka_bryunetka_roza_ocharovatelnaya_13325_1920x1080.jpg",
                              "https://images.wallpaperscraft.ru/image/single/anime_devushka_nebo_162368_1920x1080.jpg" };
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
