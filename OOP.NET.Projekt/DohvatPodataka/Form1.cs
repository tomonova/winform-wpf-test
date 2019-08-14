using Repo.DAL;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DohvatPodataka
{
    public partial class Form1 : Form
    {
        IRepo RF { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Task<List<Match>> task = new Task<List<Match>>(GetMatches);
                task.Start();
                lblLoadingStatus.Text = "Loading please wait....";
                List<Match> matches = await task;
                foreach (Match match in matches)
                {
                    if (!(comboBox1.Items.Contains(match.home_team_country) || comboBox1.Items.Contains(match.away_team_country)))
                    {
                        comboBox1.Items.Add(match.home_team_country);
                        comboBox1.Items.Add(match.away_team_country);
                    }
                }
                comboBox1.Sorted = true;
                lblLoadingStatus.Text = "Repke učitane";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private List<Match> GetMatches()
        {
            RF = RepoFactory.GetRepo();
            List<Match> matches = RF.GetMatches();
            Thread.Sleep(5000);
            return matches;
        }
    }
}
