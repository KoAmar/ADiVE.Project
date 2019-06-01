using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Main_solution
{
    class MExcel
    {
        public void DisplayInExcel(double[][] data, double result)
        {
            var excelApp = new Excel.Application
            {
                Visible = true
            };

            excelApp.Workbooks.Add();
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            var laststr = data.Length; 
            for (int str = 0; str < data.Length; str++)
                for (var col = 0; col < data[str].Length; col++)
                {
                    var value = data[str][col].ToString();
                    if (value == "65535")
                    {
                        value = "не число";
                    }
                    workSheet.Cells[str+1, col+1].Value = value;
                }
            var res = result.ToString();
            if (res == "65535")
            {
                res = "не число";
            }
            workSheet.Cells[laststr+1, 1].Value = "Определитель = ";
            workSheet.Cells[laststr+1, 2].Value = result;

            for(int col =1;col<=data[0].Length;col++)
            workSheet.Columns[col].AutoFit();


            //workSheet.Shapes.AddPicture("C:\\Users\\User\\Desktop\\курсач Delphi\\images\\cache\\graphic.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 100, 100, 350, 300);
        }

    }
}

