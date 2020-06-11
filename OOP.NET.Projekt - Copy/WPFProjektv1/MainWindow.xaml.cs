using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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
        public MainWindow()
        {
            InitializeComponent();
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

        private async void Window_Loaded (object sender, RoutedEventArgs e)
        {
           // PokreniAnimaciju();
            await DataLoad();
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
            //ZaustaviAnimaciju();
        }

        private void ZaustaviAnimaciju()
        {
            ResourceManager rm = new ResourceManager(typeof(Resources));
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
            //FindOpponents(selectedTeam);
        }

        private void FindOpponents(Team selectedTeam)
        {
            throw new NotImplementedException();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            Culture = "";
            try
            {
                Culture = AppSave.LanguageConfLoad();
                if (Culture != "")
                {
                    App.ChangeCulture(new CultureInfo(Culture));
                }
            }
            catch (FileNotFoundException)
            {
                Culture = "error";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n {ex.Message}");
            }
        }
    }
}
