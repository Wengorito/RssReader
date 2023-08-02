using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Serialization;

namespace RssReader.Model
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Rss));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Rss)serializer.Deserialize(reader);
    // }

    //[XmlRoot(ElementName = "link")]
    //public class Link
    //{

    //    [XmlAttribute(AttributeName = "href")]
    //    public string Href { get; set; }

    //    [XmlAttribute(AttributeName = "rel")]
    //    public string Rel { get; set; }

    //    [XmlAttribute(AttributeName = "type")]
    //    public string Type { get; set; }
    //}

    [XmlRoot(ElementName = "item")]
    public class Item
    {

        [XmlElement(ElementName = "title")]
        public string Title { get; set; }

        //[XmlElement(ElementName = "link")]
        //public string Link { get; set; }

        //[XmlElement(ElementName = "description")]
        //public string Description { get; set; }

        private string pubDate;

        [XmlElement(ElementName = "pubDate")]
        public string PubDate
        {
            get { return pubDate; }
            set
            {
                pubDate = value;
                PublishedDate = DateTime.ParseExact(pubDate, "ddd, dd MMM yyyy HH:mm:ss zzzz", CultureInfo.InvariantCulture);
            }
        }

        public DateTime PublishedDate { get; set; }

        //[XmlElement(ElementName = "guid")]
        //public string Guid { get; set; }

        //[XmlElement(ElementName = "author")]
        //public string Author { get; set; }
    }

    [XmlRoot(ElementName = "channel")]
    public class Channel
    {

        //[XmlElement(ElementName = "title")]
        //public string Title { get; set; }

        //[XmlElement(ElementName = "link")]
        //public List<string> Link { get; set; }

        //[XmlElement(ElementName = "description")]
        //public string Description { get; set; }

        //[XmlElement(ElementName = "language")]
        //public string Language { get; set; }

        //[XmlElement(ElementName = "pubDate")]
        //public DateTime PubDate { get; set; }

        //[XmlElement(ElementName = "lastBuildDate")]
        //public DateTime LastBuildDate { get; set; }

        //[XmlElement(ElementName = "managingEditor")]
        //public string ManagingEditor { get; set; }

        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "rss")]
    public class Rss
    {

        [XmlElement(ElementName = "channel")]
        public Channel Channel { get; set; }

        //[XmlAttribute(AttributeName = "version")]
        //public double Version { get; set; }

        //[XmlAttribute(AttributeName = "atom")]
        //public string Atom { get; set; }

        //[XmlText]
        //public string Text { get; set; }
    }


}
