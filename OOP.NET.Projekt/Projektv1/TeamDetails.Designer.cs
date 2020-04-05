namespace Projektv1
{
    partial class TeamDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeamDetails));
            this.flpTeam = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFavorites = new System.Windows.Forms.FlowLayoutPanel();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.toolStripTeam = new System.Windows.Forms.ToolStrip();
            this.tsbPostavke = new System.Windows.Forms.ToolStripButton();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.toolStripTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTeam
            // 
            this.flpTeam.AllowDrop = true;
            resources.ApplyResources(this.flpTeam, "flpTeam");
            this.flpTeam.BackColor = System.Drawing.Color.White;
            this.flpTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTeam.Name = "flpTeam";
            this.flpTeam.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpTeam_DragDrop);
            this.flpTeam.DragOver += new System.Windows.Forms.DragEventHandler(this.flpTeam_DragOver);
            this.flpTeam.MouseEnter += new System.EventHandler(this.flpTeam_MouseEnter);
            // 
            // flpFavorites
            // 
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.BackColor = System.Drawing.Color.White;
            this.flpFavorites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.flpFavorites, "flpFavorites");
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragDrop);
            this.flpFavorites.DragOver += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragOver);
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.Red;
            this.btnStatistika.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStatistika.FlatAppearance.BorderSize = 2;
            this.btnStatistika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnStatistika, "btnStatistika");
            this.btnStatistika.ForeColor = System.Drawing.Color.White;
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            this.btnStatistika.MouseEnter += new System.EventHandler(this.btnStatistika_MouseEnter);
            this.btnStatistika.MouseLeave += new System.EventHandler(this.btnStatistika_MouseLeave);
            this.btnStatistika.MouseHover += new System.EventHandler(this.btnStatistika_MouseHover);
            // 
            // toolStripTeam
            // 
            this.toolStripTeam.BackColor = System.Drawing.Color.White;
            this.toolStripTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPostavke,
            this.tsbIzlaz});
            resources.ApplyResources(this.toolStripTeam, "toolStripTeam");
            this.toolStripTeam.Name = "toolStripTeam";
            // 
            // tsbPostavke
            // 
            this.tsbPostavke.BackColor = System.Drawing.Color.Red;
            this.tsbPostavke.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPostavke.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tsbPostavke, "tsbPostavke");
            this.tsbPostavke.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbPostavke.Name = "tsbPostavke";
            // 
            // tsbIzlaz
            // 
            this.tsbIzlaz.BackColor = System.Drawing.Color.Red;
            this.tsbIzlaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIzlaz.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tsbIzlaz, "tsbIzlaz");
            this.tsbIzlaz.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbIzlaz.Name = "tsbIzlaz";
            // 
            // lblTim
            // 
            resources.ApplyResources(this.lblTim, "lblTim");
            this.lblTim.BackColor = System.Drawing.Color.White;
            this.lblTim.ForeColor = System.Drawing.Color.Red;
            this.lblTim.Name = "lblTim";
            // 
            // lblFavorite
            // 
            resources.ApplyResources(this.lblFavorite, "lblFavorite");
            this.lblFavorite.BackColor = System.Drawing.Color.White;
            this.lblFavorite.ForeColor = System.Drawing.Color.Red;
            this.lblFavorite.Name = "lblFavorite";
            // 
            // TeamDetails
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projektv1.Resources.Russia2018_Portrait;
            this.Controls.Add(this.lblFavorite);
            this.Controls.Add(this.lblTim);
            this.Controls.Add(this.toolStripTeam);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.flpFavorites);
            this.Controls.Add(this.flpTeam);
            this.Name = "TeamDetails";
            this.Load += new System.EventHandler(this.TeamDetails_Load);
            this.MouseEnter += new System.EventHandler(this.TeamDetails_MouseEnter);
            this.toolStripTeam.ResumeLayout(false);
            this.toolStripTeam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpTeam;
        private System.Windows.Forms.FlowLayoutPanel flpFavorites;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.ToolStrip toolStripTeam;
        private System.Windows.Forms.ToolStripButton tsbPostavke;
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Label lblFavorite;
    }
}