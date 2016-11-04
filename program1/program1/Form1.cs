//Alaa Hawsawi
//Program1
//due date 10/1/2014
//CIS199-01
//the program will calculate the costoumer order 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program1
{
    public partial class program1 : Form
    {
      
        public program1()
        {        
            InitializeComponent();
        }

        private void Calculate_button_Click(object sender, EventArgs e)
        {
            float space;
            int coats;
            float gallonprice;
            double labor = 10.50;
            double gallon;           
            double time = 8;
            double total;
            double sqft = 325;

          
            //input
           space= float.Parse(Square_Feet_textBox.Text);       //input how many space
           coats = int.Parse(coats_textBox.Text);       //input coats
           gallonprice = float.Parse(gallon_textBox.Text); //input the gallon price

           //Calculate
           double sqftperhr = sqft / time; //HOW MANY SQUARE FEET BY HOW MANY FEET PER HOUR
           space = space * coats;         //cal how many square feet with coats
           gallon = space / sqft;      //cal give how many gallons need 
           gallon = Math.Ceiling(gallon);      //round how many gallans the need
           gallonprice = (float)gallon * gallonprice;
           time =  space/sqftperhr;   //cal how many hour need to finish the paint
           labor = labor * time;       //cal the cost of labor
           total = gallonprice + labor; //cal the total of the job 

            //output
           Gallon_label.Text = gallon.ToString();   //output how many gallons will use.
           squarefeet_label.Text = space.ToString("n1") +" sq ft";    //output how many sq ft with coat
           pricegallon_label.Text = gallonprice.ToString("c");  //output of the price of gallon
           Time_label.Text = time.ToString("F1");   //output how many hours of labor
           Labor_label.Text = labor.ToString("C");     //output how much cost of labor
           Total_label.Text = total.ToString("C");     //output how much total of painting 
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
