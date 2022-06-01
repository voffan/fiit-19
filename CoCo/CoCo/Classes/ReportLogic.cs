using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace CoCo.Classes
{
    internal class ReportLogic: IDisposable
    {
        private Application _excel;
        private _Workbook _workbook;
        private string _filePath;
        public ReportLogic()
        {
            _excel = new Microsoft.Office.Interop.Excel.Application();

        }

        internal bool Open(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    _workbook = _excel.Workbooks.Open(filePath);
                }
                else
                {
                    _workbook = _excel.Workbooks.Add();
                    _filePath = filePath;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal void Save()
        {
            if (!string.IsNullOrEmpty(_filePath))
            {
                _workbook.SaveAs(_filePath);
                _filePath = null;
            }
            else
            {
                _workbook.Save();
            }
        }

        internal bool Set(string column, int row, object data)
        {
            try
            {
//                ((Microsoft.Office.Interop.Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].Font.Bold = true;

//                ((Microsoft.Office.Interop.Excel.Worksheet)_excel.ActiveSheet).Cells[row, column].VerticalAlignment =
//Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                ((Microsoft.Office.Interop.Excel.Worksheet)_excel.ActiveSheet).Cells[row, column] = data;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        public void Dispose()
        {
            try
            {
                _workbook.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
