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
        
        String[] carsUrls = {"https://images.wallpaperscraft.ru/image/single/bugatti_chiron_skorost_vid_sboku_113074_3840x2160.jpg" ,
                             "https://images.wallpaperscraft.ru/image/single/porsche_911_carrera_rsr_porsche_sportkar_139640_3840x2160.jpg" ,
                             "https://images.wallpaperscraft.ru/image/single/bmw_avtomobil_bamper_191131_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/mclaren_p1_gtr_mclaren_p1_mclaren_128793_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/avto_vid_speredi_razmytost_119752_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/lamborghini_centenario_vid_sboku_skorost_110265_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/mercedesbenz_mercedes_chernyj_133920_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/audi_r8_v10_vid_sboku_doroga_109803_3840x2160.jpg",
                             "https://images.wallpaperscraft.ru/image/single/bugatti_chiron_vid_sboku_goluboj_110214_3840x2160.jpg" };

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
