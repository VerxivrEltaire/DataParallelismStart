using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace DataParallelismStart {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void parallelAsyncExecute_Click(object sender, RoutedEventArgs e) {
            
        }

        private void stopExecute_Click(object sender, RoutedEventArgs e) {

        }

        private void breakExecute_Click(object sender, RoutedEventArgs e) {

        }

        private void cancelExecute_Click(object sender, RoutedEventArgs e) {

        }

        public static List<string> SiteData() {
            var webResult = new List<string>();

            webResult.Add("https://www.youtube.com");
            webResult.Add("https://www.google.com");
            webResult.Add("https://www.twitter.com");
            webResult.Add("https://www.cnn.com");
            webResult.Add("https://www.yahoo.com");
            webResult.Add("https://www.facebook.com");
            webResult.Add("https://www.sourceforge.net");
            webResult.Add("https://www.codeproject.com");
            webResult.Add("https://www.stackoverflow.com");
            webResult.Add("https://www.wikipedia.org/wiki/.NET_Framework");
            webResult.Add("https://time.com/4960202/most-influential-websites/");
            webResult.Add("https://www.webopedia.com/TERM/A/application.html");
            webResult.Add("https://ahrefs.com/blog/most-visited-websites/");
            webResult.Add("https://www.google.com/business/website-builder/");
            webResult.Add("https://www.wix.com/");
            webResult.Add("https://99designs.com/blog/web-digital/types-of-websites/");
            webResult.Add("https://blog.hubspot.com/marketing/best-website-designs-list");
            webResult.Add("https://www.britannica.com/technology/software");
            webResult.Add("https://www.sciencedaily.com/terms/computer_software.htm");
            webResult.Add("https://www.computerhope.com/jargon/s/software.htm");

            return webResult;
        }

        private static WebsiteModel DownloadWebsite(string websiteURL) {
            WebsiteModel websiteModel = new WebsiteModel();
            WebClient client = new WebClient();

            websiteModel.WebsiteUrl = websiteURL;
            websiteModel.WebsiteData = client.DownloadString(websiteURL);

            return websiteModel;
        }
    }
}
