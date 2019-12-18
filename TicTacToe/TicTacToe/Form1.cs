using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Hello! You play as X. Let's start!";


        }

        bool end = false;

        Image X = (Image)TicTacToe.Properties.Resources.ResourceManager.GetObject("kolko_krzyzyk_x");
        Image O = (Image)TicTacToe.Properties.Resources.ResourceManager.GetObject("kolko_krzyzyk_o"); 

        private void ButtonClick(object sender, EventArgs e)
        {
            Button button;
            button = sender as Button;

            if (button.Image == null)
            {
                button.Image = X;

                CheckX(X);
                if(end == false)
                {
                    Circle();
                }
                CheckX(O);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Circle()
        {
            Random rand = new Random();

            int x = 0;

            bool flag = false;

            while (flag == false)
            {
                x++;

                if( x == 10)
                {
                    flag = true;
                }

                switch (x)
                {
                    case 1:
                        if (button1.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 2:
                        if (button2.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 3:
                        if (button3.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 4:
                        if (button4.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 5:
                        if (button5.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 6:
                        if (button6.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 7:
                        if (button7.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 8:
                        if (button8.Image == null)
                        {
                            flag = true;
                        }
                        break;
                    case 9:
                        if (button9.Image == null)
                        {
                            flag = true;
                        }
                        break;
                } 
                
            }

            

                switch (x)
                {
                    case 1:
                        button1.Image = O;
                        break;
                    case 2:
                        button2.Image = O;
                        break;
                    case 3:
                        button3.Image = O;
                        break;
                    case 4:
                        button4.Image = O;
                        break;
                    case 5:
                        button5.Image = O;
                        break;
                    case 6:
                        button6.Image = O;
                        break;
                    case 7:
                        button7.Image = O;
                        break;
                    case 8:
                        button8.Image = O;
                        break;
                    case 9:
                        button9.Image = O;
                        break;
                }
            
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button1.Image = null;
            button2.Image = null;
            button3.Image = null;
            button4.Image = null;
            button5.Image = null;
            button6.Image = null;
            button7.Image = null;
            button8.Image = null;
            button9.Image = null;

            textBox1.Text = "Hello! You play as X. Let's start!";

            ButtonsUnlock();

            end = false;
        }

        private void CheckX(Image image)
        {
            string win = "You WIN!!!";
            string lose = "You LOSE!!!";
            string tekst = null;

            if(image == X)
            {
                tekst = win;
            }
            else
            {
                tekst = lose;
            }

            //pionowo
            if ((button1.Image == image) && (button2.Image == image) && (button3.Image == image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            if ((button4.Image == image) && (button5.Image == image) && (button6.Image == image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            if ((button7.Image == image) && (button8.Image == image) && (button9.Image == image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            //poziomo
            if ((button1.Image == image) && (button4.Image == image) && (button7.Image == image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            if ((button2.Image ==image) && (button5.Image == image) && (button8.Image == image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            if ((button3.Image == image) && (button5.Image == image) && (button9.Image ==image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            //ukos
            if ((button1.Image ==image) && (button5.Image ==image) && (button9.Image ==image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }
            if ((button7.Image ==image) && (button5.Image ==image) && (button3.Image ==image))
            {
                textBox1.Text = tekst;
                ButtonsLock();
                end = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
        private void ButtonsLock() // blokuje przyciski
        {

            if( button1.Image == null)
            {
                button1.Enabled = false;
            }
            if (button2.Image == null)
            {
                button2.Enabled = false;
            }

            if (button3.Image == null)
            {
                button3.Enabled = false;
            }

            if (button4.Image == null)
            {
                button4.Enabled = false;
            }

            if (button5.Image == null)
            {
                button5.Enabled = false;
            }
            if (button6.Image == null)
            {
                button6.Enabled = false;
            }
            if (button7.Image == null)
            {
                button7.Enabled = false;
            }
            if (button8.Image == null)
            {
                button8.Enabled = false;
            }
            if (button9.Image == null)
            {
                button9.Enabled = false;
            }

        }
        private void ButtonsUnlock() // odblokowywuje przyciski
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true; 
        }
    }
}
