using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace NvestApp.AbstractionDemo
{
   abstract class FileReader
    {
        private string _FileName { get; set; }
        private string _FileExtension { get; set; }
        private long _ContentLength { get; set; }

        public string GetFileName(String FullPath)
        {
            //code
            return "Test.xlsx";
        }

        public string GetExtension(String FullPath)
        {
            //code
            return ".xlsx";
        }

        public long GetCOntentLength(string FullPath)
        {
            return 1003738;
        }

        public abstract DataTable Read(string FullPath);
    }
}
