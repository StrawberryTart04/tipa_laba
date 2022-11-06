using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myach
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myachhDataSet.спекталь". При необходимости она может быть перемещена или удалена.
            this.спектальTableAdapter.Fill(this.myachhDataSet.спекталь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myachhDataSet.возрастное_ограничение". При необходимости она может быть перемещена или удалена.
            this.возрастное_ограничениеTableAdapter.Fill(this.myachhDataSet.возрастное_ограничение);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myachhDataSet.спекталь". При необходимости она может быть перемещена или удалена.
            this.спектальTableAdapter.Fill(this.myachhDataSet.спекталь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myachhDataSet.спекталь". При необходимости она может быть перемещена или удалена.
            this.спектальTableAdapter.Fill(this.myachhDataSet.спекталь);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "myachhDataSet.автор". При необходимости она может быть перемещена или удалена.
            this.авторTableAdapter.Fill(this.myachhDataSet.автор);

        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            авторBindingSource.EndEdit();
            авторTableAdapter.Update(myachhDataSet);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            авторспектальBindingSource.EndEdit();
            спектальTableAdapter.Update(myachhDataSet);
        }

        private void btnSave3_Click(object sender, EventArgs e)
        {
            возрастноеОграничениеBindingSource.EndEdit();
            возрастное_ограничениеTableAdapter.Update(myachhDataSet);
        }

        private void btnWord_Click_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Word (*.doc; *.docx)|*.doc?";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                // Экспорт в Word
                string fn = System.IO.Directory.GetCurrentDirectory() + "\\myach.docx";
                int r = dataGridView2.CurrentCell.RowIndex;
                var iD_Spektal = dataGridView2.Rows[r].Cells[0].FormattedValue.ToString();
                var name_spektal = dataGridView2.Rows[r].Cells[1].FormattedValue.ToString();
                var style = dataGridView2.Rows[r].Cells[2].FormattedValue.ToString();
                var ID_author = dataGridView2.Rows[r].Cells[3].FormattedValue.ToString();
                var id_age_restricion = dataGridView2.Rows[r].Cells[4].FormattedValue.ToString();
                try
                {
                    Word.Application wordApp = new Word.Application();
                    wordApp.Visible = false;
                    Word.Document wordDocument = wordApp.Documents.Open(fn);
                    ReplaceWordStub("{iD_Spektal}", iD_Spektal, wordDocument);
                    ReplaceWordStub("{name_spektal}", name_spektal, wordDocument);
                    ReplaceWordStub("{style}", style, wordDocument);
                    ReplaceWordStub("{ID_author}", ID_author, wordDocument);
                    ReplaceWordStub("{id_age_restricion}", id_age_restricion, wordDocument);
                    wordDocument.SaveAs2(sd.FileName);
                    wordApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                }

                catch (Exception osh)
                    {
                    MessageBox.Show(osh.ToString(), "Возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document
        wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Экспорт в Excel
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Файлы Excel (*.xls; *.xlsx)|*.xls?";
            if (sd.ShowDialog() == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.ActiveSheet;
                excelApp.Visible = false;
                for (int i = 1; i < dataGridView1.RowCount + 1; i++)
                    for (int j = 1; j < dataGridView1.ColumnCount + 1; j++)
                        worksheet.Rows[i].Columns[j] = dataGridView1.Rows[i - 1].Cells[j - 1].FormattedValue;
                excelApp.AlertBeforeOverwriting = false;
                excelApp.DisplayAlerts = false;
                try
                {
                    workbook.SaveAs(sd.FileName);
                }
                catch (Exception oshi)
                {
                    MessageBox.Show(oshi.ToString(), "У вас возникла ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
   