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
    public partial class CustomForm : Form
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


        public CustomForm()
        {
            InitializeComponent();
        }

        private void CustomForm_Load(object sender, EventArgs e)
        {

            //clears the items of the custom car list in the event of any weird memory shenangians
            customListView.Items.Clear();

            //essentially loads the items that the first form passed in

            foreach (ListViewItem eachItem in lv)
            {
                customListView.Items.Add(eachItem);
            }


        }
    
        private void checkAllCars()
        {

            foreach (ListViewItem eachItem in customListView.Items)
            {
                eachItem.Checked = true;
            }

        }

        private void uncheckAllCars()
        {

            foreach (ListViewItem eachItem in customListView.Items)
            {
                eachItem.Checked = false;
            }


        }
    
        private void saveCars()
        {
            //clear the list to be passed back to the main form in the event of memory shenanigans
            form1Cars.Clear();

            //for each checked car, we add each category and description to the list
            //we'll pass back to the main form
          
            foreach (ListViewItem item in customListView.CheckedItems)
            {

                form1Cars.Add(new Form1.car(item.SubItems[0].Text, item.SubItems[1].Text));

            }

        }

        private void customCheckAllBtn_Click(object sender, EventArgs e)
        {
            checkAllCars();
        }

        private void customUncheckAllBtn_Click(object sender, EventArgs e)
        {
            uncheckAllCars();
        }

        private void customSaveBtn_Click(object sender, EventArgs e)
        {
            saveCars();

            if (form1Cars.Count == 0)
            {
                MessageBox.Show("WARNING: You have attempted to save a list of cars that " +
                                "has no cars in it. Please select at least one car before saving " +
                                "and closing the Custom configuration form.");
                return;
            }

            this.Close();
        }
    }
}
