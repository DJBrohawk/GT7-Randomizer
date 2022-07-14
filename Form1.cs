using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GT7_Randomizer
{
    public partial class Form1 : Form
    {

        //trust me when I say you may want to avert your gaze if you expand this
        //I couldn't think of a better way to handle the E L E V E N different combinations
        //that PD somehow managed to throw at us

        //0-4 in the array are night options
        public string[][] jaggedTimeOfDay = new string[][]

        {
            //because of the way I did this, there's no order to this list
            //so the night calculations will be weird. Sorry, future me.
            //0 is the list of them all

            //0, night
            new string[]{"Early Dawn", "Dawn", "Sunrise", "Early Morning",
"Late Morning", "Afternoon", "Evening", "Sunset", "Twilight", "Night", "Midnight"},
            //1, night
            new string[]{ "Dawn", "Sunrise", "Early Morning", "Late Morning",
                "Afternoon", "Evening", "Sunset", "Twilight", "Night"},
            //2, night
            new string[]{ "Sunrise", "Early Morning", "Late Morning", "Afternoon",
                "Evening", "Sunset", "Twilight", "Night"},
            //3, night
            new string[]{ "Early Morning", "Late Morning", "Afternoon", "Evening", "Sunset", "Twilight", "Night"},
            //4, night
            new string[]{ "Early Dawn", "Dawn", "Sunrise", "Early Morning", "Late Morning",
                "Afternoon", "Evening", "Sunset", "Twilight", "Night"},    
            //5
            new string[]{ "Early Morning", "Late Morning", "Afternoon", "Evening", "Sunset"},
            //6
            new string[]{ "Early Morning", "Late Morning", "Afternoon", "Evening", "Sunset", "Twilight"},
            //7
            new string[]{ "Sunrise", "Early Morning", "Late Morning", "Afternoon", "Evening", "Sunset", "Twilight"},
            //8
            new string[]{ "Early Morning", "Late Morning", "Afternoon", "Evening"},
            //9
            new string[]{ "Dawn", "Sunrise", "Early Morning", "Late Morning", "Afternoon", "Evening", "Sunset", "Twilight"},
            //10
            new string[]{ "Early Dawn", "Dawn", "Sunrise", "Early Morning", "Late Morning", "Afternoon", 
                "Evening", "Sunset", "Twilight"}

        };

        //doing a similar thing for the weather, but there's only two arrays instead of 11.

        public string[][] jaggedWeatherList = new string[][]
        {
            //0, no rain
            new string[] {"S01", "S02", "S03", "S04", "S05", "S06", "S07", "S08", "S09", "S10", "S11", "S12", "S13", "S14", "S15",
                            "S16", "S17", "S18", "C01", "C02", "C03", "C04", "C05", "C06"},
            //1, rain
            new string[] {"S01", "S02", "S03", "S04", "S05", "S06", "S07", "S08", "S09", "S10", "S11", "S12", "S13", "S14", "S15",
                            "S16", "S17", "S18", "C01", "C02", "C03", "C04", "C05", "C06",
                            "R01", "R02", "R03", "R04", "R05", "R06", "R07", "R08"}
        };

      

        //*****NOTE***** - be sure to program this in such a way
        //that if you hard code the no repeats value, or even if you don't
        //if they try to pass in some list that is shorter than the no repeats
        //setting, it doesn't infinite loop or blow up


        //Initialize global lists to be used in functions
        List<int> gr3Repeats = new List<int>();
        List<int> gr4Repeats = new List<int>();
        List<int> customRepeats = new List<int>();
        List<string> trackRepeats = new List<string>();
        //List<int> categoryRepeats = new List<int>(); //in here in the event I want to do no repeats for categories
        List<driver> drivers = new List<driver>();
        
        int counter = 1;

        //creating track list to pass into the track form, as well as an instance of the track form
        List<ListViewItem> trackList = new List<ListViewItem>();
        TrackForm tf = new TrackForm();

        public List<track> trackListNew { get; set; }
        List<track> baseTrackList = new List<track>();

        //note, may need to do the new and base list like above
        //but trying just one list for this
        List<ListViewItem> gr3FormList = new List<ListViewItem>();
        gr3Form g3f = new gr3Form();
        List<car> gr3List = new List<car>();
        
        //a class for drivers to use for the listview
        class driver
        {
            public int number { get; set; }
            public string name { get; set; }
            public string car { get; set; }
        }

        //a class for tracks for a future listview use
        public class track
        {
            //this will be for if it supports rain or not. If it does, the program will push the rain choices
            //into this list as well as the sunny/cloudy choices
            public List<string> weather { get; set; }

            //Not every track supports every time of day. This allows for a fluid list of the supported
            //times for when randomization comes
            public List<string> timeOfDay { get; set; }

            public string name { get; set; }

            public string supportsRain { get; set; }

            public string supportsNight { get; set; }

            public track (string nm, string rain, string night, List<string> rainList, List<string> timeOfDayList)
            {

                name = nm;
                supportsRain = rain;
                supportsNight = night;
                weather = rainList;
                timeOfDay = timeOfDayList;


            }

            public track() {}

            public string getWeather(bool forceRain) {

                Random rnd = new Random();
                int weatherNumber = rnd.Next(8) + 23;
               
                //this handles occasions where force rain is on and the track doesn't have rain
                if (weather.Count <= 25)
                {
                    return getWeather();
                }

                if (forceRain == true)
                {
                    return weather[weatherNumber];
                } else
                {
                   return getWeather();
                }
            
            
            
            }

            public string getWeather() {

                Random rnd = new Random();

                int weatherNumber = rnd.Next(weather.Count);

                return weather[weatherNumber];
            
            }

            public string getTimeOfDay(bool forceNight)
            {
                if (forceNight == true)
                {

                    if (timeOfDay[timeOfDay.Count - 1] == "Night" || timeOfDay[timeOfDay.Count - 1] == "Midnight")
                    {
                        return timeOfDay[timeOfDay.Count - 1];
                    }
                    else
                    {
                        return getTimeOfDay();
                    }

                } else
                {
                    return getTimeOfDay();
                }
            }

            public string getTimeOfDay()
            {

                Random rnd = new Random();

                int timeChoice = rnd.Next(timeOfDay.Count);

                return timeOfDay[timeChoice];


            }
        }

        public class car
        {

            public string name { get; set; }

            public string drivetrain { get; set; }

            public int hp { get; set; }

            public int weight { get; set; }

            public car(string nm, string dt)
            {

                this.name = nm;
                this.drivetrain = dt;

            }


        }

        public Form1()
        {
            
            InitializeComponent();

            //event listener that listens for when the track form is closed. When it is, we pull the track list
            //from the track configuration form, so that we use the updated list with our calculations
            tf.Closed += (sender, args) => this.trackListNew = tf.getTrackList();
            g3f.Closed += (sender, args) => this.gr3List = g3f.getCarList();
        }   

        public void Form1_Load(object sender, EventArgs e)
        {
            //on load, this loads the data into the Track Configure Form. I think this is the only way
            //to do this so that the form remembers which boxes are checked and which ones aren't
            //Actually, I'm sure there's a better way, but #babyprogrammer
            loadTrackConfigure();

            //on program load, this loads the data into the Gr3 configure form. Same #babyprogrammer
            //excuse for this also
            loadGr3Configure();
              
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

            Random rnd = new Random();
            Boolean repeat = true;


            //for simplicity, there will be no repeats after 5. This can be adjusted in the code
            //or maybe via a variable down the line

            if (trackRepeats.Count >= 5)
            {
                trackRepeats.RemoveAt(0);
            }

            do
            {
                int track = rnd.Next(trackListNew.Count);
                string trackName = trackListNew[track].name;

                weatherText(trackListNew[track]);
                timeOfDayText(trackListNew[track]);

                if (!trackRepeats.Contains(trackName))
                {
                    trackRepeats.Add(trackName);
                    repeat = false;
                    trackBox.Text = trackListNew[track].name;
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

            if (raceLengthCheck.Checked)
            {
                int laps = rnd.Next(Decimal.ToInt32(maxLapBox.Value)) + 1;
                lapBox.Text = laps.ToString();

            } else
            {
                lapBox.Text = "N/A";
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

            //BoP Checkbox check. If checked, if the random bop variable is 1, then bop is on, if it's 0, it's off

            if (bopCheck.Checked)
            {
                int bop = rnd.Next(1);

                if (bop == 1)
                {
                    bopBox.Text = "On";

                } else
                {
                    bopBox.Text = "Off";
                }

            } else
            {
                bopBox.Text = "N/A";
            }

            return "error choosing track";
        }


        //the below two functions are to get the text for weather and start time from the object that 
        //"wins the random pick lottery" - had to do it this way b/c of the no repeats rule
        private void timeOfDayText(track track)
        {

            if (startTimeCheck.Checked)
            {

                if (forceNightCheck.Checked)
                {
                    startTimeBox.Text = track.getTimeOfDay(true);
                }
                else
                {
                    startTimeBox.Text = track.getTimeOfDay();
                }

            }
            else
            {

                startTimeBox.Text = "N/A";

            }
        }

        private void weatherText(track track)
        {

            //weather - this uses the getWeather function in the track object to get random weather
            //from the options the track has

            if (weatherCheck.Checked)
            {

                if (forceRainCheck.Checked)
                {
                   weatherBox.Text =  track.getWeather(true);

                } else
                {
                    weatherBox.Text = track.getWeather();
                }

            }
            else
            {
                weatherBox.Text = "N/A";
            }
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

        private void loadTrackConfigure()
        {
            //initialize some variables to determine what goes into the listview on the track form

            int rainInt = 0;
            int nightInt = 0;
            string rainStr = "No";
            string nightStr = "No";

            foreach (string line in System.IO.File.ReadLines("Data/BaseTrackList.txt"))
            {
                //load in the comma delimited file, separating each value into bits of an array.
                //Each track must have the same number of comma delimited
                //things per line, otherwise this will get messy and I'm no genius programmer here
                //as of 7/6/22, there will be 3 number of things per line
                //col[0] = Track Name
                //col[1] = Supports Rain Yes/No
                //col[2] = The daytime configuration number
                //future additions may include track length

                string[] col = line.Split(',');

                //we have to create a list of tracks by default in the event a person doesn't use
                //the configuration form, so we'll load all tracks into a list of track objects

               
   
                rainInt = Int32.Parse(col[1]);
                nightInt = Int32.Parse(col[2]);
                

                if (rainInt == 1)
                {
                    rainStr = "Yes";
                } else
                {
                    rainStr = "No";
                }

                if(nightInt >= 5)
                {
                    nightStr = "No";
                } else
                {
                    nightStr = "Yes";
                }
                
                    track test = new track(col[0], rainStr, nightStr, jaggedWeatherList[rainInt].ToList(), jaggedTimeOfDay[nightInt].ToList());
                    baseTrackList.Add(test);
              

                //like in the AddDriver method in Form1, we're going to use an array
                //(in this case, the split line from the text file) to insert data into the listview
                //creating a ListViewItem object to accomplish this
                ListViewItem item;


                //pass in an array of 5 items into the listview in the track form. The last two will be used
                //when the main form pulls the data back
                string[] arr = new string[5];

                arr[0] = col[0];
                arr[1] = rainStr;
                arr[2] = nightStr;
                arr[3] = rainInt.ToString();
                arr[4] = nightInt.ToString();

                item = new ListViewItem(arr);
                item.Checked = true;
                trackList.Add(item);

            }


            //this is how we initialize the track list that will go between forms
            //there's probably a better way to do this but in my frustration over
            //resolving a null reference error, I got this to work.
            trackListNew = baseTrackList;

            //set array of listview items in the tf object
            tf.lv = trackList;

        }

        //function to load the group 3 list into the form when the application is first launched

        private void loadGr3Configure()
        {

            //for each line in the group 3 list, add it to the base list

            foreach (string line in System.IO.File.ReadLines("Data/Gr3List.txt")) {


                //as of 7/14/22, there are only 2 things in the gr3 list, name and drivetrain
                //in time, I may add more to these, specifically power, weight, and perhaps
                //performance points, but for now, it's:
                //col[0] - name
                //col[1] - drivetrain

                string[] col = line.Split(',');

                //create a new car using the data, and add it to the list

                car car = new car(col[0], col[1]);
                gr3List.Add(car);

                ListViewItem item;

                item = new ListViewItem(col);
                item.Checked = true;
                gr3FormList.Add(item);

            }

            g3f.lv = gr3FormList;

        }

        //function to set the track list from another form
        public void setTrackList(List<track> trkList)
        {
            trackListNew = trkList;
        }

        //function to clear the track list from another form
        public List<track> getTrackList()
        {
            return trackListNew;
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

        private void trackConfigureBtn_Click(object sender, EventArgs e)
        {
            //create a new track form, which gets the track list passed to it via list view item
            tf.setTrackList(trackListNew);

            tf.ShowDialog();
            
        }

        private void gr3ConfigureBtn_Click(object sender, EventArgs e)
        {
            g3f.setCarList(gr3List);
            g3f.ShowDialog();
        }
    }
}
