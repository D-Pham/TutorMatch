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
using System.Net;
using System.Text;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace App5
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

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
        	if(pwbox.Password.Equals("wooch-proh") && username.Text.Equals("hackru2014_401")){
			  this.Frame.Navigate(typeof(BasicPage1));	
			}
           
            //var request = (HttpWebRequest)WebRequest.Create("http://url");
            //request.ContentType = "text/json";
            //request.Method = "POST";

            //using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            //{
            //    string json = "{\"name\":\"test\"," +
            //  "\"school\":\"Fuck You\"}";

            //    streamWriter.Write(json);
            //}

            //var response = (HttpWebResponse)request.GetResponse();
            //using (var streamReader = new StreamReader(response.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}
        }


        private void Image_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            if (swaghat.Visibility.Equals(Windows.UI.Xaml.Visibility.Collapsed))
            {
                swaghat.Visibility = Windows.UI.Xaml.Visibility.Visible;
            } 
        }


 

    }
}
