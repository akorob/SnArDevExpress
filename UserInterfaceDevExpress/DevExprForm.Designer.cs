namespace UserInterfaceDevExpress
{
    partial class DevExprForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBuild = new DevExpress.XtraEditors.SimpleButton();
            this.textEditFilePath = new DevExpress.XtraEditors.TextEdit();
            this.buttonFileSelect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEditColumns = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditRows = new DevExpress.XtraEditors.SpinEdit();
            this.spreadsheet = new DevExpress.XtraSpreadsheet.SpreadsheetControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditColumns.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditRows.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBuild
            // 
            this.buttonBuild.Location = new System.Drawing.Point(126, 322);
            this.buttonBuild.Name = "buttonBuild";
            this.buttonBuild.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.buttonBuild.Size = new System.Drawing.Size(75, 23);
            this.buttonBuild.TabIndex = 2;
            this.buttonBuild.Text = "Построить";
            this.buttonBuild.Click += new System.EventHandler(this.buttonBuild_Click);
            // 
            // textEditFilePath
            // 
            this.textEditFilePath.Location = new System.Drawing.Point(6, 296);
            this.textEditFilePath.Name = "textEditFilePath";
            this.textEditFilePath.Size = new System.Drawing.Size(223, 20);
            this.textEditFilePath.TabIndex = 3;
            // 
            // buttonFileSelect
            // 
            this.buttonFileSelect.Location = new System.Drawing.Point(235, 296);
            this.buttonFileSelect.Name = "buttonFileSelect";
            this.buttonFileSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonFileSelect.TabIndex = 4;
            this.buttonFileSelect.Text = "Файл...";
            this.buttonFileSelect.Click += new System.EventHandler(this.buttonFileSelect_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(71, 252);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Столбцы";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(207, 252);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Строки";
            // 
            // spinEditColumns
            // 
            this.spinEditColumns.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditColumns.Location = new System.Drawing.Point(71, 270);
            this.spinEditColumns.Name = "spinEditColumns";
            this.spinEditColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditColumns.Size = new System.Drawing.Size(50, 20);
            this.spinEditColumns.TabIndex = 7;
            this.spinEditColumns.EditValueChanged += new System.EventHandler(this.spinEditColumns_EditValueChanged);
            // 
            // spinEditRows
            // 
            this.spinEditRows.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditRows.Location = new System.Drawing.Point(207, 270);
            this.spinEditRows.Name = "spinEditRows";
            this.spinEditRows.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditRows.Size = new System.Drawing.Size(53, 20);
            this.spinEditRows.TabIndex = 8;
            this.spinEditRows.EditValueChanged += new System.EventHandler(this.spinEditRows_EditValueChanged);
            // 
            // spreadsheet
            // 
            this.spreadsheet.Location = new System.Drawing.Point(1, 3);
            this.spreadsheet.Name = "spreadsheet";
            this.spreadsheet.Options.HorizontalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.spreadsheet.Options.TabSelector.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetElementVisibility.Hidden;
            this.spreadsheet.Options.VerticalScrollbar.Visibility = DevExpress.XtraSpreadsheet.SpreadsheetScrollbarVisibility.Hidden;
            this.spreadsheet.Options.View.ShowColumnHeaders = false;
            this.spreadsheet.Options.View.ShowRowHeaders = false;
            this.spreadsheet.Size = new System.Drawing.Size(320, 242);
            this.spreadsheet.TabIndex = 9;
            this.spreadsheet.Text = "spreadsheetControl1";
            // 
            // DevExprForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 352);
            this.Controls.Add(this.spreadsheet);
            this.Controls.Add(this.spinEditRows);
            this.Controls.Add(this.spinEditColumns);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.buttonFileSelect);
            this.Controls.Add(this.textEditFilePath);
            this.Controls.Add(this.buttonBuild);
            this.Name = "DevExprForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SnakeArray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DevExprForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.textEditFilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditColumns.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditRows.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton buttonBuild;
        private DevExpress.XtraEditors.TextEdit textEditFilePath;
        private DevExpress.XtraEditors.SimpleButton buttonFileSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEditColumns;
        private DevExpress.XtraEditors.SpinEdit spinEditRows;
        private DevExpress.XtraSpreadsheet.SpreadsheetControl spreadsheet;
    }
}