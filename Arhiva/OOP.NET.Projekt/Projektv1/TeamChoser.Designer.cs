namespace Projektv1
{
    partial class TeamChoser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamChoser));
            this.cmbTeamChoser = new System.Windows.Forms.ComboBox();
            this.lblTeamChoser = new System.Windows.Forms.Label();
            this.teamChoserTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmbTeamChoser
            // 
            this.cmbTeamChoser.DropDownHeight = 250;
            resources.ApplyResources(this.cmbTeamChoser, "cmbTeamChoser");
            this.cmbTeamChoser.FormattingEnabled = true;
            this.cmbTeamChoser.Name = "cmbTeamChoser";
            this.cmbTeamChoser.SelectedIndexChanged += new System.EventHandler(this.cmbTeamChoser_SelectedIndexChanged);
            // 
            // lblTeamChoser
            // 
            resources.ApplyResources(this.lblTeamChoser, "lblTeamChoser");
            this.lblTeamChoser.BackColor = System.Drawing.Color.White;
            this.lblTeamChoser.Name = "lblTeamChoser";
            // 
            // teamChoserTimer
            // 
            this.teamChoserTimer.Enabled = true;
            this.teamChoserTimer.Tick += new System.EventHandler(this.teamChoserTimer_Tick);
            // 
            // TeamChoser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projektv1.Resources.WCTeams;
            this.Controls.Add(this.lblTeamChoser);
            this.Controls.Add(this.cmbTeamChoser);
            this.Name = "TeamChoser";
            this.Load += new System.EventHandler(this.TeamChoser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTeamChoser;
        private System.Windows.Forms.Label lblTeamChoser;
        private System.Windows.Forms.Timer teamChoserTimer;
    }
}