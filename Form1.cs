using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        int speed = 10;
        int moveX;
        int moveY;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           moveY = -speed;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            moveY = speed;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           moveX = -speed;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           moveX = speed;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += moveX;
            pictureBox1.Top += moveY;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                moveY = -speed;
            }else if(e.KeyCode == Keys.Down)
            {
                moveY = speed;
            }else if(e.KeyCode == Keys.Right)
            {
                moveX = speed;
            }else if(e.KeyCode == Keys.Left)
            {
                moveX = -speed;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                moveY = 0;
            }
            else if (e.KeyCode == Keys.Down)
            {
                moveY = 0;
            }
            else if (e.KeyCode == Keys.Right)
            {
                moveX = 0;
            }
            else if (e.KeyCode == Keys.Left)
            {
                moveX = 0;
            }
        }
    }
}
