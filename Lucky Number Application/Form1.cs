using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lucky_Number_Application
{
    public partial class Form1 : Form
    {
        //Create variables to store data
        int maxDay; //maxDay holds the total number of days in the month. 
        static int luckyNumber; //luckyNumber will hold the answer to the luckyNumbers application. 

        public Form1()
        {
            InitializeComponent();
        }

        public int getLuckyNumber()
        {
            return luckyNumber; //Returns the answer. 
        }

        //Create Method dayOfTheMonth() to call out in other methods. 
        public void dayOfTheMonth()
        {
            maxDay = 0;

            //Create Loops
            if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 6 || comboBox2.SelectedIndex == 7 || comboBox2.SelectedIndex == 9 || comboBox2.SelectedIndex == 11)
            {
                maxDay = 31;//31 Days in 1 month. 
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                int year = Int32.Parse(comboBox1.Text); //Convert using TryParse


                if (year % 100 == 0)
                    maxDay = 28; //28 days in the month

                if (year % 400 == 0)
                    maxDay = 29; //29 days in month


                if (year % 4 == 0)
                    maxDay = 29; //29 days in month
                else
                    maxDay = 28; //28 days in the month
            }
            else
                maxDay = 30; //30 days in the month. 

            if(comboBox2.SelectedIndex != -1)
            {
                comboBox3.Items.Clear();
                for(int i =0; i < maxDay; i++)
                {
                    comboBox3.Items.Add(i + 1);
                }
                comboBox3.Text = maxDay.ToString();
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //comboBox2 Event Handler
        {
            dayOfTheMonth();//Call Method
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "2010";
        }

        private void comboBox1_SelectedIndexChanged(Object sender, EventArgs e) //Combobox1 Event Handler
        {
            dayOfTheMonth();//Call method
        }

        private void buttonLuckyNumber_Click(object sender, EventArgs e) //Lucky Number btn event handler. 
        {
            if (comboBox1.SelectedIndex != 1 && comboBox2.SelectedIndex != -1 && comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1)
            {
                // Calculate the lucky number
                // Also creates ability to create/show 2nd Form. 
                luckyNumber = (comboBox1.SelectedIndex + comboBox2.SelectedIndex + comboBox3.SelectedIndex + comboBox4.SelectedIndex);
                LuckyNumberForm frm2 = new LuckyNumberForm();
                frm2.Show();
            }
            else
            {
                //In case form1 info is not filled up, display message. 
                MessageBox.Show("You didn't finsh. Please fill up all info.");
            }
        }
    }
}
