using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tekrar5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //[1] iki parametreli geriye değer döndüren çıkarma metodu
        public int cikarma(int s1, int s2)
        {
            return s1 - s2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(cikarma(10, 2));
            listBox1.Items.Add(cikarma(20, 10));
        }


        //[2] bir parametreli, geriye girilen sayının küpünü döndüren metod
        public int kup(int s)
        {
            return s * s * s ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(textBox1.Text);
            label2.Text = kup(s).ToString();
        }

        /*[3] aynı class'ta birbirine bağlı iki farklı metod var. 
         Birini çağırıp2 ile çarpıyoruz */
        private void button3_Click(object sender, EventArgs e)
        {
            int sonuc = Sample.Foo() * 2;
            MessageBox.Show(sonuc.ToString());
        }
    }
    class Sample
    {
        public static int Bar()
        {
            MessageBox.Show("Bar");
            return 100;
        }
        public static int Foo()
        {
            MessageBox.Show("Foo");
            return Bar()*2;
        }
    }
}
