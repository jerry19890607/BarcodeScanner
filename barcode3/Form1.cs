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

namespace barcode3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBox1.Focus();
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
                string a = textBox2.Text;
                string b = textBox3.Text;

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

                String line;
                try
                {
                    StreamReader sr = new StreamReader("D:\\Download\\Sample.txt");
                    line = sr.ReadToEnd();
                    sr.Close();

                    //Pass the filepath and filename to the StreamWriter Constructor
                    StreamWriter sw = new StreamWriter("D:\\Download\\Sample.txt");
                    //Write a line of text
                    sw.WriteLine(line + now.ToLocalTime().ToString() + " " + textBox1.Text + " " + comboBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + label1.Text);
                    //Close the file
                    sw.Close();
                }
                catch (Exception error)
                {
                    label7.Visible = true;
                    label7.Text = "Exception: " + error.Message;
                }
                finally
                {
                    //label7.Visible = true;
                    //label7.Text = "Executing finally block.";
                }

                if (AutoRadioButton.Checked == true)
                {
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox1.ReadOnly = false;
                    textBox2.ReadOnly = false;
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox2.Focus();
                    label7.Visible = false;
                }
                else if (ManualRadioButton.Checked == true) {
                    textBox1.ReadOnly = true;
                    textBox2.ReadOnly = true;
                    textBox2.Enabled = false;
                    textBox1.Enabled = false;
                    comboBox1.Enabled = false;
                    this.ActiveControl = button3;
                    button3.Focus();
                }
                textBox3.ReadOnly = false;
                textBox3.Enabled = false;
            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ( (e.KeyValue == (char)Keys.Return) )
            {
                textBox3.Enabled = true;
                textBox3.ReadOnly = false;
                textBox3.Focus();
                textBox2.ReadOnly = true;
                textBox2.Enabled = false;
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Return)
            {
                label5.Text = "";

                if (textBox2.Text == textBox3.Text)
                {
                    label5.Visible = true;
                    label5.Text = "Input 2 Error, Duplicate!";
                    textBox3.Clear();
                }
                else
                {
                    button1_Click(null, null);
                    textBox2.Focus();
                    textBox3.ReadOnly = true;
                    label5.Text = "";
                }
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
                if ( !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text) )
                {
                    button1_Click(null, null);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
            textBox2.Clear();
            textBox3.Clear();
            textBox2.Focus();
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            label7.Visible = false;
            label1.Text = "";
            BackColor = Color.LightGray;
            textBox1.Enabled = true;
            comboBox1.Enabled = true;
            textBox3.Enabled = false;
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                textBox2.Focus();
                textBox2.ReadOnly = false;
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
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.ReadOnly = false;
            textBox2.Enabled = true;

            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text) && !String.IsNullOrEmpty(textBox3.Text))
            {
                button1_Click(null, null);
            }
        }

    }
}
