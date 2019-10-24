using System;
using System.Collections.Generic;


namespace ConsoleApp1
{
    public class Episode
    {

        public string title { get; set; }
        public string description { get; set; }
        public DateTime pubDate { get; set; }
        public Episode(string title, string description, DateTime pubDate)
        {
            this.title = title;
            this.description = description;
            this.pubDate = pubDate;
        }
    }
    public class Podcast
    {
        public string title { get; set; }
        public string description { get; set; }
        public int intervall { get; set; }
        public string category { get; set; }
        public string link { get; set; }
        
        public List<Episode> EpisodeList {get; set;}

        public Podcast(string title, string description, int intervall, string category, List<Episode> episodeList)
        {

            this.title = title;
            this.description = description;
            this.intervall = intervall;
            this.category = category;
            this.EpisodeList = episodeList;
        }
    }
}

