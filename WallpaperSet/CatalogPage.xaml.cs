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
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace WallpaperSet
{
    
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
        }
       

        //Обработчик событий кнопки отображения картинок машин
        private void ButtonCars_Click(object sender, RoutedEventArgs e)
        {
            CatalogFrame.Content = new CarsPage();
        }
        //Обработчик событий кнопки отображения картинок аниме
        private void ButtonAnime_Click(object sender, RoutedEventArgs e)
        {

            CatalogFrame.Content = new AnimePage();

        }
        //Обработчик событий кнопки отображения картинок животных
        private void ButtonAnimals_Click(object sender, RoutedEventArgs e)
        {
            
            CatalogFrame.Content = new AnimalsPage();   
        }
        //Обработчик событий кнопки отображения картинок природы
        private void ButtonNature_Click(object sender, RoutedEventArgs e)
        {

            CatalogFrame.Content = new NaturePage();
        }
        //Обработчик событий кнопки отображения картинок еды
        private void ButtonFood_Click(object sender, RoutedEventArgs e)
        {
            
           CatalogFrame.Content = new FoodPage();
        }
        //Обработчик событий кнопки отображения картинок городов
        private void ButtonCity_Click(object sender, RoutedEventArgs e)
        {

            CatalogFrame.Content = new CityPage();
        }
        //Обработчик событий кнопки отображения картинок абстракции
        private void ButtonAbs_Click(object sender, RoutedEventArgs e)
        {

            CatalogFrame.Content = new AbsPage();
        }

       
    }
}
