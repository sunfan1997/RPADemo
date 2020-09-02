using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;


namespace Demo01
{
    public class Setting
    {
        ///<summary>
        /// 把对象序列化为字节数组
        ///</summary>
        public static byte[] SerializeObject(object obj)
        {
            if (obj == null)
                return null;
            MemoryStream ms = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            ms.Position = 0;
            byte[] bytes = new byte[ms.Length];
            ms.Read(bytes, 0, bytes.Length);
            ms.Close();
            return bytes;
        }
        ///<summary>
        /// 把字节数组反序列化成对象
        ///</summary>
        public static object DeserializeObject(byte[] bytes)
        {
            object obj = null;
            if (bytes == null)
                return obj;
            MemoryStream ms = new MemoryStream(bytes);
            ms.Position = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                obj = formatter.Deserialize(ms);
            }
            catch { obj = null; }
            ms.Close();
            return obj;
        }
        public static bool Save(string path, object value, bool isCeranew)
        {
            //如果不存在创建文件
            FileStream fs;
            if ((!File.Exists(path)) && isCeranew)
            {
                try
                {
                    fs = File.Create(path);
                }
                catch
                {
                    return false;
                }
            }
            //如果存在则打开
            else
            {
                try
                {
                    fs = File.Open(path, FileMode.Open, FileAccess.Write);
                }
                catch
                {
                    return false;
                }
            }
            //写文件
            byte[] buffer = SerializeObject(value);
            try
            {
                for (long i = 0; i < buffer.LongLength; i++)
                    fs.WriteByte(buffer[i]);
            }
            catch
            {
                return false;
            }
            fs.Close();
            return true;
        }
        public static object Read(string path)
        {
            FileStream fs;
            try
            {
                fs = File.OpenRead(path);
            }
            catch
            {
                return null;
            }
            //读入缓存
            StreamReader sreader = new StreamReader(fs);
            string str = sreader.ReadToEnd();
            fs.Close();
            sreader.Close();
            //分析内容
            byte[] buffer = Encoding.Default.GetBytes(str);
            return DeserializeObject(buffer);
        }
        [Serializable]
        public struct FormSizeandLocation
        {
            public int SizeW;
            public int SizeH;
            public int LocationX;
            public int LocationY;
            public int Style;
        }
        private static Setting.FormSizeandLocation fsp = new Setting.FormSizeandLocation();
        public static void AddRenewFormSizeControl(Form form)
        {
            form.FormClosing += new FormClosingEventHandler(FormcloseEvent);
            form.Load += new EventHandler(FormloadEvent);
        }
        private static void FormcloseEvent(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            switch (form.WindowState)
            {
                case FormWindowState.Maximized:
                    fsp.Style = 2;
                    fsp.SizeW = form.Width;
                    fsp.SizeH = form.Height;
                    fsp.LocationX = form.Location.X;
                    fsp.LocationY = form.Location.Y;
                    break;
                case FormWindowState.Minimized:
                    fsp.Style = 1;
                    break;
                case FormWindowState.Normal:
                    fsp.Style = 0;
                    fsp.SizeW = form.Width;
                    fsp.SizeH = form.Height;
                    fsp.LocationX = form.Location.X;
                    fsp.LocationY = form.Location.Y;
                    break;
            }
            Setting.Save(Directory.GetCurrentDirectory() + @"\" + "Location.set", fsp, true);
        }
        private static void FormloadEvent(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            object result = Setting.Read(Directory.GetCurrentDirectory() + @"\" + "Location.set");
            if (result != null)
            {
                fsp = (Setting.FormSizeandLocation)result;
                switch (fsp.Style)
                {
                    case 2:
                        form.WindowState = FormWindowState.Maximized;
                        break;
                    default:
                        form.WindowState = FormWindowState.Normal;
                        break;
                }
                form.Left = fsp.LocationX;
                form.Top = fsp.LocationY;
                form.Size = new Size(fsp.SizeW, fsp.SizeH);

            }
        }
    }
}
