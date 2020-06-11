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
    /// <summary>
    /// Interaction logic for MatchWindow.xaml
    /// </summary>
    public partial class MatchWindow : Window
    {
        public List<Match> Matches { get; set; }
        public string ChosenTeam { get; set; }
        public string ChosenOpponent { get; set; }
        public MatchWindow()
        {
            InitializeComponent();
        }
        public MatchWindow(List<Match> matches, string chosenTeam, string chosenOpponent)
        {
            InitializeComponent();
            Matches = matches;
            ChosenTeam = chosenTeam;
            ChosenOpponent = chosenOpponent;
        }
    }
}
