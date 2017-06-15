using System.IO;
using System;
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
    }
}
