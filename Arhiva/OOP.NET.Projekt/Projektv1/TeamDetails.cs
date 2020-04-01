﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repo.Models;

namespace Projektv1
{
    public partial class TeamDetails : Form
    {
        List<Match> matches;
        List<Player> playersList;
        string Country;
        string Code;
        private PlayerShort _odabraniPS;

        public TeamDetails(List<Match> matches,string country,string code)
        {
            InitializeComponent();
            this.Country = country;
            this.Code = code;
            this.matches = matches;
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

        private void PrikaziIgrace()
        {
            foreach (var player in playersList)
            {
                PlayerShort ps = new PlayerShort(player.Name,player.Captain,player.ShirtNumber,player.position,player.Favorite);
                ps.MouseDown += Ps_MouseDown;
                ps.Favoriziranje += OnFavoriziranje;
                if (player.Favorite)
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
            if (Enum.TryParse(position, out realPosition));
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
            if (flpFavorites.Controls.Count >= 5)
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
    }
}