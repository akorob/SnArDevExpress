using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Spreadsheet;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraSpreadsheet;

namespace UserInterfaceDevExpress
{
    /// <summary>
    /// Вывод массива на экран.
    /// </summary>
    class SpreadSheetPrinter : IPrinter
    {
        ///<summary>
        /// Элемент DataGridView главной формы приложения.
        /// </summary>
        public SpreadsheetControl Spreadsheet { get; set; }


        /// <summary>
        /// Вывод полученного массива в spreadsheet.
        /// </summary>
        /// <param name="model"></param>
        public void Print(ArrayInfo model)
        {
            var worksheet = Spreadsheet.Document.Worksheets[0];

            // Форматирование чисел по центру ячейки. 
            var range = worksheet.Range["A1:Z24"];
            var rangeFormatting = range.BeginUpdateFormatting();
            rangeFormatting.Alignment.Vertical = SpreadsheetVerticalAlignment.Center;
            rangeFormatting.Alignment.Horizontal = SpreadsheetHorizontalAlignment.Center;
            range.EndUpdateFormatting(rangeFormatting);

            // Пиксели пересчитываются в единицы "Document".
            var tableWidth = Spreadsheet.Size.Width * 300 / 96;
            var tableHeight = Spreadsheet.Size.Height * 300 / 96;

            // Отображение только заполненных ячеек.
            worksheet.Cells.RowHeight = tableHeight / model.NumRows;
            worksheet.Cells.ColumnWidth = tableWidth / model.NumColumns;

            worksheet.Import(model.Array, 0, 0);
        }


        
    }
}
