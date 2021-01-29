using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WPF_OOP6
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




        private void rdSony_Checked(object sender, RoutedEventArgs e)
        {
            TV Sony = new TV("Sony", "KD-77AG9", 100, 85, "sony.jpg");

            if (chkPower.IsChecked == true)
            {
                BitmapImage pic = new BitmapImage();
                pic.BeginInit();
                pic.UriSource = new Uri(@"Images\" + "sony.jpg", UriKind.Relative);
                pic.EndInit();
                lblBrand.Content = "Brand     " + Sony.Brand;
                lblType.Content = "Type   " + Sony.Type;
                lblPower.Content = "Power    " + true;
                lblHerz.Content = "Herz     " + Sony.Herz;
                lblImageSize.Content = "Image Size    " + Sony.ImageSize;
                lblChannel.Content = "Channel      " + Sony.Channel;
                lblVolume.Content = "Volume       " + Sony.Volume;
                img.Source = pic;
            }
            else
            {


                lblPower.Content = false;
            }

        }

        private void rdSamsung_Checked(object sender, RoutedEventArgs e)
        {
            TV Samsung = new TV("Samsung", "QLED 8K 85Q950TS (2020)", 100, 77, "samsung.jpg");

            if (chkPower.IsChecked == true)
            {
                BitmapImage pic2 = new BitmapImage();
                pic2.BeginInit();
                pic2.UriSource = new Uri(@"Images\" + "samsung.jpg", UriKind.Relative);
                pic2.EndInit();
                lblBrand.Content = "Brand  " + Samsung.Brand;
                lblType.Content = "Type  " + Samsung.Type;
                lblPower.Content = "Power   " + true;
                lblHerz.Content = "Herz  " + Samsung.Herz;
                lblImageSize.Content = "Image Size   " + Samsung.ImageSize;
                lblChannel.Content = "Channel  " + Samsung.Channel;
                lblVolume.Content = "Volume   " + Samsung.Volume;
                img.Source = pic2;

            }
            else
            {

                lblPower.Content = false;
            }


        }

        private void chkPower2_Checked(object sender, RoutedEventArgs e)
        {
            BitmapImage pic3 = new BitmapImage();
            pic3.BeginInit();
            pic3.UriSource = new Uri(@"Images\" + "philips.jpg", UriKind.Relative);
            pic3.EndInit();
            BitmapImage pic4 = new BitmapImage();
            pic4.BeginInit();
            pic4.UriSource = new Uri(@"Images\" + "tefal.jpg", UriKind.Relative);
            pic4.EndInit();


            if (cbSelection.SelectedIndex == 1)
            {
                img2.Source = pic3;
                
            }
            else if(cbSelection.SelectedIndex ==0)
            {

                img2.Source = pic4;

            }
        }
    }
}
