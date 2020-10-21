using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelDemo;

namespace RPADemo.control_widget.Application_Integration.Excel
{
    public partial class Excel_DeleteSheet : baseform
    {
        public Excel_DeleteSheet()
        {
            InitializeComponent();
        }
        public override void Start(CodeGenerator cg)
        {
            cg.AddMethod("ex", nameof(ExcelHelper.SetSheet), TB_Sheet.Text);
            cg.AddMethod("ex", nameof(ExcelHelper.DeleteSheet));

        }

        private void TB_Sheet_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();

        }
    }
}
