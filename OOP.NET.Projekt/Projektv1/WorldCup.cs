using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektv1
{

    public partial class WorldCup : Form
    {
        public WorldCup()
        {
            InitializeComponent();
        }

        private void WorldCup_Load(object sender, EventArgs e)
        {
            pbIntro.Image = Resources.WC_Logo;
        }



        private void btnHr_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("hr");
        }

        private void btnEn_Click(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("en");
        }
    }
}
