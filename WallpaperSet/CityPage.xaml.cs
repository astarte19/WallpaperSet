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
    /// Логика взаимодействия для CityPage.xaml
    /// </summary>
    public partial class CityPage : Page
    {
        public CityPage()
        {
            InitializeComponent();
            Image[] cityImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker cityWorker = new PictureWorker();
            cityWorker.UpdatePicture(cityUrls, cityImages);
        }
        
        String[] cityUrls = {   "https://images.wallpaperscraft.ru/image/single/gorod_noch_panorama_117682_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/gorod_vid_sverhu_doroga_156925_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/doroga_razmetka_most_123398_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/nochnoj_gorod_vid_sverkhu_noch_117531_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/gonkong_kitaj_neboskreby_nochnoj_gorod_ogni_goroda_119347_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/nochnoj_gorod_ogni_goroda_obzor_129026_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/nochnoj_gorod_vyveski_neon_139551_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/zamok_skala_vozvyshennost_127420_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/arkhitektura_gorod_vid_sverkhu_zdaniya_reka_118446_1920x1080.jpg",};

        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[0], "00", "City");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[1], "10", "City");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[2], "20", "City");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[3], "01", "City");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[4], "11", "City");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[5], "21", "City");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[6], "02", "City");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[7], "12", "City");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(cityUrls[8], "22", "City");
        }
    }
}
