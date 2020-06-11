using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Repo.DAL;
using Repo.Models;
using WPFProjektv1.Properties;

namespace WPFProjektv1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Culture { get; set; }
        IRepo RF { get; set; }
        List<Match> matches;
        HashSet<Team> timovi;
        Team selectedTeam;
        private string chosenTeam;
        private HashSet<Team> chosenTeams;
        ResourceManager rm;
        string size = "minimum";


        public MainWindow()
        {
            InitializeComponent();
            rm = new ResourceManager(typeof(Resources));    
        }


        private void btnCro_Click(object sender, RoutedEventArgs e)
        {
            Culture = "hr-HR";
            App.ChangeCulture(new CultureInfo(Culture));
            AppSave.LanguageConfSave(Culture);
        }

        private void btnEng_Click(object sender, RoutedEventArgs e)
        {
            Culture = "en-US";
            App.ChangeCulture(new CultureInfo(Culture));
            AppSave.LanguageConfSave(Culture);
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            size = AppSave.SizeConfLoad();
            SetSize(size);
            PokreniAnimaciju();
            await DataLoad();
        }

        private void SetSize(string size)
        {
            switch (size)
            {
                case "minimum":
                    setMinimum();
                    break;
                case "medium":
                    setMedium();
                    break;
                case "fullscreen":
                    setFullScreen();
                    break;
                default:
                    break;
            };
        }

        private async Task DataLoad()
        {
            try
            {
                Task<List<Match>> task = new Task<List<Match>>(GetMatches);
                task.Start();
                matches = await task;
                LoadTeams();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PokreniAnimaciju()
        {
            btnStory.Begin();
        }

        private void LoadTeams()
        {
            timovi = new HashSet<Team>();
            foreach (Match match in matches)
            {
                Team tim_home = new Team(match.home_team_country, match.home_team.code);
                Team tim_away = new Team(match.away_team_country, match.away_team.code);
                timovi.Add(tim_home);
                timovi.Add(tim_away);
            }
            foreach (var tim in timovi)
            {
                cmbHomeTeam.Items.Add(tim);
            }
            ZaustaviAnimaciju();
        }

        private void ZaustaviAnimaciju()
        {

            btnStory.Stop();
            lblPleaseWait.Content = rm.GetString("MainWindow.Label_PleaseWat_Loaded");
        }

        private List<Match> GetMatches()
        {
            RF = RepoFactory.GetRepo();
            List<Match> matches = RF.GetMatches();
            return matches;
        }

        private void cmbHomeTeam_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedTeam = (Team)cmbHomeTeam.SelectedItem;
            removeEntriesOpponent();
            FindOpponents(selectedTeam);
        }

        private void removeEntriesOpponent()
        {
            cmbAwayTeam.Items.Clear();
        }

        private void FindOpponents(Team selectedTeam)
        {
            chosenTeam = cmbHomeTeam.SelectedValue.ToString().Split().Last();
            FindAwayTeams(chosenTeam);
        }

        private void FindAwayTeams(string chosenTeam)
        {
            chosenTeams = new HashSet<Team>();
            LoadMatches(chosenTeam);
        }

        private void LoadMatches(string chosenTeam)
        {
            foreach (Match match in matches)
            {
                if (match.home_team.code == chosenTeam || match.away_team.code == chosenTeam)
                {
                    Match specificMatch = new Match();
                    Team homeTeam = new Team();
                    Team awayTeam = new Team();
                    homeTeam.country = match.home_team.country;
                    homeTeam.code = match.home_team.code;
                    awayTeam.country = match.away_team.country;
                    awayTeam.code = match.away_team.code;
                    if (homeTeam.country != chosenTeam || awayTeam.country != chosenTeam)
                    {
                        chosenTeams.Add(homeTeam);
                        chosenTeams.Add(awayTeam);
                    }

                }
            }
            foreach (Team team in chosenTeams)
            {
                if (team.code != chosenTeam)
                {
                    cmbAwayTeam.Items.Add(team);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbAwayTeam.Text) || string.IsNullOrEmpty(cmbHomeTeam.Text))
            {
                MessageBox.Show(rm.GetString("MainWindow.TeamsNotChosenMessage"));
                return;
            }
            string chosenOpponent = cmbAwayTeam.SelectedItem.ToString().Split().Last();
            MatchWindow mw = new MatchWindow(matches, chosenTeam, chosenOpponent);
            mw.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            setMinimum();
        }

        private void setMinimum()
        {
            mainWindow.WindowState = WindowState.Normal;
            mainWindow.Width = 835;
            mainWindow.Height = 575;
            btnBall.Width = 50;
            btnBall.Height = 50;
            btnCro.Width = 40;
            btnCro.Height = 36;
            btnEng.Width = 40;
            btnEng.Height = 35;
            btnEng.Margin = new Thickness(0, 10, 70, 0);
            string size = "minimum";
            CenterWindowOnScreen();
            AppSave.ScreenSave(size);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            setMedium();
        }

        private void setMedium()
        {
            mainWindow.WindowState = WindowState.Normal;
            mainWindow.Width = 1024;
            mainWindow.Height = 768;
            btnBall.Width = 75;
            btnBall.Height = 75;
            btnCro.Width = 70;
            btnCro.Height = 62;
            btnEng.Width = 70;
            btnEng.Height = 62;
            btnEng.Margin = new Thickness(0, 10, 115, 0);
            string size = "medium"; CenterWindowOnScreen();
            AppSave.ScreenSave(size);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            setFullScreen();
        }

        private void setFullScreen()
        {
            mainWindow.WindowState = WindowState.Maximized;
            btnBall.Width = 120;
            btnBall.Height = 120;
            btnCro.Width = 95;
            btnCro.Height = 85;
            btnEng.Width = 95;
            btnEng.Height = 85;
            btnEng.Margin = new Thickness(0, 10, 180, 0);
            string size = "fullscreen";
            AppSave.ScreenSave(size);
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
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            DialogBox db = new DialogBox();
            db.ShowDialog();
            if (db.DialogResult==true)
            {
                this.Close();
            }
        }
    }
}
