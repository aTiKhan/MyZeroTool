﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyZeroTool
{
    public partial class Form1 : Form
    {
        private BackgroundWorker _bw;

        private void Start()
        {
            if (Settings.RenameDirectories)
            {
                _bw.ReportProgress(0, "###### RENAMING DIRECTORIES ######");
                RenameDirectories(new DirectoryInfo(Settings.RootPath));
            }

            if (Settings.RenameFiles)
            {
                _bw.ReportProgress(0, "######### RENAMING FILES #########");
                RenameFiles();
            }

            if (Settings.UpdateFileContents)
            {
                _bw.ReportProgress(0, "#### PROCESSING FILE CONTENTS ####");
                UpdateFileContents();
            }

            if (Settings.RemoveBoms)
            {
                _bw.ReportProgress(0, "###### REMOVING BOMs ######");
                RemoveBoms();
            }

            _bw.ReportProgress(0, "############# DONE! ##############");
        }

        // Note: Multiple "MyCompanyName.AbpZeroTemplate"s might occur in the path
        private void RenameDirectories(DirectoryInfo dirInfo)
        {
            foreach (var subInfo in dirInfo.EnumerateDirectories())
            {
                RenameDirectories(subInfo);
                try
                {
                    var subName = subInfo.Name;
                    if (subName.Contains(Settings.ExistingCompanyName) || subName.Contains(Settings.ExistingProjectName))
                    {
                        _bw.ReportProgress(0, $"RENAMING DIRECTORY: {StripRootPath(subInfo.FullName)} ...");
                        subName = subName.ReplaceCompanyName(!string.IsNullOrWhiteSpace(tbPN.Text));
                        subInfo.MoveTo(Path.Combine(subInfo.Parent?.FullName ?? "", subName));
                        _bw.ReportProgress(1, "[OK]");
                    }
                }
                catch (Exception e)
                {
                    _bw.ReportProgress(0, $"ERROR: {e.Message}");
                }
            }
        }

        private void RenameFiles()
        {
            _bw.ReportProgress(0, "Getting list of files to be renamed...");
            var companyList = Directory.GetFiles(Settings.RootPath, $"*{Settings.ExistingCompanyName}*", SearchOption.AllDirectories);
            var projectList = Directory.GetFiles(Settings.RootPath, $"*{Settings.ExistingProjectName}*", SearchOption.AllDirectories);
            var mergedList = companyList.Union(projectList).ToList();
            _bw.ReportProgress(1, "[OK]");
            foreach (var file in mergedList)
            {
                try
                {
                    _bw.ReportProgress(0, $"RENAMING FILE: {StripRootPath(file)} ...");
                    File.Move(file, file.ReplaceCompanyName(!string.IsNullOrWhiteSpace(tbPN.Text)));
                    _bw.ReportProgress(1, "[OK]");
                }
                catch (Exception e)
                {
                    _bw.ReportProgress(0, $"ERROR: {e.Message}");
                }
            }
        }

        private void UpdateFileContents()
        {
            _bw.ReportProgress(0, "Getting list of source files for content update...");
            var fileList = Directory.EnumerateFiles(Settings.RootPath, "*", SearchOption.AllDirectories);
            _bw.ReportProgress(1, "[OK]");
            foreach (var file in fileList)
            {
                if (Settings.SourceFileExtensions.Any(x => file.EndsWith(x.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    try
                    {
                        _bw.ReportProgress(0, $"FILE: {StripRootPath(file)} ...");
                        var text = File.ReadAllText(file);
                        text = text.ReplaceCompanyName(!string.IsNullOrWhiteSpace(tbPN.Text));
                        File.WriteAllText(file, text);
                        _bw.ReportProgress(1, "[OK]");
                    }
                    catch (Exception e)
                    {
                        _bw.ReportProgress(0, $"ERROR: {e.Message}");
                    }
                }
            }
        }

        private void RemoveBoms()
        {
            _bw.ReportProgress(0, "Getting list of files for BOM removal...");
            var fileList = Directory.EnumerateFiles(Settings.RootPath, "*", SearchOption.AllDirectories);
            _bw.ReportProgress(1, "[OK]");
            foreach (var file in fileList)
            {
                if (Settings.SourceFileExtensions.Any(x => file.EndsWith(x.Trim(), StringComparison.OrdinalIgnoreCase)))
                {
                    try
                    {
                        _bw.ReportProgress(0, $"FILE: {StripRootPath(file)} ...");
                        var filestream = File.OpenRead(file);
                        var applicable = false;
                        if (filestream.Length >= 3)
                        {
                            var buffer = new byte[3];
                            filestream.Read(buffer, 0, buffer.Length);
                            if (buffer[0] == 0xEF && buffer[1] == 0xBB && buffer[2] == 0xBF)
                                applicable = true;
                            filestream.Close();
                        }
                        if (applicable)
                        {
                            var content = File.ReadAllBytes(file);
                            var newArray = new byte[content.Length - 3];
                            Array.Copy(content, 3, newArray, 0, newArray.Length);
                            File.WriteAllBytes(file, newArray);
                            _bw.ReportProgress(1, "[OK]");
                        }
                        else
                            _bw.ReportProgress(1, "[N/A]");
                    }
                    catch (Exception e)
                    {
                        _bw.ReportProgress(0, $"ERROR: {e.Message}");
                    }
                }
            }
        }

        private string StripRootPath(string path)
        {
            var result = path;
            if (path.StartsWith(Settings.RootPath))
            {
                result = path.Remove(0, Settings.RootPath.Length);
            }
            return result;
        }

        private void Log(string s)
        {
            lbLog.Items.Add(s);
            ScrollLogsToBottom();
        }

        private void LogAppendToLast(string textToAppend)
        {
            var item = lbLog.Items[lbLog.Items.Count - 1].ToString();
            lbLog.Items[lbLog.Items.Count - 1] = item + " " + textToAppend;
            ScrollLogsToBottom();
        }

        private void ScrollLogsToBottom()
        {
            if (!cbAutoScroll.Checked) return;

            int visibleItems = lbLog.ClientSize.Height / lbLog.ItemHeight;
            lbLog.TopIndex = Math.Max(lbLog.Items.Count - visibleItems + 1, 0);
        }

        private void Disable()
        {
            btnStart.Enabled = false;
        }

        private void Enable()
        {
            btnStart.Enabled = true;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnStartClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPath.Text) || string.IsNullOrWhiteSpace(tbCN.Text))
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            Settings.RootPath = tbPath.Text;
            Settings.NewCompanyName = tbCN.Text;
            Settings.NewProjectName = tbPN.Text;
            Settings.RenameDirectories = cbRenameDirectories.Checked;
            Settings.RenameFiles = cbRenameFiles.Checked;
            Settings.RemoveBoms = cbRemoveBoms.Checked;
            Settings.UpdateFileContents = cbUpdateFileContents.Checked;
            lbLog.Items.Clear();
            Disable();

            _bw = new BackgroundWorker();
            _bw.WorkerReportsProgress = true;
            _bw.DoWork += (object s1, DoWorkEventArgs e1) =>
            {
                Start();
            };
            _bw.ProgressChanged += (object s1, ProgressChangedEventArgs e1) =>
            {
                if (e1.ProgressPercentage == 1)
                    LogAppendToLast(e1.UserState.ToString());
                else
                {
                    if (e1.UserState != null)
                        Log(e1.UserState.ToString());
                }
            };
            _bw.RunWorkerCompleted += (object s1, RunWorkerCompletedEventArgs e1) =>
            {
                if (e1.Error != null)
                {
                    Log($"ERROR: {e1.Error}");
                }
                else if (e1.Cancelled)
                {
                    Log("Cancelled");
                }
                else
                {
                    if (e1.Result != null)
                    {
                        Log(e1.Result.ToString());
                    }
                }
                Enable();
            };
            _bw.RunWorkerAsync();
        }

        private void btnSaveLog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, lbLog.Items.Cast<string>());
                MessageBox.Show("Log saved successfully.");
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSettings())
            {
                frm.ShowDialog();
            }
        }
    }

    static class StringExtensions
    {
        public static string ReplaceCompanyName(this string s, bool useProjectName)
        {
            if (useProjectName) 
            {
                return s
                    .Replace(Settings.ExistingCompanyName, Settings.NewCompanyName)
                    .Replace(Settings.ExistingProjectName, Settings.NewProjectName);
            }

            return s
                .Replace($"{Settings.ExistingCompanyName}.{Settings.ExistingProjectName}", $"{Settings.NewCompanyName}")
                .Replace(Settings.ExistingProjectName, Settings.NewCompanyName);
        }
    }
}
