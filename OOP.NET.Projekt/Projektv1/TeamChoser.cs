﻿using System;
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
using Repo.Util;

namespace Projektv1
{
    public partial class TeamChoser : Form
    {
        private bool labelAnim = true;
        IRepo RF { get; set; }
        public TeamChoser()
        {
            InitializeComponent();
        }

        List<Match> matches;

        private async void TeamChoser_Load(object sender, EventArgs e)
        {
            try
            {
                Task<List<Match>> task = new Task<List<Match>>(GetMatches);
                task.Start();
                lblTeamChoser.Text = Properties.Resources.lblTeamChoserWait;
                matches = await task;

                HashSet<Team> timovi = new HashSet<Team>();
                foreach (Match match in matches)
                {
                    Team tim_home = new Team(match.home_team_country, match.home_team.code);
                    Team tim_away = new Team(match.away_team_country, match.away_team.code);
                    timovi.Add(tim_home);
                    timovi.Add(tim_away);
                }
                foreach (var tim in timovi)
                {
                    cmbTeamChoser.Items.Add(tim);
                }
                cmbTeamChoser.Sorted = true;
                labelAnim = false;
                lblTeamChoser.ForeColor = Color.Black;
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

        private void cmbTeamChoser_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = ((Team)cmbTeamChoser.SelectedItem).country.ToString();
            string code = ((Team)cmbTeamChoser.SelectedItem).code.ToString();
            TeamDetails td = new TeamDetails(matches,country,code);
            td.Show();
            this.Close();
        }

        private void teamChoserTimer_Tick(object sender, EventArgs e)
        {
            if (labelAnim)
            {
                AnimateLabel();
            }
        }

        private void AnimateLabel()
        {
            lblTeamChoser.ForeColor = Tools.GetRandomColor();
        }
    }
}
