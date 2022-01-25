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
        
        String[] cityUrls = {   "https://images.wallpaperscraft.ru/image/single/virshem_germaniya_zamok_tropa_vecher_nebo_119771_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/gorod_noch_panorama_117682_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/ruiny_chelovek_odinochestvo_124279_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/trollejbus_ostanovka_gorod_vecher_osveshchenie_119292_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/nochnoj_gorod_vid_sverkhu_noch_117531_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/most_arhitektura_goticheskij_134848_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/most_osen_gorod_121892_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/yaponiya_sirakava_doma_gory_derevya_112963_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/ulitsa_gorod_zakat_160055_3840x2160.jpg",};

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
