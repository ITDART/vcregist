namespace app
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.fstextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFile = new System.Windows.Forms.PictureBox();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.txtTSVReader = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectJar = new System.Windows.Forms.PictureBox();
            this.selectOutputPath = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.selectFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectJar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOutputPath)).BeginInit();
            this.SuspendLayout();
            // 
            // selectDate
            // 
            this.selectDate.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.selectDate.Location = new System.Drawing.Point(139, 7);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(216, 39);
            this.selectDate.TabIndex = 0;
            this.selectDate.Value = new System.DateTime(2016, 4, 27, 10, 6, 41, 0);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(396, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "登録";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fstextBox
            // 
            this.fstextBox.Font = new System.Drawing.Font("メイリオ", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.fstextBox.Location = new System.Drawing.Point(139, 55);
            this.fstextBox.Name = "fstextBox";
            this.fstextBox.Size = new System.Drawing.Size(353, 39);
            this.fstextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(60, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "受付日";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(0, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "入力ファイル";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(46, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "出力ファイル";
            // 
            // selectFile
            // 
            this.selectFile.Image = ((System.Drawing.Image)(resources.GetObject("selectFile.Image")));
            this.selectFile.Location = new System.Drawing.Point(498, 59);
            this.selectFile.Name = "selectFile";
            this.selectFile.Size = new System.Drawing.Size(27, 30);
            this.selectFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectFile.TabIndex = 7;
            this.selectFile.TabStop = false;
            this.selectFile.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtOutputPath.Location = new System.Drawing.Point(139, 116);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(353, 27);
            this.txtOutputPath.TabIndex = 8;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(5, 196);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.result.Size = new System.Drawing.Size(385, 36);
            this.result.TabIndex = 9;
            // 
            // txtTSVReader
            // 
            this.txtTSVReader.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtTSVReader.Location = new System.Drawing.Point(139, 148);
            this.txtTSVReader.Name = "txtTSVReader";
            this.txtTSVReader.Size = new System.Drawing.Size(353, 27);
            this.txtTSVReader.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(46, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "TSV Reader";
            // 
            // selectJar
            // 
            this.selectJar.Image = ((System.Drawing.Image)(resources.GetObject("selectJar.Image")));
            this.selectJar.Location = new System.Drawing.Point(498, 148);
            this.selectJar.Name = "selectJar";
            this.selectJar.Size = new System.Drawing.Size(22, 22);
            this.selectJar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectJar.TabIndex = 12;
            this.selectJar.TabStop = false;
            this.selectJar.Click += new System.EventHandler(this.selectJar_Click);
            // 
            // selectOutputPath
            // 
            this.selectOutputPath.Image = ((System.Drawing.Image)(resources.GetObject("selectOutputPath.Image")));
            this.selectOutputPath.Location = new System.Drawing.Point(498, 119);
            this.selectOutputPath.Name = "selectOutputPath";
            this.selectOutputPath.Size = new System.Drawing.Size(22, 22);
            this.selectOutputPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.selectOutputPath.TabIndex = 13;
            this.selectOutputPath.TabStop = false;
            this.selectOutputPath.Click += new System.EventHandler(this.selectOutputPath_Click);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(542, 235);
            this.Controls.Add(this.selectOutputPath);
            this.Controls.Add(this.selectJar);
            this.Controls.Add(this.txtTSVReader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.result);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.selectFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fstextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selectDate);
            this.Name = "MainWindow";
            this.Text = "災害ボランティア受付";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.MainWindow_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.selectFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectJar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectOutputPath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fstextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox selectFile;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox txtTSVReader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox selectJar;
        private System.Windows.Forms.PictureBox selectOutputPath;
    }
}

