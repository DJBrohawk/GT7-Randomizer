using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GT7_Randomizer
{
    public partial class Form1 : Form
    {
        //an array of all the times of day in the game. Unfortunately, not every track supports these, and
        //therefore, may not be used in version 1. I'm putting them in here so I don't have to look them up
        //again for when I do use them #responsibleprogrammer
        string[] timeOfDay = {"Early Dawn", "Dawn", "Sunrise", "Early Morning",
"Late Morning", "Afternoon", "Evening", "Sunset", "Twilight", "Night", "Midnight"};


        //an array of all the weather options in the game. Unfortunately, not every track supports rain
        //(the RXX ones) and so I am unsure how I will implement these for the tracks that support it
        //versus the tracks that do not
        string[] weather = {"S01", "S02", "S03", "S04", "S05", "S06", "S07", "S08", "S09", "S10", "S11", "S12", "S13", "S14", "S15",
                            "S16", "S17", "S18", "C01", "C02", "C03", "C04", "C05", "C06", 
                            "R01", "R02", "R03", "R04", "R05", "R06", "R07", "R08"};

        //Initialize global lists to be used in functions
        List<int> gr3Repeats = new List<int>();
        List<int> gr4Repeats = new List<int>();
        List<int> customRepeats = new List<int>();
        List<int> trackRepeats = new List<int>();
        //List<int> categoryRepeats = new List<int>(); //in here in the event I want to do no repeats for categories
        List<driver> drivers = new List<driver>();
        
        int counter = 1;

        //This is a test
        //a class for drivers to use for the listview
        class driver
        {
            public int number { get; set; }
            public string name { get; set; }
            public string car { get; set; }
        }

        public Form1()
        {
            
            InitializeComponent();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //generates a car using Gr3List.txt
        private string gr3Generate() {

            List<String> gr3List = new List<String>();
            Random rnd = new Random();
            Boolean repeat = true;

            foreach (string line in System.IO.File.ReadLines(@"c:\temp\Gr3List.txt")) {

                gr3List.Add(line);

            }


            //for simplicity, there will be no repeats after 5. This can be adjusted in the code
            //or maybe via a variable down the line

            if (gr3Repeats.Count >= 5)
            {
                gr3Repeats.RemoveAt(0);

            }

            do
            {

                int car = rnd.Next(gr3List.Count);

                if (!gr3Repeats.Contains(car))
                {
                    gr3Repeats.Add(car);
                    repeat = false;
                    return gr3List[car];

                }

            } while (repeat == true);

            return "error choosing car.";    
        }

        //generates a car using Gr4List.txt
        private string gr4Generate() {

            List<String> gr4List = new List<String>();
            Random rnd = new Random();
            Boolean repeat = true;

            foreach (string line in System.IO.File.ReadLines(@"c:\temp\Gr4List.txt"))
            {
                gr4List.Add(line);
            }


            //for simplicity, there will be no repeats after 5. This can be adjusted in the code
            //or maybe via a variable down the line

            if (gr4Repeats.Count >= 5)
            {
                gr4Repeats.RemoveAt(0);
            }

            do
            {

                int car = rnd.Next(gr4List.Count);

                if (!gr4Repeats.Contains(car))
                {
                    gr4Repeats.Add(car);
                    repeat = false;
                    return gr4List[car];
                }

            } while (repeat == true);

            return "error choosing car.";
        
        }

        //generates a car using a list you can pick via a file dialog box
        private string customGenerate(string sFileName) {

            List<String> customList = new List<String>();
            Random rnd = new Random();
            Boolean repeat = true;

            foreach (string line in System.IO.File.ReadLines(sFileName))
            {

                customList.Add(line);

            }

            //for simplicity, there will be no repeats after 5. This can be adjusted in the code
            //or maybe via a variable down the line

            if (customRepeats.Count >= 5)
            {
                customRepeats.RemoveAt(0);

            }

            do
            {

                int car = rnd.Next(customList.Count);

                if (!customRepeats.Contains(car))
                {
                    customRepeats.Add(car);
                    repeat = false;
                    return customList[car];

                }

            } while (repeat == true);

            return "error choosing car.";


        }

        //generates a car using TrackList.txt and optionally, CategoryList.txt
        private string trackGenerate()
        {


            List<string> trackList = new List<string>();
            Random rnd = new Random();
            Boolean repeat = true;


            //read each line of the track list text file into an array
            foreach (string line in System.IO.File.ReadLines(@"c:\temp\TrackList.txt"))
            {
                trackList.Add(line);
            }

            //for simplicity, there will be no repeats after 5. This can be adjusted in the code
            //or maybe via a variable down the line

            if (trackRepeats.Count >= 5)
            {
                trackRepeats.RemoveAt(0);
            }

            do
            {
                int track = rnd.Next(trackList.Count);

                if (!trackRepeats.Contains(track))
                {
                    trackRepeats.Add(track);
                    repeat = false;
                    trackBox.Text = trackList[track];
                }

            } while (repeat == true);

            //if the fuel and tire wear box is checked, run through a series of checks
            //to see if the value is at 0 or not.

            if (fuelTireCheck.Checked)
            {

                int fuel = rnd.Next(Decimal.ToInt32(fuelMultiplierBox.Value) + 1);
                int tire = rnd.Next(Decimal.ToInt32(tireMultiplierBox.Value) + 1);

                if (fuelMultiplierBox.Value <= 0 || fuel <= 0) { 
                        
                    fuelUseBox.Text = "Off"; 
                
                } else 
                { 
                    fuelUseBox.Text = fuel.ToString(); 
                }



                if (tireMultiplierBox.Value <= 0 || tire <= 0) {

                    tireWearBox.Text = "Off"; 

                } else
                {
                    tireWearBox.Text = tire.ToString();
                }
                
            //basically, if it's unchecked, it just puts both at off
            }
            else
            {
                fuelUseBox.Text = "Off";
                tireWearBox.Text = "Off";
            }

            //lap/endurance amount - default value is 10

            if (maxLapBox.Value != 0)
            {
                int laps = rnd.Next(Decimal.ToInt32(maxLapBox.Value) + 1);
                lapBox.Text = laps.ToString();

            } else
            {
                int laps = rnd.Next(10) + 1;
                lapBox.Text = laps.ToString();
            }

            //Randomize the category if the category box is checked. If it isn't checked
            //then "N/A" will go in the box

            if (categoryCheck.Checked)
            {
                List<string> categoryList = new List<string>();

                foreach (string line in System.IO.File.ReadLines(@"c:\temp\CategoryList.txt"))
                {
                    categoryList.Add(line);
                }

                int category = rnd.Next(categoryList.Count);
                categoryBox.Text = categoryList[category];

            } else
            {
                categoryBox.Text = "N/A";
            }

            //start type, grid or rolling. If rolling, random distance between 50-164 feet

            if (startTypeCheck.Checked)
            {
                //generate a random number, either 1 or 0. If 1, start is rolling, if 0, start is grid

                int start = rnd.Next(2);

                if (start == 1)
                {
                    int rollingStartGap = rnd.Next(115) + 50;

                    rollingStartDistanceBox.Text = rollingStartGap.ToString();
                    startTypeBox.Text = "Rolling Start";

                } else
                {
                    startTypeBox.Text = "Grid";
                    rollingStartDistanceBox.Text = "N/A";
                }


            } else
            {
                startTypeBox.Text = "N/A";
                rollingStartDistanceBox.Text = "N/A";
            }

            //weather

            return "error choosing track";
        }

        //clears the whole list of drivers
        private void clearList() {

            driverList.Items.Clear();
        
        }

        //delete individual drivers or multi selection of drivers
        private void deleteDriver()
        {

            foreach (ListViewItem eachItem in driverList.SelectedItems)
            {
                driverList.Items.Remove(eachItem);
            }

            foreach (ListViewItem eachItem in driverList.Items)
            {
                eachItem.SubItems[0].Text = (eachItem.Index + 1).ToString();
            }

            counter = driverList.Items.Count + 1;

            driverList.Refresh();
            

        }

        //add individual drivers
        private void addDriver()
        {

            if (driverNameBox.Text.Trim() == "")
            {

                MessageBox.Show("You have entered a blank name into the driver box, please fill out the driver name box and try again.");
                return;

            }

            driver newDriver = new driver();
            string[] arr = new string[3];
            ListViewItem item;

            newDriver.number = counter;
            newDriver.name = driverNameBox.Text;
            drivers.Add(newDriver);

            arr[0] = newDriver.number.ToString();
            arr[1] = newDriver.name;
            arr[2] = "";

            item = new ListViewItem(arr);
            driverList.Items.Add(item);

            counter++;

            driverNameBox.Text = "";

        }

        private void gr3Btn_Click(object sender, EventArgs e)
        {
            randomCar.Text = gr3Generate();
        }

        private void gr4Btn_Click(object sender, EventArgs e)
        {
            randomCar.Text = gr4Generate();
        }

        private void customListBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog customListFD = new OpenFileDialog();
            customListFD.Multiselect = false;
            customListFD.Filter = "Text Files (*.txt)| *.txt";
            customListFD.FilterIndex = 1;

            if (customListFD.ShowDialog() == DialogResult.OK)
            {
                string sFileName = customListFD.FileName;

                randomCar.Text = customGenerate(sFileName);

            }
            else
            {

                MessageBox.Show("There was a problem using the custom list. Please select a .txt file containing a list of cars.");
                return;
            }          
        }

        private void AddDriverBtn_Click(object sender, EventArgs e)
        {
            addDriver();
        }

        private void gr3Race()
        {
            int count = 0;

            if(driverList.Items.Count == 0)
            {
                MessageBox.Show("There are no items in the race list, you cannot generate a race. Please add at least one driver to the race list to generate a race.");
                return;
            }

            foreach(var item in drivers)
            {
                string randCar = gr3Generate();
                driverList.Items[count].SubItems[2].Text = randCar;
                count++;
            }
        }

        private void gr4Race() {

            int count = 0;

            if (driverList.Items.Count == 0)
            {
                MessageBox.Show("There are no items in the race list, you cannot generate a race. Please add at least one driver to the race list to generate a race.");
                return;
            }

            foreach (var item in drivers)
            {
                string randCar = gr4Generate();
                driverList.Items[count].SubItems[2].Text = randCar;
                count++;
            }

        }

        private void customRace()
        {
            if (driverList.Items.Count == 0)
            {
                MessageBox.Show("There are no items in the race list, you cannot generate a race. Please add at least one driver to the race list to generate a race.");
                return;
            }

            int count = 0;

            OpenFileDialog customListFD = new OpenFileDialog();
            customListFD.Multiselect = false;
            customListFD.Filter = "Text Files (*.txt)| *.txt";
            customListFD.FilterIndex = 1;


            if (customListFD.ShowDialog() == DialogResult.OK)
            {
                string sFileName = customListFD.FileName;

                foreach (var item in drivers)
                {
                    string randCar = customGenerate(sFileName);
                    driverList.Items[count].SubItems[2].Text = randCar;
                    count++;
                }

            }
            else
            {

                MessageBox.Show("There was a problem using the custom list. Please select a .txt file containing a list of cars.");
                return;
            }
        }

        private void gr3RaceBtn_Click(object sender, EventArgs e)
        {
            gr3Race();
        }

        private void gr4RaceBtn_Click(object sender, EventArgs e)
        {
            gr4Race();
        }

        private void customRaceBtn_Click(object sender, EventArgs e)
        {
            customRace();
        }

        private void clearListBtn_Click(object sender, EventArgs e)
        {
            clearList();
            counter = 1;
        }

        private void randomRaceBtn_Click(object sender, EventArgs e)
        {
            trackGenerate();
        }

        private void deleteDriverBtn_Click(object sender, EventArgs e)
        {
            deleteDriver();
        }

        private void driverNameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                addDriver();
                
            }
        }
    }
}
