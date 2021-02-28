using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışıOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsoluzaklık, ikinciatsoluzaklık, ucuncusoluzaklık, dorduncusoluzaklık, bessoluzaklık;

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pictureBox1.Left = label14.Right;
            pictureBox2.Left = label14.Right;
            pictureBox3.Left = label14.Right;
            pictureBox4.Left = label14.Right;
            pictureBox5.Left = label14.Right;
        }

        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //int zaman = Convert.ToInt32(label14.Text);
            //zaman++;
            //label14.Text = zaman.ToString();

            int  birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;
            int dortatgenislik = pictureBox4.Width;
            int besatgenislik = pictureBox5.Width;

            int bitisuzaklık = label8.Left;

            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);
            pictureBox4.Left += rastgele.Next(5, 15);
            pictureBox5.Left += rastgele.Next(5, 15);
            if (birinciatgenislik + pictureBox1.Left >=bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("ŞAHMERAN YARIŞI KAZANDI","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (ikinciatgenislik + pictureBox2.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("ATILGAN YARIŞI KAZANDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("KARAYEL YARIŞI KAZANDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dortatgenislik + pictureBox4.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("NADAS YARIŞI KAZANDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (besatgenislik + pictureBox5.Left >= bitisuzaklık)
            {
                timer1.Enabled = false;
                MessageBox.Show("KAFKASLI YARIŞI KAZANDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsoluzaklık = pictureBox1.Left;
            ikinciatsoluzaklık = pictureBox2.Left;
            ucuncusoluzaklık = pictureBox3.Left;
            dorduncusoluzaklık = pictureBox4.Left;
            bessoluzaklık = pictureBox5.Left;
        }

    }
}
