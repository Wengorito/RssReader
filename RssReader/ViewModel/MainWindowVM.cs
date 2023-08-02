using RssReader.Model;
using System.Collections.ObjectModel;

namespace RssReader.ViewModel
{
    public class MainWindowVM
    {
        private IRssHelper _rssHelper;

        public ObservableCollection<Item> Items { get; set; }

        public MainWindowVM(IRssHelper rssHelper)
        {
            Items = new ObservableCollection<Item>();
            _rssHelper = rssHelper;

            ReadRss();
        }


        private void ReadRss()
        {
            Items.Clear();

            var posts = _rssHelper.GetPosts();

            foreach (var post in posts)
            {
                Items.Add(post);
            }
        }
    }
}
