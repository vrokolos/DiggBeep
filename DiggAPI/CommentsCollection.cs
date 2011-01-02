using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Baileysoft.Rss.DiggAPI
{
    public class CommentsCollection : IEnumerable 
    {
        private List<Comment> alComments = new List<Comment>();

        public CommentsCollection(Story story)
        {
            alComments = Parser.GetComments(story);
        }

        public void Add(Comment c)
        {
            alComments.Add(c);
        }

        public void Clear()
        {
            alComments.Clear();
        }

        public int Count
        {
            get { return alComments.Count; }
        }

        public bool Contains(Comment c)
        {
            return cContains(c);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return alComments.GetEnumerator();
        }

        private bool cContains(Comment c)
        {
            return alComments.Contains(c) ? true : false;
        }
    }
   }
