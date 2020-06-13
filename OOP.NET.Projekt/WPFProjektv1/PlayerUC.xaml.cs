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

namespace WPFProjektv1
{
    public partial class PlayerUC : UserControl
    {
        public Player Player { get; set; }
        PlayerInfo pf;
        Window matchWindow; 
        public PlayerUC(Player player)
        {
            InitializeComponent();
            Player = player;
            matchWindow = Window.GetWindow(this);
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
            pf = new PlayerInfo(Player);
            pf.Show();
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            pf.Close();
        }
    }
}
