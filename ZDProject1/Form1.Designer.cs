namespace ZDProject1
{
    partial class Form1
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
            this.textBox_Text = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеКлючамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортОткрытогоКлючаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортОткрытогоКлючаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалениеПарыКлючейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЗакрытогоКлючаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.changeUser = new System.Windows.Forms.Button();
            this.loadDoc = new System.Windows.Forms.Button();
            this.saveDoc = new System.Windows.Forms.Button();
            this.label_Info = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Text
            // 
            this.textBox_Text.Location = new System.Drawing.Point(12, 95);
            this.textBox_Text.Name = "textBox_Text";
            this.textBox_Text.Size = new System.Drawing.Size(433, 223);
            this.textBox_Text.TabIndex = 0;
            this.textBox_Text.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.управлениеКлючамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(456, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem,
            this.toolStripSeparator2,
            this.оПрограммеToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.loadDoc_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.saveDoc_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // управлениеКлючамиToolStripMenuItem
            // 
            this.управлениеКлючамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.экспортОткрытогоКлючаToolStripMenuItem,
            this.импортОткрытогоКлючаToolStripMenuItem,
            this.удалениеПарыКлючейToolStripMenuItem,
            this.выборЗакрытогоКлючаToolStripMenuItem});
            this.управлениеКлючамиToolStripMenuItem.Name = "управлениеКлючамиToolStripMenuItem";
            this.управлениеКлючамиToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.управлениеКлючамиToolStripMenuItem.Text = "Управление ключами";
            // 
            // экспортОткрытогоКлючаToolStripMenuItem
            // 
            this.экспортОткрытогоКлючаToolStripMenuItem.Name = "экспортОткрытогоКлючаToolStripMenuItem";
            this.экспортОткрытогоКлючаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.экспортОткрытогоКлючаToolStripMenuItem.Text = "Экспорт открытого ключа";
            this.экспортОткрытогоКлючаToolStripMenuItem.Click += new System.EventHandler(this.экспортОткрытогоКлючаToolStripMenuItem_Click);
            // 
            // импортОткрытогоКлючаToolStripMenuItem
            // 
            this.импортОткрытогоКлючаToolStripMenuItem.Name = "импортОткрытогоКлючаToolStripMenuItem";
            this.импортОткрытогоКлючаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.импортОткрытогоКлючаToolStripMenuItem.Text = "Импорт открытого ключа";
            this.импортОткрытогоКлючаToolStripMenuItem.Click += new System.EventHandler(this.импортОткрытогоКлючаToolStripMenuItem_Click);
            // 
            // удалениеПарыКлючейToolStripMenuItem
            // 
            this.удалениеПарыКлючейToolStripMenuItem.Name = "удалениеПарыКлючейToolStripMenuItem";
            this.удалениеПарыКлючейToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.удалениеПарыКлючейToolStripMenuItem.Text = "Удаление пары ключей";
            this.удалениеПарыКлючейToolStripMenuItem.Click += new System.EventHandler(this.удалениеПарыКлючейToolStripMenuItem_Click);
            // 
            // выборЗакрытогоКлючаToolStripMenuItem
            // 
            this.выборЗакрытогоКлючаToolStripMenuItem.Name = "выборЗакрытогоКлючаToolStripMenuItem";
            this.выборЗакрытогоКлючаToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.выборЗакрытогоКлючаToolStripMenuItem.Text = "Выбор закрытого ключа";
            this.выборЗакрытогоКлючаToolStripMenuItem.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Имя пользователя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Enabled = false;
            this.textBox_Name.Location = new System.Drawing.Point(12, 56);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(138, 20);
            this.textBox_Name.TabIndex = 3;
            // 
            // changeUser
            // 
            this.changeUser.Location = new System.Drawing.Point(175, 39);
            this.changeUser.Name = "changeUser";
            this.changeUser.Size = new System.Drawing.Size(86, 37);
            this.changeUser.TabIndex = 4;
            this.changeUser.Text = "Выбрать пользователя";
            this.changeUser.UseVisualStyleBackColor = true;
            this.changeUser.Click += new System.EventHandler(this.changeUser_Click);
            // 
            // loadDoc
            // 
            this.loadDoc.Location = new System.Drawing.Point(267, 39);
            this.loadDoc.Name = "loadDoc";
            this.loadDoc.Size = new System.Drawing.Size(86, 37);
            this.loadDoc.TabIndex = 5;
            this.loadDoc.Text = "Загрузить документ";
            this.loadDoc.UseVisualStyleBackColor = true;
            this.loadDoc.Click += new System.EventHandler(this.loadDoc_Click);
            // 
            // saveDoc
            // 
            this.saveDoc.Location = new System.Drawing.Point(359, 39);
            this.saveDoc.Name = "saveDoc";
            this.saveDoc.Size = new System.Drawing.Size(86, 37);
            this.saveDoc.TabIndex = 6;
            this.saveDoc.Text = "Сохранить документ";
            this.saveDoc.UseVisualStyleBackColor = true;
            this.saveDoc.Click += new System.EventHandler(this.saveDoc_Click);
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Location = new System.Drawing.Point(12, 79);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(0, 13);
            this.label_Info.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 330);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.saveDoc);
            this.Controls.Add(this.loadDoc);
            this.Controls.Add(this.changeUser);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Text);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBox_Text;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеКлючамиToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button changeUser;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.Button loadDoc;
        private System.Windows.Forms.Button saveDoc;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортОткрытогоКлючаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортОткрытогоКлючаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалениеПарыКлючейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЗакрытогоКлючаToolStripMenuItem;
        private System.Windows.Forms.Label label_Info;
    }
}

