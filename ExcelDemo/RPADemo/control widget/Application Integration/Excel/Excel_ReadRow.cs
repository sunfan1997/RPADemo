﻿using System;
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
    public partial class Excel_ReadRow : baseform
    {
        /// <summary>
        /// 读取行
        /// </summary>
        public Excel_ReadRow()
        {
            InitializeComponent();
        }
        public string GetInfo()
        {
            return TB_SheetName.Text + TB_RowName.Text;
        }

       
    }
}
