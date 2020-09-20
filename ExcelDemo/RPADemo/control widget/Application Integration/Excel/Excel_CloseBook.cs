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
    public partial class Excel_CloseBook : baseform
    {
        /// <summary>
        /// 关闭工作簿，返回是否成功
        /// </summary>
        
        
        public Excel_CloseBook()
        {
            InitializeComponent();
        }
        public bool GetInfo()
        {
            string bookname = TB_BookName.Text;
            return true;
        }
        public override void Start()
        {
            
        }
    }
}
