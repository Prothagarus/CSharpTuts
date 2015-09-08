using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowCulator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
            UpdateLabel();

        }


        class Farmer
        {

            private string cow ;
            public string Cow
            {
                get
                {
                    return cow;
                }
                set
                {
                    cow = value;
                
                   

                }
            }


    

            public Farmer(int numberOfCows, int feedMultiplier)
            {
                this.feedMultiplier = feedMultiplier;
                NumberOfCows = numberOfCows;
            }
            private int numberOfCows;
            private int feedMultiplier;
            public int FeedMultiplier
            { get { return feedMultiplier; }  }



            public int BagsOfFeed;
            public int NumberOfCows
            {
                get
                {
                    return numberOfCows;
                }
                set
                {
                    numberOfCows = value;
                    BagsOfFeed = numberOfCows * FeedMultiplier;
                    cow = "I need" + BagsOfFeed + "bags of feed for " + value + "cows.";
                }

            }



        }



        private void UpdateLabel()
        {
            lblCow.Text = farmer.Cow;

        }
   


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            farmer.NumberOfCows = (int)numericUpDown1.Value;
            UpdateLabel();

        }

        private void calculate_Click(object sender,EventArgs e)
        {





        //Console.WriteLine("I need {0} bags of feed for {1} cows", 
        //        farmer.BagsOfFeed, farmer.NumberOfCows);

    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
