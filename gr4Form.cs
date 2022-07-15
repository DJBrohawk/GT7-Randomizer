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
    public partial class gr4Form : Form
    {
        //items for the listview and the list to return to the main form
        public List<ListViewItem> lv { get; set; }

        public List<Form1.car> form1Cars = new List<Form1.car>();

        //getter and setter functions for the car list so that the main form can use it
        //for the randomization process
        public void setCarList(List<Form1.car> cars)
        {

            this.form1Cars = cars;

        }
        public List<Form1.car> getCarList() { return form1Cars; }

        public gr4Form()
        {
            InitializeComponent();
        }

        private void gr4Form_Load(object sender, EventArgs e)
        {
            //clears the items of the track list in the event of any weird memory shenangians
            gr4ListView.Items.Clear();

            //essentially loads the items that the first form passed in

            foreach (ListViewItem eachItem in lv)
            {
                gr4ListView.Items.Add(eachItem);
            }
        }

        private void saveCars()
        {
            form1Cars.Clear();

            //for each checked car, we add each car and drivetrain to the list
            //we'll pass back to the main form

            foreach (ListViewItem item in gr4ListView.CheckedItems)
            {

                form1Cars.Add(new Form1.car(item.SubItems[0].Text, item.SubItems[1].Text));

            }
        }

        private void checkAllCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                eachItem.Checked = true;
            }
        }

        private void uncheckAllCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                eachItem.Checked = false;
            }
        }

        private void checkAllFRCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                if (eachItem.SubItems[1].Text.Trim().ToUpper() == "FR")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void checkAllMRCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                if (eachItem.SubItems[1].Text.Trim().ToUpper() == "MR")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void checkAllFFCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                if (eachItem.SubItems[1].Text.Trim().ToUpper() == "FF")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void checkAllAWDCars()
        {
            foreach (ListViewItem eachItem in gr4ListView.Items)
            {
                if (eachItem.SubItems[1].Text.Trim().ToUpper() == "AWD")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }
            }
        }

        private void gr4CheckAllBtn_Click(object sender, EventArgs e)
        {
            checkAllCars();
        }

        private void gr4UncheckAllBtn_Click(object sender, EventArgs e)
        {
            uncheckAllCars();
        }

        private void gr4FROnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllFRCars();
        }

        private void gr4MROnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllMRCars();
        }

        private void gr4FFOnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllFFCars();
        }

        private void gr4AWDOnlyBtn_Click(object sender, EventArgs e)
        {
            checkAllAWDCars();
        }

        private void gr4SaveBtn_Click(object sender, EventArgs e)
        {
            saveCars();

            if (form1Cars.Count == 0)
            {
                MessageBox.Show("WARNING: You have attempted to save a list of cars that " +
                                "has no cars in it. Please select at least one car before saving " +
                                "and closing the track configuration form.");
                return;
            }

            this.Close();
        }
    }
}
