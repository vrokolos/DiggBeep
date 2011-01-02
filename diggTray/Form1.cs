using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.Windows.Forms;
using Baileysoft.Rss.DiggAPI;

namespace diggBeep
{
    public partial class Form1 : Form
    {
        public static int sndtimes = 0;
        public static int sndcmnttimes = 0;
        public bool beepdiggs = false;
        public bool beepcomments = false;
        public string theUser = "TalSiach";
        public BindingList<Story> otherStories;
        SoundPlayer myPlayer = new SoundPlayer();
        public StoryCollection lastStories;
        public BindingList<MyStory> Stories = new BindingList<MyStory>();
        public Form1()
        {
            InitializeComponent();
            Globals.Count = "25";
            Globals.AppKey = "http://apidoc.digg.com";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Stories != null) { Stories.Clear(); }
            int deskHeight = Screen.PrimaryScreen.Bounds.Height;
            int deskWidth = Screen.PrimaryScreen.Bounds.Width;
            Location = new System.Drawing.Point(deskWidth - Width - 2, deskHeight - Height - 50);
            theUser = System.Configuration.ConfigurationManager.AppSettings["User"];
            beepdiggs = (System.Configuration.ConfigurationManager.AppSettings["BeepDiggs"] == "true");
            beepcomments = (System.Configuration.ConfigurationManager.AppSettings["BeepComments"] == "true");
            Globals.Count = System.Configuration.ConfigurationManager.AppSettings["StoryCount"];
            timer1.Interval = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Interval"].ToString()) * 1000;
            lnkUser.Text = theUser;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = Stories;
            label1.Text = "Getting stories...";
            backgroundWorker1.RunWorkerAsync();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void getStories(string User)
        {
            bool needtoadd = false;
            bool movefirst = false;
            if (lastStories != null)
            {
                foreach (Story s in lastStories)
                {
                    MyStory g = MyStory.findById(s.Id);
                    if (g == null)
                    {
                        needtoadd = true;
                        g = new MyStory(s.Id);
                    }
                    else
                    {
                        g = MyStory.findById(s.Id);

                    }
                    if ((s.Diggs != null) || (s.Diggs != ""))
                    {
                        if (!needtoadd)
                        {
                            if (g.Diggs != int.Parse(s.Diggs))
                            {
                                Stories.Remove(g);
                                Stories.Insert(0, g);
                                movefirst = true;
                                int diff = (int.Parse(s.Diggs) - g.Diggs);
                                if (diff < 0) { diff = 0; }
                                sndtimes += diff;
                                if (!playsndwrkr.IsBusy)
                                {
                                    playsndwrkr.RunWorkerAsync();
                                }
                            }
                        }
                        g.Diggs = int.Parse(s.Diggs);
                    }
                    g.Description = s.Description;
                    g.Title = s.Title;
                    g.Status = s.Status;
                    if (s.Comments != null)
                    {
                        if (!needtoadd)
                        {
                            if (g.TotalComments != int.Parse(s.Comments))
                            {
                                Stories.Remove(g);
                                Stories.Insert(0, g);
                                movefirst = true;
                                int diff = (int.Parse(s.Comments) - g.TotalComments);
                                if (diff < 0) { diff = 0; }
                                sndcmnttimes += diff;
                                if (!playsndcmntwrkr.IsBusy)
                                {
                                    playsndcmntwrkr.RunWorkerAsync();
                                }
                            }
                        }
                        g.TotalComments = int.Parse(s.Comments);
                    }
                    g.Link = s.Link;
                    if (needtoadd)
                    {
                        if (movefirst)
                        {
                            Stories.Insert(0, g);
                        }
                        else
                        {
                            Stories.Add(g);
                        }
                    }
                }
            }
            else
            {
                label1.Text = "No stories! Check settings!";
            }
        }

        private void getCatStories(string Category)
        {
/*            //StoryCollection tmp = new StoryCollection(ArticleType.popular, User);
            foreach (Story s in tmp)
            {
                MyStory g = MyStory.findById(s.Id);
                if (g == null)
                {
                    //needtoadd = true;
                    g = new MyStory(s.Id);
                }
                else
                {
                    g = MyStory.findById(s.Id);
                }
                if ((s.Diggs != null) || (s.Diggs != "")) { g.Diggs = int.Parse(s.Diggs); }
                g.Description = s.Description;
                g.Title = s.Title;
                if (s.Comments != null) { g.TotalComments = s.Comments.Count; }
                g.Link = s.Status;
//                if (needtoadd)
//                {
//                    Stories.Add(g);
//                }
            }*/
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
//                dataG = ((MyStory)dataGridView1.CurrentRow.DataBoundItem).Description;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if ((((MyStory)dataGridView1.CurrentRow.DataBoundItem).Link != null) || (((MyStory)dataGridView1.CurrentRow.DataBoundItem).Link != ""))
                {
                    System.Diagnostics.Process.Start(((MyStory)dataGridView1.CurrentRow.DataBoundItem).Link);
                }
            }
        }

        private void lnkUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.digg.com/users/" + theUser);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*linkLabel2.BackColor = panel1.BackColor;
            linkLabel3.BackColor = panel1.BackColor;
            linkLabel4.BackColor = panel1.BackColor;
            linkLabel5.BackColor = panel1.BackColor;
            linkLabel7.BackColor = panel1.BackColor;
            linkLabel8.BackColor = panel1.BackColor;
            linkLabel9.BackColor = panel1.BackColor;
            linkLabel10.BackColor = panel1.BackColor;
            linkLabel11.BackColor = panel1.BackColor;
            (sender as LinkLabel).BackColor = panel2.BackColor;*/
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                lastStories = new StoryCollection(ArticleType.byUserSubmissions, theUser);
            }
            catch { lastStories = null;
            backgroundWorker1.CancelAsync();
            }
        }

        private void playsndwrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            if (beepdiggs)
            {
                while (sndtimes != 0)
                {
                    myPlayer.SoundLocation = @"digg.wav";
                    myPlayer.PlaySync();
                    sndtimes--;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            getStories(theUser);
            if ((lastStories != null) && (lastStories.Count > 0)) { label1.Text = ""; }
            else { label1.Text = "No stories! Check settings!"; }
        }

        private void playsndcmntwrkr_DoWork(object sender, DoWorkEventArgs e)
        {
            if (beepcomments)
            {
                while (sndcmnttimes != 0)
                {
                    myPlayer.SoundLocation = @"comment.wav";
                    myPlayer.PlaySync();
                    sndcmnttimes--;
                }
            }
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            (new Settings()).ShowDialog();
            
            Form1_Load(null, null);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://digg.com/software/DiggBeep_1_10_Listen_to_your_stories");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

        }

        private void dataGridView1_DataMemberChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (((MyStory)dataGridView1.Rows[e.RowIndex].DataBoundItem).Status.ToLower() != "upcoming")
            {
                System.Drawing.Color g =
                System.Drawing.Color.FromArgb(198, 223, 233);
                
                System.Drawing.Color k =
                System.Drawing.Color.FromArgb(16, 92, 191);
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = g;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = k;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }

    public class MyStory
    {
        private static Dictionary<string, MyStory> allStories = new Dictionary<string, MyStory>();
        public MyStory(string cStoryId)
        {
            StoryId = cStoryId;
            allStories[StoryId] = this;
        }
        public string StoryId { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public int Diggs { get; set; }
        public int Burrys { get; set; }
        public int TotalComments { get; set; }
        public string Link { get; set; }
        public string Status { get; set; }
        public static MyStory findById(string id)
        {
            if (allStories.ContainsKey(id))
            {
                return allStories[id];
            }
            else { return null; }
        }
    }
}
