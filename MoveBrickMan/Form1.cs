using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveBrickMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1.使用渐显效果显示;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 1)
            {
                this.timer1.Stop();
            }
            else
            {
                this.Opacity += 0.05;
            }
        }
        //1.使用渐隐效果关闭;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0)
            {
                this.timer1.Stop();
                this.timer2.Stop();
                this.Close();
            }
            else
            {
                this.Opacity -= 0.05;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Heightone = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;            //获取屏幕的高;
            int Heighttwo = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;       //获取工作区的高;
            int Widthone = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;              //获取屏幕的宽;
            int HeightTaskbar = Heightone - Heighttwo;                                          //获取任务栏的高;
            this.Top = Heightone - 300 - HeightTaskbar;
            this.Left = Widthone - 400;
            this.Opacity = 0;
            this.timer1.Start();
        }

    }
}
