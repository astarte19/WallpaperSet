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

        String[] foodUrls = {   "https://images.wallpaperscraft.ru/image/single/kofe_kruzhka_stul_124443_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/ezhevika_malina_yagody_104785_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/macarons_desert_pechene_raznotsvetnyj_103922_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/apelsin_led_miata_139564_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/chashka_chaj_napitok_stakan_111737_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kofe_kniga_podokonnik_130911_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/tort_desert_sladkoe_slivki_shokolad_93382_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/kofeynye_zerna_eda_poverhnost_91913_1920x1080.jpg",
                                "https://images.wallpaperscraft.ru/image/single/burger_myaso_kotleta_syr_bulochka_93265_1920x1080.jpg",};

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
