using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
{
    public partial class PlayerInfo : Window
    {
        public Player Player{ get; set; }
        public PlayerInfo(Player player)
        {
            InitializeComponent();
            Player = player;
            FillInfo();
        }

        private void FillInfo()
        {
            lblName.Content = Player.Name;
            lblNumber.Content = Player.ShirtNumber;
            lblPosition.Content = Player.position.ToString();
            lblGoalsScored.Content = Player.Goals;
            lblYellow.Content = Player.YellowCards;
            //lblGamesPlayed.Content = Player.GamesPlayed;
            if (Player.Captain)
            {
                lblCaptain.Visibility = Visibility.Visible;
            }
        }
    }
}
