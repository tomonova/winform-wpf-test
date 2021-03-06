﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projektv1
{
    public partial class PlayerStat : UserControl
    {
        public string PlayerName { get; set; }
        public int YellowCardNum { get; set; }
        public int GoalNum { get; set; }
        public string PorilfePic { get; set; }



        public PlayerStat(string playerName,int yellowCard, int goalNum, int gamesPlayed,string picPath)
        {
            InitializeComponent();
            lblBrojGolova.Text = goalNum.ToString();
            lblBrojZutih.Text = yellowCard.ToString();
            lblBrojOdigranih.Text = gamesPlayed.ToString();
            lblName.Text = playerName;
            try
            {
                if (picPath != "default")
                {
                    picBoxPlayerStat.ImageLocation = picPath;
                }
                else
                {
                    picBoxPlayerStat.Image = Resources.footballer_silhouette_1;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
