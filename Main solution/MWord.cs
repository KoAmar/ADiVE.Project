using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace kursovoi
{
    class MWord
    {
        public void CreateWordDoc(int[] time, double[] result)
        {
            object oEndOfDoc = "\\endofdoc";

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add();

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            //oTable = oDoc.Tables.Add(wrdRng, Convert.ToInt32(Controller.form1.textBox9.Text), 2);
            //oTable.Range.ParagraphFormat.SpaceAfter = 6;
            //oTable.Borders.Enable = 5;

            //oTable.Cell(1, 1).Range.Text = "Время";
            //oTable.Cell(1, 2).Range.Text = "Значение";

            //for (int r = 2; r <= Convert.ToInt32(Controller.form1.textBox9.Text)+ 2; r++) {
            //    oTable.Cell(r, 1).Range.Text = time[r-2].ToString();
            //    oTable.Cell(r, 2).Range.Text = result[r-2].ToString();
            //}

            //oTable.Rows[1].Range.Font.Bold = 1;
            //oTable.Rows[1].Range.Font.Italic = 1;

            //oDoc.Shapes.AddPicture("C:\\Users\\User\\Desktop\\курсач Delphi\\images\\cache\\graphic.png", false, true, 70, 550, 300, 250, Type.Missing);
        }
    }
}


