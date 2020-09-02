using System;
using Demo02;

using System.Windows.Forms;

using System.Xml.Linq;
using Demo02.Properties;
using System.Xml;
using System.Drawing;

namespace Demo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // FindCtrlName(this);
            //InitForm();
            //XmlDocument xml = new XmlDocument();
            //XmlElement config = xml.CreateElement("Config");
            //xml.AppendChild(config);
            //XmlElement path = xml.CreateElement("Path");
            ////path节点中的文本内容为bai E:\Test\ @用于转义后面的'\'
            //path.InnerText = @"D:\Test\";
            ////将path添加为config的子节点
            //config.AppendChild(path);
            //xml.Save(@"D:\abc.xml");
            Pen p = new Pen(Color.Black, 3);
            Graphics g = panel1.CreateGraphics(); //this.CreateGraphics();
            //DrawArrow(g, p, 50, 20, 100, 20);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;//恢复实线
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//定义线尾的样式为箭头
            g.DrawLine(p, 0, 0, 400, 400);
            p.Dispose();
            g.Dispose();

        }
        void InitForm()
        {
            string tmp= XmlHelper.Read(@"D:\visual studio project\Demo02\Demo02\parameter.xml", @"table", @"");
            Console.WriteLine("======================");
            Console.WriteLine(tmp);
            Console.WriteLine("======================");

        }
        void FindCtrlName(Control parent)//遍历面板控件
        {
            foreach (Control ctrl in parent.Controls)
            {
                CtrlToXML(ctrl);
                if (ctrl.Controls.Count > 0)
                {
                    FindCtrlName(ctrl);
                }
            }
        }

        private void CtrlToXML(Control ctrl)//Linq to XML
        {
            XElement xe = XElement.Load(@"../../parameter.xml");
            XElement record = new XElement(
                
                new XElement("controls",
                new XAttribute("type", ctrl.GetType().ToString()),
                new XAttribute("language", "Chinese"),
                new XAttribute("name", ctrl.Name),
                new XElement("title", ctrl.Text),
                new XElement("visible", ctrl.Visible),
                new XElement("enable", ctrl.Enabled),
                new XElement("value", 28.00)));

            xe.Add(record);
            xe.Save(@"../../parameter.xml");
            //            MessageBox.Show("插入成功！");
        }
    }

   
}
