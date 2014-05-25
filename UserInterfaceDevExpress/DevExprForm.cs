using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserInterfaceDevExpress
{
    /// <summary>
    /// Форма приложения на основе компонентов DevExpress.
    /// </summary>
    public partial class DevExprForm : Form, ISnakeView
    {
        public DevExprForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Нажатие кнопки "Построить".
        /// </summary>
        public event EventHandler<EventArgs> BuildClicked;

        /// <summary>
        /// Нажатие кнопки для выбора файла.
        /// </summary>
        public event EventHandler<EventArgs> FileSelectClicked;

        /// <summary>
        /// Закрытие приложения.
        /// </summary>
        public event EventHandler<EventArgs> AppFormClosing;

        /// <summary>
        /// Путь к файлу вывода.
        /// </summary>
        public string FilePath
        {
            get { return textEditFilePath.Text; } 
            set { textEditFilePath.Text = value; }
        }

        /// <summary>
        /// Количество строк матрицы.
        /// </summary>
        public int NumRows
        {
            get { return (int) spinEditRows.Value; } 
            set { spinEditRows.Value = value; }
        }

        /// <summary>
        /// Количество столбцов матрицы.
        /// </summary>
        public int NumColumns
        {
            get { return (int)spinEditColumns.Value; }
            set { spinEditColumns.Value = value; }
        }

        /// <summary>
        /// Метод возвращает объект SpreadSheetPrinter для вывода матрицы на экран.
        /// </summary>
        public IPrinter GetViewPrinter()
        {
            IPrinter sshPrinter = new SpreadSheetPrinter(){ Spreadsheet = this.spreadsheet };
            return sshPrinter;

        }

        private void spinEditColumns_EditValueChanged(object sender, EventArgs e)
        {
            var value = (int)spinEditColumns.Value;
            if (value > 11)
            {
                spinEditColumns.Value = 11;
            }
            if (value < 1)
            {
                spinEditColumns.Value = 1;
            }
        }

        private void spinEditRows_EditValueChanged(object sender, EventArgs e)
        {
            var value = (int)spinEditRows.Value;
            if (value > 11)
            {
                spinEditRows.Value = 11;
            }
            if (value < 1)
            {
                spinEditRows.Value = 1;
            }
        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            if (BuildClicked != null)
            {
                BuildClicked(this, EventArgs.Empty);
            }
        }

        private void buttonFileSelect_Click(object sender, EventArgs e)
        {
            if (FileSelectClicked != null)
            {
                FileSelectClicked(this, EventArgs.Empty);
            }

        }

        private void DevExprForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (AppFormClosing != null)
            {
                AppFormClosing(this, EventArgs.Empty);
            }
        }
    }
}
