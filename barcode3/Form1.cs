﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace barcode3
{
    public partial class Form1 : Form
    {
        string logFilePath = "C:\\barcodeLog\\BarcodeLogFile.txt";

        public Form1()
        {
            InitializeComponent();        
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();

            String defaultPath;
            /*  Load default log patch form DefaultPath.conf  */
            if (File.Exists(".\\DefaultPath.conf"))
            {
                StreamReader sr = new StreamReader(".\\DefaultPath.conf");
                defaultPath = sr.ReadLine();
                sr.Close();

                if (String.IsNullOrEmpty(defaultPath))
                {
                    pathBox.Text = logFilePath;
                } 
                else {
                    pathBox.Text = defaultPath;
                }
            }
            else {
                pathBox.Text = logFilePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == ""){
                label11.Visible = true;
            }
            else if(comboBox1.SelectedIndex == 0) {
                label12.Visible = true;
            }
            else {
                DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
                string a = input1.Text.Replace(" ", "");
                string b = input2.Text.Replace(" ", "");

                label11.Visible = false;
                label12.Visible = false;
                label1.Visible = true;
                if ((a.IndexOf(b) > -1) || (b.IndexOf(a) > -1))
                {
                    label1.Text = "True";
                    BackColor = Color.LightGreen;
                }
                else
                {
                    label1.Text = "False";
                    BackColor = Color.Salmon;
                }

                logFilePath = pathBox.Text;
                string dirPath = logFilePath.Substring( 0, logFilePath.LastIndexOf("\\"));
                bool exists = System.IO.Directory.Exists(dirPath);
                if (!exists)
                {
                    try
                    {
                        System.IO.Directory.CreateDirectory(dirPath);
                    }
                    catch (Exception error)
                    {
                        label7.Visible = true;
                        label7.Text = "Exception: " + error.Message;
                    }
                }

                if (!File.Exists(logFilePath))
                {
                    StreamWriter sw = File.CreateText(logFilePath);
                    sw.Close();
                }

                try
                {
                    String line;
                    StreamReader sr = new StreamReader(logFilePath);
                    line = sr.ReadToEnd();
                    sr.Close();

                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter(logFilePath);
                    //Write a line of text
                    sw.WriteLine(line + now.ToLocalTime().ToString() + "," + textBox1.Text + "," + comboBox1.Text.Replace(" ", "") + "," + input1.Text + "," + input2.Text + "," + label1.Text);
                    //Close the file
                    sw.Close();
                }
                catch (Exception error)
                {
                    label7.Visible = true;
                    label7.Text = "Exception: " + error.Message;
                }

                if (AutoRadioButton.Checked == true)
                {
                    textBox1.Enabled = true;
                    input1.Enabled = true;
                    textBox1.ReadOnly = false;
                    input1.ReadOnly = false;
                    input1.Clear();
                    input2.Clear();
                    input1.Focus();
                    label7.Visible = false;
                }
                else if (ManualRadioButton.Checked == true) {
                    textBox1.ReadOnly = true;
                    input1.ReadOnly = true;
                    input1.Enabled = false;
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    this.ActiveControl = button3;
                }
                input2.ReadOnly = false;
                input2.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if  ( (e.KeyValue == (char)Keys.Return) || (e.KeyValue == (char)Keys.Enter) )
            {
                if ( !String.IsNullOrEmpty(input1.Text) && !String.IsNullOrEmpty(input2.Text) )
                {
                    label11.Visible = false;
                    button1_Click(null, null);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input1.Enabled = true;
            input1.Clear();
            input2.Clear();
            input1.Focus();
            textBox1.ReadOnly = false;
            input1.ReadOnly = false;
            input2.ReadOnly = false;
            label7.Visible = false;
            label1.Text = "";
            BackColor = Color.LightGray;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            input2.Enabled = false;
            label13.Visible = false;
            exportlabel.Text = "";
            exportlabel.Visible = false;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                input1.Focus();
                input1.ReadOnly = false;
            }
        }

        private void ManualRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualRadioButton.Checked == true)
            {
                AutoRadioButton.Checked = false;
            }
            else
            {
                AutoRadioButton.Checked = true;
            }
            button3_Click(null, null);
        }

        private void AutoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoRadioButton.Checked == true)
            {
                input1.ReadOnly = false;
                input2.ReadOnly = false;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            input1.Focus();
            input1.ReadOnly = false;
            input1.Enabled = true;

            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(input1.Text) && !String.IsNullOrEmpty(input2.Text))
            {
                button1_Click(null, null);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Return))
            {
                if (string.IsNullOrWhiteSpace(input1.Text))
                {
                    label13.Visible = true;
                    label13.Text = "Input 1 can't be empty!";
                    input1.Clear();
                }
                else
                {
                    label13.Visible = false;
                    input2.Enabled = true;
                    input2.ReadOnly = false;
                    input2.Focus();
                    input1.ReadOnly = true;
                    input1.Enabled = false;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (string.IsNullOrWhiteSpace(input2.Text))
                {
                    label5.Visible = true;
                    label5.Text = "Input 2 can't be empty!";
                    input2.Clear();
                }
                else
                {
                    label5.Text = "";
                    if (input1.Text == input2.Text)
                    {
                        label5.Visible = true;
                        label5.Text = "Input 2 Error, Duplicate!";
                        input2.Clear();
                    }
                    else
                    {
                        button1_Click(null, null);
                        input1.Focus();
                        input2.ReadOnly = true;
                        label5.Text = "";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select log file";
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "txt files (*.*)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                logFilePath = dialog.FileName;
                pathBox.Text = logFilePath;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            label15.AutoSize = false;
            label15.Height = 3;
            label15.Width = 868;
            label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        }

        private void exCxcel_Click(object sender, EventArgs e)
        {
            try
            {
                string txtFullPath;
                string excelFullPath;
                exportlabel.Text = "Waiting for txt export to Excel...";
                exportlabel.Visible = true;
                txtFullPath = logFilePath;

                excelFullPath = txtFullPath.Replace("txt", "xls");
                txt2excel(txtFullPath, excelFullPath);

                exportlabel.Text = "Export to " + excelFullPath + " ready!";
                button3.Focus();
            }
            catch (Exception error)
            {
                exportlabel.Text = "Something wrong! Error: " + error.Message;
            }
        }

        public static void txt2excel(string txtFullPath, string excelFullPath)
        {
            HSSFWorkbook hssfworkbook = new HSSFWorkbook();
            ISheet sheet = hssfworkbook.CreateSheet("sheet1");
            string[] txtLines = File.ReadAllLines(txtFullPath);
            for (int i = 0; i < txtLines.Length; ++i)
            {
                    string[] line = txtLines[i].Split(',');
                    IRow dataRow = sheet.CreateRow(i);
                    for (int j = 0; j < line.Length; j++)
                    {
                        ICell cell = dataRow.CreateCell(j);
                        cell.SetCellValue(line[j]);
                    }
            }

            using (FileStream fs = File.OpenWrite(excelFullPath))
            {
                hssfworkbook.Write(fs);
            }
        }
    }
}
