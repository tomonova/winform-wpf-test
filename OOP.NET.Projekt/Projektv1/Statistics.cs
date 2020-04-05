using Repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private string code;
        private List<Match> matches;
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
            arrowList = new List<PictureBox>();
            arrowList.Add(picBoxGamesPlayed);
            arrowList.Add(picBoxGoals);
            arrowList.Add(picBoxYCards);

            LoadEvents();
            LoadTeamStat();
            LoadStat();
            LoadPanels();
        }

        private void LoadPanels()
        {
            flpPlayerStat.Controls.Clear();
            foreach (Player player in players)
            {
                PlayerStat ps = new PlayerStat(player.Name, player.YellowCards, player.Goals, player.GamesPlayed);
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
                        LoadPanels();
                    }
                    else if (order==false)
                    {
                        _gamesDesc = true;
                        picBoxGamesPlayed.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.GamesPlayed).ToList();
                        LoadPanels();
                    }
                    break;
                case Data.Goals:
                    if (order == true)
                    {
                        _goalsDesc = false;
                        picBoxGoals.Image = Resources.UpArrow;
                        players=players.OrderBy(p => p.Goals).ToList();
                        LoadPanels();
                    }
                    else if (order == false)
                    {
                        _goalsDesc = true;
                        picBoxGoals.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.Goals).ToList();
                        LoadPanels();
                    }
                    break;
                case Data.YellowCards:
                    if (order == true)
                    {
                        _yCardsDesc = false;
                        picBoxYCards.Image = Resources.UpArrow;
                        players=players.OrderBy(p => p.YellowCards).ToList();
                        LoadPanels();
                    }
                    else if (order == false)
                    {
                        _yCardsDesc = true;
                        picBoxYCards.Image = Resources.DownArrow;
                        players=players.OrderBy(p => -p.YellowCards).ToList();
                        LoadPanels();
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
    }
}
