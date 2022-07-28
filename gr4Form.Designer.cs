
namespace GT7_Randomizer
{
    partial class gr4Form
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
            this.gr4ListView = new System.Windows.Forms.ListView();
            this.carName = new System.Windows.Forms.ColumnHeader();
            this.drivetrain = new System.Windows.Forms.ColumnHeader();
            this.gr4CheckAllBtn = new System.Windows.Forms.Button();
            this.gr4UncheckAllBtn = new System.Windows.Forms.Button();
            this.gr4FROnlyBtn = new System.Windows.Forms.Button();
            this.gr4SaveBtn = new System.Windows.Forms.Button();
            this.gr4AWDOnlyBtn = new System.Windows.Forms.Button();
            this.gr4FFOnlyBtn = new System.Windows.Forms.Button();
            this.gr4MROnlyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gr4ListView
            // 
            this.gr4ListView.CheckBoxes = true;
            this.gr4ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.carName,
            this.drivetrain});
            this.gr4ListView.GridLines = true;
            this.gr4ListView.HideSelection = false;
            this.gr4ListView.Location = new System.Drawing.Point(7, 12);
            this.gr4ListView.Name = "gr4ListView";
            this.gr4ListView.Size = new System.Drawing.Size(781, 385);
            this.gr4ListView.TabIndex = 1;
            this.gr4ListView.UseCompatibleStateImageBehavior = false;
            this.gr4ListView.View = System.Windows.Forms.View.Details;
            // 
            // carName
            // 
            this.carName.Text = "Car Name";
            this.carName.Width = 300;
            // 
            // drivetrain
            // 
            this.drivetrain.Text = "Drivetrain";
            this.drivetrain.Width = 100;
            // 
            // gr4CheckAllBtn
            // 
            this.gr4CheckAllBtn.Location = new System.Drawing.Point(12, 404);
            this.gr4CheckAllBtn.Name = "gr4CheckAllBtn";
            this.gr4CheckAllBtn.Size = new System.Drawing.Size(112, 34);
            this.gr4CheckAllBtn.TabIndex = 2;
            this.gr4CheckAllBtn.Text = "Check All";
            this.gr4CheckAllBtn.UseVisualStyleBackColor = true;
            this.gr4CheckAllBtn.Click += new System.EventHandler(this.gr4CheckAllBtn_Click);
            // 
            // gr4UncheckAllBtn
            // 
            this.gr4UncheckAllBtn.Location = new System.Drawing.Point(130, 403);
            this.gr4UncheckAllBtn.Name = "gr4UncheckAllBtn";
            this.gr4UncheckAllBtn.Size = new System.Drawing.Size(112, 34);
            this.gr4UncheckAllBtn.TabIndex = 3;
            this.gr4UncheckAllBtn.Text = "Uncheck All";
            this.gr4UncheckAllBtn.UseVisualStyleBackColor = true;
            this.gr4UncheckAllBtn.Click += new System.EventHandler(this.gr4UncheckAllBtn_Click);
            // 
            // gr4FROnlyBtn
            // 
            this.gr4FROnlyBtn.Location = new System.Drawing.Point(248, 403);
            this.gr4FROnlyBtn.Name = "gr4FROnlyBtn";
            this.gr4FROnlyBtn.Size = new System.Drawing.Size(104, 34);
            this.gr4FROnlyBtn.TabIndex = 4;
            this.gr4FROnlyBtn.Text = "FR Only";
            this.gr4FROnlyBtn.UseVisualStyleBackColor = true;
            this.gr4FROnlyBtn.Click += new System.EventHandler(this.gr4FROnlyBtn_Click);
            // 
            // gr4SaveBtn
            // 
            this.gr4SaveBtn.Location = new System.Drawing.Point(688, 403);
            this.gr4SaveBtn.Name = "gr4SaveBtn";
            this.gr4SaveBtn.Size = new System.Drawing.Size(100, 34);
            this.gr4SaveBtn.TabIndex = 9;
            this.gr4SaveBtn.Text = "Save";
            this.gr4SaveBtn.UseVisualStyleBackColor = true;
            this.gr4SaveBtn.Click += new System.EventHandler(this.gr4SaveBtn_Click);
            // 
            // gr4AWDOnlyBtn
            // 
            this.gr4AWDOnlyBtn.Location = new System.Drawing.Point(578, 403);
            this.gr4AWDOnlyBtn.Name = "gr4AWDOnlyBtn";
            this.gr4AWDOnlyBtn.Size = new System.Drawing.Size(104, 34);
            this.gr4AWDOnlyBtn.TabIndex = 10;
            this.gr4AWDOnlyBtn.Text = "4WD Only";
            this.gr4AWDOnlyBtn.UseVisualStyleBackColor = true;
            this.gr4AWDOnlyBtn.Click += new System.EventHandler(this.gr4AWDOnlyBtn_Click);
            // 
            // gr4FFOnlyBtn
            // 
            this.gr4FFOnlyBtn.Location = new System.Drawing.Point(468, 403);
            this.gr4FFOnlyBtn.Name = "gr4FFOnlyBtn";
            this.gr4FFOnlyBtn.Size = new System.Drawing.Size(104, 34);
            this.gr4FFOnlyBtn.TabIndex = 11;
            this.gr4FFOnlyBtn.Text = "FF Only";
            this.gr4FFOnlyBtn.UseVisualStyleBackColor = true;
            this.gr4FFOnlyBtn.Click += new System.EventHandler(this.gr4FFOnlyBtn_Click);
            // 
            // gr4MROnlyBtn
            // 
            this.gr4MROnlyBtn.Location = new System.Drawing.Point(358, 403);
            this.gr4MROnlyBtn.Name = "gr4MROnlyBtn";
            this.gr4MROnlyBtn.Size = new System.Drawing.Size(104, 34);
            this.gr4MROnlyBtn.TabIndex = 12;
            this.gr4MROnlyBtn.Text = "MR Only";
            this.gr4MROnlyBtn.UseVisualStyleBackColor = true;
            this.gr4MROnlyBtn.Click += new System.EventHandler(this.gr4MROnlyBtn_Click);
            // 
            // gr4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gr4MROnlyBtn);
            this.Controls.Add(this.gr4FFOnlyBtn);
            this.Controls.Add(this.gr4AWDOnlyBtn);
            this.Controls.Add(this.gr4SaveBtn);
            this.Controls.Add(this.gr4FROnlyBtn);
            this.Controls.Add(this.gr4UncheckAllBtn);
            this.Controls.Add(this.gr4CheckAllBtn);
            this.Controls.Add(this.gr4ListView);
            this.Name = "gr4Form";
            this.Text = "Gr.4 Config";
            this.Load += new System.EventHandler(this.gr4Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView gr4ListView;
        private System.Windows.Forms.ColumnHeader carName;
        private System.Windows.Forms.ColumnHeader drivetrain;
        private System.Windows.Forms.Button gr4CheckAllBtn;
        private System.Windows.Forms.Button gr4UncheckAllBtn;
        private System.Windows.Forms.Button gr4FROnlyBtn;
        private System.Windows.Forms.Button gr4SaveBtn;
        private System.Windows.Forms.Button gr4AWDOnlyBtn;
        private System.Windows.Forms.Button gr4FFOnlyBtn;
        private System.Windows.Forms.Button gr4MROnlyBtn;
    }
}