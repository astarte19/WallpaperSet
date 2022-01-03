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
    /// Логика взаимодействия для NaturePage.xaml
    /// </summary>
    public partial class NaturePage : Page
    {
        public NaturePage()
        {
            InitializeComponent();
            Image[] natureImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker natureWorker = new PictureWorker();
            natureWorker.UpdatePicture(natureUrls, natureImages);
        }
        String[] natureUrls = { "https://images.wallpaperscraft.ru/image/single/tuman_les_tropinka_125819_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/ozero_les_sneg_130421_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/zvezdnoe_nebo_oblaka_zakat_120716_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/okean_pliazh_vid_sverhu_134429_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/doroga_asfalt_razmetka_130996_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/les_tuman_derevia_128751_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/les_tuman_derevia_126479_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/pejzazh_gory_solntse_140434_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/izverzhenie_lava_vulkan_sakura_derevo_45542_1920x1080.jpg",};

        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[0], "00", "Nature");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[1], "10", "Nature");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[2], "20", "Nature");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[3], "01", "Nature");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[4], "11", "Nature");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[5], "21", "Nature");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[6], "02", "Nature");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[7], "12", "Nature");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(natureUrls[8], "22", "Nature");
        }
    }
}
