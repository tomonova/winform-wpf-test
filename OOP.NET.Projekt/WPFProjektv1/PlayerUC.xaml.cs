using Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WPFProjektv1
{
    public partial class PlayerUC : UserControl
    {
        public Player Player { get; set; }
        PlayerInfo PI;
        Window matchWindow;
        private readonly int _playerInfoWidth = 270;
        private readonly int _playerInfoHeight = 140;
        public PlayerUC(Player player, MatchWindow matchWindow)
        {
            InitializeComponent();
            Player = player;
            this.matchWindow = matchWindow;
            Configure();
        }

        private void Configure()
        {
            //lblNumber.Content = Player.ShirtNumber;
            if (Player.ProfilePic != null)
            {
                imgPlayer.Source = new BitmapImage(new Uri(Player.ProfilePic));
            }
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            CloseActiveInfos();
            PI = new PlayerInfo(Player);

            Point relativePoint = this.TransformToAncestor(matchWindow).Transform(new Point(0, 0));
            Point location = new Point(0, 0);

            if (relativePoint.X <= matchWindow.ActualWidth / 2 && relativePoint.Y <= matchWindow.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(0, 0));
            }

            else if (relativePoint.X > matchWindow.ActualWidth / 2 && relativePoint.Y < matchWindow.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(this.ActualWidth - _playerInfoWidth, 0));
            }
            else if (relativePoint.X < matchWindow.ActualWidth / 2 && relativePoint.Y > matchWindow.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(0, this.ActualHeight - _playerInfoHeight));
            }
            else if (relativePoint.X > matchWindow.ActualWidth / 2 && relativePoint.Y > matchWindow.ActualHeight / 2)
            {
                location = this.PointToScreen(new Point(this.ActualWidth - _playerInfoWidth, this.ActualHeight - _playerInfoHeight));
            }

            PI.Left = location.X;
            PI.Top = location.Y;
            PI.Show();
        }

        private void CloseActiveInfos()
        {
            foreach (Window window in System.Windows.Application.Current.Windows)
            {
                if (window.Title == "Player Info")
                {
                    window.Close();
                }

            };
        }
    }
}
