using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Xml;

namespace Baileysoft.Rss.DiggAPI
{
    /// <summary>
    /// Xml parser methods
    /// </summary>
    public class Parser
    {
        public static void populateStoryCollection(StoryCollection alStories,
                                                   string diggWebServiceUrl)
        {
            Story newStory = new Story();
            XmlTextReader reader = Parser.CreateWebRequest(diggWebServiceUrl);
            
            while (reader.Read())
            {
                if (reader.Name == "story")
                {
//                    for (int i = 0; i < reader.AttributeCount; i++)
                    //{
//                        switch (i)
  //                      {
                    if (reader.GetAttribute("id") != null)
                    {
                        newStory.Id = reader.GetAttribute("id").ToString();
                        newStory.Link = reader.GetAttribute("href").ToString();
                        newStory.Diggs = reader.GetAttribute("diggs").ToString();
                        newStory.Comments = reader.GetAttribute("comments").ToString();
                        newStory.Status = reader.GetAttribute("status").ToString();
                    }
                            /*case 0: newStory.Id = reader.GetAttribute(i).ToString(); break;
                            case 5: newStory.Link = reader.GetAttribute(i).ToString();
                                newStory.Status = reader.GetAttribute(i).ToString(); break;
                            case 2: newStory.SubmitDate = reader.GetAttribute(i).ToString(); break;
                            case 3: newStory.Diggs = reader.GetAttribute(i).ToString(); break;
                            case 4: //newStory.Comments = new CommentsCollection(newStory); break;                             
                                newStory.Comments = reader.GetAttribute(i).ToString(); break;
                            case 7: newStory.CommentsUrl = reader.GetAttribute(i).ToString(); break;
                            case 6: newStory.PromoteDate = reader.GetAttribute(i).ToString(); break;
                             */
                        //}
                    //}
                }

                if (reader.Name == "title")
                {
                    newStory.Title = reader.ReadString();
                }

                if (reader.Name == "description")
                {
                    newStory.Description = reader.ReadString();
                }

                if (reader.Name == "user")
                {
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        switch (i)
                        {
                            case 0: newStory.Submitter = reader.GetAttribute(i).ToString(); break;
                            case 1: newStory.SubmitterIcon = reader.GetAttribute(i).ToString(); break;
                            case 3: newStory.SubmitterProfileViews = reader.GetAttribute(i).ToString(); break;
                        }
                    }
                }

                if (reader.Name == "topic")
                {
                    newStory.Topic = reader.GetAttribute(0).ToString();
                }

                if (reader.Name == "container")
                {
                    newStory.Container = reader.GetAttribute(0);
                    alStories.Add(newStory);
                    newStory = new Story();
                }
            }
        }

        public static List<Comment> GetComments(Story story)
        {
            List<Comment> comments = new List<Comment>();
            string url = string.Format(Globals.Base + "stories/{0}/comments?count={1}&appkey={2}", story.Id, Globals.Count, Globals.AppKey);
            XmlTextReader reader = Parser.CreateWebRequest(url);
            Comment newComment = new Comment();

            while (reader.Read())
            {
                List<string> attribs = new List<string>();
                if (reader.HasAttributes)
                {
                    for (int i = 0; i < reader.AttributeCount; i++)
                    {
                        attribs.Add(reader.GetAttribute(i).ToString());
                    }
                }

                if (reader.LocalName == "comment")
                {
                    newComment.Text = reader.ReadString();
                    newComment.Date = attribs[0];
                    newComment.Id = attribs[1];
                    newComment.Up = attribs[3];
                    newComment.Down = attribs[4];
                    newComment.Replies = attribs[5];
                    newComment.User = attribs[6];
                  
                    comments.Add(newComment);
                    newComment = new Comment();
                }
            }
            return comments;
        }

        public static List<string> GetTopics()
        {
            List<string> topics = new List<string>();
            string url = Globals.Base + "topics?appkey=" + Globals.AppKey;
            XmlTextReader reader = Parser.CreateWebRequest(url);
          
            while (reader.Read())
            {
                if (reader.Name == "topic" && reader.HasAttributes)
                {
                    topics.Add(reader.GetAttribute(0));
                }
            }
            return topics;
        }

        public static List<string> GetStoryIDsByUser(string userName)
        {
            List<string> ids = new List<string>();
            string url = Globals.Base + "user/" + userName + "/diggs?count=" + Globals.Count + "&appkey=" + Globals.AppKey;
            XmlTextReader reader = Parser.CreateWebRequest(url);

            while (reader.Read())
            {
                if (reader.Name == "digg" && reader.HasAttributes)
                {
                    ids.Add(reader.GetAttribute(1));
                }
            }
            return ids;
        }


        public static XmlTextReader CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.UserAgent = "DiggBeep";
            webRequest.Credentials = System.Net.CredentialCache.DefaultCredentials;
            webRequest.Accept = "text/xml";
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();

            System.IO.Stream responseStream = webResponse.GetResponseStream();
            XmlTextReader reader = new XmlTextReader(responseStream);
            return reader;
        }
    }
}
