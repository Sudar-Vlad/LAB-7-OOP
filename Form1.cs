using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LAB_7_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Title = "Виберіть файл";
                openFileDialog1.Filter = "Текстові файли (*.txt)|*.txt";

                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array f = new Array(100);
            string s = textBox1.Text;
            f.input(textBox2, s);
            f.zap();
            f.ras(textBox3);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
