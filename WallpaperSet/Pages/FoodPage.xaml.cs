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
    /// Логика взаимодействия для FoodPage.xaml
    /// </summary>
    public partial class FoodPage : Page
    {
        public FoodPage()
        {
            InitializeComponent();
            Image[] foodImages = { Image1, Image2, Image3, Image4, Image5, Image6, Image7, Image8, Image9 };
            PictureWorker foodWorker = new PictureWorker();
            foodWorker.UpdatePicture(foodUrls, foodImages);
        }

        String[] foodUrls = {   "https://images.wallpaperscraft.ru/image/single/kofe_kniga_ochki_140830_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kakao_zefir_pled_kniga_osen_118517_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/frukty_tsitrusy_ananas_121783_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/marshmellou_zefir_spiralnyj_123683_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/chernika_iagody_miata_196995_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/desert_tort_pirozhnoe_malina_sladkoe_frukty_chernika_chernaya_smorodina_eda_krem_93481_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/ananas_frukt_spelyj_etiketka_110141_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/chereshnya_vishnya_blyudo_tsvety_106400_3840x2160.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kofejnye_zerna_kofe_serdtse_121652_3840x2160.jpg",};

        private void Image00Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[0], "00", "Food");
        }

        private void Image10Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[1], "10", "Food");
        }

        private void Image20Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[2], "20", "Food");
        }

        private void Image01Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[3], "01", "Food");
        }

        private void Image11Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[4], "11", "Food");
        }

        private void Image21Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[5], "21", "Food");
        }

        private void Image02Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[6], "02", "Food");
        }

        private void Image12Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[7], "12", "Food");
        }

        private void Image22Button_Click(object sender, RoutedEventArgs e)
        {
            PictureWorker pictureWorker = new PictureWorker();
            pictureWorker.DownloadAndSetWall(foodUrls[8], "22", "Food");
        }
    }
}
