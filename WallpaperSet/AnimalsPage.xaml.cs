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
    /// Логика взаимодействия для AnimalsPage.xaml
    /// </summary>
    public partial class AnimalsPage : Page
    {
        public AnimalsPage()
        {
            InitializeComponent();
            Image[] animalsImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker animalsWorker = new PictureWorker();
            animalsWorker.UpdatePicture(animalsUrls, animalsImages);
        }
        
        String[] animalsUrls = {"https://images.wallpaperscraft.ru/image/single/kot_zima_pushistyj_sneg_99366_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/volk_skala_obryv_khishchnik_120088_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/volk_volki_khishchniki_tuman_sneg_gory_116660_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/schenok_morda_milyy_pushistyy_66456_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/sobaka_ovcharka_sidit_118661_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/orel_polet_nebo_krylya_oblaka_97499_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/tigr_morda_kamen_vzglyad_hischnik_92029_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/sova_ptica_hischnik_luna_polet_71729_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/schenok_kotenok_para_druzhba_56364_1920x1080.jpg",};


        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[0], "00", "Animals");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[1], "10", "Animals");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[2], "20", "Animals");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[3], "01", "Animals");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[4], "11", "Animals");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[5], "21", "Animals");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[6], "02", "Animals");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[7], "12", "Animals");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(animalsUrls[8], "22", "Animals");
        }
    }
}
