using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Repo.DAL;
using Repo.Models;


namespace Projektv1
{
    public partial class TeamDetails : Form
    {
        List<Match> matches;
        List<Player> playersList;
        HashSet<Team> teams;
        Team savedTeam; 
        string Country;
        string Code;
        private PlayerShort _odabraniPS;
        private readonly int FAVORITE_NUM = 3;

        public TeamDetails(List<Match> matches,string country,string code,HashSet<Team> timovi,Team savedTeam)
        {
            InitializeComponent();
            Country = country;
            Code = code;
            teams = timovi;
            this.matches = matches;
            this.savedTeam = savedTeam;
        }


        private void btnStatistika_MouseHover(object sender, EventArgs e)
        {
            btnStatistika.BackColor = Color.White;
            btnStatistika.ForeColor = Color.Red;
        }

        private void btnStatistika_MouseLeave(object sender, EventArgs e)
        {
            btnStatistika.BackColor = Color.Red;
            btnStatistika.ForeColor = Color.White;
        }

        private void btnStatistika_MouseEnter(object sender, EventArgs e)
        {
            btnStatistika.BackColor = Color.White;
            btnStatistika.ForeColor = Color.Red;
        }

        private void TeamDetails_Load(object sender, EventArgs e)
        {
            UcitajIgrace();
            PrikaziIgrace();
            _odabraniPS = null;
        }

        private void SaveTeam()
        {

            savedTeam.Players.Clear(); 
            foreach (PlayerShort item in flpFavorites.Controls)
            {
                Player testniplayer = new Player(Country, Code, item.PlayerName,item.Favorite);
                savedTeam.Players.Add(testniplayer);
                savedTeam.country = testniplayer.country;
                savedTeam.code = testniplayer.code;
            }
            try
            {
                Repo.DAL.AppSave.TeamSave(savedTeam);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void PrikaziIgrace()
        {
            foreach (var player in playersList)
            {
                PlayerShort ps = new PlayerShort(player.Name,player.Captain,player.ShirtNumber,player.position,player.Favorite);
                ps.MouseDown += Ps_MouseDown;
                ps.Favoriziranje += OnFavoriziranje;
                if (savedTeam.Players!=null)
                {
                    foreach (Player savedPlayer in savedTeam.Players)
                    {
                        if (savedPlayer.Name == ps.PlayerName)
                        {
                            ps.Favorite = true;
                        }
                    } 
                }
                if (ps.Favorite)
                    flpFavorites.Controls.Add(ps);
                else
                {
                    flpTeam.Controls.Add(ps);
                }
            }
        }

        private void Ps_MouseDown(object sender, MouseEventArgs e)
        {
            PlayerShort ps = sender as PlayerShort;
            _odabraniPS = ps;
            ps.DoDragDrop(42, DragDropEffects.Move);
        }

        private void UcitajIgrace()
        {
            foreach (Match match in matches)
            {
                if (match.home_team_statistics.country == Country)
                {
                    HashSet<Player> players = new HashSet<Player>();
                    List<StartingEleven> start11 = new List<StartingEleven>();
                    List<Substitute> substitutes = new List<Substitute>();
                    foreach (StartingEleven player in match.home_team_statistics.starting_eleven)
                    {
                        players.Add(new Player(Country, Code, player.name, player.captain, player.shirt_number, dohvatiPozicju(player.position)));
                    }
                    foreach (Substitute item in match.home_team_statistics.substitutes)
                    {
                        players.Add(new Player(Country, Code, item.name, item.captain, item.shirt_number, dohvatiPozicju(item.position)));
                    }
                    playersList = players.OrderBy(x => x.ShirtNumber).ToList();
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

        private void flpTeam_MouseEnter(object sender, EventArgs e)
        {
            flpTeam.Focus();
        }

        private void TeamDetails_MouseEnter(object sender, EventArgs e)
        {
            btnStatistika.Focus();
        }

        public void OnFavoriziranje(object sender, EventArgs e)
        {
            PlayerShort ps = sender as PlayerShort;
            _odabraniPS = ps;
            if (_odabraniPS.Favorite==false)
            {
                _odabraniPS.Favorite = false;
                _odabraniPS.StarOnOFF();
                flpTeam.Controls.Add(_odabraniPS);
                flpFavorites.Controls.Remove(_odabraniPS);
                Favorite();
            }
            else
            {
                SrediFavorite();
            }
        }

        private void SrediFavorite()
        {
            if (flpFavorites.Controls.Count >= FAVORITE_NUM)
            {
                MessageBox.Show($"{Properties.Resources.FavoriteWarning}");
            }
            else
            {
                _odabraniPS.Favorite = true;
                _odabraniPS.StarOnOFF();
                Favorite();
            }
        }

        private void Favorite()
        {
            foreach (PlayerShort ps in flpTeam.Controls)
            {
                if (ps.Favorite == true)
                {
                    flpFavorites.Controls.Add(ps);
                    flpTeam.Controls.Remove(ps);
                }
            }

            foreach (PlayerShort ps in flpFavorites.Controls)
            {
                if (ps.Favorite == false)
                {
                    flpTeam.Controls.Add(ps);
                    flpFavorites.Controls.Remove(ps);
                }
            }
            SortFLP(flpTeam, flpFavorites);
        }

        private void SortFLP(FlowLayoutPanel flpTeam, FlowLayoutPanel flpFavorites)
        {
            List<PlayerShort> listaKlupa = new List<PlayerShort>();
            List<PlayerShort> listaFavoriti = new List<PlayerShort>();
            foreach (var item in flpTeam.Controls)
            {
                listaKlupa.Add((PlayerShort)item);
            }
            foreach (var item in flpFavorites.Controls)
            {
                listaFavoriti.Add((PlayerShort)item);
            }
            listaKlupa.Sort();
            listaFavoriti.Sort();
            foreach (var item in listaKlupa)
            {
                flpTeam.Controls.Add(item);
            }
            foreach (var item in listaFavoriti  )
            {
                flpFavorites.Controls.Add(item);
            }
            SaveTeam();
        }

        private void flpFavorites_DragDrop(object sender, DragEventArgs e)
        {
            SrediFavorite();
        }

        private void flpFavorites_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flpTeam_DragDrop(object sender, DragEventArgs e)
        {
            _odabraniPS.Favorite = false;
            _odabraniPS.StarOnOFF();
            Favorite();
        }

        private void flpTeam_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            var listAllPS = new List<PlayerShort>();
            foreach (PlayerShort item in flpTeam.Controls)
            {
                listAllPS.Add(item);
            }
            foreach (PlayerShort item in flpFavorites.Controls)
            {
                listAllPS.Add(item);
            }
            foreach (PlayerShort ps in listAllPS)
            {
                if (ps.PicturPath!="default")
                {
                    foreach (Player player in playersList)
                    {
                        if (ps.PlayerName == player.Name)
                        {
                            player.ProfilePic = ps.PicturPath;
                        }
                    }
                }
            }
            
            Statistics stat = new Statistics(playersList, matches, Country);
            stat.Show();
        }

        private void tsbIzlaz_Click(object sender, EventArgs e)
        {
            LanugageConfirm lc = new LanugageConfirm();

            if (lc.ShowDialog() == DialogResult.OK)
            {
                SaveTeam();
                Application.Exit(); 
            }
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanugageConfirm lc = new LanugageConfirm();
            if (lc.ShowDialog()==DialogResult.OK)
            {
                SetLanguage("en-US");
            }
        }

        private void hrvatskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LanugageConfirm lc = new LanugageConfirm();
            if (lc.ShowDialog() == DialogResult.OK)
            {
                SetLanguage("hr-HR");
            }
        }

        private void SetLanguage(string language)
        {
            UpdateConfig("language", language);
            try
            {
                AppSave.LanguageConfSave(language);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            Application.Restart();
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

        private void momcadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamChoser tc = new TeamChoser(matches, teams);
            tc.Show();
            this.Close();
        }
    }
}
