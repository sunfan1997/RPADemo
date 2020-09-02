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
    public partial class Excel_WriteCell : baseform
    {
        /// <summary>
        /// 写入单元格
        /// </summary>
        string bookname = null;
        string cellname = null;
        string content = null;
        public Excel_WriteCell()
        {
            InitializeComponent();
        }
        public string GetInfo()
        {
            bookname = TB_BookName.Text;
            cellname = TB_CellName.Text;
            content = TB_Content.Text;
            return bookname+ cellname+ content;
        }
    }
}
