using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1sharpSasha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
        }
        Year year = null;
        private void button1_Click(object sender, EventArgs e)
        {
            year = new Year(dateTimePicker1.Value.Year);
            year.mm = new Month(dateTimePicker1.Value.Month);
            year.dd = new Day(dateTimePicker1.Value.Day);
            label2.Text = "";
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            if(year!=null)
                label2.Text = year.what_day(year);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Year year1, year2;
            year1 = new Year(dateTimePicker2.Value.Year);
            year1.mm = new Month(dateTimePicker2.Value.Month);
            year1.dd = new Day(dateTimePicker2.Value.Day);
            year2 = new Year(dateTimePicker3.Value.Year);
            year2.mm = new Month(dateTimePicker3.Value.Month);
            year2.dd = new Day(dateTimePicker3.Value.Day);
            label2.Visible = true;
            double day_diff = year2.getYear() * 365.25 + year2.mm.getMonth() * 30.7 + year2.dd.getDay() - (year1.getYear() * 365.25 + year1.mm.getMonth() * 30.7 + year1.dd.getDay());
            label2.Text = "Дней: " + ((int)Math.Ceiling(day_diff)).ToString();
            label2.Text += " Месяцев: " + ((int)Math.Ceiling((day_diff / 30.7))).ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
