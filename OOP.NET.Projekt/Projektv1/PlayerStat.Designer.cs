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
            this.picBoxPlayerStat.Image = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayerStat.InitialImage = global::Projektv1.Resources.footballer_silhouette_1;
            this.picBoxPlayerStat.Location = new System.Drawing.Point(0, 0);
            this.picBoxPlayerStat.Name = "picBoxPlayerStat";
            this.picBoxPlayerStat.Size = new System.Drawing.Size(63, 53);
            this.picBoxPlayerStat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerStat.TabIndex = 0;
            this.picBoxPlayerStat.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(69, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl1.Location = new System.Drawing.Point(69, 27);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(73, 17);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Broj igara:";
            // 
            // lblBrojOdigranih
            // 
            this.lblBrojOdigranih.AutoSize = true;
            this.lblBrojOdigranih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojOdigranih.Location = new System.Drawing.Point(139, 27);
            this.lblBrojOdigranih.Name = "lblBrojOdigranih";
            this.lblBrojOdigranih.Size = new System.Drawing.Size(16, 17);
            this.lblBrojOdigranih.TabIndex = 3;
            this.lblBrojOdigranih.Text = "0";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl2.Location = new System.Drawing.Point(164, 27);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(83, 17);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Broj golova:";
            // 
            // lblBrojGolova
            // 
            this.lblBrojGolova.AutoSize = true;
            this.lblBrojGolova.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojGolova.Location = new System.Drawing.Point(243, 27);
            this.lblBrojGolova.Name = "lblBrojGolova";
            this.lblBrojGolova.Size = new System.Drawing.Size(16, 17);
            this.lblBrojGolova.TabIndex = 5;
            this.lblBrojGolova.Text = "0";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl3.Location = new System.Drawing.Point(265, 27);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(123, 17);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "Broj žutih kartona:";
            // 
            // lblBrojZutih
            // 
            this.lblBrojZutih.AutoSize = true;
            this.lblBrojZutih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBrojZutih.Location = new System.Drawing.Point(382, 27);
            this.lblBrojZutih.Name = "lblBrojZutih";
            this.lblBrojZutih.Size = new System.Drawing.Size(16, 17);
            this.lblBrojZutih.TabIndex = 7;
            this.lblBrojZutih.Text = "0";
            // 
            // PlayerStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Size = new System.Drawing.Size(419, 54);
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
