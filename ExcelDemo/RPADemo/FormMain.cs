

using ExcelDemo;
using ExcelDemo.control_widget;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RPADemo
{
    public partial class FormMain : Form
    {
        string path = null;
        bool isMouseDown = false;
        bool isMouseMove = false;

        DataTable dt = new DataTable();

        ExcelDemo.baseform test = null;
        TreeNode Node;
        public FormMain()
        {
            InitializeComponent();
            
        }

        public void btnSpire_Click(object sender, EventArgs e)
        {
            path = @"D:\visual studio项目\Test.xlsx";
            ExcelHelper excelhelper = new ExcelHelper(path);
            excelhelper.Sort(1, 2, 8);
        }


        
        private void Btn_Saveas_Click(object sender, EventArgs e)
        {
            ReadXml();
        }

        private void Btn_Save_ButtonClick(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode node = xml.CreateXmlDeclaration("1.0", "utf-8", "");
            xml.AppendChild(node);
            XmlNode root = xml.CreateElement("config");
            xml.AppendChild(root);
            xml.Save(@"../../parameter.xml");
            FindCtrlName(Pan_Main);
            MessageBox.Show("保存成功！");
        }

        #region treeview鼠标事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            isMouseDown = true;
            
         
        }

        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            isMouseDown = true;
        }
        private void treeView1_MouseLeave(object sender, EventArgs e)
        {
            isMouseMove = true;
        }
        private void treeView1_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            Node = e.Node;
        }

        #endregion

        #region panel2鼠标事件
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (isMouseDown && isMouseMove)
            {
                CheckNode(Node);
                Point Point = Pan_Main.PointToClient(Control.MousePosition); //鼠标相对于panel2左上角的坐标
                test.Location = Point;
                
                this.Pan_Main.Controls.Add(test);
                FindBaseForm(Pan_Main);

            }
            isMouseDown = false;
            isMouseMove = false;
            if (Node.Text.Equals(treeView1.SelectedNode.Text))
            {
                isMouseDown = true;
            }

        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

           

        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            
            FindBaseForm(Pan_Main); 
        }

        #endregion

        #region 不同节点调用不同窗体

        private void CheckNode(TreeNode node)
        {
            switch (node.Text)
            {
                case "Excel应用程序范围":
                    {
                        test = new Excel_OpenFile();
                    }
                    break;
                case "保存工作簿":
                    {
                        test = new Excel_SaveBook();

                    }
                    break;
                case "关闭工作簿":
                    {
                        test = new Excel_CloseBook();

                    }
                    break;
                case "写入单元格":
                    {
                        test = new Excel_WriteCell();

                    }
                    break;
                case "写入单范围":
                    {
                        test = new Excel_WriteRange();
                    }
                    break;
                case "删除单范围":
                    {
                        test = new Excel_DeleteRange();
                    }
                    break;
                case "获取单元格颜色":
                    {
                        test = new Excel_GetCellColor();
                    }
                    break;
                case "获取工作簿工作表":
                    {
                        test = new Excel_GetWorkBookSheet();
                    }
                    break;
                case "获取选定范围":
                    {
                        test = new Excel_GetSelectedRange();
                    }
                    break;
                case "读取列":
                    {
                        test = new Excel_ReadCloumn();
                    }
                    break;
                case "读取单元格":
                    {
                        test = new Excel_ReadCell();
                    }
                    break;
                case "读取单元格公式":
                    {
                        test = new Excel_ReadCellFormula();
                    }
                    break;
                case "读取范围":
                    {
                        test = new Excel_ReadRange();
                    }
                    break;
                case "读取行":
                    {
                        test = new Excel_ReadRow();
                    }
                    break;
                case "选取范围":
                    {
                        test = new Excel_SelectRange();
                    }
                    break;
                case "附加范围":
                    {
                        test = new Excel_AppendRange();
                    }
                    break;
                default :MessageBox.Show("控件未添加");break;
        
            }

        }
        #endregion

        #region 运行按钮
        private void Tsb_Run_ButtonClick(object sender, EventArgs e)
        {
        }
        #endregion

        #region 保存为xml
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
                new XElement("location",
                new XAttribute("x", ctrl.Location.X),
                new XAttribute("y", ctrl.Location.Y))
              )
           );

            xe.Add(record);
            xe.Save(@"../../parameter.xml");
         
        }


        #endregion

        #region 读取xml生成控件
        //读取xml文件
        public void ReadXml()
        {
            //将XML文件加载进来
            XDocument doc = XDocument.Load(@"../../parameter.xml");
            //获取到XML的根元素进行操作
            XElement root = doc.Root;
            XElement ele = root.Element("controls");
            //获取name标签的值
            //XElement shuxing = ele.Element("title");
            //Console.WriteLine(shuxing.Value);
            //获取根元素下的所有子元素
            IEnumerable<XElement> enumerable = root.Elements();
            foreach (XElement item in enumerable)
            {
               // Console.WriteLine(item.Attribute("type").Value);
                String type = item.Attribute("type").Value;
                Control control=new Control();
                bool flag = true;
                switch (type)
                {
                    case "System.Windows.Forms.Panel":
                        {
                            control = new Panel();
                            control=(Panel)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.Excel_OpenFile":
                        {
                            control = new Excel_OpenFile();
                            control = (Excel_OpenFile)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.Label":
                        {
                            control = new Label();
                            control = (Label)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.Button":
                        {
                            control = new Button();
                            control = (Button)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.TextBox":
                        {
                            control = new TextBox();
                            control = (TextBox)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.Excel_CloseBook":
                        {
                            control = new Excel_CloseBook();
                            control = (Excel_CloseBook)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.TreeView":
                        {
                            control = new TreeView();
                            control = (TreeView)InitWidget(item, control);
                        }
                        break;
                    case "ExcelDemo.control_widget.ToolStrip":
                        {
                            control = new ToolStrip();
                            control = (ToolStrip)InitWidget(item, control);
                        }
                        break;
                    default:
                        {
                            flag = false;
                        }
                        break;
                }

                if (flag)
                {
                    Pan_Main.Controls.Add(control);
                }
            }
        }
            
        public Control InitWidget(XElement item,Control control)
        {
            foreach (XElement item1 in item.Elements())
            {
                switch (item1.Name.ToString())
                {
                    case "title":
                        {
                            control.Text = item1.Value;
                        }
                        break;
                    case "visible":
                        {
                            control.Visible = item1.Value == "true" ? true : false;
                        }
                        break;
                    case "enable":
                        {
                            control.Enabled = item1.Value == "true" ? true : false;
                        }
                        break;
                    case "location":
                        {
                            Point point = new Point();
                            point.X = int.Parse(item1.Attribute("x").Value);
                            point.Y = int.Parse(item1.Attribute("y").Value);
                            control.Location = point;
                        }
                        break;
                }
                //  Console.WriteLine(item1.Name+item1.Value);   //输出 name  name1            
            }
            return control;
        }


        #endregion

        #region 画线
        public void FindBaseForm(Control parent)
        {
            //Console.WriteLine(parent.Controls.Count);
            List<baseform> list_control = new List<baseform>();
           
            for(int i=0;i<parent.Controls.Count;i++)
            {
               // Console.WriteLine(parent.Controls[i].GetType().Name);

                try
                {
                    list_control.Add((baseform)parent.Controls[i]);
                }
                catch(Exception e)
                {
                    //e.ToString();
                    continue;
                }
                
               
            }
            list_control.Sort(compare);
            //Console.WriteLine(list_control.Count);
            for (int i=0;i<list_control.Count-1;i++)
            {
               // Console.WriteLine(list_control[i].Name);
                
                int x1, y1, x2, y2;
                x1 = list_control[i].Location.X + list_control[i].Size.Width/2;
                y1 = list_control[i].Location.Y + list_control[i].Size.Height;
                x2 = list_control[i+1].Location.X + list_control[i+1].Size.Width / 2;
                y2 = list_control[i+1].Location.Y ;
                connectline(x1, y1, x2, y2);
            }
        }
        public void connectline(int x1,int y1,int x2,int y2)
        {
            Pen p = new Pen(Color.Black, 3);
            Graphics g = Pan_Main.CreateGraphics(); //this.CreateGraphics();
            //DrawArrow(g, p, 50, 20, 100, 20);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;//恢复实线
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//定义线尾的样式为箭头
            g.DrawLine(p,x1,y1,x2,y2);
          
            p.Dispose();
            g.Dispose();
        }
        public  void  clearline()
        {
            Graphics g = Pan_Main.CreateGraphics(); //this.CreateGraphics();
            g.Clear(Pan_Main.BackColor);
            g.Dispose();
        }
        
        #endregion

        private  int compare(Control a,Control b)
        {
            if (a.Location.Y < b.Location.Y)
            {
                return 0;
            }else if(a.Location.Y > b.Location.Y)
            {
                return 1;
            }else if(a.Location.X < b.Location.X)
            {
                return 0;
            }
            return 1;    
        }
        //变量按钮
        private void TSBtn_Variable_Click(object sender, EventArgs e)
        {
            DGV_Variable.Visible = DGV_Variable.Visible == true ? false : true; 
        }
        private int rowindex=0;
        private void ToolStripMenuItem_Delete_Click(object sender, EventArgs e)
        {
            if(!DGV_Variable.CurrentRow.IsNewRow)
            {
                DGV_Variable.Rows.RemoveAt(rowindex);
            }
        }

        private void DGV_Variable_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

            rowindex = e.RowIndex;
        }

        private void DGV_Variable_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //dt = ToDataTable(DGV_Variable);
            //Console.WriteLine("========================");
            //for (int i = 0; i < DGV_Variable.Rows.Count; i++)
            //{
            //    Console.WriteLine(dt.Rows[i]["VarName"].ToString() +
            //        dt.Rows[i]["VarType"].ToString() +
            //        dt.Rows[i][2].ToString() +
            //        dt.Rows[i][3].ToString());
            //}

        }
        //复制
        private DataTable ToDataTable(DataGridView dataGridView, string tableName = null)
        {
            DataGridView dgv = dataGridView;
            DataTable table = new DataTable(tableName);

            for (int iCol = 0; iCol < dgv.Columns.Count; iCol++)
            {
                table.Columns.Add(dgv.Columns[iCol].Name);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                DataRow datarw = table.NewRow();
                for (int iCol = 0; iCol < dgv.Columns.Count; iCol++)
                {
                    datarw[iCol] = row.Cells[iCol].Value;
                }
                table.Rows.Add(datarw);
            }

            return table;
        }

       
    }

}
