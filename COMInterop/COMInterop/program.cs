using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMInterop
{
    class program
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
           
            for(int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)workSheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)workSheet.Cells[ i + 1 , 2]).Value2 = data[i, 0];
            }
            workSheet.SaveAs(savePath + "\\book-old.xlsx",
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing,
                Type.Missing);
            excelApp.Quit();
        }
        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = excelApp.ActiveSheet;

            for(int i=0; i< data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1] = data[i, 0];
                workSheet.Cells[i + 1, 2] = data[i, 1];
            }
            workSheet.SaveAs(savePath + "\\book-dynamic.xlsx");
            excelApp.Quit();
        }
        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"Alice in Wonderland" ,"Alice"},
                {"Transformers Dark of the moon","Bumblebee" },
                {"Bumblebee" ,"Bumblebee"},
                {"Transformers MTMTE", "Megatron" }
            };

            Console.WriteLine("Creating Excel document in oldway...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel document in newway...");
            NewWay(array, savePath);
        }
    }
}
