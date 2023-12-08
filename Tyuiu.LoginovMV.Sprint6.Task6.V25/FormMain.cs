using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LoginovMV.Sprint6.Task6.V25.Lib;
using System.IO;

namespace Tyuiu.LoginovMV.Sprint6.Task6.V25
{
    public partial class FormMain_LMV : Form
    {
        public FormMain_LMV()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_LMV_Click(object sender, EventArgs e)
        {
            openFileDialog_LMV.ShowDialog();
            openFilePath = openFileDialog_LMV.FileName;
            textBoxInPut_LMV.Text = File.ReadAllText(openFilePath);
            groupBoxInPut_LMV.Text = groupBoxInPut_LMV.Text + " " + openFileDialog_LMV.FileName;
            buttonOpenFile_LMV.Enabled = false;
            buttonDone_LMV.Enabled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            buttonOpenFile_LMV.Enabled = true;
            buttonDone_LMV.Enabled = false;
            textBoxRes_LMV.Text = ds.CollectTextFromFile(openFilePath);

        }

        private void buttonAbout_LMV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
