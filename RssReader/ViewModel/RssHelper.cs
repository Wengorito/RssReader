using RssReader.Model;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

namespace RssReader.ViewModel
{
    public class RssHelper : IRssHelper
    {
        public List<Item> GetPosts()
        {
            var posts = new List<Item>();

            var serializer = new XmlSerializer(typeof(Rss));

            using (var webClient = new WebClient())
            {
                var xml = Encoding.UTF8.GetString(webClient.DownloadData("https://spidersweb.pl/api/post/feed/feed-gn"));

                //using (Stream reader = new MemoryStream(Encoding.Default.GetBytes(xml)))
                using (StringReader reader = new StringReader(xml))
                {
                    var blog = (Rss)serializer.Deserialize(reader);

                    posts = blog.Channel.Item;
                }
            }

            return posts;
        }
    }
}
