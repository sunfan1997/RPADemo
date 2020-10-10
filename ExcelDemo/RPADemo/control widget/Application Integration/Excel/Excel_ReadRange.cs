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
    public partial class Excel_ReadRange : baseform
    {

        /// <summary>
        /// 读取范围
        /// </summary>
        public Excel_ReadRange()
        {
            InitializeComponent();
        }
        public string GetInfo()
        {
            return TB_SheetName.Text + TB_Range.Text;
        }

        public override void Start()
        {
            CodeGenerator cg = new CodeGenerator();
            
        }
    }
}
