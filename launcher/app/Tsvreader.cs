using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using static System.Configuration.ConfigurationManager;


namespace app
{
    public class Tsvreader
    {
        private string _extractInfoPath;
        private string _outputPath;

        public Tsvreader()
        {

            ExtractInfoPath = Properties.Settings.Default.ExtractInfoPath;
            OutputPath = Properties.Settings.Default.OutputPath;

        }

        public void Run(string registerDate, string inputFilePath)
        {
            if (!File.Exists(inputFilePath))
            {
                　Output = inputFilePath + "は存在しません";
                return;
            }
            RegisterDate = registerDate;
            InputFilePath = inputFilePath;

            const string command = "java";
            var psInfo = new ProcessStartInfo
            {
                FileName = command,
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

        public string OutputPath
        {
            get { return _outputPath; }
            set
            {
                _outputPath = value;
                Properties.Settings.Default.OutputPath = value;
                Properties.Settings.Default.Save();
            }
        }

        public string ExtractInfoPath
        {
            get { return _extractInfoPath; }
            set
            {
                _extractInfoPath = value;
                Properties.Settings.Default.ExtractInfoPath = value;
                Properties.Settings.Default.Save();
            }
        }

        public string Output { get; set; }
    }
}
