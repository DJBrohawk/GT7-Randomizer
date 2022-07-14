
namespace GT7_Randomizer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gr3Btn = new System.Windows.Forms.Button();
            this.gr4Btn = new System.Windows.Forms.Button();
            this.randomCarBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.driverNameBox = new System.Windows.Forms.TextBox();
            this.AddDriverBtn = new System.Windows.Forms.Button();
            this.customListBtn = new System.Windows.Forms.Button();
            this.gr3RaceBtn = new System.Windows.Forms.Button();
            this.gr4RaceBtn = new System.Windows.Forms.Button();
            this.customRaceBtn = new System.Windows.Forms.Button();
            this.driverList = new System.Windows.Forms.ListView();
            this.No = new System.Windows.Forms.ColumnHeader();
            this.DriverName = new System.Windows.Forms.ColumnHeader();
            this.Car = new System.Windows.Forms.ColumnHeader();
            this.clearListBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBox = new System.Windows.Forms.TextBox();
            this.randomRaceBtn = new System.Windows.Forms.Button();
            this.weatherCheck = new System.Windows.Forms.CheckBox();
            this.fuelTireCheck = new System.Windows.Forms.CheckBox();
            this.fuelUseBox = new System.Windows.Forms.TextBox();
            this.tireWearBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lapBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.enduranceCheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.weatherBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bopCheck = new System.Windows.Forms.CheckBox();
            this.bopBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maxLapBox = new System.Windows.Forms.NumericUpDown();
            this.fuelMultiplierBox = new System.Windows.Forms.NumericUpDown();
            this.tireMultiplierBox = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.categoryCheck = new System.Windows.Forms.CheckBox();
            this.deleteDriverBtn = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.startTimeBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.startTypeBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.timeMultiplierBox = new System.Windows.Forms.TextBox();
            this.startTypeCheck = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rollingStartDistanceBox = new System.Windows.Forms.TextBox();
            this.timeMultiplierCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.raceTypeBox = new System.Windows.Forms.TextBox();
            this.raceLengthCheck = new System.Windows.Forms.CheckBox();
            this.trackConfigureBtn = new System.Windows.Forms.Button();
            this.forceRainCheck = new System.Windows.Forms.CheckBox();
            this.forceNightCheck = new System.Windows.Forms.CheckBox();
            this.startTimeCheck = new System.Windows.Forms.CheckBox();
            this.gr3ConfigureBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maxLapBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelMultiplierBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireMultiplierBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gr3Btn
            // 
            this.gr3Btn.Location = new System.Drawing.Point(57, 549);
            this.gr3Btn.Name = "gr3Btn";
            this.gr3Btn.Size = new System.Drawing.Size(200, 34);
            this.gr3Btn.TabIndex = 0;
            this.gr3Btn.Text = "Generate Random Gr3 Car";
            this.gr3Btn.UseVisualStyleBackColor = true;
            this.gr3Btn.Click += new System.EventHandler(this.gr3Btn_Click);
            // 
            // gr4Btn
            // 
            this.gr4Btn.Location = new System.Drawing.Point(263, 549);
            this.gr4Btn.Name = "gr4Btn";
            this.gr4Btn.Size = new System.Drawing.Size(200, 34);
            this.gr4Btn.TabIndex = 1;
            this.gr4Btn.Text = "Generate Random Gr4";
            this.gr4Btn.UseVisualStyleBackColor = true;
            this.gr4Btn.Click += new System.EventHandler(this.gr4Btn_Click);
            // 
            // randomCarBox
            // 
            this.randomCarBox.Location = new System.Drawing.Point(129, 496);
            this.randomCarBox.Name = "randomCarBox";
            this.randomCarBox.Size = new System.Drawing.Size(570, 31);
            this.randomCarBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 499);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Random Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(716, 150);
            this.label2.TabIndex = 4;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // driverNameBox
            // 
            this.driverNameBox.Location = new System.Drawing.Point(921, 392);
            this.driverNameBox.Name = "driverNameBox";
            this.driverNameBox.Size = new System.Drawing.Size(183, 31);
            this.driverNameBox.TabIndex = 6;
            this.driverNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.driverNameBox_KeyDown);
            // 
            // AddDriverBtn
            // 
            this.AddDriverBtn.Location = new System.Drawing.Point(1110, 389);
            this.AddDriverBtn.Name = "AddDriverBtn";
            this.AddDriverBtn.Size = new System.Drawing.Size(121, 35);
            this.AddDriverBtn.TabIndex = 7;
            this.AddDriverBtn.Text = "Add Driver";
            this.AddDriverBtn.UseVisualStyleBackColor = true;
            this.AddDriverBtn.Click += new System.EventHandler(this.AddDriverBtn_Click);
            // 
            // customListBtn
            // 
            this.customListBtn.Location = new System.Drawing.Point(469, 549);
            this.customListBtn.Name = "customListBtn";
            this.customListBtn.Size = new System.Drawing.Size(288, 34);
            this.customListBtn.TabIndex = 8;
            this.customListBtn.Text = "Generate Random from Custom";
            this.customListBtn.UseVisualStyleBackColor = true;
            this.customListBtn.Click += new System.EventHandler(this.customListBtn_Click);
            // 
            // gr3RaceBtn
            // 
            this.gr3RaceBtn.Location = new System.Drawing.Point(921, 469);
            this.gr3RaceBtn.Name = "gr3RaceBtn";
            this.gr3RaceBtn.Size = new System.Drawing.Size(310, 34);
            this.gr3RaceBtn.TabIndex = 9;
            this.gr3RaceBtn.Text = "Generate Gr3 Race";
            this.gr3RaceBtn.UseVisualStyleBackColor = true;
            this.gr3RaceBtn.Click += new System.EventHandler(this.gr3RaceBtn_Click);
            // 
            // gr4RaceBtn
            // 
            this.gr4RaceBtn.Location = new System.Drawing.Point(921, 509);
            this.gr4RaceBtn.Name = "gr4RaceBtn";
            this.gr4RaceBtn.Size = new System.Drawing.Size(310, 34);
            this.gr4RaceBtn.TabIndex = 10;
            this.gr4RaceBtn.Text = "Generate Gr4 Race";
            this.gr4RaceBtn.UseVisualStyleBackColor = true;
            this.gr4RaceBtn.Click += new System.EventHandler(this.gr4RaceBtn_Click);
            // 
            // customRaceBtn
            // 
            this.customRaceBtn.Location = new System.Drawing.Point(921, 549);
            this.customRaceBtn.Name = "customRaceBtn";
            this.customRaceBtn.Size = new System.Drawing.Size(310, 34);
            this.customRaceBtn.TabIndex = 11;
            this.customRaceBtn.Text = "Generate Race from Custom List";
            this.customRaceBtn.UseVisualStyleBackColor = true;
            this.customRaceBtn.Click += new System.EventHandler(this.customRaceBtn_Click);
            // 
            // driverList
            // 
            this.driverList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.DriverName,
            this.Car});
            this.driverList.FullRowSelect = true;
            this.driverList.GridLines = true;
            this.driverList.HideSelection = false;
            this.driverList.Location = new System.Drawing.Point(921, 9);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(304, 368);
            this.driverList.TabIndex = 12;
            this.driverList.UseCompatibleStateImageBehavior = false;
            this.driverList.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "#";
            this.No.Width = 25;
            // 
            // DriverName
            // 
            this.DriverName.Text = "Driver";
            this.DriverName.Width = 100;
            // 
            // Car
            // 
            this.Car.Text = "Car";
            this.Car.Width = 200;
            // 
            // clearListBtn
            // 
            this.clearListBtn.Location = new System.Drawing.Point(1078, 430);
            this.clearListBtn.Name = "clearListBtn";
            this.clearListBtn.Size = new System.Drawing.Size(153, 33);
            this.clearListBtn.TabIndex = 13;
            this.clearListBtn.Text = "Delete All";
            this.clearListBtn.UseVisualStyleBackColor = true;
            this.clearListBtn.Click += new System.EventHandler(this.clearListBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Track";
            // 
            // trackBox
            // 
            this.trackBox.Location = new System.Drawing.Point(69, 173);
            this.trackBox.Name = "trackBox";
            this.trackBox.Size = new System.Drawing.Size(533, 31);
            this.trackBox.TabIndex = 17;
            // 
            // randomRaceBtn
            // 
            this.randomRaceBtn.Location = new System.Drawing.Point(56, 385);
            this.randomRaceBtn.Name = "randomRaceBtn";
            this.randomRaceBtn.Size = new System.Drawing.Size(485, 34);
            this.randomRaceBtn.TabIndex = 18;
            this.randomRaceBtn.Text = "Generate Random Track";
            this.randomRaceBtn.UseVisualStyleBackColor = true;
            this.randomRaceBtn.Click += new System.EventHandler(this.randomRaceBtn_Click);
            // 
            // weatherCheck
            // 
            this.weatherCheck.AutoSize = true;
            this.weatherCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.weatherCheck.Location = new System.Drawing.Point(798, 252);
            this.weatherCheck.Name = "weatherCheck";
            this.weatherCheck.Size = new System.Drawing.Size(103, 29);
            this.weatherCheck.TabIndex = 19;
            this.weatherCheck.Text = "Weather";
            this.weatherCheck.UseVisualStyleBackColor = true;
            // 
            // fuelTireCheck
            // 
            this.fuelTireCheck.AutoSize = true;
            this.fuelTireCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fuelTireCheck.Location = new System.Drawing.Point(751, 284);
            this.fuelTireCheck.Name = "fuelTireCheck";
            this.fuelTireCheck.Size = new System.Drawing.Size(150, 29);
            this.fuelTireCheck.TabIndex = 20;
            this.fuelTireCheck.Text = "Fuel/Tire Wear";
            this.fuelTireCheck.UseVisualStyleBackColor = true;
            // 
            // fuelUseBox
            // 
            this.fuelUseBox.Location = new System.Drawing.Point(90, 248);
            this.fuelUseBox.Name = "fuelUseBox";
            this.fuelUseBox.Size = new System.Drawing.Size(33, 31);
            this.fuelUseBox.TabIndex = 21;
            // 
            // tireWearBox
            // 
            this.tireWearBox.Location = new System.Drawing.Point(220, 247);
            this.tireWearBox.Name = "tireWearBox";
            this.tireWearBox.Size = new System.Drawing.Size(33, 31);
            this.tireWearBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Fuel Use";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Tire Wear";
            // 
            // lapBox
            // 
            this.lapBox.Location = new System.Drawing.Point(286, 211);
            this.lapBox.Name = "lapBox";
            this.lapBox.Size = new System.Drawing.Size(40, 31);
            this.lapBox.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(185, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Laps/Mins.";
            // 
            // enduranceCheck
            // 
            this.enduranceCheck.AutoSize = true;
            this.enduranceCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.enduranceCheck.Location = new System.Drawing.Point(784, 217);
            this.enduranceCheck.Name = "enduranceCheck";
            this.enduranceCheck.Size = new System.Drawing.Size(117, 29);
            this.enduranceCheck.TabIndex = 29;
            this.enduranceCheck.Text = "Race Type";
            this.enduranceCheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(688, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "Max # of Laps/Mins";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(661, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Max Fuel Use Multiplier";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(655, 432);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Max Tire Wear Multiplier";
            // 
            // weatherBox
            // 
            this.weatherBox.Location = new System.Drawing.Point(451, 248);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(150, 31);
            this.weatherBox.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Weather";
            // 
            // bopCheck
            // 
            this.bopCheck.AutoSize = true;
            this.bopCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bopCheck.Location = new System.Drawing.Point(832, 182);
            this.bopCheck.Name = "bopCheck";
            this.bopCheck.Size = new System.Drawing.Size(69, 29);
            this.bopCheck.TabIndex = 37;
            this.bopCheck.Text = "BoP";
            this.bopCheck.UseVisualStyleBackColor = true;
            // 
            // bopBox
            // 
            this.bopBox.Location = new System.Drawing.Point(376, 210);
            this.bopBox.Name = "bopBox";
            this.bopBox.Size = new System.Drawing.Size(47, 31);
            this.bopBox.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 25);
            this.label13.TabIndex = 39;
            this.label13.Text = "BoP";
            // 
            // maxLapBox
            // 
            this.maxLapBox.Location = new System.Drawing.Point(863, 354);
            this.maxLapBox.Name = "maxLapBox";
            this.maxLapBox.Size = new System.Drawing.Size(55, 31);
            this.maxLapBox.TabIndex = 40;
            this.maxLapBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // fuelMultiplierBox
            // 
            this.fuelMultiplierBox.Location = new System.Drawing.Point(863, 391);
            this.fuelMultiplierBox.Name = "fuelMultiplierBox";
            this.fuelMultiplierBox.Size = new System.Drawing.Size(55, 31);
            this.fuelMultiplierBox.TabIndex = 41;
            this.fuelMultiplierBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tireMultiplierBox
            // 
            this.tireMultiplierBox.Location = new System.Drawing.Point(863, 428);
            this.tireMultiplierBox.Name = "tireMultiplierBox";
            this.tireMultiplierBox.Size = new System.Drawing.Size(55, 31);
            this.tireMultiplierBox.TabIndex = 42;
            this.tireMultiplierBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 43;
            this.label14.Text = "Category";
            // 
            // categoryBox
            // 
            this.categoryBox.Location = new System.Drawing.Point(519, 211);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(82, 31);
            this.categoryBox.TabIndex = 44;
            // 
            // categoryCheck
            // 
            this.categoryCheck.AutoSize = true;
            this.categoryCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoryCheck.Location = new System.Drawing.Point(791, 147);
            this.categoryCheck.Name = "categoryCheck";
            this.categoryCheck.Size = new System.Drawing.Size(110, 29);
            this.categoryCheck.TabIndex = 45;
            this.categoryCheck.Text = "Category";
            this.categoryCheck.UseVisualStyleBackColor = true;
            // 
            // deleteDriverBtn
            // 
            this.deleteDriverBtn.Location = new System.Drawing.Point(921, 429);
            this.deleteDriverBtn.Name = "deleteDriverBtn";
            this.deleteDriverBtn.Size = new System.Drawing.Size(151, 34);
            this.deleteDriverBtn.TabIndex = 46;
            this.deleteDriverBtn.Text = "Delete Driver";
            this.deleteDriverBtn.UseVisualStyleBackColor = true;
            this.deleteDriverBtn.Click += new System.EventHandler(this.deleteDriverBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 325);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 25);
            this.label15.TabIndex = 47;
            this.label15.Text = "Starting Time";
            // 
            // startTimeBox
            // 
            this.startTimeBox.Location = new System.Drawing.Point(134, 324);
            this.startTimeBox.Name = "startTimeBox";
            this.startTimeBox.Size = new System.Drawing.Size(150, 31);
            this.startTimeBox.TabIndex = 48;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 290);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 25);
            this.label16.TabIndex = 49;
            this.label16.Text = "Start Type";
            // 
            // startTypeBox
            // 
            this.startTypeBox.Location = new System.Drawing.Point(108, 287);
            this.startTypeBox.Name = "startTypeBox";
            this.startTypeBox.Size = new System.Drawing.Size(150, 31);
            this.startTypeBox.TabIndex = 50;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(314, 328);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 25);
            this.label17.TabIndex = 51;
            this.label17.Text = "Time Multiplier";
            // 
            // timeMultiplierBox
            // 
            this.timeMultiplierBox.Location = new System.Drawing.Point(451, 328);
            this.timeMultiplierBox.Name = "timeMultiplierBox";
            this.timeMultiplierBox.Size = new System.Drawing.Size(150, 31);
            this.timeMultiplierBox.TabIndex = 52;
            // 
            // startTypeCheck
            // 
            this.startTypeCheck.AutoSize = true;
            this.startTypeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startTypeCheck.Location = new System.Drawing.Point(785, 112);
            this.startTypeCheck.Name = "startTypeCheck";
            this.startTypeCheck.Size = new System.Drawing.Size(116, 29);
            this.startTypeCheck.TabIndex = 53;
            this.startTypeCheck.Text = "Start Type";
            this.startTypeCheck.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(288, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(179, 25);
            this.label18.TabIndex = 54;
            this.label18.Text = "Rolling Start Distance";
            // 
            // rollingStartDistanceBox
            // 
            this.rollingStartDistanceBox.Location = new System.Drawing.Point(473, 288);
            this.rollingStartDistanceBox.Name = "rollingStartDistanceBox";
            this.rollingStartDistanceBox.Size = new System.Drawing.Size(128, 31);
            this.rollingStartDistanceBox.TabIndex = 55;
            // 
            // timeMultiplierCheck
            // 
            this.timeMultiplierCheck.AutoSize = true;
            this.timeMultiplierCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.timeMultiplierCheck.Location = new System.Drawing.Point(746, 77);
            this.timeMultiplierCheck.Name = "timeMultiplierCheck";
            this.timeMultiplierCheck.Size = new System.Drawing.Size(155, 29);
            this.timeMultiplierCheck.TabIndex = 56;
            this.timeMultiplierCheck.Text = "Time Multiplier";
            this.timeMultiplierCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(705, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Randomization Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "Race Type";
            // 
            // raceTypeBox
            // 
            this.raceTypeBox.Location = new System.Drawing.Point(103, 211);
            this.raceTypeBox.Name = "raceTypeBox";
            this.raceTypeBox.Size = new System.Drawing.Size(76, 31);
            this.raceTypeBox.TabIndex = 59;
            // 
            // raceLengthCheck
            // 
            this.raceLengthCheck.AutoSize = true;
            this.raceLengthCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.raceLengthCheck.Location = new System.Drawing.Point(782, 319);
            this.raceLengthCheck.Name = "raceLengthCheck";
            this.raceLengthCheck.Size = new System.Drawing.Size(119, 29);
            this.raceLengthCheck.TabIndex = 60;
            this.raceLengthCheck.Text = "Laps/Mins";
            this.raceLengthCheck.UseVisualStyleBackColor = true;
            // 
            // trackConfigureBtn
            // 
            this.trackConfigureBtn.Location = new System.Drawing.Point(302, 428);
            this.trackConfigureBtn.Name = "trackConfigureBtn";
            this.trackConfigureBtn.Size = new System.Drawing.Size(120, 34);
            this.trackConfigureBtn.TabIndex = 61;
            this.trackConfigureBtn.Text = "Track Config";
            this.trackConfigureBtn.UseVisualStyleBackColor = true;
            this.trackConfigureBtn.Click += new System.EventHandler(this.trackConfigureBtn_Click);
            // 
            // forceRainCheck
            // 
            this.forceRainCheck.AutoSize = true;
            this.forceRainCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forceRainCheck.Location = new System.Drawing.Point(620, 77);
            this.forceRainCheck.Name = "forceRainCheck";
            this.forceRainCheck.Size = new System.Drawing.Size(120, 29);
            this.forceRainCheck.TabIndex = 63;
            this.forceRainCheck.Text = "Force Rain";
            this.forceRainCheck.UseVisualStyleBackColor = true;
            // 
            // forceNightCheck
            // 
            this.forceNightCheck.AutoSize = true;
            this.forceNightCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.forceNightCheck.Location = new System.Drawing.Point(620, 112);
            this.forceNightCheck.Name = "forceNightCheck";
            this.forceNightCheck.Size = new System.Drawing.Size(130, 29);
            this.forceNightCheck.TabIndex = 64;
            this.forceNightCheck.Text = "Force Night";
            this.forceNightCheck.UseVisualStyleBackColor = true;
            // 
            // startTimeCheck
            // 
            this.startTimeCheck.AutoSize = true;
            this.startTimeCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startTimeCheck.Location = new System.Drawing.Point(633, 147);
            this.startTimeCheck.Name = "startTimeCheck";
            this.startTimeCheck.Size = new System.Drawing.Size(117, 29);
            this.startTimeCheck.TabIndex = 65;
            this.startTimeCheck.Text = "Start Time";
            this.startTimeCheck.UseVisualStyleBackColor = true;
            // 
            // gr3ConfigureBtn
            // 
            this.gr3ConfigureBtn.Location = new System.Drawing.Point(469, 425);
            this.gr3ConfigureBtn.Name = "gr3ConfigureBtn";
            this.gr3ConfigureBtn.Size = new System.Drawing.Size(112, 34);
            this.gr3ConfigureBtn.TabIndex = 66;
            this.gr3ConfigureBtn.Text = "Gr3 Config";
            this.gr3ConfigureBtn.UseVisualStyleBackColor = true;
            this.gr3ConfigureBtn.Click += new System.EventHandler(this.gr3ConfigureBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 589);
            this.Controls.Add(this.gr3ConfigureBtn);
            this.Controls.Add(this.startTimeCheck);
            this.Controls.Add(this.forceNightCheck);
            this.Controls.Add(this.forceRainCheck);
            this.Controls.Add(this.trackConfigureBtn);
            this.Controls.Add(this.raceLengthCheck);
            this.Controls.Add(this.raceTypeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeMultiplierCheck);
            this.Controls.Add(this.rollingStartDistanceBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.startTypeCheck);
            this.Controls.Add(this.timeMultiplierBox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.startTypeBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.startTimeBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.deleteDriverBtn);
            this.Controls.Add(this.categoryCheck);
            this.Controls.Add(this.categoryBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tireMultiplierBox);
            this.Controls.Add(this.fuelMultiplierBox);
            this.Controls.Add(this.maxLapBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bopBox);
            this.Controls.Add(this.bopCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.enduranceCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lapBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tireWearBox);
            this.Controls.Add(this.fuelUseBox);
            this.Controls.Add(this.fuelTireCheck);
            this.Controls.Add(this.weatherCheck);
            this.Controls.Add(this.randomRaceBtn);
            this.Controls.Add(this.trackBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearListBtn);
            this.Controls.Add(this.driverList);
            this.Controls.Add(this.customRaceBtn);
            this.Controls.Add(this.gr4RaceBtn);
            this.Controls.Add(this.gr3RaceBtn);
            this.Controls.Add(this.customListBtn);
            this.Controls.Add(this.AddDriverBtn);
            this.Controls.Add(this.driverNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.randomCarBox);
            this.Controls.Add(this.gr4Btn);
            this.Controls.Add(this.gr3Btn);
            this.Name = "Form1";
            this.Text = "GT7 Randomizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxLapBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelMultiplierBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireMultiplierBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gr3Btn;
        private System.Windows.Forms.Button gr4Btn;
        private System.Windows.Forms.TextBox randomCarBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox driverNameBox;
        private System.Windows.Forms.Button AddDriverBtn;
        private System.Windows.Forms.Button customListBtn;
        private System.Windows.Forms.Button gr3RaceBtn;
        private System.Windows.Forms.Button gr4RaceBtn;
        private System.Windows.Forms.Button customRaceBtn;
        private System.Windows.Forms.ListView driverList;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader DriverName;
        private System.Windows.Forms.ColumnHeader Car;
        private System.Windows.Forms.Button clearListBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox trackBox;
        private System.Windows.Forms.Button randomRaceBtn;
        private System.Windows.Forms.CheckBox weatherCheck;
        private System.Windows.Forms.CheckBox fuelTireCheck;
        private System.Windows.Forms.TextBox fuelUseBox;
        private System.Windows.Forms.TextBox tireWearBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lapBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox enduranceCheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox weatherBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox bopCheck;
        private System.Windows.Forms.TextBox bopBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown maxLapBox;
        private System.Windows.Forms.NumericUpDown fuelMultiplierBox;
        private System.Windows.Forms.NumericUpDown tireMultiplierBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.CheckBox categoryCheck;
        private System.Windows.Forms.Button deleteDriverBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox startTimeBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox startTypeBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox timeMultiplierBox;
        private System.Windows.Forms.CheckBox startTypeCheck;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox rollingStartDistanceBox;
        private System.Windows.Forms.CheckBox timeMultiplierCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox raceTypeBox;
        private System.Windows.Forms.CheckBox raceLengthCheck;
        private System.Windows.Forms.Button trackConfigureBtn;
        private System.Windows.Forms.CheckBox forceRainCheck;
        private System.Windows.Forms.CheckBox forceNightCheck;
        private System.Windows.Forms.CheckBox startTimeCheck;
        private System.Windows.Forms.Button gr3ConfigureBtn;
    }
}

