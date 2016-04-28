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
            //TODO:javaの実行パスの指定方法検討
            const string command = @"""C:\Program Files (x86)\Java\jre1.8.0_91\bin\java.exe""";
            var psInfo = new ProcessStartInfo
            {
                FileName = command,
                //TODO:出力先のパス設定は外部に持たせる
                //TODO:ファイルの存在チェック、ファイルパスを"で囲む
                Arguments = @"-jar E:\ITDART\tsvreader\bin\ExtractInfo.jar "  +fstextBox.Text + " " + selectDate.Value.ToShortDateString() + @" E:\ITDART\workspace\test.csv",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true
            };

            var p = Process.Start(psInfo);
            if (p == null) return;
            var output = p.StandardOutput.ReadToEnd();
            //TODO: 標準出力が取れていないので取る方法調査（cmdファイルはさむしかない？）
            p.WaitForExit();
            output = output.Replace("\r\r\n", "\n");
            Debug.Write(output);
            Debug.Write(p.ExitCode);
            //TODO:実行結果を画面に表示する処理
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
