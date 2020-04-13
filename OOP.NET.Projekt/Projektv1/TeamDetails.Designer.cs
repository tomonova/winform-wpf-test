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
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.momcadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jezikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hrvatskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbIzlaz = new System.Windows.Forms.ToolStripButton();
            this.lblTim = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.toolStripTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpTeam
            // 
            resources.ApplyResources(this.flpTeam, "flpTeam");
            this.flpTeam.AllowDrop = true;
            this.flpTeam.BackColor = System.Drawing.Color.White;
            this.flpTeam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpTeam.Name = "flpTeam";
            this.flpTeam.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpTeam_DragDrop);
            this.flpTeam.DragOver += new System.Windows.Forms.DragEventHandler(this.flpTeam_DragOver);
            this.flpTeam.MouseEnter += new System.EventHandler(this.flpTeam_MouseEnter);
            // 
            // flpFavorites
            // 
            resources.ApplyResources(this.flpFavorites, "flpFavorites");
            this.flpFavorites.AllowDrop = true;
            this.flpFavorites.BackColor = System.Drawing.Color.White;
            this.flpFavorites.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpFavorites.Name = "flpFavorites";
            this.flpFavorites.DragDrop += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragDrop);
            this.flpFavorites.DragOver += new System.Windows.Forms.DragEventHandler(this.flpFavorites_DragOver);
            // 
            // btnStatistika
            // 
            resources.ApplyResources(this.btnStatistika, "btnStatistika");
            this.btnStatistika.BackColor = System.Drawing.Color.Red;
            this.btnStatistika.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnStatistika.FlatAppearance.BorderSize = 2;
            this.btnStatistika.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            resources.ApplyResources(this.toolStripTeam, "toolStripTeam");
            this.toolStripTeam.BackColor = System.Drawing.Color.White;
            this.toolStripTeam.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.tsbIzlaz});
            this.toolStripTeam.Name = "toolStripTeam";
            // 
            // toolStripDropDownButton1
            // 
            resources.ApplyResources(this.toolStripDropDownButton1, "toolStripDropDownButton1");
            this.toolStripDropDownButton1.BackColor = System.Drawing.Color.Red;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.momcadToolStripMenuItem,
            this.jezikToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            // 
            // momcadToolStripMenuItem
            // 
            resources.ApplyResources(this.momcadToolStripMenuItem, "momcadToolStripMenuItem");
            this.momcadToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.momcadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.momcadToolStripMenuItem.Name = "momcadToolStripMenuItem";
            this.momcadToolStripMenuItem.Click += new System.EventHandler(this.momcadToolStripMenuItem_Click);
            // 
            // jezikToolStripMenuItem
            // 
            resources.ApplyResources(this.jezikToolStripMenuItem, "jezikToolStripMenuItem");
            this.jezikToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.jezikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.hrvatskiToolStripMenuItem});
            this.jezikToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.jezikToolStripMenuItem.Name = "jezikToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.englishToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // hrvatskiToolStripMenuItem
            // 
            resources.ApplyResources(this.hrvatskiToolStripMenuItem, "hrvatskiToolStripMenuItem");
            this.hrvatskiToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.hrvatskiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hrvatskiToolStripMenuItem.Name = "hrvatskiToolStripMenuItem";
            this.hrvatskiToolStripMenuItem.Click += new System.EventHandler(this.hrvatskiToolStripMenuItem_Click);
            // 
            // tsbIzlaz
            // 
            resources.ApplyResources(this.tsbIzlaz, "tsbIzlaz");
            this.tsbIzlaz.BackColor = System.Drawing.Color.Red;
            this.tsbIzlaz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbIzlaz.ForeColor = System.Drawing.Color.White;
            this.tsbIzlaz.Margin = new System.Windows.Forms.Padding(10, 1, 0, 2);
            this.tsbIzlaz.Name = "tsbIzlaz";
            this.tsbIzlaz.Click += new System.EventHandler(this.tsbIzlaz_Click);
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
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
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
        private System.Windows.Forms.ToolStripButton tsbIzlaz;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem momcadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jezikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hrvatskiToolStripMenuItem;
    }
}