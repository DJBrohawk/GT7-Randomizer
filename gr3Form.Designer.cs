
namespace GT7_Randomizer
{
    partial class gr3Form
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
            this.gr3ListView = new System.Windows.Forms.ListView();
            this.carName = new System.Windows.Forms.ColumnHeader();
            this.drivetrain = new System.Windows.Forms.ColumnHeader();
            this.checkAllGr3Btn = new System.Windows.Forms.Button();
            this.uncheckAllGr3Btn = new System.Windows.Forms.Button();
            this.gr3FROnlyBtn = new System.Windows.Forms.Button();
            this.gr3MROnlyBtn = new System.Windows.Forms.Button();
            this.saveGr3Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gr3ListView
            // 
            this.gr3ListView.CheckBoxes = true;
            this.gr3ListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.carName,
            this.drivetrain});
            this.gr3ListView.GridLines = true;
            this.gr3ListView.HideSelection = false;
            this.gr3ListView.Location = new System.Drawing.Point(12, 12);
            this.gr3ListView.Name = "gr3ListView";
            this.gr3ListView.Size = new System.Drawing.Size(781, 385);
            this.gr3ListView.TabIndex = 0;
            this.gr3ListView.UseCompatibleStateImageBehavior = false;
            this.gr3ListView.View = System.Windows.Forms.View.Details;
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
            // checkAllGr3Btn
            // 
            this.checkAllGr3Btn.Location = new System.Drawing.Point(17, 409);
            this.checkAllGr3Btn.Name = "checkAllGr3Btn";
            this.checkAllGr3Btn.Size = new System.Drawing.Size(112, 34);
            this.checkAllGr3Btn.TabIndex = 1;
            this.checkAllGr3Btn.Text = "Check All";
            this.checkAllGr3Btn.UseVisualStyleBackColor = true;
            this.checkAllGr3Btn.Click += new System.EventHandler(this.checkAllGr3Btn_Click);
            // 
            // uncheckAllGr3Btn
            // 
            this.uncheckAllGr3Btn.Location = new System.Drawing.Point(135, 409);
            this.uncheckAllGr3Btn.Name = "uncheckAllGr3Btn";
            this.uncheckAllGr3Btn.Size = new System.Drawing.Size(112, 34);
            this.uncheckAllGr3Btn.TabIndex = 2;
            this.uncheckAllGr3Btn.Text = "Uncheck All";
            this.uncheckAllGr3Btn.UseVisualStyleBackColor = true;
            this.uncheckAllGr3Btn.Click += new System.EventHandler(this.uncheckAllGr3Btn_Click);
            // 
            // gr3FROnlyBtn
            // 
            this.gr3FROnlyBtn.Location = new System.Drawing.Point(253, 409);
            this.gr3FROnlyBtn.Name = "gr3FROnlyBtn";
            this.gr3FROnlyBtn.Size = new System.Drawing.Size(112, 34);
            this.gr3FROnlyBtn.TabIndex = 3;
            this.gr3FROnlyBtn.Text = "FR Only";
            this.gr3FROnlyBtn.UseVisualStyleBackColor = true;
            this.gr3FROnlyBtn.Click += new System.EventHandler(this.gr3FROnlyBtn_Click);
            // 
            // gr3MROnlyBtn
            // 
            this.gr3MROnlyBtn.Location = new System.Drawing.Point(371, 409);
            this.gr3MROnlyBtn.Name = "gr3MROnlyBtn";
            this.gr3MROnlyBtn.Size = new System.Drawing.Size(112, 34);
            this.gr3MROnlyBtn.TabIndex = 4;
            this.gr3MROnlyBtn.Text = "MR Only";
            this.gr3MROnlyBtn.UseVisualStyleBackColor = true;
            this.gr3MROnlyBtn.Click += new System.EventHandler(this.gr3MROnlyBtn_Click);
            // 
            // saveGr3Btn
            // 
            this.saveGr3Btn.Location = new System.Drawing.Point(676, 409);
            this.saveGr3Btn.Name = "saveGr3Btn";
            this.saveGr3Btn.Size = new System.Drawing.Size(112, 34);
            this.saveGr3Btn.TabIndex = 5;
            this.saveGr3Btn.Text = "Save";
            this.saveGr3Btn.UseVisualStyleBackColor = true;
            this.saveGr3Btn.Click += new System.EventHandler(this.saveGr3Btn_Click);
            // 
            // gr3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveGr3Btn);
            this.Controls.Add(this.gr3MROnlyBtn);
            this.Controls.Add(this.gr3FROnlyBtn);
            this.Controls.Add(this.uncheckAllGr3Btn);
            this.Controls.Add(this.checkAllGr3Btn);
            this.Controls.Add(this.gr3ListView);
            this.Name = "gr3Form";
            this.Text = "Gr.3 List";
            this.Load += new System.EventHandler(this.gr3Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView gr3ListView;
        private System.Windows.Forms.ColumnHeader carName;
        private System.Windows.Forms.ColumnHeader drivetrain;
        private System.Windows.Forms.Button checkAllGr3Btn;
        private System.Windows.Forms.Button uncheckAllGr3Btn;
        private System.Windows.Forms.Button gr3FROnlyBtn;
        private System.Windows.Forms.Button gr3MROnlyBtn;
        private System.Windows.Forms.Button saveGr3Btn;
    }
}