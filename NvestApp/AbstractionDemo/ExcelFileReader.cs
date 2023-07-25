using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NvestApp.AbstractionDemo
{
    class ExcelFileReader : FileReader
    {
        public override DataTable Read(string FullPath)
        {
            throw new NotImplementedException();
        }
    }
}
