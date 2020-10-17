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
    public partial class Excel_ReadCell : baseform
    {
        /// <summary>
        /// 读取单元格
        /// </summary>
        public Excel_ReadCell()
        {
            InitializeComponent();
           
        }
        public string GetInfo()
        {
            return TB_SheetName.Text + TB_CellName.Text;
        }
        public override void Start(CodeGenerator cg)
        {
            List<string> list = new List<string>(TB_CellName.Text.Replace("\"","").Split(','));
        
            cg.AddMethod("ex", nameof(ExcelHelper.ReadCell), list[0],list[1] );

        }

      
    }
}
