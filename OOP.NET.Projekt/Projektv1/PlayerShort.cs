using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repo.Models;
using static Repo.Models.Player;

namespace Projektv1
{
    public partial class PlayerShort : UserControl , IComparable<PlayerShort>
    { 
        public string PlayerName { get; set; }
        public bool Captain { get; set; }
        public int ShirtNumber { get; set; }
        public Position position { get; set; }
        public bool Favorite { get; set; }
        public delegate void FavoriziranjeEventHandler(object sender, EventArgs e);
        public event FavoriziranjeEventHandler Favoriziranje;
        public string PicturPath { get; set; }

        public PlayerShort(string playerName, bool captain, int shirtNumber, Position position, bool favorite)
        {
            InitializeComponent();
            picBoxFavorite.Visible = false;
            lblCaptain.Visible = false;
            this.PlayerName = playerName;
            this.Captain = captain;
            this.ShirtNumber = shirtNumber;
            this.position = position;
            PicturPath = "default";
        }

        private void PlayerShort_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            foreach (Control control in this.Controls)
                control.ContextMenuStrip = ctxMenu;
        }

        private void postaviSlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostaviSliku();
        }

        private void dodajUFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Favorite==false)
            {
                Favorite = true;
                picBoxFavorite.Visible = true;
            }
            else
            {
                Favorite = false;
                picBoxFavorite.Visible = false;
            }
            OnFavoriziranje();
        }

        private void picBoxPlayer_DoubleClick(object sender, EventArgs e)
        {
            PostaviSliku();
        }

        private void PostaviSliku()
        {
            OpenFileDialog chosenPicture = new OpenFileDialog();
            chosenPicture.Filter = Properties.Resources.openFileDialog;
            chosenPicture.InitialDirectory = Application.StartupPath;
            if (chosenPicture.ShowDialog() == DialogResult.OK)
            {
                picBoxPlayer.ImageLocation = chosenPicture.FileName;
                PicturPath = picBoxPlayer.ImageLocation;
            }
        }

        private void UcitajPodatke()
        {
            if (Captain)
                lblCaptain.Visible = true;
            if (Favorite)
                picBoxFavorite.Visible = true;
            lblNumber.Text = ShirtNumber.ToString();
            lblPlayerName.Text = PlayerName;
            lblPosition.Text = position.ToString();
            if (PicturPath=="default")
            {
                picBoxPlayer.Image = Resources.footballer_silhouette_1;
            }
            else
            {
                picBoxPlayer.Image = Image.FromFile(PicturPath);
            }
        }
        internal void StarOnOFF()
        {
            if (Favorite == true)
            {
                picBoxFavorite.Visible = true;
            }
            else
            {
                picBoxFavorite.Visible = false;
            }
        }

        protected virtual void OnFavoriziranje()
        {
            if (Favoriziranje != null)
                Favoriziranje(this, EventArgs.Empty);
        }
        public override string ToString()
        {
            return $"{PlayerName} {ShirtNumber}";
        }

        public int CompareTo(PlayerShort other)
        {
            return this.ShirtNumber.CompareTo(other.ShirtNumber);
        }
    }
}
