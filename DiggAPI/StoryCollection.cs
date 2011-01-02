using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Baileysoft.Rss.DiggAPI
{
    /// <summary>
    /// The Type of query
    /// </summary>
    public enum ArticleType
    {
        popular,
        upcoming,
        topic,
        topicUpcoming,
        byUserSubmissions,
        byUserDiggs,
        byId
    }

    /// <summary>
    /// Collection of Story Objects
    /// </summary>
    public class StoryCollection : IEnumerable 
    {
        public List<Story> alStory = new List<Story>();

        public StoryCollection(ArticleType aType):
            this(aType, null)
        {  }

        /// <summary>
        /// Overloaded Constructor
        /// </summary>
        /// <param name="aType">ArticleType</param>
        /// <param name="ArticleTypeCriteria">Search Criteria</param>
        public StoryCollection(ArticleType aType,
                               string ArticleTypeCriteria)
        {
            if (aType == ArticleType.byUserDiggs)
            {
                foreach (string id in Parser.GetStoryIDsByUser(ArticleTypeCriteria))
                     Parser.populateStoryCollection(this, BuildUrl(ArticleType.byId, id));
            }
            else
            {
                Parser.populateStoryCollection(this, BuildUrl(aType, ArticleTypeCriteria));
            }
        }

        public void Add(Story c)
        {
            alStory.Add(c);
        }

        public void Clear()
        {
            alStory.Clear();
        }

        public int Count
        {
            get { return alStory.Count; }
        }

        public bool Contains(Story c)
        {
            return cContains(c);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return alStory.GetEnumerator();
        }

        private bool cContains(Story c)
        {
            return (alStory.Contains(c)) ? true : false;
        }

        private string BuildUrl(ArticleType aType, string criteria)
        {
            string url = string.Empty;
            switch (aType)
            {
                case ArticleType.popular:
                    url = Globals.UrlStories + "popular?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
                case ArticleType.upcoming:
                    url = Globals.UrlStories + "upcoming?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
                //case ArticleType.container:
                //    url = Globals.UrlStories + "container/" + criteria + "&count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                //    break;
                case ArticleType.topic:
                    url = Globals.UrlTopics + criteria + "/popular?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
                case ArticleType.topicUpcoming:
                    url = Globals.UrlTopics + criteria + "/upcoming?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
                case ArticleType.byId:
                    url = Globals.UrlStory + criteria + "?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
                case ArticleType.byUserSubmissions:
                    url = Globals.UrlUser + criteria + "/submissions?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
                    break;
            }
            return url;
        }
    }
}
