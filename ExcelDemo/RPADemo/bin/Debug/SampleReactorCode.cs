//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCode
{
    using System;
    using System.Windows.Forms;
    using RPADemo;
    
    
    public class Program
    {
        
        private string path;
        
        public static void Main()
        {
            RPADemo.ExcelHelper ex = new RPADemo.ExcelHelper("test.xlsx");
            ex.SetSheet(1);
            ex.DeleteSheet();
            ex.SaveBook();
        }
    }
}
