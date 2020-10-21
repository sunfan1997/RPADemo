using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPADemo;

namespace ExcelDemo.control_widget
{
    public partial class Excel_SaveBook : baseform
    {
        /// <summary>
        /// 保存工作簿，返回是否保存成功
        /// </summary>
        public Excel_SaveBook()
        {
            InitializeComponent();
        }
        public bool GetInfo()
        {
            return true;
        }
        public override void Start(CodeGenerator cg)
        {
            cg.AddMethod("ex", nameof(ExcelHelper.SaveBook));
        }
    }
    
}
