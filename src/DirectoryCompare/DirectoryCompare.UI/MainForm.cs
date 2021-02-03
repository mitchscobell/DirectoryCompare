using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DirectoryCompare.UI
{
    public partial class MainForm : Form
    {
        private List<FileInfo> SourceFiles = new List<FileInfo>();
        private List<FileInfo> CompareFiles = new List<FileInfo>();
        public MainForm()
        {
            InitializeComponent();
            ResetForm();

            textBoxSourceDirectory.Text = @"C:\test1\";
            textBoxCompareDirectory.Text = @"C:\test2\";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetForm()
        {
            textBoxSourceDirectory.Text = string.Empty;
            textBoxCompareDirectory.Text = string.Empty;

            SourceFiles.Clear();
            CompareFiles.Clear();

            dataGridViewSourceFiles.DataSource = null;
            dataGridViewCompareFiles.DataSource = null;

            checkBoxRecursive.Checked = false;
        }

        private void CompareDirectories()
        {

            var recursive = checkBoxRecursive.Checked;
            try
            {
                //TODO load source files
                SourceFiles = GetFiles(textBoxSourceDirectory.Text, recursive);

                //TODO load compare files
                CompareFiles = GetFiles(textBoxCompareDirectory.Text, recursive);

                dataGridViewSourceFiles.DataSource = SourceFiles;
                dataGridViewCompareFiles.DataSource = CompareFiles;

                HighlightDifferences();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private List<FileInfo> GetFiles(string directory, bool recursive = false)
        {
            var files = new List<FileInfo>();

            var directoryInfo = new DirectoryInfo(directory);

            files.AddRange(directoryInfo.GetFiles());

            if (recursive)
            {
                var childDirectories = directoryInfo.GetDirectories();

                foreach (var dir in childDirectories)
                {
                    files.AddRange(GetFiles(dir.FullName, true));
                }
            }

            return files;
        }

        private void HighlightDifferences()
        {
            foreach (FileInfo sourceFile in SourceFiles)
            {
                var compareFile = CompareFiles.FirstOrDefault(c => c.Name == sourceFile.Name);

                if (compareFile != null)
                {
                    //TODO MD5 of both files to compare
                    var sourceMd5 = CalculateMD5(sourceFile.FullName);
                    var compareMd5 = CalculateMD5(compareFile.FullName);

                    var sourceLocalDirectory = sourceFile.FullName.Replace
                        (textBoxSourceDirectory.Text, string.Empty);

                    var compareLocalDirectory = compareFile.FullName.Replace
                        (textBoxCompareDirectory.Text, string.Empty);


                    // if different highlight yellow
                    if (sourceMd5 != compareMd5 ||
                        sourceLocalDirectory != compareLocalDirectory)
                    {
                        DataGridViewRow row = FindRow(compareFile.FullName, dataGridViewCompareFiles);

                        ChangedFileRowStyle(row);
                    }

                }
                else
                {
                    //TODO file doesn't exist, highlight green
                    DataGridViewRow row = FindRow(sourceFile.FullName, dataGridViewSourceFiles);

                    DeletedFileRowStyle(row);
                }
            }

            var sourceFileNames = SourceFiles.Select(s => s.Name);
            //TODO files that are in compare that aren't in source
            foreach (var compare in CompareFiles)
            {
                if (!sourceFileNames.Contains(compare.Name))
                {
                    DataGridViewRow row = FindRow(compare.FullName, dataGridViewCompareFiles);

                    NewFileRowStyle(row);
                }
            }
        }

        private DataGridViewRow FindRow(string fullFileName, DataGridView dataGridView)
        {
            DataGridViewRow row = dataGridView.Rows
                        .Cast<DataGridViewRow>()
                        .Where(r => r.Cells["FullName"].Value.ToString().Equals(fullFileName))
                        .First();

            return row;
        }

        private void NewFileRowStyle(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = Color.Green;
            row.DefaultCellStyle.ForeColor = Color.White;
        }

        private void ChangedFileRowStyle(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = Color.Yellow;
            row.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void DeletedFileRowStyle(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = Color.Red;
            row.DefaultCellStyle.ForeColor = Color.White;
        }

        private string CalculateMD5(string filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    var hash = md5.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                }
            }
        }

        private void buttonBrowseDirectorySource_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSourceDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonBrowseDirectoryCompare_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxCompareDirectory.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonCompare_Click(object sender, EventArgs e)
        {
            CompareDirectories();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
