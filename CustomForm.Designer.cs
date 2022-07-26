
namespace GT7_Randomizer
{
    partial class CustomForm
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
            this.customListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.customCheckAllBtn = new System.Windows.Forms.Button();
            this.customUncheckAllBtn = new System.Windows.Forms.Button();
            this.customSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customListView
            // 
            this.customListView.CheckBoxes = true;
            this.customListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7,
            this.columnHeader6,
            this.columnHeader3});
            this.customListView.GridLines = true;
            this.customListView.HideSelection = false;
            this.customListView.Location = new System.Drawing.Point(12, 12);
            this.customListView.Name = "customListView";
            this.customListView.Size = new System.Drawing.Size(1249, 544);
            this.customListView.TabIndex = 0;
            this.customListView.UseCompatibleStateImageBehavior = false;
            this.customListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Drivetrain";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HP";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Torque";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Weight";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "PP";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categories";
            this.columnHeader3.Width = 500;
            // 
            // customCheckAllBtn
            // 
            this.customCheckAllBtn.Location = new System.Drawing.Point(13, 563);
            this.customCheckAllBtn.Name = "customCheckAllBtn";
            this.customCheckAllBtn.Size = new System.Drawing.Size(112, 34);
            this.customCheckAllBtn.TabIndex = 1;
            this.customCheckAllBtn.Text = "Check All";
            this.customCheckAllBtn.UseVisualStyleBackColor = true;
            this.customCheckAllBtn.Click += new System.EventHandler(this.customCheckAllBtn_Click);
            // 
            // customUncheckAllBtn
            // 
            this.customUncheckAllBtn.Location = new System.Drawing.Point(131, 563);
            this.customUncheckAllBtn.Name = "customUncheckAllBtn";
            this.customUncheckAllBtn.Size = new System.Drawing.Size(112, 34);
            this.customUncheckAllBtn.TabIndex = 2;
            this.customUncheckAllBtn.Text = "Uncheck All";
            this.customUncheckAllBtn.UseVisualStyleBackColor = true;
            this.customUncheckAllBtn.Click += new System.EventHandler(this.customUncheckAllBtn_Click);
            // 
            // customSaveBtn
            // 
            this.customSaveBtn.Location = new System.Drawing.Point(1149, 563);
            this.customSaveBtn.Name = "customSaveBtn";
            this.customSaveBtn.Size = new System.Drawing.Size(112, 34);
            this.customSaveBtn.TabIndex = 3;
            this.customSaveBtn.Text = "Save";
            this.customSaveBtn.UseVisualStyleBackColor = true;
            this.customSaveBtn.Click += new System.EventHandler(this.customSaveBtn_Click);
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 605);
            this.Controls.Add(this.customSaveBtn);
            this.Controls.Add(this.customUncheckAllBtn);
            this.Controls.Add(this.customCheckAllBtn);
            this.Controls.Add(this.customListView);
            this.Name = "CustomForm";
            this.Text = "CustomForm";
            this.Load += new System.EventHandler(this.CustomForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button customCheckAllBtn;
        private System.Windows.Forms.Button customUncheckAllBtn;
        private System.Windows.Forms.Button customSaveBtn;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}