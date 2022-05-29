using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3sharp
{
    public interface Paper
    {
        int size { get; set; }
        void tear();
        void glue();
    }
    public abstract class Notebook : Paper
    {
        public int size { get; set; }
        public int count { get; set; }
        public int pages { get; set; }
        public string lines { get; set; }
        public int price { get; set; }


        public Notebook(int size, int count, int pages, string lines, int price)
        {
            this.size = size;
            this.count = count;
            this.pages = pages;
            this.lines = lines;
            this.price = price;
        }
        public void tear()
        {
            if (size < 6)
            {
                size++;
                MessageBox.Show("Вы порвали лист");
            }
            else
            {
                MessageBox.Show("Лист больше нельзя порвать");
            }
        }
        public void glue()
        {
            if (size > 2)
            {
                size--;
                MessageBox.Show("Вы склеили листы");
            }
            else
            {
                MessageBox.Show("Лист больше нельзя склеить");
            }
        }
        public void pulloutpaper()
        {
            pages--;
            MessageBox.Show("Вы выдернули лист");
        }
        public void sale()
        {
            if (count >= 100)
                MessageBox.Show("Цена со скидкой: " + (price - (price*0.1)));
            else
                MessageBox.Show("Количество тетрадей меньше 100, скидка отсутствует");
        }
    }
    public class DrawingNotebook : Notebook
    {
        public int picture { get; set; }
        public string drawingtool { get; set; }
        public DrawingNotebook(int size, int count, int pages, string lines, int price, int picture, string drawingtool) : base(size, count, pages, lines, price)
        {
            this.picture = picture;
            this.drawingtool = drawingtool;
        }
        public void draw()
        {
            picture++;
            MessageBox.Show("Вы нарисовали рисунок");
        }
        public void erase()
        {
            if (picture > 0)
            {
                picture--;
                MessageBox.Show("Вы стерли рисунок");
            }
            else
            {
                MessageBox.Show("Все рисунки стерты");
            }
        }
    }
}
