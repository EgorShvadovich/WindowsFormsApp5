using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t = 0;
        bool game = false;
        int click = 0;
        int maxClick = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            if (game == true)
                game = false;
            click++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            t++;
            if (t == 10 && game == false)
            {
                game = true;
                timer1.Stop();
                MessageBox.Show("blabla: " + click + "\nmax click: " + maxClick);
                t = 0;
                click = 0;
            }
            if (click > maxClick)
            {
                maxClick = click;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = DateTime.Now;
            var y = new DateTime(2023, 01, 01, 0, 0, 0);
            TimeSpan z = y - x;
            this.Text = z.ToString().Substring(0, 11);
        }
    }
}
