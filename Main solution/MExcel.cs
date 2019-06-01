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
            //workSheet.Cells[1, 1] = "Время";
            //workSheet.Cells[1, 2] = "Значение";
            for (int str = 0; str < data.Length; str++)
                for (var col = 0; col < data[str].Length; col++)
                {
                    //workSheet.Columns[col].AutoFit();
                    Console.WriteLine(data[str][col]);
                    var value = data[str][col].ToString();
                    if (value == "65535")
                    {
                        value = "не число";
                    }
                    workSheet.Cells[str+1, col+1].Value = value;
                }


            //workSheet.Shapes.AddPicture("C:\\Users\\User\\Desktop\\курсач Delphi\\images\\cache\\graphic.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 100, 100, 350, 300);
        }

    }
}

