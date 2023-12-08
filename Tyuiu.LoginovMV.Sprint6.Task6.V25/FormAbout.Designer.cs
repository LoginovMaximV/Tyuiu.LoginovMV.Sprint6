
namespace Tyuiu.LoginovMV.Sprint6.Task6.V25
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar_LMV = new System.Windows.Forms.PictureBox();
            this.labelAbout_LMV = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LMV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.labelAbout_LMV);
            this.panel1.Controls.Add(this.pictureBoxAvatar_LMV);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 260);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxAvatar_LMV
            // 
            this.pictureBoxAvatar_LMV.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_LMV.Image")));
            this.pictureBoxAvatar_LMV.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxAvatar_LMV.Name = "pictureBoxAvatar_LMV";
            this.pictureBoxAvatar_LMV.Size = new System.Drawing.Size(209, 208);
            this.pictureBoxAvatar_LMV.TabIndex = 0;
            this.pictureBoxAvatar_LMV.TabStop = false;
            // 
            // labelAbout_LMV
            // 
            this.labelAbout_LMV.AutoSize = true;
            this.labelAbout_LMV.Location = new System.Drawing.Point(219, 4);
            this.labelAbout_LMV.Name = "labelAbout_LMV";
            this.labelAbout_LMV.Size = new System.Drawing.Size(413, 180);
            this.labelAbout_LMV.TabIndex = 1;
            this.labelAbout_LMV.Text = resources.GetString("labelAbout_LMV.Text");
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(506, 213);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(97, 30);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 284);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LMV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelAbout_LMV;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_LMV;
    }
}