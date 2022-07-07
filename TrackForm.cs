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
    public partial class TrackForm : Form
    {

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



        //we set a public list of list view items that we establish in Form1
        //we do this so that the list will "remember" what has been checked or unchecked
        //this was the only way I could think to do this
        public List<ListViewItem> lv { get; set; }

        public List<Form1.track> form1Tracks = new List<Form1.track>();

        //getter and setter functions for the track list so that the main form can use it
        //for the randomization process
        public void setTrackList(List<Form1.track> tracks)
        {

            this.form1Tracks = tracks;

        }
        public List<Form1.track> getTrackList(){return form1Tracks;}

        public TrackForm()
        {
            InitializeComponent();       
        }

        private void TrackForm_Load(object sender, EventArgs e)
        {
            //clears the items of the track list in the event of any weird memory shenangians
                trackList.Items.Clear();

            //essentially loads the items that the first form passed in

            foreach (ListViewItem eachItem in lv)
            {
                trackList.Items.Add(eachItem);
            }


        }


        //function for saving the tracks to our local list of tracks, which can be retrieved by the main form
        public void saveTracks()
        {
            //wipe out current list of tracks, recreate list using only checked ones
            
            form1Tracks.Clear();

            //for each checked item, recreate the track list array with the ones that are checked

            foreach (ListViewItem item in trackList.CheckedItems) {

                int rain = Int32.Parse(item.SubItems[3].Text);
                int night = Int32.Parse(item.SubItems[4].Text);

               form1Tracks.Add(new Form1.track(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, jaggedWeatherList[rain].ToList(), jaggedTimeOfDay[night].ToList()));

            }
        }

        //The below four functions are simple functions I elected to keep separate from the buttons. I don't like
        //to clog my button event functions with any code if I can help it, so these are just representative of
        //what the buttons of the same name are doing
        private void checkAllTracks()
        {

            foreach(ListViewItem item in trackList.Items)
            {

                item.Checked = true;
            }

        }
        private void uncheckAllTracks()
        {

            foreach(ListViewItem item in trackList.Items)
            {
                item.Checked = false;
            }
        }   
        private void checkAllRainTracks()
        {

            foreach(ListViewItem item in trackList.Items)
            {

                if(item.SubItems[1].Text == "Yes")
                {
                    item.Checked = true;
                } else
                {
                    item.Checked = false;
                }

            }


        }
        private void checkAllNightTracks()
        {

            foreach (ListViewItem item in trackList.Items)
            {

                if (item.SubItems[2].Text == "Yes")
                {
                    item.Checked = true;
                }
                else
                {
                    item.Checked = false;
                }

            }


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //runs the saveTracks function and also performs a small check to see if the track list is empty,
            //which could happen by mistake. Exiting out of the form with a blank list still causes some problems, so (if I remember)
            //I will try to put some more blank list checking in the main form

            saveTracks();

            if (form1Tracks.Count == 0)
            {
                MessageBox.Show("WARNING: You have attempted to save a list of tracks that " +
                                "has no tracks in it. Please select at least one track before saving " +
                                "and closing the track configuration form.");
                return;
            }

            this.Close();
        }

        private void checkAllTracksBtn_Click(object sender, EventArgs e)
        {
            checkAllTracks();
        }

        private void uncheckAllTracksBtn_Click(object sender, EventArgs e)
        {
            uncheckAllTracks();
        }

        private void rainOnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllRainTracks();
        }

        private void nightOnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllNightTracks();
        }
    }
}
