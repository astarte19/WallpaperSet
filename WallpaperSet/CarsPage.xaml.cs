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
    /// Логика взаимодействия для CarsPage.xaml
    /// </summary>
    public partial class CarsPage : Page
    {
        public CarsPage()
        {
            InitializeComponent();
            Image[] carsImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker carsWorker = new PictureWorker();
            carsWorker.UpdatePicture(carsUrls, carsImages);
        }
        
        String[] carsUrls = {"https://images.wallpaperscraft.ru/image/single/rollsroyce_vid_speredi_fary_136993_1920x1080.jpg" ,
                             "https://images.wallpaperscraft.ru/image/single/bmw_mashina_sportkar_144444_1920x1080.jpg" ,
                             "https://images.wallpaperscraft.ru/image/single/mercedes_benz_s_class_w222_112850_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/koenigsegg_agera_rs_vid_sboku_osen_derevya_107373_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/lamborghini_aventador_lp_750_4_sv_108049_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/mclaren_p1_gtr_mclaren_p1_mclaren_128793_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/toyota_gt86_vid_szadi_vecher_105093_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/bugatti_chiron_bugatti_sportkar_129532_1920x1080.jpg",
                             "https://images.wallpaperscraft.ru/image/single/ford_mustang_gt_vid_sboku_krasnyj_94340_1920x1080.jpg" };

        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[0],"00","Cars");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[1], "10", "Cars");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[2], "20", "Cars");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[3], "01", "Cars");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[4], "11", "Cars");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[5], "21", "Cars");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[6], "02", "Cars");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[7], "12", "Cars");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(carsUrls[8], "22", "Cars");
        }
    }
}
