using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            float timeframe = float.Parse(textBox1.Text);
            DateTime now = DateTime.Now;
            float minute = now.Minute;
            textBox2.Text= minute.ToString();
            label3.Text = now.Hour.ToString() + ":" + now.Minute.ToString() + ":" + now.Second.ToString();
            if (now.Second==0)
            {
                if (minute % timeframe == 0)
                {
                    Console.Beep(2000, 500);
                }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(2000,500);
        }
    }
}
