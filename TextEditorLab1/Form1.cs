using System;
using System.IO;
using System.Windows.Forms;

namespace TextEditorLab1
{
    public partial class Form1 : Form
    {
        private string currentFileName = "Untitled.txt";
        private bool isSaved = false;

        public Form1()
        {
            InitializeComponent();
            UpdateStatus();
        }

        private void UpdateStatus()
        {
            tsslFileName.Text = "Файл: " + currentFileName;
        }

        // ---------- File ----------
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            currentFileName = "Untitled.txt";
            isSaved = false;
            UpdateStatus();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                currentFileName = openFileDialog1.FileName;
                isSaved = true;
                UpdateStatus();
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                currentFileName = saveFileDialog1.FileName;
                isSaved = true;
                UpdateStatus();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isSaved) { saveAsToolStripMenuItem_Click(sender, e); return; }
            File.WriteAllText(currentFileName, richTextBox1.Text);
            UpdateStatus();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Close(); }

        // ---------- Edit ----------
        private void cutToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Cut(); }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Copy(); }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) { richTextBox1.Paste(); }

        // ---------- Help ----------
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Text Editor Tutorial v1.0\n" +
                "Лабораторная работа №1\n" +
                "Студент гр. ИС24 ФИО Гаврилов Артём Викторович\n" +
                "Платформа: .NET Framework 4.7.2",
                "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ---------- ToolStrip-кнопки (дублируют меню) ----------
        private void tsbNew_Click(object sender, EventArgs e) { newToolStripMenuItem_Click(sender, e); }
        private void tsbOpen_Click(object sender, EventArgs e) { openToolStripMenuItem_Click(sender, e); }
        private void tsbSave_Click(object sender, EventArgs e) { saveToolStripMenuItem_Click(sender, e); }
        private void tsbCut_Click(object sender, EventArgs e) { cutToolStripMenuItem_Click(sender, e); }
        private void tsbCopy_Click(object sender, EventArgs e) { copyToolStripMenuItem_Click(sender, e); }
        private void tsbPaste_Click(object sender, EventArgs e) { pasteToolStripMenuItem_Click(sender, e); }
    }
}
