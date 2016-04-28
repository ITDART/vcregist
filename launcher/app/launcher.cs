using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace app
{
    public partial class MainWindow : Form
    {
        public Tsvreader TsvReader { set; get; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TsvReader = new Tsvreader();
            this.MaximizeBox = false;
            selectDate.Value = DateTime.Now;
            txtOutputPath.Text = TsvReader.OutputPath;
            txtTSVReader.Text = TsvReader.ExtractInfoPath;
            selectFile.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fstextBox.Text))
            {
                result.Text = "入力ファイルを選択するか、ドラッグ＆ドロップしてください。";
                return;
            }

            TsvReader.Run(selectDate.Value.ToShortDateString(), fstextBox.Text); 
            result.Text = TsvReader.Output;
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

        private void selectOutputPath_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                if (!string.IsNullOrEmpty(txtOutputPath.Text))
                {
                    dialog.InitialDirectory = Path.GetDirectoryName(txtOutputPath.Text);
                    dialog.FileName = Path.GetFileName(txtOutputPath.Text);
                }
                dialog.Filter = "CSVファイル(*.csv)|";
                dialog.Title = "結果の出力先";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtOutputPath.Text = dialog.FileName;
                    TsvReader.OutputPath = dialog.FileName;
                }
            }
        }

        private void selectJar_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                if (!string.IsNullOrEmpty(txtTSVReader.Text))
                {
                    dialog.InitialDirectory = Path.GetDirectoryName(txtTSVReader.Text);
                    dialog.FileName = Path.GetFileName(txtTSVReader.Text);
                }
                dialog.Filter = "JARファイル(*.jar)|";
                dialog.Title = "TSV Reader 読み取りJARの選択";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtTSVReader.Text = dialog.FileName;
                    TsvReader.ExtractInfoPath = dialog.FileName;
                }
            }
        }
    }
}
