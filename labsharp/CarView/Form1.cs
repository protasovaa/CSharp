using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            textBox4.Visible = false;
        }
        public List<Car> cars = new List<Car>();
        public List<CarSecondLevel> secondCars = new List<CarSecondLevel>();
        int i = 0, j = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                secondCars.Add(new CarSecondLevel(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text)));
                textBox6.Text += (secondCars[j].info() + Environment.NewLine + "Qp=" + secondCars[j].quality() + Environment.NewLine);
                j++;
            }
            else
            {
                cars.Add(new Car(textBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text)));
                textBox5.Text += (cars[i].info() + Environment.NewLine + "Q=" + cars[i].quality() + Environment.NewLine);
                i++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Visible = true;
                textBox4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                textBox4.Visible = false;
            }
        }
    }
}
