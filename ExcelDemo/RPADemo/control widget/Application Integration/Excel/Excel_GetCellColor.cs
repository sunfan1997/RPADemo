using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelDemo.control_widget
{
    public partial class Excel_GetCellColor : baseform
    {
        /// <summary>
        /// 获取单元格颜色
        /// </summary>
        public Excel_GetCellColor()
        {
            InitializeComponent();
        }
        public string GetInfo()
        {
            return TB_SheetName.Text + TB_CellName.Text;
        }
    }
}
