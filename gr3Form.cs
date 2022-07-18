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
    public partial class gr3Form : Form
    {
        
        public List<ListViewItem> lv { get; set; }

        public List<Form1.car> form1Cars = new List<Form1.car>();

        //getter and setter functions for the car list so that the main form can use it
        //for the randomization process
        public void setCarList(List<Form1.car> cars)
        {

            this.form1Cars = cars;

        }
        public List<Form1.car> getCarList() { return form1Cars; }


        public gr3Form()
        {
            InitializeComponent();
        }

        private void gr3Form_Load(object sender, EventArgs e)
        {

            //clears the items of the track list in the event of any weird memory shenangians
            gr3ListView.Items.Clear();

            //essentially loads the items that the first form passed in

            foreach (ListViewItem eachItem in lv)
            {
                gr3ListView.Items.Add(eachItem);
            }



        }

        //function to save the cars and set the list to go back to the main form for use
        //in randomizing
        private void saveCars()
        {

            form1Cars.Clear();

            //for each checked car, we add each car and drivetrain to the list
            //we'll pass back to the main form

            foreach (ListViewItem item in gr3ListView.CheckedItems)
            {

                form1Cars.Add(new Form1.car(item.SubItems[0].Text, item.SubItems[1].Text));

            }

        }

        private void checkAllCars()
        {
            foreach(ListViewItem eachItem in gr3ListView.Items)
            {
                eachItem.Checked = true;
            }
        }

        private void uncheckAllCars()
        {

            foreach(ListViewItem eachItem in gr3ListView.Items)
            {
                eachItem.Checked = false;
            }


        }

        private void checkAllFRCars()
        {
            foreach (ListViewItem eachItem in gr3ListView.Items)
            {
                if(eachItem.SubItems[1].Text.Trim().ToUpper() == "FR")
                {
                    eachItem.Checked = true;
                } else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void checkAllMRCars()
        {
            foreach (ListViewItem eachItem in gr3ListView.Items)
            {
                if(eachItem.SubItems[1].Text.Trim().ToUpper() == "MR")
                {
                    eachItem.Checked = true;
                } else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void saveGr3Btn_Click(object sender, EventArgs e)
        {
            saveCars();

            if (form1Cars.Count == 0)
            {
                MessageBox.Show("WARNING: You have attempted to save a list of cars that " +
                                "has no cars in it. Please select at least one car before saving " +
                                "and closing the Gr3 configuration form.");
                return;
            }

            this.Close();
        }

        private void checkAllGr3Btn_Click(object sender, EventArgs e)
        {
            checkAllCars();
        }

        private void uncheckAllGr3Btn_Click(object sender, EventArgs e)
        {
            uncheckAllCars();
        }

        private void gr3FROnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllFRCars();
        }

        private void gr3MROnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllMRCars();
        }
    }
}
