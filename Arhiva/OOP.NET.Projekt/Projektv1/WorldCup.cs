using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Repo.DAL;

namespace Projektv1
{

    public partial class WorldCup : Form
    {
        public WorldCup()
        {
            InitializeComponent();
        }

        private void WorldCup_Load(object sender, EventArgs e)
        {
            string language ="";
            try
            {
                language = AppSave.LanguageConfLoad();
            }
            catch (FileNotFoundException)
            {
                language = "error";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n {ex.Message}");
            }
            pbIntro.Image = Resources.WC_Logo;
            btnEn.Visible = false;
            btnHr.Visible = false;

            if (language == "error")
            {
                btnEn.Visible = true;
                btnHr.Visible = true;
            }
            else
            {
                UpdateConfig("language", language);
                timerMain.Tick += TimerMain_Tick;
                timerMain.Interval = 500;
                timerMain.Start();
            }           
        }

        private void TimerMain_Tick(object sender, EventArgs e)
        {
            
            timerMain.Stop();
            TeamChoser teamChoser = new TeamChoser();
            teamChoser.Show();
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHr_Click(object sender, EventArgs e)
        {
            SetLanguage("hr-HR");
        }

        private void SetLanguage(string language)
        {
            UpdateConfig("language", language);
            AppSave.LanguageConfSave(language);
            Application.Restart();
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            SetLanguage("en-US");
        }

        public void UpdateConfig(string key, string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xmlElement in xmlDoc.DocumentElement)
            {
                if (xmlElement.Name.Equals("appSettings"))
                {
                    foreach (XmlNode xNode in xmlElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value.Equals(key))
                        {
                            xNode.Attributes[1].Value = value;
                        }
                    }
                }
            }
            ConfigurationManager.RefreshSection("appSettings");
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }
    }
}
