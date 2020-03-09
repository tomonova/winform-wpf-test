using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using Repo.DAL;
using Repo.Models;

namespace Projektv1
{
    public partial class TeamChoser : Form
    {
        IRepo RF { get; set; }
        public TeamChoser()
        {
            InitializeComponent();
        }

        private async void TeamChoser_Load(object sender, EventArgs e)
        {
            try
            {
                Task<List<Match>> task = new Task<List<Match>>(GetMatches);
                task.Start();
                lblTeamChoser.Text = Properties.Resources.lblTeamChoserWait;
                List<Match> matches = await task;
                foreach (Match match in matches)
                {
                    if (!(cmbTeamChoser.Items.Contains(match.home_team_country) || cmbTeamChoser.Items.Contains(match.away_team_country)))
                    {
                        cmbTeamChoser.Items.Add(match.home_team_country);
                        cmbTeamChoser.Items.Add(match.away_team_country);
                    }
                }
                cmbTeamChoser.Sorted = true;
                lblTeamChoser.Text = Properties.Resources.lblTeamChoserChose;
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
            return matches;
        }
    }
}
