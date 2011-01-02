using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Baileysoft.Rss.DiggAPI
{
    /// <summary>
    /// Collection of strings (the topic names available)
    /// </summary>
    public class TopicsCollection : IEnumerable 
    {
        private List<string> alTopics = new List<string>();

        public TopicsCollection()
        {
            alTopics = Parser.GetTopics();
        }

        public void Add(string c)
        {
            alTopics.Add(c);
        }

        public void Clear()
        {
            alTopics.Clear();
        }

        public int Count
        {
            get { return alTopics.Count; }
        }

        public bool Contains(string c)
        {
            return cContains(c);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return alTopics.GetEnumerator();
        }

        private bool cContains(string c)
        {
            return alTopics.Contains(c) ? true : false;
        }
    }
}
