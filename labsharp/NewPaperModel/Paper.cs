using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPaperModel
{
    public interface Paper
    {
        string size { get; set; }
        void tear();
        void glue();
    }
    public abstract class Notebook : Paper
    {
        public string size { get; set; }
        public int count { get; set; }
        public int pages { get; set; }
        public string lines { get; set; }
        public int price { get; set; }


        public Notebook(string size, int count, int pages, string lines, int price)
        {
            this.size = size;
            this.count = count;
            this.pages = pages;
            this.lines = lines;
            this.price = price;
        }
        public void tear()
        {
            if (Convert.ToInt32(size.Substring(1,1)) < 6)
            {
                size = "A"+ (Convert.ToInt32(size.Substring(1, 1))+1);
                MessageBox.Show("Вы порвали лист");
            }
            else
            {
                MessageBox.Show("Лист больше нельзя порвать");
            }
        }
        public void glue()
        {
            if (Convert.ToInt32(size.Substring(1, 1)) > 2)
            {
                size = "A" + (Convert.ToInt32(size.Substring(1, 1))-1);
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
        public DrawingNotebook() : base("", 0, 0, "", 0)
        {
            this.picture = 0;
            this.drawingtool = "";
        }
        public DrawingNotebook(string size, int count, int pages, string lines, int price, int picture, string drawingtool) : base(size, count, pages, lines, price)
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
    public class MusicNotebook : Notebook
    {
        public int note { get; set; }
        public MusicNotebook() : base("", 0, 0, "", 0)
        {
            this.note = 0;
        }
        public MusicNotebook(string size, int count, int pages, string lines, int price, int note) : base(size, count, pages, lines, price)
        {
            this.note = note;
        }
        public void draw()
        {
            note++;
            MessageBox.Show("Вы нарисовали ноту");
        }
        public void erase()
        {
            if (note > 0)
            {
                note--;
                MessageBox.Show("Вы стерли ноту");
            }
            else
            {
                MessageBox.Show("Все ноты стерты");
            }
        }
    }

    public class WritingNotebook : Notebook
    {
        public int symbol { get; set; }
        public WritingNotebook() : base("", 0, 0, "", 0)
        {
            this.symbol = 0;
        }
        public WritingNotebook(string size, int count, int pages, string lines, int price, int symbol) : base(size, count, pages, lines, price)
        {
            this.symbol = symbol;
        }
        public void write()
        {
            symbol++;
            MessageBox.Show("Вы написали букву");
        }
        public void erase()
        {
            if (symbol > 0)
            {
                symbol--;
                MessageBox.Show("Вы стерли букву");
            }
            else
            {
                MessageBox.Show("Все буквы стерты");
            }
        }
    }
}
