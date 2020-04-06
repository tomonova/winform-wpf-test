using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace Projektv1
{
    public partial class MatchStat : UserControl
    {
        private const string resxFile = @"..\..\Resources.resx";

        public MatchStat(string homeCode,string homeCountry, string awayCode,string awayCountry, string venue, int homeGoals, int awayGoals, int visitors)
        {
            InitializeComponent();
            lblAwayScore.Text = awayGoals.ToString();
            lblAwayTeam.Text = awayCountry;
            lblHomeScore.Text = homeGoals.ToString();
            lblHomeTeam.Text = homeCountry;
            lblVenue.Text = venue;
            lblVisitors.Text = visitors.ToString();
            picBoxHome.Image = (Image)Resources.ResourceManager.GetObject(homeCode);
            picBoxAway.Image = (Image)Resources.ResourceManager.GetObject(awayCode);

        }

        private void MatchStat_Load(object sender, EventArgs e)
        {

        }
    }
}
