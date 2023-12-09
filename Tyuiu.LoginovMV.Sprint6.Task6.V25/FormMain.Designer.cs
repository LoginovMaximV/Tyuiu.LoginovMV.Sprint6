
namespace Tyuiu.LoginovMV.Sprint6.Task6.V25
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
            this.openFileDialog_LMV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_LMV = new System.Windows.Forms.ToolTip(this.components);
            this.buttonAbout_LMV = new System.Windows.Forms.Button();
            this.buttonDone_LMV = new System.Windows.Forms.Button();
            this.buttonOpenFile_LMV = new System.Windows.Forms.Button();
            this.panelTask_LMV = new System.Windows.Forms.Panel();
            this.groupBoxTask_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LMV = new System.Windows.Forms.TextBox();
            this.panelButtons_LMV = new System.Windows.Forms.Panel();
            this.panelInPut_LMV = new System.Windows.Forms.Panel();
            this.groupBoxInPut_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxInPut_LMV = new System.Windows.Forms.TextBox();
            this.panelRes_LMV = new System.Windows.Forms.Panel();
            this.groupBoxRes_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxRes_LMV = new System.Windows.Forms.TextBox();
            this.splitterSplinter_LMV = new System.Windows.Forms.Splitter();
            this.panelTask_LMV.SuspendLayout();
            this.groupBoxTask_LMV.SuspendLayout();
            this.panelButtons_LMV.SuspendLayout();
            this.panelInPut_LMV.SuspendLayout();
            this.groupBoxInPut_LMV.SuspendLayout();
            this.panelRes_LMV.SuspendLayout();
            this.groupBoxRes_LMV.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog_LMV
            // 
            this.openFileDialog_LMV.FileName = "openFileDialog1";
            // 
            // toolTip_LMV
            // 
            this.toolTip_LMV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_LMV.ToolTipTitle = "Подсказка";
            // 
            // buttonAbout_LMV
            // 
            this.buttonAbout_LMV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonAbout_LMV.Image")));
            this.buttonAbout_LMV.Location = new System.Drawing.Point(855, 3);
            this.buttonAbout_LMV.Name = "buttonAbout_LMV";
            this.buttonAbout_LMV.Size = new System.Drawing.Size(80, 80);
            this.buttonAbout_LMV.TabIndex = 2;
            this.toolTip_LMV.SetToolTip(this.buttonAbout_LMV, "Сведения о программе");
            this.buttonAbout_LMV.UseVisualStyleBackColor = true;
            this.buttonAbout_LMV.Click += new System.EventHandler(this.buttonAbout_LMV_Click);
            // 
            // buttonDone_LMV
            // 
            this.buttonDone_LMV.Enabled = false;
            this.buttonDone_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_LMV.Image")));
            this.buttonDone_LMV.Location = new System.Drawing.Point(89, 3);
            this.buttonDone_LMV.Name = "buttonDone_LMV";
            this.buttonDone_LMV.Size = new System.Drawing.Size(80, 80);
            this.buttonDone_LMV.TabIndex = 1;
            this.toolTip_LMV.SetToolTip(this.buttonDone_LMV, "Производит поиск слов \r\nв которых встречается Е\r\nи выводит в строчку");
            this.buttonDone_LMV.UseVisualStyleBackColor = true;
            this.buttonDone_LMV.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonOpenFile_LMV
            // 
            this.buttonOpenFile_LMV.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_LMV.Image")));
            this.buttonOpenFile_LMV.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile_LMV.Name = "buttonOpenFile_LMV";
            this.buttonOpenFile_LMV.Size = new System.Drawing.Size(80, 80);
            this.buttonOpenFile_LMV.TabIndex = 0;
            this.toolTip_LMV.SetToolTip(this.buttonOpenFile_LMV, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            this.buttonOpenFile_LMV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LMV.Click += new System.EventHandler(this.buttonOpenFile_LMV_Click);
            // 
            // panelTask_LMV
            // 
            this.panelTask_LMV.Controls.Add(this.groupBoxTask_LMV);
            this.panelTask_LMV.Controls.Add(this.panelButtons_LMV);
            this.panelTask_LMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_LMV.Location = new System.Drawing.Point(5, 5);
            this.panelTask_LMV.Name = "panelTask_LMV";
            this.panelTask_LMV.Size = new System.Drawing.Size(938, 186);
            this.panelTask_LMV.TabIndex = 0;
            // 
            // groupBoxTask_LMV
            // 
            this.groupBoxTask_LMV.Controls.Add(this.textBoxTask_LMV);
            this.groupBoxTask_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_LMV.Location = new System.Drawing.Point(0, 84);
            this.groupBoxTask_LMV.Name = "groupBoxTask_LMV";
            this.groupBoxTask_LMV.Size = new System.Drawing.Size(938, 102);
            this.groupBoxTask_LMV.TabIndex = 1;
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
            this.textBoxTask_LMV.Size = new System.Drawing.Size(932, 77);
            this.textBoxTask_LMV.TabIndex = 0;
            this.textBoxTask_LMV.Text = resources.GetString("textBoxTask_LMV.Text");
            // 
            // panelButtons_LMV
            // 
            this.panelButtons_LMV.Controls.Add(this.buttonAbout_LMV);
            this.panelButtons_LMV.Controls.Add(this.buttonDone_LMV);
            this.panelButtons_LMV.Controls.Add(this.buttonOpenFile_LMV);
            this.panelButtons_LMV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_LMV.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_LMV.Name = "panelButtons_LMV";
            this.panelButtons_LMV.Size = new System.Drawing.Size(938, 84);
            this.panelButtons_LMV.TabIndex = 0;
            // 
            // panelInPut_LMV
            // 
            this.panelInPut_LMV.Controls.Add(this.groupBoxInPut_LMV);
            this.panelInPut_LMV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_LMV.Location = new System.Drawing.Point(5, 191);
            this.panelInPut_LMV.Name = "panelInPut_LMV";
            this.panelInPut_LMV.Size = new System.Drawing.Size(476, 348);
            this.panelInPut_LMV.TabIndex = 1;
            // 
            // groupBoxInPut_LMV
            // 
            this.groupBoxInPut_LMV.Controls.Add(this.textBoxInPut_LMV);
            this.groupBoxInPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInPut_LMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPut_LMV.Name = "groupBoxInPut_LMV";
            this.groupBoxInPut_LMV.Size = new System.Drawing.Size(476, 348);
            this.groupBoxInPut_LMV.TabIndex = 0;
            this.groupBoxInPut_LMV.TabStop = false;
            this.groupBoxInPut_LMV.Text = "Ввод:";
            // 
            // textBoxInPut_LMV
            // 
            this.textBoxInPut_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInPut_LMV.Location = new System.Drawing.Point(3, 22);
            this.textBoxInPut_LMV.Multiline = true;
            this.textBoxInPut_LMV.Name = "textBoxInPut_LMV";
            this.textBoxInPut_LMV.ReadOnly = true;
            this.textBoxInPut_LMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPut_LMV.Size = new System.Drawing.Size(470, 323);
            this.textBoxInPut_LMV.TabIndex = 0;
            // 
            // panelRes_LMV
            // 
            this.panelRes_LMV.Controls.Add(this.groupBoxRes_LMV);
            this.panelRes_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRes_LMV.Location = new System.Drawing.Point(481, 191);
            this.panelRes_LMV.Name = "panelRes_LMV";
            this.panelRes_LMV.Size = new System.Drawing.Size(462, 348);
            this.panelRes_LMV.TabIndex = 2;
            // 
            // groupBoxRes_LMV
            // 
            this.groupBoxRes_LMV.Controls.Add(this.textBoxRes_LMV);
            this.groupBoxRes_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRes_LMV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRes_LMV.Name = "groupBoxRes_LMV";
            this.groupBoxRes_LMV.Size = new System.Drawing.Size(462, 348);
            this.groupBoxRes_LMV.TabIndex = 0;
            this.groupBoxRes_LMV.TabStop = false;
            this.groupBoxRes_LMV.Text = "Вывод:";
            // 
            // textBoxRes_LMV
            // 
            this.textBoxRes_LMV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxRes_LMV.Location = new System.Drawing.Point(3, 22);
            this.textBoxRes_LMV.Multiline = true;
            this.textBoxRes_LMV.Name = "textBoxRes_LMV";
            this.textBoxRes_LMV.ReadOnly = true;
            this.textBoxRes_LMV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxRes_LMV.Size = new System.Drawing.Size(456, 323);
            this.textBoxRes_LMV.TabIndex = 0;
            // 
            // splitterSplinter_LMV
            // 
            this.splitterSplinter_LMV.Location = new System.Drawing.Point(481, 191);
            this.splitterSplinter_LMV.Name = "splitterSplinter_LMV";
            this.splitterSplinter_LMV.Size = new System.Drawing.Size(3, 348);
            this.splitterSplinter_LMV.TabIndex = 3;
            this.splitterSplinter_LMV.TabStop = false;
            // 
            // FormMain_LMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 544);
            this.Controls.Add(this.splitterSplinter_LMV);
            this.Controls.Add(this.panelRes_LMV);
            this.Controls.Add(this.panelInPut_LMV);
            this.Controls.Add(this.panelTask_LMV);
            this.MinimumSize = new System.Drawing.Size(970, 600);
            this.Name = "FormMain_LMV";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 25 | Логинов М.В.";
            this.panelTask_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.PerformLayout();
            this.panelButtons_LMV.ResumeLayout(false);
            this.panelInPut_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.PerformLayout();
            this.panelRes_LMV.ResumeLayout(false);
            this.groupBoxRes_LMV.ResumeLayout(false);
            this.groupBoxRes_LMV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_LMV;
        private System.Windows.Forms.ToolTip toolTip_LMV;
        private System.Windows.Forms.Panel panelTask_LMV;
        private System.Windows.Forms.GroupBox groupBoxTask_LMV;
        private System.Windows.Forms.TextBox textBoxTask_LMV;
        private System.Windows.Forms.Panel panelButtons_LMV;
        private System.Windows.Forms.Button buttonAbout_LMV;
        private System.Windows.Forms.Button buttonDone_LMV;
        private System.Windows.Forms.Button buttonOpenFile_LMV;
        private System.Windows.Forms.Panel panelInPut_LMV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LMV;
        private System.Windows.Forms.TextBox textBoxInPut_LMV;
        private System.Windows.Forms.Panel panelRes_LMV;
        private System.Windows.Forms.GroupBox groupBoxRes_LMV;
        private System.Windows.Forms.TextBox textBoxRes_LMV;
        private System.Windows.Forms.Splitter splitterSplinter_LMV;
    }
}

