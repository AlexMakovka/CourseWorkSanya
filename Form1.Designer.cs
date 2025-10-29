namespace CourseWorkSanya
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancelStudent = new System.Windows.Forms.Button();
            this.buttonSaveStudent = new System.Windows.Forms.Button();
            this.textBoxGroupStudent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRecordStudent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFullnameStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewLecturer = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewTheme = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewStatement = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonRewrite = new System.Windows.Forms.Button();
            this.textBoxDirection = new System.Windows.Forms.TextBox();
            this.labelReq1 = new System.Windows.Forms.Label();
            this.comboBoxReq1 = new System.Windows.Forms.ComboBox();
            this.comboBoxReq2 = new System.Windows.Forms.ComboBox();
            this.labelReq2 = new System.Windows.Forms.Label();
            this.dataGridViewReq = new System.Windows.Forms.DataGridView();
            this.comboBoxReq3 = new System.Windows.Forms.ComboBox();
            this.labelReq3 = new System.Windows.Forms.Label();
            this.comboBoxReq4 = new System.Windows.Forms.ComboBox();
            this.labelReq4 = new System.Windows.Forms.Label();
            this.comboBoxReq5 = new System.Windows.Forms.ComboBox();
            this.labelReq5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecordStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatement)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 479);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeleteStudent);
            this.tabPage1.Controls.Add(this.buttonAddStudent);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dataGridViewStudent);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Студенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(637, 421);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(217, 23);
            this.buttonDeleteStudent.TabIndex = 3;
            this.buttonDeleteStudent.Text = "Отчислить";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(414, 421);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(217, 23);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCancelStudent);
            this.groupBox1.Controls.Add(this.buttonSaveStudent);
            this.groupBox1.Controls.Add(this.textBoxGroupStudent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownRecordStudent);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFullnameStudent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(860, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить студента";
            this.groupBox1.Visible = false;
            // 
            // buttonCancelStudent
            // 
            this.buttonCancelStudent.Location = new System.Drawing.Point(195, 152);
            this.buttonCancelStudent.Name = "buttonCancelStudent";
            this.buttonCancelStudent.Size = new System.Drawing.Size(157, 23);
            this.buttonCancelStudent.TabIndex = 7;
            this.buttonCancelStudent.Text = "Отмена";
            this.buttonCancelStudent.UseVisualStyleBackColor = true;
            this.buttonCancelStudent.Click += new System.EventHandler(this.buttonCancelStudent_Click);
            // 
            // buttonSaveStudent
            // 
            this.buttonSaveStudent.Location = new System.Drawing.Point(18, 152);
            this.buttonSaveStudent.Name = "buttonSaveStudent";
            this.buttonSaveStudent.Size = new System.Drawing.Size(157, 23);
            this.buttonSaveStudent.TabIndex = 6;
            this.buttonSaveStudent.Text = "Сохранить";
            this.buttonSaveStudent.UseVisualStyleBackColor = true;
            this.buttonSaveStudent.Click += new System.EventHandler(this.buttonSaveStudent_Click);
            // 
            // textBoxGroupStudent
            // 
            this.textBoxGroupStudent.Location = new System.Drawing.Point(90, 95);
            this.textBoxGroupStudent.Name = "textBoxGroupStudent";
            this.textBoxGroupStudent.Size = new System.Drawing.Size(273, 22);
            this.textBoxGroupStudent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа";
            // 
            // numericUpDownRecordStudent
            // 
            this.numericUpDownRecordStudent.Location = new System.Drawing.Point(90, 67);
            this.numericUpDownRecordStudent.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRecordStudent.Name = "numericUpDownRecordStudent";
            this.numericUpDownRecordStudent.ReadOnly = true;
            this.numericUpDownRecordStudent.Size = new System.Drawing.Size(273, 22);
            this.numericUpDownRecordStudent.TabIndex = 3;
            this.numericUpDownRecordStudent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "№ зачётки";
            // 
            // textBoxFullnameStudent
            // 
            this.textBoxFullnameStudent.Location = new System.Drawing.Point(90, 39);
            this.textBoxFullnameStudent.Name = "textBoxFullnameStudent";
            this.textBoxFullnameStudent.Size = new System.Drawing.Size(273, 22);
            this.textBoxFullnameStudent.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.RowHeadersWidth = 51;
            this.dataGridViewStudent.RowTemplate.Height = 24;
            this.dataGridViewStudent.Size = new System.Drawing.Size(848, 412);
            this.dataGridViewStudent.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewLecturer);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1235, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преподаватели";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLecturer
            // 
            this.dataGridViewLecturer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecturer.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewLecturer.Name = "dataGridViewLecturer";
            this.dataGridViewLecturer.RowHeadersWidth = 51;
            this.dataGridViewLecturer.RowTemplate.Height = 24;
            this.dataGridViewLecturer.Size = new System.Drawing.Size(1223, 438);
            this.dataGridViewLecturer.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewTheme);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1235, 450);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Предмет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTheme
            // 
            this.dataGridViewTheme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheme.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTheme.Name = "dataGridViewTheme";
            this.dataGridViewTheme.RowHeadersWidth = 51;
            this.dataGridViewTheme.RowTemplate.Height = 24;
            this.dataGridViewTheme.Size = new System.Drawing.Size(1223, 438);
            this.dataGridViewTheme.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewStatement);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1235, 450);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ведомость";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStatement
            // 
            this.dataGridViewStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatement.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStatement.Name = "dataGridViewStatement";
            this.dataGridViewStatement.RowHeadersWidth = 51;
            this.dataGridViewStatement.RowTemplate.Height = 24;
            this.dataGridViewStatement.Size = new System.Drawing.Size(1223, 438);
            this.dataGridViewStatement.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBoxReq5);
            this.tabPage5.Controls.Add(this.labelReq5);
            this.tabPage5.Controls.Add(this.comboBoxReq4);
            this.tabPage5.Controls.Add(this.labelReq4);
            this.tabPage5.Controls.Add(this.comboBoxReq3);
            this.tabPage5.Controls.Add(this.labelReq3);
            this.tabPage5.Controls.Add(this.dataGridViewReq);
            this.tabPage5.Controls.Add(this.comboBoxReq2);
            this.tabPage5.Controls.Add(this.labelReq2);
            this.tabPage5.Controls.Add(this.comboBoxReq1);
            this.tabPage5.Controls.Add(this.labelReq1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1235, 450);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Запросы";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(730, 507);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(217, 23);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonRewrite
            // 
            this.buttonRewrite.Enabled = false;
            this.buttonRewrite.Location = new System.Drawing.Point(953, 507);
            this.buttonRewrite.Name = "buttonRewrite";
            this.buttonRewrite.Size = new System.Drawing.Size(217, 23);
            this.buttonRewrite.TabIndex = 2;
            this.buttonRewrite.Text = "Перезаписать";
            this.buttonRewrite.UseVisualStyleBackColor = true;
            this.buttonRewrite.Click += new System.EventHandler(this.buttonRewrite_Click);
            // 
            // textBoxDirection
            // 
            this.textBoxDirection.Location = new System.Drawing.Point(348, 508);
            this.textBoxDirection.Name = "textBoxDirection";
            this.textBoxDirection.Size = new System.Drawing.Size(376, 22);
            this.textBoxDirection.TabIndex = 3;
            // 
            // labelReq1
            // 
            this.labelReq1.AutoSize = true;
            this.labelReq1.Location = new System.Drawing.Point(32, 35);
            this.labelReq1.Name = "labelReq1";
            this.labelReq1.Size = new System.Drawing.Size(313, 16);
            this.labelReq1.TabIndex = 0;
            this.labelReq1.Text = "Средний балл студентов по указанной группе";
            // 
            // comboBoxReq1
            // 
            this.comboBoxReq1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReq1.FormattingEnabled = true;
            this.comboBoxReq1.Location = new System.Drawing.Point(35, 54);
            this.comboBoxReq1.Name = "comboBoxReq1";
            this.comboBoxReq1.Size = new System.Drawing.Size(310, 24);
            this.comboBoxReq1.TabIndex = 1;
            this.comboBoxReq1.SelectedIndexChanged += new System.EventHandler(this.comboBoxReq1_SelectedIndexChanged);
            // 
            // comboBoxReq2
            // 
            this.comboBoxReq2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReq2.FormattingEnabled = true;
            this.comboBoxReq2.Location = new System.Drawing.Point(35, 119);
            this.comboBoxReq2.Name = "comboBoxReq2";
            this.comboBoxReq2.Size = new System.Drawing.Size(310, 24);
            this.comboBoxReq2.TabIndex = 3;
            this.comboBoxReq2.SelectedIndexChanged += new System.EventHandler(this.comboBoxReq2_SelectedIndexChanged);
            // 
            // labelReq2
            // 
            this.labelReq2.AutoSize = true;
            this.labelReq2.Location = new System.Drawing.Point(32, 100);
            this.labelReq2.Name = "labelReq2";
            this.labelReq2.Size = new System.Drawing.Size(268, 16);
            this.labelReq2.TabIndex = 2;
            this.labelReq2.Text = "Средний балл по указанному предмету";
            // 
            // dataGridViewReq
            // 
            this.dataGridViewReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReq.Location = new System.Drawing.Point(391, 6);
            this.dataGridViewReq.Name = "dataGridViewReq";
            this.dataGridViewReq.RowHeadersWidth = 51;
            this.dataGridViewReq.RowTemplate.Height = 24;
            this.dataGridViewReq.Size = new System.Drawing.Size(838, 438);
            this.dataGridViewReq.TabIndex = 4;
            // 
            // comboBoxReq3
            // 
            this.comboBoxReq3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReq3.FormattingEnabled = true;
            this.comboBoxReq3.Location = new System.Drawing.Point(35, 184);
            this.comboBoxReq3.Name = "comboBoxReq3";
            this.comboBoxReq3.Size = new System.Drawing.Size(310, 24);
            this.comboBoxReq3.TabIndex = 6;
            this.comboBoxReq3.SelectedIndexChanged += new System.EventHandler(this.comboBoxReq3_SelectedIndexChanged);
            // 
            // labelReq3
            // 
            this.labelReq3.AutoSize = true;
            this.labelReq3.Location = new System.Drawing.Point(32, 165);
            this.labelReq3.Name = "labelReq3";
            this.labelReq3.Size = new System.Drawing.Size(247, 16);
            this.labelReq3.TabIndex = 5;
            this.labelReq3.Text = "Успеваемость выбранного студента";
            // 
            // comboBoxReq4
            // 
            this.comboBoxReq4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReq4.FormattingEnabled = true;
            this.comboBoxReq4.Location = new System.Drawing.Point(35, 249);
            this.comboBoxReq4.Name = "comboBoxReq4";
            this.comboBoxReq4.Size = new System.Drawing.Size(310, 24);
            this.comboBoxReq4.TabIndex = 8;
            this.comboBoxReq4.SelectedIndexChanged += new System.EventHandler(this.comboBoxReq4_SelectedIndexChanged);
            // 
            // labelReq4
            // 
            this.labelReq4.AutoSize = true;
            this.labelReq4.Location = new System.Drawing.Point(32, 230);
            this.labelReq4.Name = "labelReq4";
            this.labelReq4.Size = new System.Drawing.Size(272, 16);
            this.labelReq4.TabIndex = 7;
            this.labelReq4.Text = "Успеваемость по выбранному предмету";
            // 
            // comboBoxReq5
            // 
            this.comboBoxReq5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReq5.FormattingEnabled = true;
            this.comboBoxReq5.Location = new System.Drawing.Point(35, 315);
            this.comboBoxReq5.Name = "comboBoxReq5";
            this.comboBoxReq5.Size = new System.Drawing.Size(310, 24);
            this.comboBoxReq5.TabIndex = 10;
            this.comboBoxReq5.SelectedIndexChanged += new System.EventHandler(this.comboBoxReq5_SelectedIndexChanged);
            // 
            // labelReq5
            // 
            this.labelReq5.AutoSize = true;
            this.labelReq5.Location = new System.Drawing.Point(32, 296);
            this.labelReq5.Name = "labelReq5";
            this.labelReq5.Size = new System.Drawing.Size(290, 16);
            this.labelReq5.TabIndex = 9;
            this.labelReq5.Text = "Успеваемость у заданного преподавателя";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 542);
            this.Controls.Add(this.textBoxDirection);
            this.Controls.Add(this.buttonRewrite);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1285, 589);
            this.MinimumSize = new System.Drawing.Size(1285, 589);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecordStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecturer)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheme)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatement)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonRewrite;
        private System.Windows.Forms.TextBox textBoxDirection;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCancelStudent;
        private System.Windows.Forms.Button buttonSaveStudent;
        private System.Windows.Forms.TextBox textBoxGroupStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRecordStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFullnameStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLecturer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewTheme;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewStatement;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBoxReq2;
        private System.Windows.Forms.Label labelReq2;
        private System.Windows.Forms.ComboBox comboBoxReq1;
        private System.Windows.Forms.Label labelReq1;
        private System.Windows.Forms.DataGridView dataGridViewReq;
        private System.Windows.Forms.ComboBox comboBoxReq5;
        private System.Windows.Forms.Label labelReq5;
        private System.Windows.Forms.ComboBox comboBoxReq4;
        private System.Windows.Forms.Label labelReq4;
        private System.Windows.Forms.ComboBox comboBoxReq3;
        private System.Windows.Forms.Label labelReq3;
    }
}

