using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;


namespace kursovoi
{
    class Ppoint
    {
        PowerPoint.Application ppApp;
        PowerPoint.Presentations objPresSet;
        PowerPoint.SlideShowWindows objSSWs;
        PowerPoint.SlideShowSettings objSSS;
        public void ShowPresentation()//открытие презентации
        {
            ppApp = new PowerPoint.Application();
            string path = Application.StartupPath + @"\presentation.ppt";
            ppApp.Visible = Microsoft.Office.Core.MsoTriState.msoTrue;
            objPresSet = ppApp.Presentations;
            PowerPoint._Presentation oPres = objPresSet.Open(path , 
                Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, 
                Microsoft.Office.Core.MsoTriState.msoTrue);

        }
    }
}

