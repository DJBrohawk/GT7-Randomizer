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



        //we set a public list of list view items that we establish in Form1
        //we do this so that the list will "remember" what has been checked or unchecked
        //this was the only way I could think to do this
        public List<ListViewItem> lv { get; set; }

        public List<Form1.track> form1Tracks = new List<Form1.track>();

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
                trackList.Items.Clear();

            foreach (ListViewItem eachItem in lv)
            {
                trackList.Items.Add(eachItem);
            }

           

            /*Doing some testing
            
            //on load, we want to take the Track List text file and import it into
            //the list view, so that we can select which tracks we want to use
            //in the search

            foreach (string line in System.IO.File.ReadLines(@"c:\temp\TrackListTest.txt"))
            {
                //load in the comma delimited file, separating each value into bits of an array.
                //Each track must have the same number of comma delimited
                //things per line, otherwise this will get messy and I'm no genius programmer here
                //as of 7/5/22, there will be X number of things per line
                //col[0] = Track Name
                //col[1] = Supports Rain Yes/No
                //col[2] = Supports Night Driving Yes/No
                //future additions may include track length

                string[] col = line.Split(',');
                

                //like in the AddDriver method in Form1, we're going to use an array
                //(in this case, the split line from the text file) to insert data into the listview
                //creating a ListViewItem object to accomplish this
                ListViewItem item;

                item = new ListViewItem(col);
                item.Checked = true;
                trackList.Items.Add(item);

            


            }*/
        }

        public void saveTracks()
        {
            //wipe out current list of tracks, recreate list using only checked ones
            
            form1Tracks.Clear();

            //for each checked item, recreate the track list array with the ones that are checked

            foreach (ListViewItem item in trackList.CheckedItems) {

               form1Tracks.Add(new Form1.track(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text));

                    }

        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveTracks();
            this.Close();
        }
    }
}
