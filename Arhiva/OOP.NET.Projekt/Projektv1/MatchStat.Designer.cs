namespace Projektv1
{
    partial class MatchStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchStat));
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHomeTeam = new System.Windows.Forms.Label();
            this.lblAwayTeam = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVisitors = new System.Windows.Forms.Label();
            this.picBoxAway = new System.Windows.Forms.PictureBox();
            this.picBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomeScore
            // 
            resources.ApplyResources(this.lblHomeScore, "lblHomeScore");
            this.lblHomeScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHomeScore.Name = "lblHomeScore";
            // 
            // lblAwayScore
            // 
            resources.ApplyResources(this.lblAwayScore, "lblAwayScore");
            this.lblAwayScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAwayScore.Name = "lblAwayScore";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Name = "label1";
            // 
            // lblHomeTeam
            // 
            resources.ApplyResources(this.lblHomeTeam, "lblHomeTeam");
            this.lblHomeTeam.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHomeTeam.Name = "lblHomeTeam";
            // 
            // lblAwayTeam
            // 
            resources.ApplyResources(this.lblAwayTeam, "lblAwayTeam");
            this.lblAwayTeam.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblAwayTeam.Name = "lblAwayTeam";
            // 
            // lblVenue
            // 
            resources.ApplyResources(this.lblVenue, "lblVenue");
            this.lblVenue.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblVenue.Name = "lblVenue";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Name = "label2";
            // 
            // lblVisitors
            // 
            resources.ApplyResources(this.lblVisitors, "lblVisitors");
            this.lblVisitors.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblVisitors.Name = "lblVisitors";
            // 
            // picBoxAway
            // 
            resources.ApplyResources(this.picBoxAway, "picBoxAway");
            this.picBoxAway.Name = "picBoxAway";
            this.picBoxAway.TabStop = false;
            // 
            // picBoxHome
            // 
            resources.ApplyResources(this.picBoxHome, "picBoxHome");
            this.picBoxHome.Name = "picBoxHome";
            this.picBoxHome.TabStop = false;
            // 
            // MatchStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblVisitors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblVenue);
            this.Controls.Add(this.lblAwayTeam);
            this.Controls.Add(this.lblHomeTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAwayScore);
            this.Controls.Add(this.lblHomeScore);
            this.Controls.Add(this.picBoxAway);
            this.Controls.Add(this.picBoxHome);
            this.Name = "MatchStat";
            this.Load += new System.EventHandler(this.MatchStat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxHome;
        private System.Windows.Forms.PictureBox picBoxAway;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHomeTeam;
        private System.Windows.Forms.Label lblAwayTeam;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVisitors;
    }
}
