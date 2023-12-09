
namespace Tyuiu.LoginovMV.Sprint6.Task7.V17
{
    partial class FormMain_LMV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_LMV));
            this.panelTop_LMV = new System.Windows.Forms.Panel();
            this.buttonAbout_LMV = new System.Windows.Forms.Button();
            this.buttonSaveFile_LMV = new System.Windows.Forms.Button();
            this.buttonOpenFile_LMV = new System.Windows.Forms.Button();
            this.buttonDone_LMV = new System.Windows.Forms.Button();
            this.groupBoxTask_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LMV = new System.Windows.Forms.TextBox();
            this.panelLeft_LMV = new System.Windows.Forms.Panel();
            this.groupBoxInPut_LMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_LMV = new System.Windows.Forms.DataGridView();
            this.panelRight_LMV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_LMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPut_LMV = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_LMV = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton_LMV = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix_LMV = new System.Windows.Forms.SaveFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTop_LMV.SuspendLayout();
            this.groupBoxTask_LMV.SuspendLayout();
            this.panelLeft_LMV.SuspendLayout();
            this.groupBoxInPut_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LMV)).BeginInit();
            this.panelRight_LMV.SuspendLayout();
            this.groupBoxOutPut_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_LMV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_LMV
            // 
            this.panelTop_LMV.Controls.Add(this.buttonAbout_LMV);
            this.panelTop_LMV.Controls.Add(this.buttonSaveFile_LMV);
            this.panelTop_LMV.Controls.Add(this.buttonOpenFile_LMV);
            this.panelTop_LMV.Controls.Add(this.buttonDone_LMV);
            this.panelTop_LMV.Controls.Add(this.groupBoxTask_LMV);
            this.panelTop_LMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_LMV.Location = new System.Drawing.Point(5, 5);
            this.panelTop_LMV.Name = "panelTop_LMV";
            this.panelTop_LMV.Size = new System.Drawing.Size(1068, 187);
            this.panelTop_LMV.TabIndex = 0;
            // 
            // buttonAbout_LMV
            // 
            this.buttonAbout_LMV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_LMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_LMV.Image")));
            this.buttonAbout_LMV.Location = new System.Drawing.Point(973, 3);
            this.buttonAbout_LMV.Name = "buttonAbout_LMV";
            this.buttonAbout_LMV.Size = new System.Drawing.Size(92, 83);
            this.buttonAbout_LMV.TabIndex = 4;
            this.toolTipButton_LMV.SetToolTip(this.buttonAbout_LMV, "Информация о программе");
            this.buttonAbout_LMV.UseVisualStyleBackColor = true;
            this.buttonAbout_LMV.Click += new System.EventHandler(this.buttonAbout_LMV_Click);
            // 
            // buttonSaveFile_LMV
            // 
            this.buttonSaveFile_LMV.Enabled = false;
            this.buttonSaveFile_LMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_LMV.Image")));
            this.buttonSaveFile_LMV.Location = new System.Drawing.Point(199, 3);
            this.buttonSaveFile_LMV.Name = "buttonSaveFile_LMV";
            this.buttonSaveFile_LMV.Size = new System.Drawing.Size(92, 83);
            this.buttonSaveFile_LMV.TabIndex = 3;
            this.toolTipButton_LMV.SetToolTip(this.buttonSaveFile_LMV, "Сохраняет файл в \r\nуказанное место ");
            this.buttonSaveFile_LMV.UseVisualStyleBackColor = true;
            this.buttonSaveFile_LMV.Click += new System.EventHandler(this.buttonSaveFile_LMV_Click);
            // 
            // buttonOpenFile_LMV
            // 
            this.buttonOpenFile_LMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenFile_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_LMV.Image")));
            this.buttonOpenFile_LMV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_LMV.Name = "buttonOpenFile_LMV";
            this.buttonOpenFile_LMV.Size = new System.Drawing.Size(92, 83);
            this.buttonOpenFile_LMV.TabIndex = 1;
            this.toolTipButton_LMV.SetToolTip(this.buttonOpenFile_LMV, "Открывает файл и \r\nзагружает матрицу");
            this.buttonOpenFile_LMV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LMV.Click += new System.EventHandler(this.buttonOpenFile_LMV_Click);
            // 
            // buttonDone_LMV
            // 
            this.buttonDone_LMV.Enabled = false;
            this.buttonDone_LMV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_LMV.Image")));
            this.buttonDone_LMV.Location = new System.Drawing.Point(101, 3);
            this.buttonDone_LMV.Name = "buttonDone_LMV";
            this.buttonDone_LMV.Size = new System.Drawing.Size(92, 83);
            this.buttonDone_LMV.TabIndex = 2;
            this.toolTipButton_LMV.SetToolTip(this.buttonDone_LMV, "Преобразовывает матрицу по \r\nусловию задачи");
            this.buttonDone_LMV.UseVisualStyleBackColor = true;
            this.buttonDone_LMV.Click += new System.EventHandler(this.buttonDone_LMV_Click);
            // 
            // groupBoxTask_LMV
            // 
            this.groupBoxTask_LMV.Controls.Add(this.textBoxTask_LMV);
            this.groupBoxTask_LMV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxTask_LMV.Location = new System.Drawing.Point(0, 92);
            this.groupBoxTask_LMV.Name = "groupBoxTask_LMV";
            this.groupBoxTask_LMV.Size = new System.Drawing.Size(1068, 95);
            this.groupBoxTask_LMV.TabIndex = 0;
            this.groupBoxTask_LMV.TabStop = false;
            this.groupBoxTask_LMV.Text = "Условие:";
            // 
            // textBoxTask_LMV
            // 
            this.textBoxTask_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTask_LMV.Location = new System.Drawing.Point(3, 22);
            this.textBoxTask_LMV.Multiline = true;
            this.textBoxTask_LMV.Name = "textBoxTask_LMV";
            this.textBoxTask_LMV.ReadOnly = true;
            this.textBoxTask_LMV.Size = new System.Drawing.Size(1062, 70);
            this.textBoxTask_LMV.TabIndex = 0;
            this.textBoxTask_LMV.Text = resources.GetString("textBoxTask_LMV.Text");
            // 
            // panelLeft_LMV
            // 
            this.panelLeft_LMV.Controls.Add(this.groupBoxInPut_LMV);
            this.panelLeft_LMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_LMV.Location = new System.Drawing.Point(5, 192);
            this.panelLeft_LMV.Name = "panelLeft_LMV";
            this.panelLeft_LMV.Size = new System.Drawing.Size(533, 347);
            this.panelLeft_LMV.TabIndex = 1;
            // 
            // groupBoxInPut_LMV
            // 
            this.groupBoxInPut_LMV.Controls.Add(this.dataGridViewInPut_LMV);
            this.groupBoxInPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_LMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_LMV.Name = "groupBoxInPut_LMV";
            this.groupBoxInPut_LMV.Size = new System.Drawing.Size(533, 347);
            this.groupBoxInPut_LMV.TabIndex = 0;
            this.groupBoxInPut_LMV.TabStop = false;
            this.groupBoxInPut_LMV.Text = "Ввод:";
            // 
            // dataGridViewInPut_LMV
            // 
            this.dataGridViewInPut_LMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_LMV.ColumnHeadersVisible = false;
            this.dataGridViewInPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInPut_LMV.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewInPut_LMV.Name = "dataGridViewInPut_LMV";
            this.dataGridViewInPut_LMV.ReadOnly = true;
            this.dataGridViewInPut_LMV.RowHeadersVisible = false;
            this.dataGridViewInPut_LMV.RowHeadersWidth = 62;
            this.dataGridViewInPut_LMV.RowTemplate.Height = 28;
            this.dataGridViewInPut_LMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewInPut_LMV.Size = new System.Drawing.Size(527, 322);
            this.dataGridViewInPut_LMV.TabIndex = 0;
            // 
            // panelRight_LMV
            // 
            this.panelRight_LMV.Controls.Add(this.groupBoxOutPut_LMV);
            this.panelRight_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight_LMV.Location = new System.Drawing.Point(538, 192);
            this.panelRight_LMV.Name = "panelRight_LMV";
            this.panelRight_LMV.Size = new System.Drawing.Size(535, 347);
            this.panelRight_LMV.TabIndex = 2;
            // 
            // groupBoxOutPut_LMV
            // 
            this.groupBoxOutPut_LMV.Controls.Add(this.dataGridViewOutPut_LMV);
            this.groupBoxOutPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_LMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_LMV.Name = "groupBoxOutPut_LMV";
            this.groupBoxOutPut_LMV.Size = new System.Drawing.Size(535, 347);
            this.groupBoxOutPut_LMV.TabIndex = 0;
            this.groupBoxOutPut_LMV.TabStop = false;
            this.groupBoxOutPut_LMV.Text = "Вывод:";
            // 
            // dataGridViewOutPut_LMV
            // 
            this.dataGridViewOutPut_LMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPut_LMV.ColumnHeadersVisible = false;
            this.dataGridViewOutPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutPut_LMV.Location = new System.Drawing.Point(3, 22);
            this.dataGridViewOutPut_LMV.Name = "dataGridViewOutPut_LMV";
            this.dataGridViewOutPut_LMV.ReadOnly = true;
            this.dataGridViewOutPut_LMV.RowHeadersVisible = false;
            this.dataGridViewOutPut_LMV.RowHeadersWidth = 62;
            this.dataGridViewOutPut_LMV.RowTemplate.Height = 28;
            this.dataGridViewOutPut_LMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewOutPut_LMV.Size = new System.Drawing.Size(529, 322);
            this.dataGridViewOutPut_LMV.TabIndex = 0;
            // 
            // openFileDialogTask_LMV
            // 
            this.openFileDialogTask_LMV.FileName = "openFileDialog1";
            // 
            // toolTipButton_LMV
            // 
            this.toolTipButton_LMV.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolTipButton_LMV.IsBalloon = true;
            this.toolTipButton_LMV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton_LMV.ToolTipTitle = "Подсказка";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(538, 192);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 347);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // FormMain_LMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 544);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelRight_LMV);
            this.Controls.Add(this.panelLeft_LMV);
            this.Controls.Add(this.panelTop_LMV);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FormMain_LMV";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 17 | Логинов М.В.";
            this.Load += new System.EventHandler(this.FormMain_LMV_Load);
            this.panelTop_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.PerformLayout();
            this.panelLeft_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LMV)).EndInit();
            this.panelRight_LMV.ResumeLayout(false);
            this.groupBoxOutPut_LMV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPut_LMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_LMV;
        private System.Windows.Forms.Button buttonAbout_LMV;
        private System.Windows.Forms.Button buttonSaveFile_LMV;
        private System.Windows.Forms.Button buttonDone_LMV;
        private System.Windows.Forms.Button buttonOpenFile_LMV;
        private System.Windows.Forms.GroupBox groupBoxTask_LMV;
        private System.Windows.Forms.TextBox textBoxTask_LMV;
        private System.Windows.Forms.Panel panelLeft_LMV;
        private System.Windows.Forms.Panel panelRight_LMV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LMV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_LMV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LMV;
        private System.Windows.Forms.DataGridView dataGridViewOutPut_LMV;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_LMV;
        private System.Windows.Forms.ToolTip toolTipButton_LMV;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_LMV;
        private System.Windows.Forms.Splitter splitter1;
    }
}

