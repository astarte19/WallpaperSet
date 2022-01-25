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
        
        String[] animalsUrls = {"https://images.wallpaperscraft.ru/image/single/kot_zima_pushistyj_sneg_99366_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/volk_volki_khishchniki_tuman_sneg_gory_116660_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/volk_skala_obryv_khishchnik_120088_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/shchenok_haski_sobaka_146772_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/popugaj_sinij_ptitsa_119602_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/medved_buryj_trava_prikolnyj_lezhat_101886_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kot_morda_profil_chernyj_fon_118788_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/sobaka_morda_trava_razmytost_97096_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/enot_morda_zverek_lezhit_107094_3840x2160.jpg",};


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
