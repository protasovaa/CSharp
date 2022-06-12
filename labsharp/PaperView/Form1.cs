using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        List<Paper> notebooks = new List<Paper>();
        DrawingNotebook drawingNotebook = new DrawingNotebook(5, 2, 48, "линия", 30, 1, "карандаш");

        public void output()
        {
            listBox1.Items.Clear();
            foreach(DrawingNotebook drawingNotebook in notebooks)
            {
                listBox1.Items.Add("Тетрадь: " + Environment.NewLine + "Размер: A" + drawingNotebook.size + Environment.NewLine + "Кол-во листов: " + drawingNotebook.pages + Environment.NewLine + "Разлиновка: "+ drawingNotebook.lines + Environment.NewLine + "Кол-во тетрадей: " + drawingNotebook.count + Environment.NewLine + "Цена за шт: " + drawingNotebook.price + Environment.NewLine + "Рисунки: " + drawingNotebook.picture + Environment.NewLine + "Чем нарисованы: "+drawingNotebook.drawingtool);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBox1.MeasureItem += lst_MeasureItem;
            this.listBox1.DrawItem += lst_DrawItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notebooks.Add(new DrawingNotebook(Convert.ToInt32(comboBox1.SelectedItem), Convert.ToInt32(textBox1.Text), Convert.ToInt32(comboBox2.SelectedItem), comboBox3.SelectedItem.ToString(), Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text), comboBox4.SelectedItem.ToString()));
            output();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                if (notebooks.Count > 0)
                {
                    notebooks.RemoveAt(listBox1.SelectedIndex);
                    output();
                }
                else
                {
                    MessageBox.Show("Пустой список");
                }
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).tear();
                output();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).glue();
                output();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).pulloutpaper();
                output();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).sale();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).draw();
                output();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ((DrawingNotebook)notebooks[listBox1.SelectedIndex]).erase();
                output();
            }
            else MessageBox.Show(" Вы не выбрали элемент listBox1 ");
        }
    }
}
