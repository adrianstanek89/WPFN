using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows;

namespace ProgressBar
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient webClient;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient())
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                try
                {
                    webClient.DownloadFileAsync(new Uri(urlAddress), location);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("Pobieranie zostalo przerwane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Pobieranie zostalo szczesliwie zakonczone.", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonDownload_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(urlAddress.Text))
            {
                DownloadFile(urlAddress.Text, Path.Combine(Directory.GetCurrentDirectory(), $"file.pdf"));
            }
        }
    }
}
