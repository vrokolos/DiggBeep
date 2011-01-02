using System;
using System.Collections.Generic;
using System.Text;

namespace Baileysoft.Rss.DiggAPI
{
    /// <summary>
    /// The object representation of an article
    /// </summary>
    public class Story
    {
        #region fields
        private string id;
        private string link;
        private string submitDate;
        private string promoteDate;
        private string diggs;
        private string comments;
        private string commentsUrl;
        private string title;
        private string description;
        private string submitter;
        private string submitterIcon;
        private string submitterProfileViews;
        private string status;
        private string topic;
        private string container;
        #endregion fields

        #region properties
        /// <summary>
        /// Article id
        /// </summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>
        /// Article link (external)
        /// </summary>
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        /// <summary>
        /// Article submission date
        /// </summary>
        public string SubmitDate
        {
            get { return submitDate; }
            set { submitDate = value; }
        }
        /// <summary>
        /// Article promotion date
        /// </summary>
        public string PromoteDate
        {
            get { return promoteDate; }
            set { promoteDate = value; }
        }
        /// <summary>
        /// Article digg count
        /// </summary>
        public string Diggs
        {
            get { return diggs; }
            set { diggs = value; }
        }
        /// <summary>
        /// Article comment count
        /// </summary>
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        /// <summary>
        /// Article comments url href
        /// </summary>
        public string CommentsUrl
        {
            get { return commentsUrl; }
            set { commentsUrl = value; }
        }
        /// <summary>
        /// Article title
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>
        /// Article Summary
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>
        /// Submitter
        /// </summary>
        public string Submitter
        {
            get { return submitter; }
            set { submitter = value; }
        }
        /// <summary>
        /// Submitter icon url href
        /// </summary>
        public string SubmitterIcon
        {
            get { return submitterIcon; }
            set { submitterIcon = value; }
        }
        /// <summary>
        /// Submitter profile view count
        /// </summary>
        public string SubmitterProfileViews
        {
            get { return submitterProfileViews; }
            set { submitterProfileViews = value; }
        }
        /// <summary>
        /// Article popularity
        /// </summary>
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>
        /// Article topic category
        /// </summary>
        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }
        /// <summary>
        /// Article container
        /// </summary>
        public string Container
        {
            get { return container; }
            set { container = value; }
        }
        #endregion

        /// <summary>
        /// Builds Story Object Based on Story ID
        /// </summary>
        /// <param name="storyId">Story ID</param>
        /// <returns>Story Object</returns>
        public Story GetStoryByID(string storyId)
        {
            Story iStory = new Story();
            StoryCollection articles = new StoryCollection(ArticleType.byId, 
                                                           storyId); 
            foreach (Story aStory in articles)
            {
                iStory = aStory;
            }
            return iStory;
        }

    }
}
