using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows;

namespace AsynchronousProgramming
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

        private async void Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            //DownloadHtml("http://msdn.microsoft.com");
            //await DownloadHtmlAsync("http://msdn.microsoft.com");

            //var html =await GetHtmlAsync("http://msdn.microsoft.com");
            //MessageBox.Show(html.Substring(0,10));

            var getHtmlTask = GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show("Waiting for the complete...");
            var html = await getHtmlTask;
            MessageBox.Show(html.Substring(0, 10));
        }
        public async Task DownloadHtmlAsync(string url)
        {
            var webClient = new WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);
            using (var streamWriter = new StreamWriter(@"D:\result.html"))
            {
                await streamWriter.WriteAsync(html);
            }
        }
        public void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"D:\result.html"))
            {
                streamWriter.Write(html);
            }
        }
        public string GetHtml(string url)
        {
            var webClient = new WebClient();
            return webClient.DownloadString(url);
        }
        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
            await Task.Delay(3000);
            return await webClient.DownloadStringTaskAsync(url);
        }
    }
}
