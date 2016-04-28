using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Configuration.ConfigurationManager;


namespace app
{
    public class Tsvreader
    {
        public Tsvreader(string registerDate,string inputFilePath)
        {
            if (!File.Exists(inputFilePath))
            {
                throw new FileNotFoundException(inputFilePath + "は存在しません");
            }
            RegisterDate = registerDate;
            InputFilePath = inputFilePath;
            ExtractInfoPath = AppSettings.Get("ExtractInfoPath");
            OutputPath = AppSettings.Get("OutputPath");

        }

        public void Run()
        {
            //TODO:JARファイルの指定方法、出力ファイルの指定方法
            const string command = "java";
            var psInfo = new ProcessStartInfo
            {
                FileName = command,
                //TODO:出力先のパス設定は外部に持たせる
                Arguments =
                    $@"-jar {ExtractInfoPath} {RegisterDate} ""{InputFilePath}"" ""{OutputPath}""",
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true
            };

            var p = Process.Start(psInfo);
            if (p == null) return;
            var output = p.StandardError.ReadToEnd();
            p.WaitForExit();
            Output = output.Replace("\r\r\n", "\n");
        }

        public string InputFilePath { get; set; }

        public string RegisterDate { get; set; }

        public string OutputPath { get; set; }
        public string ExtractInfoPath { get; set; }
        public string Output { get; set; }
    }
}
