using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THE_MOST_COMFORTABLE_TEXT_READER
{
    public partial class Form1 : Form
    {
        string filename = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filename = "";
            richTextBox1.Clear();
            this.Text = "Безымянный";
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = saveFileDialog1.FileName;
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = saveFileDialog1.FileName;
            }
        }

        private void сохрнаитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    filename = saveFileDialog1.FileName;
                    this.Text = filename;
                }
            }
            else
            {
                richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
            }
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = openFileDialog1.FileName;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.BackColor = colorDialog1.Color;
            }
        }

        private void открытьToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                richTextBox1.LoadFile(openFileDialog1.FileName,
            RichTextBoxStreamType.PlainText);
                this.Text = openFileDialog1.FileName;

            }
        }
    }
}
