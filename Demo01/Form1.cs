using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Demo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
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
