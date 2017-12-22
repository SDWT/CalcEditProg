namespace Calculator_prog
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Switcher = new System.Windows.Forms.TabControl();
            this.EditorPage = new System.Windows.Forms.TabPage();
            this.Editor = new System.Windows.Forms.TextBox();
            this.EditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.InformationToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.InfToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculatorPage = new System.Windows.Forms.TabPage();
            this.CalculatorTextBox = new System.Windows.Forms.TextBox();
            this.InformationPage = new System.Windows.Forms.TabPage();
            this.AboutProgramRTF = new System.Windows.Forms.RichTextBox();
            this.AutorPict = new System.Windows.Forms.PictureBox();
            this.EditorSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.EditorOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Switcher.SuspendLayout();
            this.EditorPage.SuspendLayout();
            this.EditorMenuStrip.SuspendLayout();
            this.CalculatorPage.SuspendLayout();
            this.InformationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutorPict)).BeginInit();
            this.SuspendLayout();
            // 
            // Switcher
            // 
            this.Switcher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Switcher.Controls.Add(this.EditorPage);
            this.Switcher.Controls.Add(this.CalculatorPage);
            this.Switcher.Controls.Add(this.InformationPage);
            this.Switcher.Location = new System.Drawing.Point(0, 0);
            this.Switcher.Name = "Switcher";
            this.Switcher.SelectedIndex = 0;
            this.Switcher.Size = new System.Drawing.Size(304, 201);
            this.Switcher.TabIndex = 0;
            // 
            // EditorPage
            // 
            this.EditorPage.Controls.Add(this.Editor);
            this.EditorPage.Controls.Add(this.EditorMenuStrip);
            this.EditorPage.Location = new System.Drawing.Point(4, 22);
            this.EditorPage.Name = "EditorPage";
            this.EditorPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditorPage.Size = new System.Drawing.Size(296, 175);
            this.EditorPage.TabIndex = 0;
            this.EditorPage.Text = "Редактор";
            this.EditorPage.UseVisualStyleBackColor = true;
            // 
            // Editor
            // 
            this.Editor.AcceptsTab = true;
            this.Editor.AllowDrop = true;
            this.Editor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editor.Location = new System.Drawing.Point(0, 30);
            this.Editor.Multiline = true;
            this.Editor.Name = "Editor";
            this.Editor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Editor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Editor.Size = new System.Drawing.Size(296, 145);
            this.Editor.TabIndex = 1;
            this.Editor.WordWrap = false;
            // 
            // EditorMenuStrip
            // 
            this.EditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStrip,
            this.InformationToolStrip});
            this.EditorMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.EditorMenuStrip.Name = "EditorMenuStrip";
            this.EditorMenuStrip.Size = new System.Drawing.Size(290, 24);
            this.EditorMenuStrip.TabIndex = 2;
            this.EditorMenuStrip.Text = "Меню";
            // 
            // FileToolStrip
            // 
            this.FileToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenStripMenu,
            this.SaveStripMenu,
            this.toolStripSeparator1,
            this.ExitStripMenu});
            this.FileToolStrip.Name = "FileToolStrip";
            this.FileToolStrip.Size = new System.Drawing.Size(48, 20);
            this.FileToolStrip.Text = "Файл";
            // 
            // OpenStripMenu
            // 
            this.OpenStripMenu.Name = "OpenStripMenu";
            this.OpenStripMenu.Size = new System.Drawing.Size(132, 22);
            this.OpenStripMenu.Text = "Открыть";
            this.OpenStripMenu.Click += new System.EventHandler(this.OpenStripMenu_Click);
            // 
            // SaveStripMenu
            // 
            this.SaveStripMenu.Name = "SaveStripMenu";
            this.SaveStripMenu.Size = new System.Drawing.Size(132, 22);
            this.SaveStripMenu.Text = "Сохранить";
            this.SaveStripMenu.Click += new System.EventHandler(this.SaveStripMenu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // ExitStripMenu
            // 
            this.ExitStripMenu.Name = "ExitStripMenu";
            this.ExitStripMenu.Size = new System.Drawing.Size(132, 22);
            this.ExitStripMenu.Text = "Выход";
            this.ExitStripMenu.Click += new System.EventHandler(this.CloseStripMenu_Click);
            // 
            // InformationToolStrip
            // 
            this.InformationToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfToolStrip});
            this.InformationToolStrip.Name = "InformationToolStrip";
            this.InformationToolStrip.Size = new System.Drawing.Size(65, 20);
            this.InformationToolStrip.Text = "Справка";
            // 
            // InfToolStrip
            // 
            this.InfToolStrip.Name = "InfToolStrip";
            this.InfToolStrip.Size = new System.Drawing.Size(149, 22);
            this.InfToolStrip.Text = "О программе";
            this.InfToolStrip.Click += new System.EventHandler(this.InfToolStrip_Click);
            // 
            // CalculatorPage
            // 
            this.CalculatorPage.Controls.Add(this.CalculatorTextBox);
            this.CalculatorPage.Location = new System.Drawing.Point(4, 22);
            this.CalculatorPage.Name = "CalculatorPage";
            this.CalculatorPage.Padding = new System.Windows.Forms.Padding(3);
            this.CalculatorPage.Size = new System.Drawing.Size(296, 175);
            this.CalculatorPage.TabIndex = 1;
            this.CalculatorPage.Text = "Калькулятор";
            this.CalculatorPage.UseVisualStyleBackColor = true;
            // 
            // CalculatorTextBox
            // 
            this.CalculatorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculatorTextBox.Location = new System.Drawing.Point(0, 0);
            this.CalculatorTextBox.Name = "CalculatorTextBox";
            this.CalculatorTextBox.ReadOnly = true;
            this.CalculatorTextBox.Size = new System.Drawing.Size(296, 20);
            this.CalculatorTextBox.TabIndex = 0;
            // 
            // InformationPage
            // 
            this.InformationPage.Controls.Add(this.AboutProgramRTF);
            this.InformationPage.Controls.Add(this.AutorPict);
            this.InformationPage.Location = new System.Drawing.Point(4, 22);
            this.InformationPage.Name = "InformationPage";
            this.InformationPage.Size = new System.Drawing.Size(296, 175);
            this.InformationPage.TabIndex = 2;
            this.InformationPage.Text = "О программе";
            this.InformationPage.UseVisualStyleBackColor = true;
            // 
            // AboutProgramRTF
            // 
            this.AboutProgramRTF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutProgramRTF.Location = new System.Drawing.Point(145, 8);
            this.AboutProgramRTF.Name = "AboutProgramRTF";
            this.AboutProgramRTF.ReadOnly = true;
            this.AboutProgramRTF.ShowSelectionMargin = true;
            this.AboutProgramRTF.Size = new System.Drawing.Size(143, 120);
            this.AboutProgramRTF.TabIndex = 1;
            this.AboutProgramRTF.Text = "SD product\nProgramm function:\ntxt-files editor;\ncalculator;\n";
            // 
            // AutorPict
            // 
            this.AutorPict.Image = global::Calculator_prog.Properties.Resources.SD;
            this.AutorPict.ImageLocation = "";
            this.AutorPict.InitialImage = global::Calculator_prog.Properties.Resources.SD_250x250;
            this.AutorPict.Location = new System.Drawing.Point(8, 8);
            this.AutorPict.Name = "AutorPict";
            this.AutorPict.Size = new System.Drawing.Size(130, 120);
            this.AutorPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AutorPict.TabIndex = 0;
            this.AutorPict.TabStop = false;
            // 
            // EditorSaveFileDialog
            // 
            this.EditorSaveFileDialog.RestoreDirectory = true;
            // 
            // EditorOpenFileDialog
            // 
            this.EditorOpenFileDialog.FileName = "openFileDialog1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.Switcher);
            this.MinimumSize = new System.Drawing.Size(256, 240);
            this.Name = "MainForm";
            this.Text = "Приложение";
            this.Switcher.ResumeLayout(false);
            this.EditorPage.ResumeLayout(false);
            this.EditorPage.PerformLayout();
            this.EditorMenuStrip.ResumeLayout(false);
            this.EditorMenuStrip.PerformLayout();
            this.CalculatorPage.ResumeLayout(false);
            this.CalculatorPage.PerformLayout();
            this.InformationPage.ResumeLayout(false);
            this.InformationPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutorPict)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Switcher;
        private System.Windows.Forms.TabPage EditorPage;
        private System.Windows.Forms.TextBox Editor;
        private System.Windows.Forms.TabPage CalculatorPage;
        private System.Windows.Forms.TextBox CalculatorTextBox;
        private System.Windows.Forms.TabPage InformationPage;
        private System.Windows.Forms.MenuStrip EditorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStrip;
        private System.Windows.Forms.ToolStripMenuItem InformationToolStrip;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem InfToolStrip;
        private System.Windows.Forms.SaveFileDialog EditorSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog EditorOpenFileDialog;
        private System.Windows.Forms.ToolStripMenuItem OpenStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitStripMenu;
        private System.Windows.Forms.PictureBox AutorPict;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.RichTextBox AboutProgramRTF;
    }
}

