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
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
            ControlProperty.Form1CP(this);
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
        //2.使用渐隐效果关闭;
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if(this.Opacity > 0)
            {
                this.Opacity -= 0.05;
            }
            else if (this.Opacity == 0)
            {
                this.timer2.Stop();
                this.Close();
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int Heightone = Screen.PrimaryScreen.Bounds.Height;            //获取屏幕的高;
            int Heighttwo = Screen.PrimaryScreen.WorkingArea.Height;       //获取工作区的高;
            int Widthone = Screen.PrimaryScreen.Bounds.Width;              //获取屏幕的宽;
            int HeightTaskbar = Heightone - Heighttwo;                     //获取任务栏的高;
            this.Top = Heightone - 250 - HeightTaskbar;
            this.Left = Widthone - 400;
            this.Opacity = 0;
            this.timer1.Start();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
        }

    }
}
