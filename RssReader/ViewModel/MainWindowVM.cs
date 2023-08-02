using RssReader.Model;
using System.Collections.ObjectModel;

namespace RssReader.ViewModel
{
    public class MainWindowVM
    {
        public ObservableCollection<Item> Items { get; set; }

        public MainWindowVM()
        {
            Items = new ObservableCollection<Item>();

            ReadRss();
        }


        private void ReadRss()
        {
            Items.Clear();

            var posts = RssHelper.GetPosts();

            foreach (var post in posts)
            {
                Items.Add(post);
            }
        }
    }
}
