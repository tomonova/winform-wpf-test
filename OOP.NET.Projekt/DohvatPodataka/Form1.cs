using Repo.DAL;
using Repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DohvatPodataka
{
    public partial class Form1 : Form
    {
        IRepo RF { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RF = RepoFactory.GetRepo();
            List<Match> matches = RF.GetMatches();
            foreach (Match match in matches)
            {
                if (!(comboBox1.Items.Contains(match.home_team_country)||comboBox1.Items.Contains(match.away_team_country)))
                {
                    comboBox1.Items.Add(match.home_team_country);
                    comboBox1.Items.Add(match.away_team_country);
                }
            }
            comboBox1.Sorted = true;
        }
    }
}
