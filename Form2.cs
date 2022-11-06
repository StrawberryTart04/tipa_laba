using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form2 : Form
    {
        public static Form2 Kp
        {
            get;
            set;
        }
        public Form2()
        {
            Kp = this;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1.Kp.Cp(textBox1.Text);
            Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        public void Upload(string Upload)
        {
            textBox1.Text = Upload;
        }

        private void загрузитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        // Обработчик события «MenuItemClick» для пункта меню «Цвет фона»
        private void задатьЦветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }
        // Обработчик события «MenuItemClick» для пункта меню «Шрифт»
        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                textBox1.Font = fontDialog1.Font;
        }
        // Обработчик события «MenuItemClick» для пункта меню «Сохранить в файл»
        private void сохранитьВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для записи
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create,
                FileAccess.Write);
                //создаем поток записи
                StreamWriter sw = new StreamWriter(fs);
                //записываем данные
                sw.WriteLine(textBox1.Text);
                //закрываем стримы
                sw.Close();
                fs.Close();
            }
        }
        // Обработчик события «MenuItemClick» для пункта меню «Загрузить из файла»
        private void загрузитьИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //создаем новый файл для чтения
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open,
                FileAccess.Read);
                //создаем поток чтения
                StreamReader sr = new StreamReader(fs);
                textBox1.Text = sr.ReadToEnd();
                //закрываем стримы
                sr.Close();
                fs.Close();
            }
        }
        // Обработчик события «MenuItemClick» для пункта меню «Печать»
        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // обработчик события печати
            printDocument1.PrintPage += PrintPageHandler;
            printPreviewDialog1.Document = printDocument1;
            // если в диалоге было нажато ОК
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printPreviewDialog1.Document.Print(); // печатаем   
        }
        // Обработчик события «Печать»
        private void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, Font, Brushes.Black, 20, 20);
        }

    }
}
