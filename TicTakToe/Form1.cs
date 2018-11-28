using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TicTakToe
{
    public partial class Form1 : Form
    {
        int winx=0,wino=0;
        int mouseCounter,bt1=3, bt2=3, bt3=3, bt4=3, bt5=3, bt6=3, bt7=3, bt8=3, bt9=3;
        
        public static string RootFolder()
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo root = di.Parent.Parent;
            return root.FullName;
        }

        string backgrPath = Path.Combine(RootFolder(), "blue.jpg");
        string xPath = Path.Combine(RootFolder(), "iks.png");
        string oPath = Path.Combine(RootFolder(), "oks.png");

        public Form1()
        {
            InitializeComponent();
            cleargame();
            foreach (Control c in this.Controls)
            {
                c.Click += ClickCounter;
                
            }
        }

        private void ClickCounter(object sender, EventArgs e)
        {
            mouseCounter++;
            x.Text = Convert.ToString(winx);
            o.Text = Convert.ToString(wino);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if(mouseCounter % 2 == 0)
            {          
                btn1.Image = Image.FromFile(xPath);
                bt1 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn1.Image = Image.FromFile(oPath);
                bt1 = 0;
            }
            check();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {           
                btn2.Image = Image.FromFile(xPath);
                bt2 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn2.Image = Image.FromFile(oPath);
                bt2 = 0;
            }
            check();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {
                btn3.Image = Image.FromFile(xPath);
                bt3 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn3.Image = Image.FromFile(oPath);
                bt3 = 0;
            }
            check();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {             
                btn4.Image = Image.FromFile(xPath);
                bt4 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn4.Image = Image.FromFile(oPath);
                bt4 = 0;
            }
            check();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleargame();
            mouseCounter = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btn5_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {               
                btn5.Image = Image.FromFile(xPath);
                bt5 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn5.Image = Image.FromFile(oPath);
                bt5 = 0;
            }
            check();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {
                btn6.Image = Image.FromFile(xPath);
                bt6 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn6.Image = Image.FromFile(oPath);
                bt6 = 0;
            }
            check();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {               
                btn7.Image = Image.FromFile(xPath);
                bt7 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn7.Image = Image.FromFile(oPath);
                bt7 = 0;
            }
            check();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {               
                btn8.Image = Image.FromFile(xPath);
                bt8 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn8.Image = Image.FromFile(oPath);
                bt8 = 0;
            }
            check();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (mouseCounter % 2 == 0)
            {               
                btn9.Image = Image.FromFile(xPath);
                bt9 = 1;
            }
            else if (mouseCounter % 2 == 1)
            {
                btn9.Image = Image.FromFile(oPath);
                bt9 = 0;
            }
            check();
        }
        private void check()
        {
            if (bt1 != 3 && bt2 != 3 && bt3 != 3)
            {

                if (bt1==0 && bt2==0 && bt3==0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                }
                else if (bt1 == 1 && bt2 == 1 && bt3 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();
                }
            }

            if (bt1 != 3 && bt5 != 3 && bt9 != 3)
            {
                if (bt1 == 0 && bt5 == 0 && bt9 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                }

                else if (bt1 == 1 && bt5 == 1 && bt9 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();                    
                }
            }

            if (bt1 != 3 && bt4 != 3 && bt7 != 3)
            {
                if (bt1 == 0 && bt4 == 0 && bt7 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                }

                else if (bt1 == 1 && bt4 == 1 && bt7 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();
                }
            }

            if (bt2 != 3 && bt5 != 3 && bt8 != 3)
            {
                if (bt2 == 0 && bt5 == 0 && bt8 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                    
                }

                else if (bt2 == 1 && bt5 == 1 && bt8 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();                    
                }
            }
            if (bt3 != 3 && bt6 != 3 && bt9 != 3)
            {
                if (bt3 == 0 && bt6 == 0 && bt9 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();                   
                }

                else if (bt3 == 1 && bt6 == 1 && bt9 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();                   
                }
            }
            if (bt3 != 3 && bt5 != 3 && bt7 != 3)
            {
                if (bt3 == 0 && bt5 == 0 && bt7 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                    
                }
                else if (bt3 == 1 && bt5 == 1 && bt7 == 1)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();                    
                }
            }
            if (bt4 != 3 && bt5 != 3 && bt6 != 3)
            {
                if (bt4 == 0 && bt5 == 0 && bt6 == 0)
                {
                    MessageBox.Show("O is Winner");
                    wino++;
                    play();
                    
                }
                else if (bt4 == 0 && bt5 == 0 && bt6 == 0)
                {
                    MessageBox.Show("X is Winner");
                    winx++;
                    play();                    
                }
            }
            if (bt7 != 3 && bt8 != 3 && bt9 != 3)
            {
                if (bt7 == 0 && bt8 == 0 && bt9 == 0)
                {
                    MessageBox.Show("O is Winner");
                    play();
                    wino++;
                }
                else if (bt7 == 1 && bt8 == 1 && bt9 == 1)
                {
                    MessageBox.Show("X is Winner");
                    play();
                    winx++;
                }
            }
             if (mouseCounter == 8)
            {
               
                MessageBox.Show("It's a Draw......");
                mouseCounter = -1;

                play();
            }


        }
        public void cleargame()
        {
            bt1 = 3;
            bt2 = 3;
            bt9 = 3;
            bt3 = 3;
            bt4 = 3;
            bt5 = 3;
            bt6 = 3;
            bt7 = 3;
            bt8 = 3;
           
            // Buttons background at game start
            btn1.Image = btn2.Image = btn3.Image = btn4.Image = btn5.Image = btn6.Image = btn7.Image = btn8.Image = btn9.Image =
                Image.FromFile(backgrPath);

        }

        public void play()
        {
            cleargame();
            mouseCounter = -1;
        }

        public void OnMouseDownClickCount(object sender, MouseEventArgs ae)
        {

            int n= ae.Clicks;
        }
    }
}
