using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.BusinessLetter
{
    public interface IExcelDoc
    {
        DataTable ReadExcel(string path, string sheetName);
        DataTable SearchByName(DataTable dt, string pretraga);
    }
}
