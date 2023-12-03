
namespace Tyuiu.LoginovMV.Sprint6.Task3.V29
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_LMV = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxResult_LMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewRes_LMV = new System.Windows.Forms.DataGridView();
            this.labelResult_LMV = new System.Windows.Forms.Label();
            this.buttonHelp_LMV = new System.Windows.Forms.Button();
            this.buttonDone_LMV = new System.Windows.Forms.Button();
            this.groupBoxInPut_LMV = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_LMV = new System.Windows.Forms.DataGridView();
            this.labelInPut_LMV = new System.Windows.Forms.Label();
            this.groupBoxTask_LMV.SuspendLayout();
            this.groupBoxResult_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_LMV)).BeginInit();
            this.groupBoxInPut_LMV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LMV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_LMV
            // 
            this.groupBoxTask_LMV.Controls.Add(this.textBox1);
            this.groupBoxTask_LMV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_LMV.Name = "groupBoxTask_LMV";
            this.groupBoxTask_LMV.Size = new System.Drawing.Size(277, 425);
            this.groupBoxTask_LMV.TabIndex = 0;
            this.groupBoxTask_LMV.TabStop = false;
            this.groupBoxTask_LMV.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 393);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxResult_LMV
            // 
            this.groupBoxResult_LMV.Controls.Add(this.labelResult_LMV);
            this.groupBoxResult_LMV.Controls.Add(this.dataGridViewRes_LMV);
            this.groupBoxResult_LMV.Location = new System.Drawing.Point(553, 12);
            this.groupBoxResult_LMV.Name = "groupBoxResult_LMV";
            this.groupBoxResult_LMV.Size = new System.Drawing.Size(235, 381);
            this.groupBoxResult_LMV.TabIndex = 1;
            this.groupBoxResult_LMV.TabStop = false;
            this.groupBoxResult_LMV.Text = "Вывод данных";
            // 
            // dataGridViewRes_LMV
            // 
            this.dataGridViewRes_LMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRes_LMV.ColumnHeadersVisible = false;
            this.dataGridViewRes_LMV.Location = new System.Drawing.Point(22, 76);
            this.dataGridViewRes_LMV.Name = "dataGridViewRes_LMV";
            this.dataGridViewRes_LMV.RowHeadersVisible = false;
            this.dataGridViewRes_LMV.RowHeadersWidth = 62;
            this.dataGridViewRes_LMV.RowTemplate.Height = 28;
            this.dataGridViewRes_LMV.Size = new System.Drawing.Size(194, 225);
            this.dataGridViewRes_LMV.TabIndex = 0;
            // 
            // labelResult_LMV
            // 
            this.labelResult_LMV.AutoSize = true;
            this.labelResult_LMV.Location = new System.Drawing.Point(65, 39);
            this.labelResult_LMV.Name = "labelResult_LMV";
            this.labelResult_LMV.Size = new System.Drawing.Size(93, 20);
            this.labelResult_LMV.TabIndex = 1;
            this.labelResult_LMV.Text = "Результат:";
            // 
            // buttonHelp_LMV
            // 
            this.buttonHelp_LMV.Location = new System.Drawing.Point(606, 399);
            this.buttonHelp_LMV.Name = "buttonHelp_LMV";
            this.buttonHelp_LMV.Size = new System.Drawing.Size(37, 39);
            this.buttonHelp_LMV.TabIndex = 2;
            this.buttonHelp_LMV.Text = " ? ";
            this.buttonHelp_LMV.UseVisualStyleBackColor = true;
            this.buttonHelp_LMV.Click += new System.EventHandler(this.buttonHelp_LMV_Click);
            // 
            // buttonDone_LMV
            // 
            this.buttonDone_LMV.Location = new System.Drawing.Point(649, 399);
            this.buttonDone_LMV.Name = "buttonDone_LMV";
            this.buttonDone_LMV.Size = new System.Drawing.Size(139, 39);
            this.buttonDone_LMV.TabIndex = 3;
            this.buttonDone_LMV.Text = "Выполнить";
            this.buttonDone_LMV.UseVisualStyleBackColor = true;
            this.buttonDone_LMV.Click += new System.EventHandler(this.buttonDone_LMV_Click);
            // 
            // groupBoxInPut_LMV
            // 
            this.groupBoxInPut_LMV.Controls.Add(this.labelInPut_LMV);
            this.groupBoxInPut_LMV.Controls.Add(this.dataGridViewInPut_LMV);
            this.groupBoxInPut_LMV.Location = new System.Drawing.Point(297, 13);
            this.groupBoxInPut_LMV.Name = "groupBoxInPut_LMV";
            this.groupBoxInPut_LMV.Size = new System.Drawing.Size(250, 380);
            this.groupBoxInPut_LMV.TabIndex = 4;
            this.groupBoxInPut_LMV.TabStop = false;
            this.groupBoxInPut_LMV.Text = "Исходные данные";
            // 
            // dataGridViewInPut_LMV
            // 
            this.dataGridViewInPut_LMV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_LMV.ColumnHeadersVisible = false;
            this.dataGridViewInPut_LMV.Location = new System.Drawing.Point(23, 75);
            this.dataGridViewInPut_LMV.Name = "dataGridViewInPut_LMV";
            this.dataGridViewInPut_LMV.RowHeadersVisible = false;
            this.dataGridViewInPut_LMV.RowHeadersWidth = 62;
            this.dataGridViewInPut_LMV.RowTemplate.Height = 28;
            this.dataGridViewInPut_LMV.Size = new System.Drawing.Size(194, 225);
            this.dataGridViewInPut_LMV.TabIndex = 0;
            // 
            // labelInPut_LMV
            // 
            this.labelInPut_LMV.AutoSize = true;
            this.labelInPut_LMV.Location = new System.Drawing.Point(77, 38);
            this.labelInPut_LMV.Name = "labelInPut_LMV";
            this.labelInPut_LMV.Size = new System.Drawing.Size(80, 20);
            this.labelInPut_LMV.TabIndex = 1;
            this.labelInPut_LMV.Text = "Матрица:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxInPut_LMV);
            this.Controls.Add(this.buttonDone_LMV);
            this.Controls.Add(this.buttonHelp_LMV);
            this.Controls.Add(this.groupBoxResult_LMV);
            this.Controls.Add(this.groupBoxTask_LMV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 0 | Логинов М.В. ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_LMV.ResumeLayout(false);
            this.groupBoxTask_LMV.PerformLayout();
            this.groupBoxResult_LMV.ResumeLayout(false);
            this.groupBoxResult_LMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRes_LMV)).EndInit();
            this.groupBoxInPut_LMV.ResumeLayout(false);
            this.groupBoxInPut_LMV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_LMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LMV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxResult_LMV;
        private System.Windows.Forms.Label labelResult_LMV;
        private System.Windows.Forms.DataGridView dataGridViewRes_LMV;
        private System.Windows.Forms.Button buttonHelp_LMV;
        private System.Windows.Forms.Button buttonDone_LMV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LMV;
        private System.Windows.Forms.Label labelInPut_LMV;
        private System.Windows.Forms.DataGridView dataGridViewInPut_LMV;
    }
}

