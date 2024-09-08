using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms.Integration;
using System.Windows.Media;
using Newtonsoft.Json.Linq;

namespace My_Profile
{
    public partial class ProfilePage : Page
    {
        private const string ApiKey = "AIzaSyDTqaDjXFJaFuYBaY-06rcTLYVHouttTBk";
        private const string ApiUrl = "https://www.googleapis.com/youtube/v3/search";

        public ProfilePage()
        {
            InitializeComponent();
        }

        private async void OnSearchButtonClick(object sender, RoutedEventArgs e)
        {
            string query = SearchTextBox.Text;
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            try
            {
                var results = await SearchYouTubeAsync(query);
                ResultsListBox.ItemsSource = results;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task<List<VideoItem>> SearchYouTubeAsync(string query)
        {
            var httpClient = new HttpClient();
            var requestUri = $"{ApiUrl}?part=snippet&maxResults=10&q={Uri.EscapeDataString(query)}&key={ApiKey}";

            var response = await httpClient.GetStringAsync(requestUri);
            var json = JObject.Parse(response);

            var videoItems = new List<VideoItem>();
            foreach (var item in json["items"])
            {
                var title = (string)item["snippet"]["title"];
                var videoId = (string)item["id"]["videoId"];
                var thumbnailUrl = (string)item["snippet"]["thumbnails"]["high"]["url"];
                videoItems.Add(new VideoItem
                {
                    Title = title,
                    VideoId = videoId,
                    ThumbnailUrl = thumbnailUrl
                });
            }

            return videoItems;
        }

        private void OnPlayButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            var listBoxItem = VisualTreeHelper.GetParent(button) as ListBoxItem;
            var selectedItem = listBoxItem?.DataContext as VideoItem;

            if (selectedItem == null)
                return;

            var videoId = selectedItem.VideoId;
            var url = $"https://www.youtube.com/embed/{videoId}?autoplay=1";

            // Load video in the WebBrowser
            VideoPlayer.Navigate(url);
        }

        private void OnVideoSelected(object sender, SelectionChangedEventArgs e)
        {
            // Optional: Handle selection changes if needed
        }
    }

    public class VideoItem
    {
        public string Title { get; set; }
        public string VideoId { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
