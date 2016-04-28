using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace app
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            selectDate.Value = DateTime.Now;
            selectFile.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = new Tsvreader(selectDate.Value.ToShortDateString(),fstextBox.Text);
            p.Run(); 
            result.Text = p.Output;
        }

        private void selectFile_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fstextBox.Text = dialog.FileName;
                }
            }
        }

        private void MainWindow_DragDrop(object sender, DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Length >= 1)
                fstextBox.Text = files[0]; //select the first one  
        }

        private void MainWindow_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Link : DragDropEffects.None;
        }
    }
}
