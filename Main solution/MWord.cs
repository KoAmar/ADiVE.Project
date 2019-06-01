using Microsoft.Office.Interop.Word;
using System.Globalization;

namespace Main_solution
{
    internal class MWord
    {
        public static void CreateWordDoc(double[][] data, double result)
        {
            object oEndOfDoc = "\\endofdoc";

            _Application oWord = new Application
            {
                Visible = true
            };
            _Document oDoc = oWord.Documents.Add();

            var res = result.ToString();
            if (res == "65535")
            {
                res = "не число";
            }
            oDoc.Content.Text = "Определитель = "+res;

            Table oTable;
            var wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, data.Length, data[0].Length);
            oTable.Borders.Enable = 3;

            for (var str = 0; str < data.Length; str++)
                for (var col = 0; col < data[str].Length; col++)
                {
                    var value = data[str][col].ToString(CultureInfo.InvariantCulture);
                    if (value == "65535")
                    {
                        value = "не число";
                    }
                    oTable.Cell(str + 1, col + 1).Range.Text = value;
                }
        }
    }
}


