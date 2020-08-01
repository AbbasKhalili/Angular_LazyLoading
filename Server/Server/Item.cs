using System.Collections.Generic;

namespace Server
{
    public class Item
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Img { get; set; }
        public string ImgLarge { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public List<string> Tags { get; set; }
    } 
}
