using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
namespace şekil_çizimi
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g; //g isimli grafik işlemleri yapacağım değişenimi tanımlıyorum.
        Font fontum = new Font("tahoma", 15); //Kullanacağım yazı fontunu özellikilerini oluşturuyorum. Kullanımı: (yazı tipi,yazı boyutu)
        SolidBrush fircam = new SolidBrush(Color.Red); //Kullanacağım fırçayı özellikilerini oluşturuyorum. Kullanımı: (fırça rengi)
        Pen kalemim = new Pen(Color.Chocolate, 2); //Kullanacağım kalemin özellikilerini oluşturuyorum. Kullanımı: (kalem rengi,kalem uç kalınlığı
        int x = 620;
        int y = 50;
        //mousePath = new System.Drawing.Drawing2D.GraphicsPath();
        public void kare()
        {
            int adet=Convert.ToInt32(textBox2.Text);
            int kenarUzunluğu = Convert.ToInt32(textBox1.Text);
            for(int i = 1; i <= adet; i++)
            {
                x=x+(kenarUzunluğu+10)+ adet;
                g = this.CreateGraphics();
                //g.Clear(this.BackColor);
                g.DrawRectangle(kalemim, x, y, kenarUzunluğu, kenarUzunluğu);//ilk iki değer başlangıç koordinatları
                g.Dispose();//önceki çizdiğimiz şekli bilgisayarın hafızasından siliyor
            }
        }
        public void daire()
        {
            int adet=Convert.ToInt32(textBox2.Text);
            int yarıçap = Convert.ToInt32(textBox1.Text);
            for (int i = 1;i <= adet; i++)
            {
                x = x + (yarıçap + 10) + adet;
                g = this.CreateGraphics();//grafik oluşturmaya başla
               // g.Clear(this.BackColor); //Ekranı temizle
                g.DrawEllipse(kalemim, x, y, yarıçap, yarıçap);
                g.Dispose();
            } 
        }
        //public void üçgen()
        //{
        //   int kenarUzunluğu=Convert.ToInt32(textBox1.Text);
        //    g = this.CreateGraphics();
        //    g.Clear(this.BackColor);
        //    Point[] p2 = { new Point(500, 50), new Point(450-kenarUzunluğu, kenarUzunluğu/2), new Point(550+kenarUzunluğu, kenarUzunluğu/2) };
        //    g.DrawPolygon(kalemim, p2);
        //    g.Dispose();

        //}
        public void üçgen()
        {
            int adet = Convert.ToInt32(textBox2.Text);
            int ükenarUzunluğu = Convert.ToInt32(textBox1.Text);
            for (int i = 1;i<=adet; i++)
            {
                x=x+(ükenarUzunluğu + 200) + adet;
                g = this.CreateGraphics();
                //g.Clear(this.BackColor);
                Point[] p2 = { new Point(x, y), new Point(x-50 - ükenarUzunluğu, y+50 + ükenarUzunluğu / 2), new Point(x+50 + ükenarUzunluğu, y+50 + ükenarUzunluğu / 2) };
                g.DrawPolygon(kalemim, p2);
                g.Dispose();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                kare();
            }
            if (radioButton3.Checked)
            {
                daire();
            }
            if (radioButton2.Checked)
            {
                üçgen();
            }
        }
        public void yukarı()
        {
            y = y - 10;
            
            if (radioButton1.Checked)
            {
                int kenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                // g.Clear(this.BackColor);
                g.DrawRectangle(kalemim, x, y, kenarUzunluğu, kenarUzunluğu - 10);//ilk iki değer başlangıç koordinatları
                g.Dispose();
            }
            if (radioButton2.Checked)
            {
                int ükenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                // g.Clear(this.BackColor);
                Point[] p2 = { new Point(x, y ), new Point(x-50 - ükenarUzunluğu, (y+50 + (ükenarUzunluğu / 2) -10)), new Point(x+50 + ükenarUzunluğu, (y+50 + (ükenarUzunluğu / 2) - 10)) };
                g.DrawPolygon(kalemim, p2);
                g.Dispose();
            }
            if (radioButton3.Checked)
            {
                int yarıçap = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();//grafik oluşturmaya başla
                                          // g.Clear(this.BackColor); //Ekranı temizle
                g.DrawEllipse(kalemim, x - 10, y , yarıçap + 10, yarıçap - 10);
                g.Dispose();
            }
        }
        public void aşağı()
        {
            y = y + 10;
            if (radioButton1.Checked)
            {
                int kenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                //   g.Clear(this.BackColor);
                g.DrawRectangle(kalemim, x, y , kenarUzunluğu, kenarUzunluğu + 10);//ilk iki değer başlangıç koordinatları
                g.Dispose();
            }
            if (radioButton2.Checked)
            {
                int ükenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                //g.Clear(this.BackColor);
                Point[] p2 = { new Point(x, y ), new Point(x-50 - ükenarUzunluğu,( y+50 + (ükenarUzunluğu / 2) + 10)), new Point(x+50 + ükenarUzunluğu, (y+50 + (ükenarUzunluğu / 2) + 10)) };
                g.DrawPolygon(kalemim, p2);
                g.Dispose();
            }
            if (radioButton3.Checked)
            {
                int yarıçap = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();//grafik oluşturmaya başla
                //  g.Clear(this.BackColor); //Ekranı temizle
                g.DrawEllipse(kalemim, x, y , yarıçap, yarıçap + 10);
                g.Dispose();
            }
        }
        public void sağ()
        {
            x = x + 10;
            if (radioButton1.Checked)
            {
                int kenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                // g.Clear(this.BackColor);
                g.DrawRectangle(kalemim, x , y, kenarUzunluğu + 10, kenarUzunluğu);//ilk iki değer başlangıç koordinatları
                g.Dispose();
            }
            if (radioButton2.Checked)
            {
                int ükenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                //  g.Clear(this.BackColor);
                Point[] p2 = { new Point(x , 50), new Point((x-50 - ükenarUzunluğu) + 10, (y+50 + (ükenarUzunluğu / 2))), new Point((x +50+ ükenarUzunluğu) + 10, (y+50 + ükenarUzunluğu / 2) )};
                g.DrawPolygon(kalemim, p2);
                g.Dispose();
            }
            if (radioButton3.Checked)
            {
                int yarıçap = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();//grafik oluşturmaya başla
                                          //  g.Clear(this.BackColor); //Ekranı temizle
                g.DrawEllipse(kalemim, x , y, yarıçap + 10, yarıçap);
                g.Dispose();
            }
        }
        public void sol()
        {
            x = x - 10;
            if (radioButton1.Checked)
            {
                int kenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                // g.Clear(this.BackColor);
                g.DrawRectangle(kalemim, x, y, kenarUzunluğu - 10, kenarUzunluğu);//ilk iki değer başlangıç koordinatları
                g.Dispose();
            }
            if (radioButton2.Checked)
            {
                int ükenarUzunluğu = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();
                // g.Clear(this.BackColor);
                Point[] p2 = { new Point(x , 50), new Point((x-50 - ükenarUzunluğu) - 10, y+50 + (ükenarUzunluğu / 2)), new Point((x+50 + ükenarUzunluğu) - 10, y+50 + ükenarUzunluğu / 2) };
                g.DrawPolygon(kalemim, p2);
                g.Dispose();
            }
            if (radioButton3.Checked)
            {
                int yarıçap = Convert.ToInt32(textBox1.Text);
                g = this.CreateGraphics();//grafik oluşturmaya başla
                                          // g.Clear(this.BackColor); //Ekranı temizle
                g.DrawEllipse(kalemim, x, y, yarıçap - 10, yarıçap);
                g.Dispose();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            yukarı();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sağ();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            aşağı();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sol();
        }
    }
}