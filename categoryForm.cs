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
    }
}
