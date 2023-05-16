using Bytescout.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VTiger.Generic
{
    public class Excellutility
    {
      public string getavalue(string sheetname,int row,int cel)
        {
            Spreadsheet sheet = new Spreadsheet();
            sheet.LoadFromFile(Constantpaths.excelpath);
           string value=sheet.Workbook.Worksheets.ByName(sheetname).Cell(row, cel).ToString();
            return value;
        }

        public string getavalue(string sheetname,string key)
        {
            Spreadsheet sheet=new Spreadsheet();
            sheet.LoadFromFile(Constantpaths.excelpath);
            int lrow=sheet.Workbook.Worksheets.ByName(sheetname).UsedRangeRowMax;
            string value = null;
            for (int i = 0; i <=lrow; i++)
            {
                string akey =sheet.Workbook.Worksheets.ByName(sheetname).Cell(i, 0).ToString();
            
                if( akey.Equals(key))
                {
                    value = sheet.Workbook.Worksheets.ByName(sheetname).Cell(i, 1).ToString();
                    break;
                }
            }
            return value;
        }


    }
}
