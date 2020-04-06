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
            this.flpMatches.AutoScroll = true;
            this.flpMatches.BackColor = System.Drawing.Color.Transparent;
            this.flpMatches.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMatches.Location = new System.Drawing.Point(802, 5);
            this.flpMatches.Name = "flpMatches";
            this.flpMatches.Size = new System.Drawing.Size(355, 1010);
            this.flpMatches.TabIndex = 0;
            this.flpMatches.WrapContents = false;
            // 
            // flpPlayerStat
            // 
            this.flpPlayerStat.AutoScroll = true;
            this.flpPlayerStat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPlayerStat.BackColor = System.Drawing.Color.Transparent;
            this.flpPlayerStat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPlayerStat.Location = new System.Drawing.Point(2, 5);
            this.flpPlayerStat.Name = "flpPlayerStat";
            this.flpPlayerStat.Size = new System.Drawing.Size(444, 1021);
            this.flpPlayerStat.TabIndex = 0;
            this.flpPlayerStat.WrapContents = false;
            // 
            // btnGamesPlayed
            // 
            this.btnGamesPlayed.BackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.BorderSize = 0;
            this.btnGamesPlayed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGamesPlayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGamesPlayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGamesPlayed.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGamesPlayed.Location = new System.Drawing.Point(492, 68);
            this.btnGamesPlayed.Name = "btnGamesPlayed";
            this.btnGamesPlayed.Size = new System.Drawing.Size(210, 50);
            this.btnGamesPlayed.TabIndex = 1;
            this.btnGamesPlayed.Text = "Games Played";
            this.btnGamesPlayed.UseVisualStyleBackColor = false;
            this.btnGamesPlayed.Click += new System.EventHandler(this.btnGamesPlayed_Click);
            this.btnGamesPlayed.MouseEnter += new System.EventHandler(this.btnGamesPlayed_MouseEnter);
            this.btnGamesPlayed.MouseLeave += new System.EventHandler(this.btnGamesPlayed_MouseLeave);
            // 
            // btnGoals
            // 
            this.btnGoals.BackColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.BorderSize = 0;
            this.btnGoals.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnGoals.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGoals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnGoals.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnGoals.Location = new System.Drawing.Point(492, 143);
            this.btnGoals.Name = "btnGoals";
            this.btnGoals.Size = new System.Drawing.Size(210, 50);
            this.btnGoals.TabIndex = 3;
            this.btnGoals.Text = "Goals Scored";
            this.btnGoals.UseVisualStyleBackColor = false;
            this.btnGoals.Click += new System.EventHandler(this.btnGoals_Click);
            this.btnGoals.MouseEnter += new System.EventHandler(this.btnGoals_MouseEnter);
            this.btnGoals.MouseLeave += new System.EventHandler(this.btnGoals_MouseLeave);
            // 
            // btnYellowCards
            // 
            this.btnYellowCards.BackColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.BorderSize = 0;
            this.btnYellowCards.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnYellowCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellowCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnYellowCards.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnYellowCards.Location = new System.Drawing.Point(492, 221);
            this.btnYellowCards.Name = "btnYellowCards";
            this.btnYellowCards.Size = new System.Drawing.Size(210, 50);
            this.btnYellowCards.TabIndex = 5;
            this.btnYellowCards.Text = "YellowCards";
            this.btnYellowCards.UseVisualStyleBackColor = false;
            this.btnYellowCards.Click += new System.EventHandler(this.btnYellowCards_Click);
            this.btnYellowCards.MouseEnter += new System.EventHandler(this.btnYellowCards_MouseEnter);
            this.btnYellowCards.MouseLeave += new System.EventHandler(this.btnYellowCards_MouseLeave);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrint.Location = new System.Drawing.Point(492, 968);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(268, 47);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "PRINT";
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
            this.pictureBox4.Image = global::Projektv1.Resources.FiFaW_512;
            this.pictureBox4.InitialImage = global::Projektv1.Resources.FiFaW_512;
            this.pictureBox4.Location = new System.Drawing.Point(452, 361);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(344, 380);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // picBoxYCards
            // 
            this.picBoxYCards.BackColor = System.Drawing.Color.White;
            this.picBoxYCards.InitialImage = null;
            this.picBoxYCards.Location = new System.Drawing.Point(698, 221);
            this.picBoxYCards.Name = "picBoxYCards";
            this.picBoxYCards.Size = new System.Drawing.Size(62, 50);
            this.picBoxYCards.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxYCards.TabIndex = 6;
            this.picBoxYCards.TabStop = false;
            // 
            // picBoxGoals
            // 
            this.picBoxGoals.BackColor = System.Drawing.Color.White;
            this.picBoxGoals.InitialImage = null;
            this.picBoxGoals.Location = new System.Drawing.Point(698, 143);
            this.picBoxGoals.Name = "picBoxGoals";
            this.picBoxGoals.Size = new System.Drawing.Size(62, 50);
            this.picBoxGoals.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGoals.TabIndex = 4;
            this.picBoxGoals.TabStop = false;
            // 
            // picBoxGamesPlayed
            // 
            this.picBoxGamesPlayed.BackColor = System.Drawing.Color.White;
            this.picBoxGamesPlayed.InitialImage = null;
            this.picBoxGamesPlayed.Location = new System.Drawing.Point(698, 68);
            this.picBoxGamesPlayed.Name = "picBoxGamesPlayed";
            this.picBoxGamesPlayed.Size = new System.Drawing.Size(62, 50);
            this.picBoxGamesPlayed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGamesPlayed.TabIndex = 2;
            this.picBoxGamesPlayed.TabStop = false;
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1158, 1027);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
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