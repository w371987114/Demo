using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace GDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            List<string[]> listid=new List<string[]>();
            string[] list1={"1","2","3"};
            string[] list2={"a","b","c"};
            string[] list3 = { "A", "B", "C" };
            listid.Add(list1);
            listid.Add(list2);
            listid.Add(list3);
            string result = listid[2][2];

            int week = DateTime.Now.DayOfYear;

            //画一个渐变的正方形
            Graphics g = e.Graphics;
            Rectangle rect = new Rectangle(50, 30, 100, 100);
            LinearGradientBrush lBrush = new LinearGradientBrush(rect, Color.Purple, Color.LightBlue, LinearGradientMode.BackwardDiagonal);
            g.FillRectangle(lBrush, rect);

            //画一段弧
            Pen pen1 = new Pen(Color.Blue);
            Rectangle rect2 = new Rectangle(50, 50, 200, 100);
            g.DrawArc(pen1, rect2,12,84);

            //画一条线段
            Pen pen2 = new Pen(Color.Red);
            Point pointStart = new Point(130, 130);
            Point pointEnd = new Point(250, 250);
            g.DrawLine(pen2, pointStart, pointEnd);
        }
    }
}
