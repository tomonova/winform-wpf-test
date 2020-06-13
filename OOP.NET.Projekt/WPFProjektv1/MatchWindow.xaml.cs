using Repo.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFProjektv1
{    public partial class MatchWindow : Window
    {
        public List<Match> Matches { get; set; }
        private List<Player> homePlayers { get; set; }
        private List<Player> awayPlayers { get; set; }
        private HashSet<Ivent> Ivents { get; set; }
        public string ChosenTeam { get; set; }
        public string ChosenOpponent { get; set; }
        public Match ChosenMatch { get; set; }
        private int homeTeamGoalsScored { get; set; }
        private int homeTeamGoalsReceived { get; set; }
        private int awayTeamGoalsScored { get; set; }
        private int awayTeamGoalsReceived { get; set; }
        private int homeTeamWins { get; set; }
        private int homeTeamLoses { get; set; }
        private int homeTeamDraws { get; set; }
        private int awayTeamWins { get; set; }
        private int awayTeamLoses { get; set; }
        private int awayTeamDraws { get; set; }
        private string size;
        public MatchWindow()
        {
            InitializeComponent();
        }
        public MatchWindow(List<Match> matches, string chosenTeam, string chosenOpponent,string size)
        {
            this.size = size;
            homePlayers = new List<Player>();
            awayPlayers = new List<Player>();
            Ivents = new HashSet<Ivent>();
            InitializeComponent();
            Matches = matches;
            ChosenTeam = chosenTeam;
            ChosenOpponent = chosenOpponent;
        }
        private void Match_Loaded(object sender, RoutedEventArgs e)
        {
            if (!FindMatch())
            {
                MessageBox.Show($"something went wrong \n" +
                 $"{ChosenTeam} vs {ChosenOpponent} does not exist");
                return;
            }
            SetSize();
            LoadEvents();
            FillStats();
            FillField();
        }

        private void SetSize()
        {
            switch (size)
            {
                case "minimum":
                    this.Width = 1024;
                    this.Height = 768;
                    CenterWindowOnScreen();
                    break;
                case "medium":
                    this.Width = 1400;
                    this.Height = 900;
                    CenterWindowOnScreen();
                    break;
                case "fullscreen":
                    this.WindowState = WindowState.Maximized;
                    break;
                default:
                    break;
            }
        }

        private void FillField()
        {
            homePlayers = getPlayers("home");
            awayPlayers = getPlayers("away");
            LoadEvents();
            LoadPlayerStat();
            positionTeams();
        }


        private void positionTeams()
        {
            foreach (Player player in homePlayers)
            {
                PlayerUC pUC = new PlayerUC(player);
                setSize(pUC);
                if (player.position == Player.Position.Midfield)
                {
                    HomeMidfield.Children.Add(pUC);
                }
                else if (player.position == Player.Position.Defender)
                {
                    HomeDefense.Children.Add(pUC);
                }
                else if (player.position == Player.Position.Forward)
                {
                    HomeForward.Children.Add(pUC);
                }
                else if(player.position == Player.Position.Goalie)
                {
                    HomeGoalie.Children.Add(pUC);
                }
            }
            foreach (Player player in awayPlayers)
            {
                PlayerUC pUC = new PlayerUC(player);
                setSize(pUC);
                if (player.position == Player.Position.Midfield)
                {
                    AwayMidfield.Children.Add(pUC);
                }
                else if (player.position == Player.Position.Defender)
                {
                    AwayDefense.Children.Add(pUC);
                }
                else if (player.position == Player.Position.Forward)
                {
                    AwayForward.Children.Add(pUC);
                }
                else if (player.position == Player.Position.Goalie)
                {
                    AwayGoalie.Children.Add(pUC);
                }
            }
        }

        private void setSize(PlayerUC pUC)
        {
            switch (size)
            {
                case "medium":
                    pUC.Width = 85;
                    pUC.Height = 95;
                    pUC.imgPlayer.Width = 85;
                    pUC.imgPlayer.Height = 95;
                    pUC.Margin = new Thickness(5, 15, 5, 15);
                    break;
                case "fullscreen":
                    pUC.Width = 105;
                    pUC.Height = 115;
                    pUC.imgPlayer.Width = 110;
                    pUC.imgPlayer.Height = 120;
                    pUC.Margin = new Thickness(5, 25, 5, 25);
                    break;
                default:
                    break;
            }
        }

        private List<Player> getPlayers(string team)
        {
            List<Player> players = new List<Player>();
            if (team == "home")
            {
                foreach (var item in ChosenMatch.home_team_statistics.starting_eleven)
                {
                    players.Add(new Player
                    {
                        Name = item.name,
                        Captain = item.captain,
                        position = dohvatiPozicju(item.position),
                        ShirtNumber = item.shirt_number
                    });
                }
            }
            if (team == "away")
            {
                foreach (var item in ChosenMatch.away_team_statistics.starting_eleven)
                {
                    players.Add(new Player
                    {
                        Name = item.name,
                        Captain = item.captain,
                        position = dohvatiPozicju(item.position),
                        ShirtNumber = item.shirt_number
                    });
                }
            }
            return players;
        }
        private void LoadEvents()
        {
            foreach (Match match in Matches)
            {
                if (match.home_team.country == ChosenMatch.home_team_country)
                {
                    foreach (var item in match.home_team_events)
                    {
                        Ivents.Add(new Ivent(item.player, item.type_of_event,item.time));
                    }
                }
                if (match.away_team_country == ChosenMatch.home_team_country)
                {
                    foreach (var item in match.away_team_events)
                    {
                        Ivents.Add(new Ivent(item.player, item.type_of_event, item.time));
                    }
                }
                if (match.home_team.country == ChosenMatch.away_team_country)
                {
                    foreach (var item in match.home_team_events)
                    {
                        Ivents.Add(new Ivent(item.player, item.type_of_event, item.time));
                    }
                }
                if (match.away_team_country == ChosenMatch.away_team_country)
                {
                    foreach (var item in match.away_team_events)
                    {
                        Ivents.Add(new Ivent(item.player, item.type_of_event, item.time));
                    }
                }
            }
        }
        private void LoadPlayerStat()
        {
            foreach (Ivent ivent in Ivents)
            {
                if (ivent.type_of_event == "goal" || ivent.type_of_event == "goal-penalty")
                {
                    string playername = ivent.player;
                    foreach (Player player in homePlayers)
                    {
                        if (player.Name == playername)
                        {
                            player.Goals = 1;
                        }
                    }
                    foreach (Player player in awayPlayers)
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
                    foreach (Player player in homePlayers)
                    {
                        if (player.Name == playername)
                        {
                            player.YellowCards = 1;
                        }
                    }
                    foreach (Player player in awayPlayers)
                    {
                        if (player.Name == playername)
                        {
                            player.YellowCards = 1;
                        }
                    }
                }
            }
        }
        private Player.Position dohvatiPozicju(string position)
        {
            Player.Position realPosition;
            if (Enum.TryParse(position, out realPosition))
            {
                ;
            }
            else
                realPosition = Player.Position.Unknown;

            return realPosition;
        }

        private bool FindMatch()
        {
            foreach (Match match in Matches)
            {
                if ((match.home_team.code == ChosenTeam || match.home_team.code == ChosenOpponent)
                    && (match.away_team.code == ChosenTeam || match.away_team.code == ChosenOpponent))
                {
                    ChosenMatch = new Match
                    {
                        home_team_country = match.home_team_country,
                        away_team_country = match.away_team_country,
                        home_team = match.home_team,
                        away_team = match.away_team,
                        home_team_events = new List<HomeTeamEvent>(match.home_team_events),
                        away_team_events = new List<AwayTeamEvent>(match.away_team_events),
                        home_team_statistics = match.home_team_statistics,
                        away_team_statistics = match.away_team_statistics
                    };
                    return true;
                }
            }
            return false;
        }

        private void FillStats()
        {
            fillTeams();
            fillTeamStats();
        }

        private void fillTeamStats()
        {
            GetStatsHome(ChosenMatch.home_team.code);
            GetStatsAway(ChosenMatch.away_team.code);
        }

        private void GetStatsHome(string team)
        {
            homeTeamDraws = 0;
            homeTeamGoalsReceived = 0;
            homeTeamGoalsScored = 0;
            homeTeamLoses = 0;
            homeTeamWins = 0;

            foreach (Match match in Matches)
            {
                if (match.home_team.code == team)
                {
                    if (match.home_team.goals > match.away_team.goals)
                    {
                        homeTeamWins++;
                    }
                    else if (match.home_team.goals < match.away_team.goals)
                    {
                        homeTeamLoses++;
                    }
                    else
                    {
                        homeTeamDraws++;
                    }
                    homeTeamGoalsScored += match.home_team.goals;
                    homeTeamGoalsReceived += match.away_team.goals;
                }

                if (match.away_team.code == team)
                {
                    if (match.away_team.goals > match.away_team.goals)
                    {
                        homeTeamWins++;
                    }
                    else if (match.away_team.goals < match.home_team.goals)
                    {
                        homeTeamLoses++;
                    }
                    else
                    {
                        homeTeamDraws++;
                    }
                    homeTeamGoalsScored += match.away_team.goals;
                    homeTeamGoalsReceived += match.home_team.goals;
                }
            }
            lblHomeTeamDifference.Content = $"{homeTeamGoalsScored - homeTeamGoalsReceived}";
            lblHomeTeamDraw.Content = $"{homeTeamDraws}";
            lblHomeTeamLoses.Content = $"{homeTeamLoses}";
            lblHomeTeamWins.Content = $"{homeTeamWins}";
            lblHomeTeamMatches.Content = $"{homeTeamDraws + homeTeamLoses + homeTeamWins}";
            lblHomeTeamScored.Content = $"{homeTeamGoalsScored}";
            lblHomeTeamReceived.Content = $"{homeTeamGoalsReceived}";
        }
        private void GetStatsAway(string team)
        {
            awayTeamDraws = 0;
            awayTeamGoalsReceived = 0;
            awayTeamGoalsScored = 0;
            awayTeamLoses = 0;
            awayTeamWins = 0;

            foreach (Match match in Matches)
            {
                if (match.home_team.code == team)
                {
                    if (match.home_team.goals > match.away_team.goals)
                    {
                        awayTeamWins++;
                    }
                    else if (match.home_team.goals < match.away_team.goals)
                    {
                        awayTeamLoses++;
                    }
                    else
                    {
                        awayTeamDraws++;
                    }
                    awayTeamGoalsScored += match.home_team.goals;
                    awayTeamGoalsReceived += match.away_team.goals;
                }

                if (match.away_team.code == team)
                {
                    if (match.away_team.goals > match.away_team.goals)
                    {
                        awayTeamWins++;
                    }
                    else if (match.away_team.goals < match.home_team.goals)
                    {
                        awayTeamLoses++;
                    }
                    else
                    {
                        awayTeamDraws++;
                    }
                    awayTeamGoalsScored += match.away_team.goals;
                    awayTeamGoalsReceived += match.home_team.goals;
                }
            }
            lblAwayTeamDifference.Content = $"{awayTeamGoalsScored - awayTeamGoalsReceived}";
            lblAwayTeamDraw.Content = $"{awayTeamDraws}";
            lblAwayTeamLoses.Content = $"{awayTeamLoses}";
            lblAwayTeamWins.Content = $"{awayTeamWins}";
            lblAwayTeamMatches.Content = $"{awayTeamDraws + awayTeamLoses + awayTeamWins}";
            lblAwayTeamScored.Content = $"{awayTeamGoalsScored}";
            lblAwayTeamReceived.Content = $"{awayTeamGoalsReceived}";
        }
        private void fillTeams()
        {
            lblHomeCountry.Content = $"{ChosenMatch.home_team_country} {ChosenMatch.home_team.code}";
            lblAwayCountry.Content = $"{ChosenMatch.away_team_country} {ChosenMatch.away_team.code}";
            imgHome.Source = new BitmapImage(new Uri($"Images/{ChosenMatch.home_team.code}.png", UriKind.Relative));
            imgAway.Source = new BitmapImage(new Uri($"Images/{ChosenMatch.away_team.code}.png", UriKind.Relative));
        }
        private void CenterWindowOnScreen()
        {
            double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
            double screenHeight = System.Windows.SystemParameters.PrimaryScreenHeight;
            double windowWidth = this.Width;
            double windowHeight = this.Height;
            this.Left = (screenWidth / 2) - (windowWidth / 2);
            this.Top = (screenHeight / 2) - (windowHeight / 2);
        }
    }
}
