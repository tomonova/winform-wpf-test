namespace Projektv1
{
    partial class PlayerStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerStat));
            this.picBoxPlayerStat = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblBrojOdigranih = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblBrojGolova = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblBrojZutih = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerStat)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPlayerStat
            // 
            resources.ApplyResources(this.picBoxPlayerStat, "picBoxPlayerStat");
            this.picBoxPlayerStat.Image = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayerStat.InitialImage = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayerStat.Name = "picBoxPlayerStat";
            this.picBoxPlayerStat.TabStop = false;
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // lbl1
            // 
            resources.ApplyResources(this.lbl1, "lbl1");
            this.lbl1.Name = "lbl1";
            // 
            // lblBrojOdigranih
            // 
            resources.ApplyResources(this.lblBrojOdigranih, "lblBrojOdigranih");
            this.lblBrojOdigranih.Name = "lblBrojOdigranih";
            // 
            // lbl2
            // 
            resources.ApplyResources(this.lbl2, "lbl2");
            this.lbl2.Name = "lbl2";
            // 
            // lblBrojGolova
            // 
            resources.ApplyResources(this.lblBrojGolova, "lblBrojGolova");
            this.lblBrojGolova.Name = "lblBrojGolova";
            // 
            // lbl3
            // 
            resources.ApplyResources(this.lbl3, "lbl3");
            this.lbl3.Name = "lbl3";
            // 
            // lblBrojZutih
            // 
            resources.ApplyResources(this.lblBrojZutih, "lblBrojZutih");
            this.lblBrojZutih.Name = "lblBrojZutih";
            // 
            // PlayerStat
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblBrojZutih);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblBrojGolova);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblBrojOdigranih);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBoxPlayerStat);
            this.Name = "PlayerStat";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerStat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPlayerStat;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblBrojOdigranih;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblBrojGolova;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblBrojZutih;
    }
}
