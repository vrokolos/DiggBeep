using System;
using System.Collections.Generic;
using System.Text;

namespace Baileysoft.Rss.DiggAPI
{
    public class Comment
    {
        #region fields
        private string date;
        private string id;
        private string up;
        private string down;
        private string replies;
        private string user;
        private string text;
        //private Story story;
        #endregion

        #region properties
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Up
        {
            get { return up; }
            set { up = value; }
        }
        public string Down
        {
            get { return down; }
            set { down = value; }
        }
        public string Replies
        {
            get { return replies; }
            set { replies = value; }
        }
        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        //public Story GetStory
        //{
        //    get { return story; }
        //    set { story = value; }
        //}
        #endregion



    }
}
