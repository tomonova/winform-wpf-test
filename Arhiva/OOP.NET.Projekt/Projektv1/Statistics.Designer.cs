namespace Projektv1
{
    partial class Statistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistics));
            this.flpMatches = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayerStat = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGamesPlayed = new System.Windows.Forms.Button();
            this.btnGoals = new System.Windows.Forms.Button();
            this.btnYellowCards = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picBoxYCards = new System.Windows.Forms.PictureBox();
            this.picBoxGoals = new System.Windows.Forms.PictureBox();
            this.picBoxGamesPlayed = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGamesPlayed)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMatches
            // 
            resources.ApplyResources(this.flpMatches, "flpMatches");
            this.flpMatches.BackColor = System.Drawing.Color.Transparent;
            this.flpMatches.Name = "flpMatches";
            // 
            // flpPlayerStat
            // 
            resources.ApplyResources(this.flpPlayerStat, "flpPlayerStat");
            this.flpPlayerStat.BackColor = System.Drawing.Color.Transparent;
            this.flpPlayerStat.Name = "flpPlayerStat";
            // 
            // btnGamesPlayed
            // 
            resources.ApplyResources(this.btnGamesPlayed, "btnGamesPlayed");
            this.btnGamesPlayed.BackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.BorderSize = 0;
            this.btnGamesPlayed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGamesPlayed.Name = "btnGamesPlayed";
            this.btnGamesPlayed.UseVisualStyleBackColor = false;
            this.btnGamesPlayed.Click += new System.EventHandler(this.btnGamesPlayed_Click);
            this.btnGamesPlayed.MouseEnter += new System.EventHandler(this.btnGamesPlayed_MouseEnter);
            this.btnGamesPlayed.MouseLeave += new System.EventHandler(this.btnGamesPlayed_MouseLeave);
            // 
            // btnGoals
            // 
            resources.ApplyResources(this.btnGoals, "btnGoals");
            this.btnGoals.BackColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.BorderSize = 0;
            this.btnGoals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGoals.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.UseVisualStyleBackColor = false;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            this.btnGoals.MouseEnter += new System.EventHandler(this.btnGoals_MouseEnter);
            this.btnGoals.MouseLeave += new System.EventHandler(this.btnGoals_MouseLeave);
            // 
            // btnYellowCards
            // 
            resources.ApplyResources(this.btnYellowCards, "btnYellowCards");
            this.btnYellowCards.BackColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.BorderSize = 0;
            this.btnYellowCards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnYellowCards.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnYellowCards.Name = "btnYellowCards";
            this.btnYellowCards.UseVisualStyleBackColor = false;
            this.btnYellowCards.Click += new System.EventHandler(this.btnYellowCards_Click);
            this.btnYellowCards.MouseEnter += new System.EventHandler(this.btnYellowCards_MouseEnter);
            this.btnYellowCards.MouseLeave += new System.EventHandler(this.btnYellowCards_MouseLeave);
            // 
            // btnPrint
            // 
            resources.ApplyResources(this.btnPrint, "btnPrint");
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowCurrentPage = true;
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // pictureBox4
            // 
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Image = global::Projektv1.Resources.FiFaW_512;
            this.pictureBox4.InitialImage = global::Projektv1.Resources.FiFaW_512;
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // picBoxYCards
            // 
            resources.ApplyResources(this.picBoxYCards, "picBoxYCards");
            this.picBoxYCards.BackColor = System.Drawing.Color.White;
            this.picBoxYCards.Name = "picBoxYCards";
            this.picBoxYCards.TabStop = false;
            // 
            // picBoxGoals
            // 
            resources.ApplyResources(this.picBoxGoals, "picBoxGoals");
            this.picBoxGoals.BackColor = System.Drawing.Color.White;
            this.picBoxGoals.Name = "picBoxGoals";
            this.picBoxGoals.TabStop = false;
            // 
            // picBoxGamesPlayed
            // 
            resources.ApplyResources(this.picBoxGamesPlayed, "picBoxGamesPlayed");
            this.picBoxGamesPlayed.BackColor = System.Drawing.Color.White;
            this.picBoxGamesPlayed.Name = "picBoxGamesPlayed";
            this.picBoxGamesPlayed.TabStop = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Statistics
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.picBoxYCards);
            this.Controls.Add(this.btnYellowCards);
            this.Controls.Add(this.picBoxGoals);
            this.Controls.Add(this.btnGoals);
            this.Controls.Add(this.picBoxGamesPlayed);
            this.Controls.Add(this.btnGamesPlayed);
            this.Controls.Add(this.flpPlayerStat);
            this.Controls.Add(this.flpMatches);
            this.Name = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxYCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGamesPlayed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMatches;
        private System.Windows.Forms.FlowLayoutPanel flpPlayerStat;
        private System.Windows.Forms.Button btnGamesPlayed;
        private System.Windows.Forms.PictureBox picBoxGamesPlayed;
        private System.Windows.Forms.PictureBox picBoxGoals;
        private System.Windows.Forms.Button btnGoals;
        private System.Windows.Forms.PictureBox picBoxYCards;
        private System.Windows.Forms.Button btnYellowCards;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}