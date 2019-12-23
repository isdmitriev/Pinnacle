using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using PinnacleClasses.DatabaseObjects;

using Excel = Microsoft.Office.Interop.Excel;

namespace PinnacleClasses.ExcelConverter
{
  public  class ExcelWriter
    {
        public void WritePricesToExcelFile()
        {
            //var excelApp = new Application();
            //excelApp.SheetsInNewWorkbook = 2;
            //var xlBook =(Microsoft.Office.Interop.Excel.Workbook)excelApp.Workbooks.Add(Type.Missing);

            //var oSHeet = (Microsoft.Office.Interop.Excel.Worksheet)excelApp.Worksheets.Item[1];
            //oSHeet.Name = "ilya";
            //oSHeet.Cells[1, 1] ="il";
            //xlBook.SaveAs("d:\\19.xlsx");



            // Создаём экземпляр нашего приложения
            Excel.Application excelApp = new Excel.Application();
         
            // Создаём экземпляр рабочий книги Excel
            Excel.Workbook workBook;
            // Создаём экземпляр листа Excel
            Excel.Worksheet workSheet;

            workBook = excelApp.Workbooks.Add(Type.Missing);

            workSheet = (Excel.Worksheet)workBook.ActiveSheet;
            workSheet.Name = "1988";

            // Заполняем первую строку числами от 1 до 10




            workSheet.Cells[2, 5] = 23;

           

            
            workBook.SaveAs("D:\\101.xlsx");








        }
    }
}
