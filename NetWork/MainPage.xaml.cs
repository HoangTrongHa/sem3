using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NetWork.Models;
using Windows.UI.Xaml.Media.Imaging;
using static NetWork.Models.NetWorks;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NetWork
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Page_LoadedAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                Root myPage = await NetWorks.getNetWork();
                string image = String.Format(myPage.image);
                ImageResult.Source = new BitmapImage(new Uri(image, UriKind.Absolute));
                DateResult.Text = myPage.date;
                TitleResult.Text = myPage.title;
                string description = myPage.content.description;
                ContentResult1.Text = description;

            }
            catch (Exception ex)
            {


            }
        }
    }
}
