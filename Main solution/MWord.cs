using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace Main_solution
{
    class MWord
    {
        private object doc;

        public void CreateWordDoc(double[][] data, double result)
        {
            object oEndOfDoc = "\\endofdoc";

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application
            {
                Visible = true
            };
            oDoc = oWord.Documents.Add();

            var res = result.ToString();
            if (res == "65535")
            {
                res = "не число";
            }
            oDoc.Content.Text = "Определитель = "+res;

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, data.Length, data[0].Length);
            oTable.Borders.Enable = 3;

            var laststr = data.Length;
            for (int str = 0; str < data.Length; str++)
                for (var col = 0; col < data[str].Length; col++)
                {
                    var value = data[str][col].ToString();
                    if (value == "65535")
                    {
                        value = "не число";
                    }
                    oTable.Cell(str + 1, col + 1).Range.Text = value;
                }
            


            //for (int col = 1; col <= data[0].Length; col++)
            //    workSheet.Columns[col].AutoFit();
            //oDoc.Shapes.AddPicture("C:\\Users\\User\\Desktop\\курсач Delphi\\images\\cache\\graphic.png", false, true, 70, 550, 300, 250, Type.Missing);
        }
    }
}


