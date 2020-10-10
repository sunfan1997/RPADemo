using System;
using ExcelDemo.control_widget;
using System.Windows.Forms;
using RPADemo;

namespace ExcelDemo.control_widget
{
    /// <summary>
    /// 打开excel文件，返回文件路径
    /// </summary>
    public partial class Excel_OpenFile : baseform
    {
        string filename;

      
        public Excel_OpenFile()
        {
            InitializeComponent();
            
        }

        private void Btn_SelectFile_Click(object sender, EventArgs e)
        {
            //首先，实例化对话框类实例
            OpenFileDialog openDialog = new OpenFileDialog();
            //然后，判断如果当前用户在对话框里点击的是OK按钮的话。
            if (DialogResult.OK == openDialog.ShowDialog(this))
            {
                //将打开文件对话框的FileName属性传递到你的字符串进行处理
                filename = openDialog.FileName;
                TB_FilePath.Text = "'"+filename+"'";
            }
        }

        public string GetInfo()
        {
            return filename;
        }
        public override void  Start()
        {
            CodeGenerator cg = new CodeGenerator();
            cg.AddField( "path",typeof(string));
            cg.AddObject("ex", typeof(ExcelHelper),TB_FilePath.Text);
           
            //cg.GenerateCode();
        }
    }
}
