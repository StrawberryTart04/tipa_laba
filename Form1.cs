using myach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        private Form2 Fm2 = new Form2();
        private AboutBox1 ab1 = new AboutBox1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fm2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ab1.ShowDialog();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Хотите завершить работу программы?", "Запрос ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void вызовСправкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция недоступна в данный момент", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnDB_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }
    }
}
