namespace Projektv1
{
    partial class WorldCup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorldCup));
            this.btnHr = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.lblTest = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.pbIntro = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHr
            // 
            resources.ApplyResources(this.btnHr, "btnHr");
            this.btnHr.Name = "btnHr";
            this.btnHr.UseVisualStyleBackColor = true;
            this.btnHr.Click += new System.EventHandler(this.btnHr_Click);
            // 
            // btnEn
            // 
            resources.ApplyResources(this.btnEn, "btnEn");
            this.btnEn.Name = "btnEn";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // lblTest
            // 
            resources.ApplyResources(this.lblTest, "lblTest");
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Name = "lblTest";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1;
            // 
            // pbIntro
            // 
            resources.ApplyResources(this.pbIntro, "pbIntro");
            this.pbIntro.Name = "pbIntro";
            this.pbIntro.TabStop = false;
            // 
            // WorldCup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnHr);
            this.Controls.Add(this.pbIntro);
            this.Name = "WorldCup";
            this.Load += new System.EventHandler(this.WorldCup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIntro;
        private System.Windows.Forms.Button btnHr;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Timer timerMain;
    }
}