﻿using Repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektv1
{
    public partial class Statistics : Form
    {
        public enum Data
        {
            GamesPlayed,
            Goals,
            YellowCards
        }

        private string country;
        private List<Match> matches;
        private List<Match> chosenMatches;
        private List<Player> players;
        private List<Ivent> ivents;
        private List<TeamStatistics> teamStat;
        private bool _gamesDesc = true;
        private bool _goalsDesc = true;
        private bool _yCardsDesc = true;
        List<PictureBox> arrowList;
        


        public Statistics(List<Player> players,List<Match> matches,string country)
        {
            InitializeComponent();
            this.matches = matches;
            this.players = players;
            this.country = country;

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            ivents = new List<Ivent>();
            teamStat = new List<TeamStatistics>();
            chosenMatches = new List<Match>();
            arrowList = new List<PictureBox>();
            arrowList.Add(picBoxGamesPlayed);
            arrowList.Add(picBoxGoals);
            arrowList.Add(picBoxYCards);

            LoadEvents();
            LoadTeamStat();
            LoadStat();
            LoadStatPanels();
            LoadMatches();
            LoadMatchPanels();

        }


        private void LoadMatches()
        {
            foreach (Match match in matches)
            {
                if (match.home_team_country==country || match.away_team_country==country)
                {
                    Match specificMatch = new Match();
                    HomeTeam ht = new HomeTeam();
                    AwayTeam at = new AwayTeam();
                    ht.country = match.home_team.country;
                    ht.code = match.home_team.code;
                    at.country= match.away_team.country;
                    at.code= match.away_team.code;
                    specificMatch.venue = match.venue;
                    specificMatch.attendance = match.attendance;
                    ht.goals = match.home_team.goals;
                    at.goals = match.away_team.goals;
                    specificMatch.home_team = ht;
                    specificMatch.away_team = at;
                    chosenMatches.Add(specificMatch);
                }
            }
        }
        private void LoadMatchPanels()
        {
            chosenMatches = chosenMatches.OrderByDescending(m => m.attendance).ToList();
            foreach (Match match in chosenMatches)
            {
                MatchStat ms = new MatchStat(match.home_team.code, match.home_team.country,
                    match.away_team.code, match.away_team.country,
                    match.venue, match.home_team.goals,
                    match.away_team.goals, Convert.ToInt32( match.attendance));
                    flpMatches.Controls.Add(ms);
            }
        }


        private void LoadStatPanels()
        {
            flpPlayerStat.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerStat ps = new PlayerStat(player.Name, player.YellowCards, player.Goals, player.GamesPlayed,player.ProfilePic);
                flpPlayerStat.Controls.Add(ps);
            }
        }

        private void LoadTeamStat()
        {
            foreach (Match match in matches)
            {
                if (match.home_team.country == country)
                {
                    foreach (var item in match.home_team_statistics.starting_eleven)
                    {
                        string playername = item.name;
                        players.Find(p => p.Name == playername).GamesPlayed = 1;
                    }
                }
                if (match.away_team_country == country)
                {
                    foreach (var item in match.away_team_statistics.starting_eleven)
                    {
                        string playername = item.name;
                        players.Find(p => p.Name.Equals(playername)).GamesPlayed = 1;
                    }
                }
            }
        }

        private void LoadStat()
        {
            foreach (Ivent ivent in ivents)
            {
                if (ivent.type_of_event == "goal" || ivent.type_of_event == "goal-penalty")
                {
                    string playername = ivent.player;
                    foreach (Player player in players)
                    {
                        if (player.Name == playername)
                        {
                            player.Goals = 1;
                        }
                    }

                }
                else if (ivent.type_of_event == "yellow-card" || ivent.type_of_event == "yellow-card-second")
                {
                    string playername = ivent.player;
                    foreach (Player player in players)
                    {
                        if (player.Name == playername)
                        {
                            player.YellowCards = 1;
                        }
                    }
                }
                if (ivent.type_of_event == "substitution-in")
                {
                    string playername = ivent.player;
                    foreach (Player player in players)
                    {
                        if (player.Name == playername)
                        {
                            player.GamesPlayed = 1;
                        }
                    }
                }
            }
        }

        private void LoadEvents()
        {
            foreach (Match match in matches)
            {
                if (match.home_team.country == country)
                {
                    foreach (var item in match.home_team_events)
                    {
                        ivents.Add(new Ivent(item.player, item.type_of_event));
                    }
                }
                if (match.away_team_country == country)
                {
                    foreach (var item in match.away_team_events)
                    {
                        ivents.Add(new Ivent(item.player, item.type_of_event));
                    }
                }
            }
        }

        private void btnGamesPlayed_Click(object sender, EventArgs e)
        {
            
            Sortiraj(Data.GamesPlayed, _gamesDesc);
        }
        private void btnGoals_Click(object sender, EventArgs e)
        {
            Sortiraj(Data.Goals, _goalsDesc);
        }

        private void btnYellowCards_Click(object sender, EventArgs e)
        {
            Sortiraj(Data.YellowCards, _yCardsDesc);
        }

        private void Sortiraj(Data type, bool order)
        {
            ObrisiStrelice();
            switch (type)
            {
                case Data.GamesPlayed:
                    if (order==true)
                    {
                        _gamesDesc = false;
                        picBoxGamesPlayed.Image = Resources.UpArrow;
                        players=players.OrderBy(p => p.GamesPlayed).ToList();
                        LoadStatPanels();
                    }
                    else if (order==false)
                    {
                        _gamesDesc = true;
                        picBoxGamesPlayed.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.GamesPlayed).ToList();
                        LoadStatPanels();
                    }
                    break;
                case Data.Goals:
                    if (order == true)
                    {
                        _goalsDesc = false;
                        picBoxGoals.Image = Resources.UpArrow;
                        players=players.OrderBy(p => p.Goals).ToList();
                        LoadStatPanels();
                    }
                    else if (order == false)
                    {
                        _goalsDesc = true;
                        picBoxGoals.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.Goals).ToList();
                        LoadStatPanels();
                    }
                    break;
                case Data.YellowCards:
                    if (order == true)
                    {
                        _yCardsDesc = false;
                        picBoxYCards.Image = Resources.UpArrow;
                        players=players.OrderBy(p => p.YellowCards).ToList();
                        LoadStatPanels();
                    }
                    else if (order == false)
                    {
                        _yCardsDesc = true;
                        picBoxYCards.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.YellowCards).ToList();
                        LoadStatPanels();
                    }
                    break;
                default:
                    break;
            }
        }

        private void ObrisiStrelice()
        {
            foreach (var item in arrowList)
            {
                item.Image = null;
            }

        }

        private void btnGamesPlayed_MouseEnter(object sender, EventArgs e)
        {
            btnGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, 
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), 
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnGamesPlayed_MouseLeave(object sender, EventArgs e)
        {
            btnGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, 
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnGoals_MouseEnter(object sender, EventArgs e)
        {
            btnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, 
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), 
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnGoals_MouseLeave(object sender, EventArgs e)
        {
            btnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnYellowCards_MouseEnter(object sender, EventArgs e)
        {
            btnYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F,
                ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))),
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        private void btnYellowCards_MouseLeave(object sender, EventArgs e)
        {
            btnYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        }

        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            Graphics g = CreateGraphics();
            bmp = new Bitmap(Size.Width+200,Size.Height+200,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(Location.X, Location.Y,0,0,Size);
            pageSetupDialog1.Document.DefaultPageSettings.Landscape = true;
            pageSetupDialog1.Document.DefaultPageSettings.PaperSize = new PaperSize("A3", 1170, 1270);
            if (printDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnPrint.Visible = true;
                }
            }
            
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void printDocument1_EndPrint(object sender, PrintEventArgs e)
        {
            MessageBox.Show($"{Properties.Resources.endPrintInfo}");
            btnPrint.Visible = true;
        }
    }
}
