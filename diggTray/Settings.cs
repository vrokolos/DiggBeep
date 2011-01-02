using System;
using System.Configuration;
using System.Windows.Forms;

namespace diggBeep
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.AppSettings["User"] != null)
            {
                textBox1.Text = ConfigurationManager.AppSettings["User"].ToString();
                checkBox1.Checked = (System.Configuration.ConfigurationManager.AppSettings["BeepDiggs"] == "true");
                checkBox2.Checked = (System.Configuration.ConfigurationManager.AppSettings["BeepComments"] == "true");
                numericUpDown1.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["StoryCount"]);
                numericUpDown2.Value = int.Parse(System.Configuration.ConfigurationManager.AppSettings["Interval"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                System.Configuration.Configuration config =
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["User"].Value = textBox1.Text;
                if (checkBox1.Checked)
                {
                    config.AppSettings.Settings["BeepDiggs"].Value = "true";
                }
                else
                {
                    config.AppSettings.Settings["BeepDiggs"].Value = "false";
                }
                if (checkBox2.Checked)
                {
                    config.AppSettings.Settings["BeepComments"].Value = "true";
                }
                else
                {
                    config.AppSettings.Settings["BeepComments"].Value = "false";
                }
                config.AppSettings.Settings["StoryCount"].Value = numericUpDown1.Value.ToString();
                config.AppSettings.Settings["Interval"].Value = numericUpDown2.Value.ToString();

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                Close();
            }
            else
            {
                MessageBox.Show("Please insert your digg username");
            }
        }
    }
}
