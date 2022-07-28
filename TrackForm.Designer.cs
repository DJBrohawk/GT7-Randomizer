
namespace GT7_Randomizer
{
    partial class TrackForm
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
            this.trackList = new System.Windows.Forms.ListView();
            this.trackName = new System.Windows.Forms.ColumnHeader();
            this.supportsRain = new System.Windows.Forms.ColumnHeader();
            this.supportsNight = new System.Windows.Forms.ColumnHeader();
            this.saveBtn = new System.Windows.Forms.Button();
            this.checkAllTracksBtn = new System.Windows.Forms.Button();
            this.uncheckAllTracksBtn = new System.Windows.Forms.Button();
            this.rainOnlyBtn = new System.Windows.Forms.Button();
            this.nightOnlyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trackList
            // 
            this.trackList.CheckBoxes = true;
            this.trackList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trackName,
            this.supportsRain,
            this.supportsNight});
            this.trackList.GridLines = true;
            this.trackList.HideSelection = false;
            this.trackList.Location = new System.Drawing.Point(13, 13);
            this.trackList.Name = "trackList";
            this.trackList.Size = new System.Drawing.Size(775, 425);
            this.trackList.TabIndex = 0;
            this.trackList.UseCompatibleStateImageBehavior = false;
            this.trackList.View = System.Windows.Forms.View.Details;
            // 
            // trackName
            // 
            this.trackName.Text = "Track Name";
            this.trackName.Width = 500;
            // 
            // supportsRain
            // 
            this.supportsRain.Text = "Rain?";
            this.supportsRain.Width = 65;
            // 
            // supportsNight
            // 
            this.supportsNight.Text = "Night?";
            this.supportsNight.Width = 70;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(667, 448);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 34);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // checkAllTracksBtn
            // 
            this.checkAllTracksBtn.Location = new System.Drawing.Point(13, 448);
            this.checkAllTracksBtn.Name = "checkAllTracksBtn";
            this.checkAllTracksBtn.Size = new System.Drawing.Size(112, 34);
            this.checkAllTracksBtn.TabIndex = 2;
            this.checkAllTracksBtn.Text = "Check All";
            this.checkAllTracksBtn.UseVisualStyleBackColor = true;
            this.checkAllTracksBtn.Click += new System.EventHandler(this.checkAllTracksBtn_Click);
            // 
            // uncheckAllTracksBtn
            // 
            this.uncheckAllTracksBtn.Location = new System.Drawing.Point(131, 448);
            this.uncheckAllTracksBtn.Name = "uncheckAllTracksBtn";
            this.uncheckAllTracksBtn.Size = new System.Drawing.Size(112, 34);
            this.uncheckAllTracksBtn.TabIndex = 3;
            this.uncheckAllTracksBtn.Text = "Uncheck All";
            this.uncheckAllTracksBtn.UseVisualStyleBackColor = true;
            this.uncheckAllTracksBtn.Click += new System.EventHandler(this.uncheckAllTracksBtn_Click);
            // 
            // rainOnlyBtn
            // 
            this.rainOnlyBtn.Location = new System.Drawing.Point(249, 448);
            this.rainOnlyBtn.Name = "rainOnlyBtn";
            this.rainOnlyBtn.Size = new System.Drawing.Size(112, 34);
            this.rainOnlyBtn.TabIndex = 4;
            this.rainOnlyBtn.Text = "Rain Only";
            this.rainOnlyBtn.UseVisualStyleBackColor = true;
            this.rainOnlyBtn.Click += new System.EventHandler(this.rainOnlyBtn_Click);
            // 
            // nightOnlyBtn
            // 
            this.nightOnlyBtn.Location = new System.Drawing.Point(367, 448);
            this.nightOnlyBtn.Name = "nightOnlyBtn";
            this.nightOnlyBtn.Size = new System.Drawing.Size(112, 34);
            this.nightOnlyBtn.TabIndex = 5;
            this.nightOnlyBtn.Text = "Night Only";
            this.nightOnlyBtn.UseVisualStyleBackColor = true;
            this.nightOnlyBtn.Click += new System.EventHandler(this.nightOnlyBtn_Click);
            // 
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.nightOnlyBtn);
            this.Controls.Add(this.rainOnlyBtn);
            this.Controls.Add(this.uncheckAllTracksBtn);
            this.Controls.Add(this.checkAllTracksBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.trackList);
            this.Name = "TrackForm";
            this.Text = "Track Config";
            this.Load += new System.EventHandler(this.TrackForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView trackList;
        private System.Windows.Forms.ColumnHeader trackName;
        private System.Windows.Forms.ColumnHeader supportsRain;
        private System.Windows.Forms.ColumnHeader supportsNight;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button checkAllTracksBtn;
        private System.Windows.Forms.Button uncheckAllTracksBtn;
        private System.Windows.Forms.Button rainOnlyBtn;
        private System.Windows.Forms.Button nightOnlyBtn;
    }
}