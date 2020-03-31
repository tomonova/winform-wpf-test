namespace Projektv1
{
    partial class PlayerShort
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerShort));
            this.lblNumber = new System.Windows.Forms.Label();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.postaviSlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUFavoriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCaptain = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.picBoxFavorite = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            resources.ApplyResources(this.lblNumber, "lblNumber");
            this.lblNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNumber.ContextMenuStrip = this.ctxMenu;
            this.lblNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNumber.Name = "lblNumber";
            // 
            // ctxMenu
            // 
            resources.ApplyResources(this.ctxMenu, "ctxMenu");
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postaviSlikuToolStripMenuItem,
            this.dodajUFavoriteToolStripMenuItem});
            this.ctxMenu.Name = "ctxMenu";
            // 
            // postaviSlikuToolStripMenuItem
            // 
            resources.ApplyResources(this.postaviSlikuToolStripMenuItem, "postaviSlikuToolStripMenuItem");
            this.postaviSlikuToolStripMenuItem.Name = "postaviSlikuToolStripMenuItem";
            this.postaviSlikuToolStripMenuItem.Click += new System.EventHandler(this.postaviSlikuToolStripMenuItem_Click);
            // 
            // dodajUFavoriteToolStripMenuItem
            // 
            resources.ApplyResources(this.dodajUFavoriteToolStripMenuItem, "dodajUFavoriteToolStripMenuItem");
            this.dodajUFavoriteToolStripMenuItem.Name = "dodajUFavoriteToolStripMenuItem";
            this.dodajUFavoriteToolStripMenuItem.Click += new System.EventHandler(this.dodajUFavoriteToolStripMenuItem_Click);
            // 
            // lblPlayerName
            // 
            resources.ApplyResources(this.lblPlayerName, "lblPlayerName");
            this.lblPlayerName.ContextMenuStrip = this.ctxMenu;
            this.lblPlayerName.Name = "lblPlayerName";
            // 
            // lblCaptain
            // 
            resources.ApplyResources(this.lblCaptain, "lblCaptain");
            this.lblCaptain.ContextMenuStrip = this.ctxMenu;
            this.lblCaptain.ForeColor = System.Drawing.Color.Red;
            this.lblCaptain.Name = "lblCaptain";
            // 
            // lblPosition
            // 
            resources.ApplyResources(this.lblPosition, "lblPosition");
            this.lblPosition.ContextMenuStrip = this.ctxMenu;
            this.lblPosition.Name = "lblPosition";
            // 
            // picBoxFavorite
            // 
            resources.ApplyResources(this.picBoxFavorite, "picBoxFavorite");
            this.picBoxFavorite.ContextMenuStrip = this.ctxMenu;
            this.picBoxFavorite.Image = global::Projektv1.Resources.golden_star;
            this.picBoxFavorite.Name = "picBoxFavorite";
            this.picBoxFavorite.TabStop = false;
            // 
            // picBoxPlayer
            // 
            resources.ApplyResources(this.picBoxPlayer, "picBoxPlayer");
            this.picBoxPlayer.BackColor = System.Drawing.Color.White;
            this.picBoxPlayer.BackgroundImage = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayer.ContextMenuStrip = this.ctxMenu;
            this.picBoxPlayer.Image = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayer.InitialImage = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.TabStop = false;
            this.picBoxPlayer.DoubleClick += new System.EventHandler(this.picBoxPlayer_DoubleClick);
            // 
            // PlayerShort
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContextMenuStrip = this.ctxMenu;
            this.Controls.Add(this.picBoxFavorite);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblCaptain);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.picBoxPlayer);
            this.Name = "PlayerShort";
            this.Load += new System.EventHandler(this.PlayerShort_Load);
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCaptain;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.PictureBox picBoxFavorite;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem postaviSlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUFavoriteToolStripMenuItem;
    }
}
