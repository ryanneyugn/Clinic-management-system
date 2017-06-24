using System.IO;
using System;
using System.Text;
using System.Collections.Generic;
namespace TXT
{
    public class TXTOBJECT
    {
        private string path;
        private string[] arr;

        public TXTOBJECT(string path)
        {
            this.path = path;
        }

        public string[] read()
        {
            if(File.Exists(path))
            {
                arr = File.ReadAllLines(path);
                return arr;
            }
            else
            {
                return null;
            }
        }
        
        public void writeAppend(string hoten, string sdt, string dv)
        {
            // Compose a string that consists of three lines.
            string lines = hoten + " - " + sdt + " - " + dv + "\n";

            // Write the string to a file.
            FileStream f = File.Open(path, FileMode.Append);
            Byte[] info = new UTF8Encoding(true).GetBytes(lines);
            f.Write(info, 0, info.Length);

            f.Close();
        }

        public void writeOver(List<string> ds)
        {
            // Compose a string that consists of three lines.
            //string lines = hoten + " - " + sdt + "\n";

            // Write the string to a file.
            FileStream f = File.Open(path, FileMode.Truncate);
            foreach(string str in ds)
            {
                string strs = str + "\n";
                Byte[] info = new UTF8Encoding(true).GetBytes(strs);
                f.Write(info, 0, info.Length);
            }
            f.Close();
        }
    }
}
