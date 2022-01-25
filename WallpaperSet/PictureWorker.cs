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
using System.Net;
using System.IO;
using System.Drawing;
using System.Threading;

namespace WallpaperSet
{
    public class PictureWorker
    {

        
        
        const int SPI_SETDESKWALLPAPER = 20;
        const int SPIF_UPDATEINIFILE = 0x01;
        const int SPIF_SENDWININICHANGE = 0x02;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo
            (int uAction, int uParam, string lpvParam, int fuWinIni);

        public  void SetWall(string imagepath, int style, int tile)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true);
            key.SetValue("WallpaperStyle", style.ToString());
            key.SetValue("TileWallpaper", tile.ToString());
            SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, imagepath,
        SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

        }
       
      public  void UpdatePicture(String[] itemUrls, Image[] itemImages)
        {
           
            for (int i = 0; i < 9; i++)
            {
               
                    var uri = new Uri(itemUrls[i]);
                    var bitmap = new BitmapImage(uri);
                    itemImages[i].Source = bitmap;
               
                                   
                 
               
            }          
        }

        
        public void DownloadAndSetWall(string url,string i, string imagename)
        {
            string path = @"DownloadedImages/" + imagename + i + ".jpg";
            MessageBoxResult result = MessageBox.Show("Установить изображение в качестве обоев?\n(Для первой установки потребуется загрузка)",
                                          "Подтверждение",
                                          MessageBoxButton.YesNo,
                                          MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                if(File.Exists(path))
                {
                    SetWall(AppDomain.CurrentDomain.BaseDirectory + path, 0, 0);
                } 
                else
                {
                    using (WebClient client = new WebClient())
                    {
                        client.DownloadFile(url, path);
                    }

                    SetWall(AppDomain.CurrentDomain.BaseDirectory + path, 0, 0);
                }
                

                
            }
        }
       
    }
}
