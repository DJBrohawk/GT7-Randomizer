
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
            this.supportsRain.Text = "Supports Rain?";
            this.supportsRain.Width = 40;
            // 
            // supportsNight
            // 
            this.supportsNight.Text = "Night Driving?";
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
            // TrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.trackList);
            this.Name = "TrackForm";
            this.Text = "TrackForm";
            this.Load += new System.EventHandler(this.TrackForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView trackList;
        private System.Windows.Forms.ColumnHeader trackName;
        private System.Windows.Forms.ColumnHeader supportsRain;
        private System.Windows.Forms.ColumnHeader supportsNight;
        private System.Windows.Forms.Button saveBtn;
    }
}