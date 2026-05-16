namespace TextEditorLab1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileToolStripMenuItem, this.editToolStripMenuItem, this.helpToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;

            // File
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.newToolStripMenuItem, this.openToolStripMenuItem, this.saveToolStripMenuItem,
                this.saveAsToolStripMenuItem, this.toolStripSeparator1, this.exitToolStripMenuItem });
            this.fileToolStripMenuItem.Text = "File";

            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);

            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);

            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);

            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);

            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);

            // Edit
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem });
            this.editToolStripMenuItem.Text = "Edit";

            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);

            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);

            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);

            // Help
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.aboutToolStripMenuItem });
            this.helpToolStripMenuItem.Text = "Help";

            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);

            // toolStrip1
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbNew, this.tsbOpen, this.tsbSave, this.toolStripSeparator2,
                this.tsbCut, this.tsbCopy, this.tsbPaste });
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);

            this.tsbNew.Text = "New"; this.tsbNew.ToolTipText = "Создать (Ctrl+N)";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            this.tsbOpen.Text = "Open"; this.tsbOpen.ToolTipText = "Открыть (Ctrl+O)";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            this.tsbSave.Text = "Save"; this.tsbSave.ToolTipText = "Сохранить (Ctrl+S)";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            this.tsbCut.Text = "Cut"; this.tsbCut.ToolTipText = "Вырезать";
            this.tsbCut.Click += new System.EventHandler(this.tsbCut_Click);
            this.tsbCopy.Text = "Copy"; this.tsbCopy.ToolTipText = "Копировать";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            this.tsbPaste.Text = "Paste"; this.tsbPaste.ToolTipText = "Вставить";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);

            // richTextBox1
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 49);
            this.richTextBox1.Size = new System.Drawing.Size(780, 449);
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 10F);

            // statusStrip1
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.tsslFileName });
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.tsslFileName.Text = "Файл: Untitled.txt";

            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Editor Tutorial — Студент гр. ИС24 ФИО Гаврилов Артём Викторович";
            this.menuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
