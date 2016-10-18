using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


namespace MapServiceTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click_Thumbnail(object sender, RoutedEventArgs e)
        {
            MapService.MapServiceClient client = new MapService.MapServiceClient();

            var response = client.GetMapThumbnail("radom");
            var thumbnailByte = Convert.FromBase64String(response.Thumbnail);
            ShowImage(thumbnailByte);
            SaveImage(thumbnailByte, "thumbnail");
        }

        private void SaveImage(byte[] imageBytes, string filename)
        {
            var path = string.Format(@"C:\{0}.png", filename);

            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(stream))
            {
                writer.Write(imageBytes);
            }
        }

        private void Button_Click_DetailedImage(object sender, RoutedEventArgs e)
        {
            MapService.MapServiceClient client = new MapService.MapServiceClient();
            var response = client.GetDetailedMapByPixelLocation("radom", 181, 121, 290, 220);
            var imageBytes = Convert.FromBase64String(response.DetailedImage);
            ShowImage(imageBytes);
            SaveImage(imageBytes, "detailed");
        }

        private void ShowImage(byte[] imageBytes)
        {
            var bitmapImage = new BitmapImage();

            using (var ms = new System.IO.MemoryStream(imageBytes))
            {       
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = ms;
                bitmapImage.EndInit();
            }

            Image.Source = bitmapImage;
            Image.Source.Freeze();
        }
    }
}
