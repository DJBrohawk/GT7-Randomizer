
namespace GT7_Randomizer
{
    partial class categoryForm
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
            this.categoryListView = new System.Windows.Forms.ListView();
            this.categoryCheckAllBtn = new System.Windows.Forms.Button();
            this.categoryUncheckAllBtn = new System.Windows.Forms.Button();
            this.categoryStandardOnlyBtn = new System.Windows.Forms.Button();
            this.categoryNonStandardOnlyBtn = new System.Windows.Forms.Button();
            this.categoryCustomOnlyBtn = new System.Windows.Forms.Button();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.categorySaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categoryListView
            // 
            this.categoryListView.CheckBoxes = true;
            this.categoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.categoryListView.GridLines = true;
            this.categoryListView.HideSelection = false;
            this.categoryListView.Location = new System.Drawing.Point(12, 12);
            this.categoryListView.Name = "categoryListView";
            this.categoryListView.Size = new System.Drawing.Size(856, 507);
            this.categoryListView.TabIndex = 0;
            this.categoryListView.UseCompatibleStateImageBehavior = false;
            this.categoryListView.View = System.Windows.Forms.View.Details;
            // 
            // categoryCheckAllBtn
            // 
            this.categoryCheckAllBtn.Location = new System.Drawing.Point(12, 525);
            this.categoryCheckAllBtn.Name = "categoryCheckAllBtn";
            this.categoryCheckAllBtn.Size = new System.Drawing.Size(141, 34);
            this.categoryCheckAllBtn.TabIndex = 1;
            this.categoryCheckAllBtn.Text = "Check All";
            this.categoryCheckAllBtn.UseVisualStyleBackColor = true;
            // 
            // categoryUncheckAllBtn
            // 
            this.categoryUncheckAllBtn.Location = new System.Drawing.Point(159, 525);
            this.categoryUncheckAllBtn.Name = "categoryUncheckAllBtn";
            this.categoryUncheckAllBtn.Size = new System.Drawing.Size(141, 34);
            this.categoryUncheckAllBtn.TabIndex = 2;
            this.categoryUncheckAllBtn.Text = "Uncheck All";
            this.categoryUncheckAllBtn.UseVisualStyleBackColor = true;
            // 
            // categoryStandardOnlyBtn
            // 
            this.categoryStandardOnlyBtn.Location = new System.Drawing.Point(306, 525);
            this.categoryStandardOnlyBtn.Name = "categoryStandardOnlyBtn";
            this.categoryStandardOnlyBtn.Size = new System.Drawing.Size(141, 34);
            this.categoryStandardOnlyBtn.TabIndex = 4;
            this.categoryStandardOnlyBtn.Text = "Standard Only";
            this.categoryStandardOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // categoryNonStandardOnlyBtn
            // 
            this.categoryNonStandardOnlyBtn.Location = new System.Drawing.Point(453, 525);
            this.categoryNonStandardOnlyBtn.Name = "categoryNonStandardOnlyBtn";
            this.categoryNonStandardOnlyBtn.Size = new System.Drawing.Size(174, 34);
            this.categoryNonStandardOnlyBtn.TabIndex = 5;
            this.categoryNonStandardOnlyBtn.Text = "Nonstandard Only";
            this.categoryNonStandardOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // categoryCustomOnlyBtn
            // 
            this.categoryCustomOnlyBtn.Location = new System.Drawing.Point(633, 525);
            this.categoryCustomOnlyBtn.Name = "categoryCustomOnlyBtn";
            this.categoryCustomOnlyBtn.Size = new System.Drawing.Size(141, 34);
            this.categoryCustomOnlyBtn.TabIndex = 6;
            this.categoryCustomOnlyBtn.Text = "Custom Only";
            this.categoryCustomOnlyBtn.UseVisualStyleBackColor = true;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Category";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 600;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Standard";
            this.columnHeader3.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 583);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(693, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Custom Category entries will be at the bottom of the list and not sorted alphabet" +
    "ically";
            // 
            // categorySaveBtn
            // 
            this.categorySaveBtn.Location = new System.Drawing.Point(726, 578);
            this.categorySaveBtn.Name = "categorySaveBtn";
            this.categorySaveBtn.Size = new System.Drawing.Size(141, 34);
            this.categorySaveBtn.TabIndex = 8;
            this.categorySaveBtn.Text = "Save";
            this.categorySaveBtn.UseVisualStyleBackColor = true;
            // 
            // categoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 618);
            this.Controls.Add(this.categorySaveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryCustomOnlyBtn);
            this.Controls.Add(this.categoryNonStandardOnlyBtn);
            this.Controls.Add(this.categoryStandardOnlyBtn);
            this.Controls.Add(this.categoryUncheckAllBtn);
            this.Controls.Add(this.categoryCheckAllBtn);
            this.Controls.Add(this.categoryListView);
            this.Name = "categoryForm";
            this.Text = "Category Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView categoryListView;
        private System.Windows.Forms.Button categoryCheckAllBtn;
        private System.Windows.Forms.Button categoryUncheckAllBtn;
        private System.Windows.Forms.Button categoryStandardOnlyBtn;
        private System.Windows.Forms.Button categoryNonStandardOnlyBtn;
        private System.Windows.Forms.Button categoryCustomOnlyBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button categorySaveBtn;
    }
}