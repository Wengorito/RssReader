using RssReader.Model;
using System.Collections.Generic;

namespace RssReader.ViewModel
{
    public interface IRssHelper
    {
        List<Item> GetPosts();
    }
}
