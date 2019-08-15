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
            this.pbIntro = new System.Windows.Forms.PictureBox();
            this.btnHr = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIntro
            // 
            this.pbIntro.Location = new System.Drawing.Point(0, 0);
            this.pbIntro.Name = "pbIntro";
            this.pbIntro.Size = new System.Drawing.Size(1065, 765);
            this.pbIntro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIntro.TabIndex = 0;
            this.pbIntro.TabStop = false;
            // 
            // btnHr
            // 
            this.btnHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHr.Location = new System.Drawing.Point(400, 350);
            this.btnHr.Name = "btnHr";
            this.btnHr.Size = new System.Drawing.Size(65, 65);
            this.btnHr.TabIndex = 1;
            this.btnHr.Text = "HR";
            this.btnHr.UseVisualStyleBackColor = true;
            this.btnHr.Click += new System.EventHandler(this.btnHr_Click);
            // 
            // btnEn
            // 
            this.btnEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEn.Location = new System.Drawing.Point(600, 350);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(65, 65);
            this.btnEn.TabIndex = 2;
            this.btnEn.Text = "EN";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // WorldCup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 766);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnHr);
            this.Controls.Add(this.pbIntro);
            this.Name = "WorldCup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorldCup";
            this.Load += new System.EventHandler(this.WorldCup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIntro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIntro;
        private System.Windows.Forms.Button btnHr;
        private System.Windows.Forms.Button btnEn;
    }
}