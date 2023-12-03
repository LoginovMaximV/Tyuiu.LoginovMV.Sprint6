
namespace Tyuiu.LoginovMV.Sprint6.Task2.V5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LMV = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_LMV = new System.Windows.Forms.GroupBox();
            this.textBoxStop_LMV = new System.Windows.Forms.TextBox();
            this.textBoxStart_LMV = new System.Windows.Forms.TextBox();
            this.labelStop_LMV = new System.Windows.Forms.Label();
            this.labelStart_LMV = new System.Windows.Forms.Label();
            this.buttonHelp_LMV = new System.Windows.Forms.Button();
            this.buttonDone_LMV = new System.Windows.Forms.Button();
            this.groupBoxResult_LMV = new System.Windows.Forms.GroupBox();
            this.labelResult_LMV = new System.Windows.Forms.Label();
            this.chartResult_LMV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewXY_LMV = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_LMV.SuspendLayout();
            this.groupBoxInPut_LMV.SuspendLayout();
            this.groupBoxResult_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LMV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_LMV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_LMV
            // 
            this.groupBoxTask_LMV.Controls.Add(this.textBoxTask_LMV);
            this.groupBoxTask_LMV.Location = new System.Drawing.Point(14, 12);
            this.groupBoxTask_LMV.Name = "groupBoxTask_LMV";
            this.groupBoxTask_LMV.Size = new System.Drawing.Size(636, 300);
            this.groupBoxTask_LMV.TabIndex = 0;
            this.groupBoxTask_LMV.TabStop = false;
            this.groupBoxTask_LMV.Text = "Условие";
            this.groupBoxTask_LMV.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_LMV
            // 
            this.textBoxTask_LMV.Location = new System.Drawing.Point(10, 27);
            this.textBoxTask_LMV.Multiline = true;
            this.textBoxTask_LMV.Name = "textBoxTask_LMV";
            this.textBoxTask_LMV.ReadOnly = true;
            this.textBoxTask_LMV.Size = new System.Drawing.Size(620, 258);
            this.textBoxTask_LMV.TabIndex = 0;
            this.textBoxTask_LMV.Text = "Протабулировать функцию ( (2х-3) / (cos(x)-2x) ) + 5x - 6 \r\nна заданном диапазоне" +
    " [-5;5].\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInPut_LMV
            // 
            this.groupBoxInPut_LMV.Controls.Add(this.textBoxStop_LMV);
            this.groupBoxInPut_LMV.Controls.Add(this.textBoxStart_LMV);
            this.groupBoxInPut_LMV.Controls.Add(this.labelStop_LMV);
            this.groupBoxInPut_LMV.Controls.Add(this.labelStart_LMV);
            this.groupBoxInPut_LMV.Location = new System.Drawing.Point(13, 320);
            this.groupBoxInPut_LMV.Name = "groupBoxInPut_LMV";
            this.groupBoxInPut_LMV.Size = new System.Drawing.Size(304, 100);
            this.groupBoxInPut_LMV.TabIndex = 1;
            this.groupBoxInPut_LMV.TabStop = false;
            this.groupBoxInPut_LMV.Text = "Ввод данных";
            // 
            // textBoxStop_LMV
            // 
            this.textBoxStop_LMV.Location = new System.Drawing.Point(162, 49);
            this.textBoxStop_LMV.Name = "textBoxStop_LMV";
            this.textBoxStop_LMV.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_LMV.TabIndex = 3;
            this.textBoxStop_LMV.Text = "5";
            this.textBoxStop_LMV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_LMV_KeyPress);
            // 
            // textBoxStart_LMV
            // 
            this.textBoxStart_LMV.Location = new System.Drawing.Point(9, 49);
            this.textBoxStart_LMV.Name = "textBoxStart_LMV";
            this.textBoxStart_LMV.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_LMV.TabIndex = 2;
            this.textBoxStart_LMV.Text = "-5";
            this.textBoxStart_LMV.TextChanged += new System.EventHandler(this.textBoxStart_LMV_TextChanged);
            this.textBoxStart_LMV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_LMV_KeyPress);
            // 
            // labelStop_LMV
            // 
            this.labelStop_LMV.AutoSize = true;
            this.labelStop_LMV.Location = new System.Drawing.Point(161, 26);
            this.labelStop_LMV.Name = "labelStop_LMV";
            this.labelStop_LMV.Size = new System.Drawing.Size(101, 20);
            this.labelStop_LMV.TabIndex = 1;
            this.labelStop_LMV.Text = "Конец шага:";
            // 
            // labelStart_LMV
            // 
            this.labelStart_LMV.AutoSize = true;
            this.labelStart_LMV.Location = new System.Drawing.Point(7, 26);
            this.labelStart_LMV.Name = "labelStart_LMV";
            this.labelStart_LMV.Size = new System.Drawing.Size(102, 20);
            this.labelStart_LMV.TabIndex = 0;
            this.labelStart_LMV.Text = "Старт шага:";
            // 
            // buttonHelp_LMV
            // 
            this.buttonHelp_LMV.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_LMV.Location = new System.Drawing.Point(324, 330);
            this.buttonHelp_LMV.Name = "buttonHelp_LMV";
            this.buttonHelp_LMV.Size = new System.Drawing.Size(125, 90);
            this.buttonHelp_LMV.TabIndex = 2;
            this.buttonHelp_LMV.Text = "Справка";
            this.buttonHelp_LMV.UseVisualStyleBackColor = false;
            this.buttonHelp_LMV.Click += new System.EventHandler(this.buttonHelp_LMV_Click);
            // 
            // buttonDone_LMV
            // 
            this.buttonDone_LMV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_LMV.Location = new System.Drawing.Point(456, 330);
            this.buttonDone_LMV.Name = "buttonDone_LMV";
            this.buttonDone_LMV.Size = new System.Drawing.Size(193, 90);
            this.buttonDone_LMV.TabIndex = 3;
            this.buttonDone_LMV.Text = "Выполнить";
            this.buttonDone_LMV.UseVisualStyleBackColor = false;
            this.buttonDone_LMV.Click += new System.EventHandler(this.buttonDone_LMV_Click);
            this.buttonDone_LMV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_LMV_MouseDown);
            this.buttonDone_LMV.MouseEnter += new System.EventHandler(this.buttonDone_LMV_MouseEnter);
            this.buttonDone_LMV.MouseLeave += new System.EventHandler(this.buttonDone_LMV_MouseLeave);
            // 
            // groupBoxResult_LMV
            // 
            this.groupBoxResult_LMV.Controls.Add(this.labelResult_LMV);
            this.groupBoxResult_LMV.Controls.Add(this.chartResult_LMV);
            this.groupBoxResult_LMV.Controls.Add(this.dataGridViewXY_LMV);
            this.groupBoxResult_LMV.Location = new System.Drawing.Point(656, 13);
            this.groupBoxResult_LMV.Name = "groupBoxResult_LMV";
            this.groupBoxResult_LMV.Size = new System.Drawing.Size(968, 407);
            this.groupBoxResult_LMV.TabIndex = 4;
            this.groupBoxResult_LMV.TabStop = false;
            this.groupBoxResult_LMV.Text = "Вывод данных";
            // 
            // labelResult_LMV
            // 
            this.labelResult_LMV.AutoSize = true;
            this.labelResult_LMV.Location = new System.Drawing.Point(7, 26);
            this.labelResult_LMV.Name = "labelResult_LMV";
            this.labelResult_LMV.Size = new System.Drawing.Size(93, 20);
            this.labelResult_LMV.TabIndex = 2;
            this.labelResult_LMV.Text = "Результат:";
            // 
            // chartResult_LMV
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_LMV.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_LMV.Legends.Add(legend5);
            this.chartResult_LMV.Location = new System.Drawing.Point(191, 50);
            this.chartResult_LMV.Name = "chartResult_LMV";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_LMV.Series.Add(series5);
            this.chartResult_LMV.Size = new System.Drawing.Size(609, 351);
            this.chartResult_LMV.TabIndex = 1;
            this.chartResult_LMV.Text = "chart1";
            // 
            // dataGridViewXY_LMV
            // 
            this.dataGridViewXY_LMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXY_LMV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridViewXY_LMV.Location = new System.Drawing.Point(7, 50);
            this.dataGridViewXY_LMV.Name = "dataGridViewXY_LMV";
            this.dataGridViewXY_LMV.RowHeadersVisible = false;
            this.dataGridViewXY_LMV.RowHeadersWidth = 62;
            this.dataGridViewXY_LMV.RowTemplate.Height = 28;
            this.dataGridViewXY_LMV.Size = new System.Drawing.Size(178, 351);
            this.dataGridViewXY_LMV.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 8;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 50;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "F(X)";
            this.ColumnY.MinimumWidth = 8;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Width = 50;
            // 
            // FormMain_LMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 450);
            this.Controls.Add(this.groupBoxResult_LMV);
            this.Controls.Add(this.buttonDone_LMV);
            this.Controls.Add(this.buttonHelp_LMV);
            this.Controls.Add(this.groupBoxInPut_LMV);
            this.Controls.Add(this.groupBoxTask_LMV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_LMV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант  5 | Логинов М.В.";
            this.groupBoxTask_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.PerformLayout();
            this.groupBoxInPut_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.PerformLayout();
            this.groupBoxResult_LMV.ResumeLayout(false);
            this.groupBoxResult_LMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LMV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_LMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LMV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LMV;
        private System.Windows.Forms.Button buttonHelp_LMV;
        private System.Windows.Forms.Button buttonDone_LMV;
        private System.Windows.Forms.GroupBox groupBoxResult_LMV;
        private System.Windows.Forms.TextBox textBoxTask_LMV;
        private System.Windows.Forms.TextBox textBoxStop_LMV;
        private System.Windows.Forms.TextBox textBoxStart_LMV;
        private System.Windows.Forms.Label labelStop_LMV;
        private System.Windows.Forms.Label labelStart_LMV;
        private System.Windows.Forms.Label labelResult_LMV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LMV;
        private System.Windows.Forms.DataGridView dataGridViewXY_LMV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
    }
}

