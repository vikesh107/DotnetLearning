using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelReader
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with the path to your Excel file
            string excelFilePath = @"D:\Vikesh Workspace\demo01"

            // Create Excel application and open the workbook
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Open(excelFilePath);

            // Specify the sheet name
            string sheetName = "investor acct";

            // Get the worksheet
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[sheetName];

            // Get column values
            Excel.Range columnRange = worksheet.UsedRange.Columns["AccountNumber"]; // Replace "A" with your column name
            Array columnValues = (Array)columnRange.Value;

            // Get subcolumn values
            Excel.Range subcolumnRange = worksheet.UsedRange.Columns["encrypted"]; // Replace "B" with your subcolumn name
            Array subcolumnValues = (Array)subcolumnRange.Value;

            // Output column values
            Console.WriteLine("Column Values:");
            foreach (var value in columnValues)
            {
                Console.WriteLine(value);
            }

            // Output subcolumn values
            Console.WriteLine("\nSubcolumn Values:");
            foreach (var value in subcolumnValues)
            {
                Console.WriteLine(value);
            }

            // Close Excel
            workbook.Close();
            excelApp.Quit();
        }
    }
}