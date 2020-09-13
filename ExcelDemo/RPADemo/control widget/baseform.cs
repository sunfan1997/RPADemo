using System;

using System.Windows.Forms;
using RPADemo;
using System.Drawing;

namespace ExcelDemo
{
    public partial class baseform : UserControl
    {
        bool MoveFlag = false;//鼠标是否按下
        int xPos = 0;//鼠标x坐标
        int yPos = 0;//鼠标y坐标
        public baseform()
        {
            InitializeComponent();
        }

       
        private void baseform_MouseDown(object sender, MouseEventArgs e)
        {
            MoveFlag = true;//已经按下.
            xPos = e.X;//当前x坐标.
            yPos = e.Y;//当前y坐标.
        }

        private void baseform_MouseUp(object sender, MouseEventArgs e)
        {
            MoveFlag = false;
        }

        private void baseform_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveFlag)
            {
                this.Left+= Convert.ToInt16(e.X - xPos);//设置x坐标.
                this.Top += Convert.ToInt16(e.Y - yPos);//设置y坐标.
                clearline();
                //point.X = e.X - xPos;//设置x坐标.
                //point.Y = e.Y - yPos;//设置y坐标.
                //this.Location = point;
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void clearline()
        {
            Graphics g = this.Parent.CreateGraphics(); //this.CreateGraphics();
            g.Clear(this.Parent.BackColor);
            g.Dispose();
        }
        public virtual void Start()
        {
            Console.WriteLine("baseform");

        }
        //public void SetTitle(string title)
        //{
        //    LB_Title.Text = title;
        //}
    }
}
