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
    public partial class categoryForm : Form
    {

        public List<ListViewItem> lv { get; set; }

        public List<Form1.category> form1Cats = new List<Form1.category>();

        //getter and setter functions for the car list so that the main form can use it
        //for the randomization process
        public void setCategoryList(List<Form1.category> cats)
        {

            this.form1Cats = cats;

        }
        public List<Form1.category> getCategoryList() { return form1Cats; }


        public categoryForm()
        {
            InitializeComponent();
        }

        private void categoryForm_Load(object sender, EventArgs e)
        {
            //clears the items of the track list in the event of any weird memory shenangians
            categoryListView.Items.Clear();

            //essentially loads the items that the first form passed in

            foreach (ListViewItem eachItem in lv)
            {
                categoryListView.Items.Add(eachItem);
            }
        }

        private void checkAllCats()
        {
            foreach(ListViewItem eachItem in categoryListView.Items)
            {

                eachItem.Checked = true;

            }


        }

        private void uncheckAllCats()
        {

            foreach (ListViewItem eachItem in categoryListView.Items)
            {

                eachItem.Checked = false;

            }

        }

        private void checkStandardCats()
        {

            foreach (ListViewItem eachItem in categoryListView.Items)
            {

                if (eachItem.SubItems[2].Text.Trim() == "Standard")
                {
                    eachItem.Checked = true;
                } else
                {
                    eachItem.Checked = false;
                }

            }

        }

        private void checkNonstandardCats()
        {

            foreach (ListViewItem eachItem in categoryListView.Items)
            {

                if (eachItem.SubItems[2].Text.Trim() == "Nonstandard")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }

            }

        }

        private void checkCustomCats()
        {

            foreach (ListViewItem eachItem in categoryListView.Items)
            {

                if (eachItem.SubItems[2].Text.Trim() == "Custom")
                {
                    eachItem.Checked = true;
                }
                else
                {
                    eachItem.Checked = false;
                }

            }

        }

        private void saveCats()
        {

            form1Cats.Clear();

            //for each checked category, we add each category and description to the list
            //we'll pass back to the main form

            //ultimately, the description isn't currently used, but it's passed in, in the event
            //I want to add it to the main form. I feel like this is kinda proactive programming

            foreach (ListViewItem item in categoryListView.CheckedItems)
            {

                form1Cats.Add(new Form1.category(item.SubItems[0].Text, item.SubItems[1].Text));

            }


        }

        private void categoryCheckAllBtn_Click(object sender, EventArgs e)
        {
            checkAllCats();
        }

        private void categoryUncheckAllBtn_Click(object sender, EventArgs e)
        {
            uncheckAllCats();
        }

        private void categoryStandardOnlyBtn_Click(object sender, EventArgs e)
        {
            checkStandardCats();
        }

        private void categoryNonStandardOnlyBtn_Click(object sender, EventArgs e)
        {
            checkNonstandardCats();
        }

        private void categoryCustomOnlyBtn_Click(object sender, EventArgs e)
        {
            checkCustomCats();
        }

        private void categorySaveBtn_Click(object sender, EventArgs e)
        {
            saveCats();

            if (form1Cats.Count == 0)
            {
                MessageBox.Show("WARNING: You have attempted to save a list of categories that " +
                                "has no categories in it. Please select at least one category before saving " +
                                "and closing the category configuration form.");
                return;
            }

            this.Close();
        }
    }

}
