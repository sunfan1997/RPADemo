using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;
using System.Data;
using Spire.Xls.Collections;
using Spire.Xls.Core.Spreadsheet.Sorting;

namespace RPADemo
{
    class ExcelHelper
    {
        private string path;
        Workbook workbook = new Workbook();
        Worksheet sheet;
        public ExcelHelper(string path)
        {
            this.path = path;
            if (!string.IsNullOrEmpty(path))
            {
                workbook.LoadFromFile(path);
                sheet = workbook.Worksheets[0];
            }
        }
        public ExcelHelper(string path,int sheets)
        {
            this.path = path;
            if(!string.IsNullOrEmpty(path))
            {
                workbook.LoadFromFile(path);
                sheet = workbook.Worksheets[sheets];
            }
        }
        //改变颜色
        public void ChangeColor(string path)
        {
           
            sheet.Range["A1:A2"].Style.KnownColor = ExcelColors.Gray50Percent;
            workbook.SaveToFile(path, ExcelVersion.Version2016);

        }
        #region 列重命名
        /// <summary>
        /// 我的理解是更改第一行的文本内容
        /// </summary>
        /// <param name="column">第几列</param>
        /// <param name="name">重命名名称</param>
        public void RenameColumn(int column,object name)
        {
            WriteCell(0, column, name);
        }
        #endregion

        #region sheet表重命名
        public void RenameSheet(string name)
        {
            sheet.Name = name;
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        #endregion

        #region 表格过滤，排序
        /// <summary>
        /// 过滤(文本)
        /// </summary>
        /// <param name="sheets">第几张表</param>
        /// <param name="column">筛选第几列</param>
        /// <param name="str">筛选文本条件</param>
        public void Filter(int column,string str)
        {

            ////获取第一个工作表
            //sheet = workbook.Worksheets[sheets];

            ////获取AutoFilters对象
            //AutoFiltersCollection filters = sheet.AutoFilters;

            ////设置需要筛选的单元格区域
            //filters.Range = sheet.Range[1, 1, sheet.LastRow, 5];

            ////在所选区域的第二列添加筛选器，并设置过滤准则，即文本“C”
            //filters.AddFilter(column, str);

            ////执行过滤
            //filters.Filter();

            ////保存文档
            //workbook.SaveToFile(path, ExcelVersion.Version2013);

        }

        /// <summary>
        /// 排序(文本)
        /// </summary>
        /// <param name="index"></param>
        public void Sort(int column,int start,int end)
        {
            //排序是否包含标题（默认第一个数据为标题，不会对它进行排序）
            workbook.DataSorter.IsIncludeTitle = false;

            //指定要排序的单元格范围并进行排序
            string Startrow = acsiitochar(column + 65)+start.ToString();
            string Endrow = acsiitochar(column + 65).ToString()+end.ToString();
            string RowRange = Startrow + ":" + Endrow;
            workbook.DataSorter.Sort(sheet.Range[RowRange]);

            //保存文档
            workbook.SaveToFile(path, ExcelVersion.Version2016);

        }

        //acsii码转字母
        public string acsiitochar(int num)
        {
            byte[] array = new byte[1];
            array[0] = (byte)(Convert.ToInt32(num));//ASCII码强制转换二进制
            string ret = Convert.ToString(System.Text.Encoding.ASCII.GetString(array));
            return ret;
        }
        #endregion

        #region 插入行/插入列
        //插入行
        public void InsertRow( int index)
        {
            sheet.InsertRow(index);
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        //插入列
        public void InsertColumn( int index)
        {
            sheet.InsertColumn(index);
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        #endregion

        #region 创建文件
        public void CreateFile(string path)
        {
            Workbook workbook = new Workbook();

            
            workbook.SaveToFile(path, ExcelVersion.Version2016);

            Console.WriteLine("文件写入完成！");

        }
        #endregion

        #region 获取表格行列数
        //获取行数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        public int GetRowCount()
        {
            int iRowCount = sheet.Rows.Length;
            return iRowCount;
        }
        //获取列数
        public int GetColumnCount()
        {
            int iColumnCount = sheet.Columns.Length;
            return iColumnCount;
        }
        #endregion

        #region 读取\写入整行/整列
        /// <summary>
        /// 读取第row行
        /// </summary>
        /// <param name="row">行号</param>
        public DataTable ReadWholeRow(int row)
        {
            //sheet = workbook.Worksheets[sheets];
            //DataTable dt = SheetToDataTable(false, sheet);
            DataTable ans = new DataTable();
            //int ColumnCount = sheet.Columns.Length;
            //for(int column=0;column<ColumnCount;column++)
            //{
            //    ans.Rows[row][column] = dt.Rows[row][column];
            //}
            return ans;
        }

        /// <summary>
        /// 读取第column列
        /// </summary>
        /// <param name="column">列号</param>
        public DataTable ReadWholeColumn(int sheets, int column)
        {
            DataTable dt = SheetToDataTable(false, sheet);
            DataTable ans = new DataTable();
            int RowCount = sheet.Rows.Length;
            for (int row = 0; row < RowCount; row++)
            {
                ans.Rows[row][column] = dt.Rows[row][column];
            }
            return ans;
        }

        /// <summary>
        /// 写入第row行
        /// </summary>
        /// <param name="sheets">第几张表</param>
        /// <param name="row">行号</param>
        public void WriteWholeRow(int sheets, int row,DataTable info)
        {
            Worksheet sheet = workbook.Worksheets[sheets];
            DataTable dt = SheetToDataTable(false, sheet);
            int ColumnCount = sheet.Columns.Length;
            for (int column = 0; column < ColumnCount; column++)
            {
                dt.Rows[row][column] = dt.Rows[0][column];
            }
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }

        /// <summary>
        /// 写入第column列
        /// </summary>
        /// <param name="sheets">第几张表</param>
        /// <param name="column">列号</param>
        public void WriteWholeColumn(int sheets, int column, DataTable info)
        {
            Worksheet sheet = workbook.Worksheets[sheets];
            DataTable dt = SheetToDataTable(false, sheet);
            int RowCount = sheet.Rows.Length;
            for (int row = 0; row < RowCount; row++)
            {
                dt.Rows[row][column] = dt.Rows[row][0];
            }
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        #endregion

        #region 读取\写入单元格
        //读取单元格
        public Object ReadCell(int row,int column)
        {
            DataTable dt = SheetToDataTable(false, sheet);
            return dt.Rows[row][column];
        }
        //写入单元格
        public void WriteCell(int row, int column,object content)
        {
            DataTable dt = SheetToDataTable(false, sheet);
            dt.Rows[row][column] = content;
            workbook.SaveToFile(path, ExcelVersion.Version2016);
        }
        #endregion

        #region 读写整张表
        //数据写入表
        public void WriteWholeData(DataTable dt)
        {

            int iRowCount = dt.Rows.Count;
            int iColCount = dt.Columns.Count;
            for (int row = 0; row < iRowCount; row++)
            {
                for (int column = 0; column < iColCount; column++)
                {
                    sheet.Range[row, column].Text = dt.Rows[row][column].ToString();
                }
            }
        }
        //读取整张表
        public void ReadWholeSheet()
        {
         
            DataTable dt = SheetToDataTable(false, sheet);
            int iRowCount = dt.Rows.Count;
            int iColCount = dt.Columns.Count;
            for (int row = 0; row < iRowCount; row++)
            {
                for (int column = 0; column < iColCount; column++)
                {
                    Console.Write(dt.Rows[row][column].ToString());
                }
                Console.WriteLine();
            }
        }
        private DataTable SheetToDataTable(bool hasTitle, Worksheet sheet)
        {
            int iRowCount = sheet.Rows.Length;
            int iColCount = sheet.Columns.Length;
            var dt = new DataTable();
            //生成列头
            for (var i = 0; i < iColCount; i++)
            {
                var name = "column" + i;
                if (hasTitle)
                {
                    var txt = sheet.Range[1, i + 1].Text;
                    if (!string.IsNullOrEmpty(txt)) name = txt;
                }
                while (dt.Columns.Contains(name)) name = name + "_1";//重复行名称会报错。
                dt.Columns.Add(new DataColumn(name, typeof(string)));
            }
            //生成行数据
            // ReSharper disable once SuggestVarOrType_BuiltInTypes
            var rowIdx = hasTitle ? 2 : 1;
            for (var iRow = rowIdx; iRow <= iRowCount; iRow++)
            {
                var dr = dt.NewRow();
                for (var iCol = 1; iCol <= iColCount; iCol++)
                {
                    dr[iCol - 1] = sheet.Range[iRow, iCol].Text;
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion
    }
}
