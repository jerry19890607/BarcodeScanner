namespace barcode3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.compare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.ManualRadioButton = new System.Windows.Forms.RadioButton();
            this.AutoRadioButton = new System.Windows.Forms.RadioButton();
            this.step1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.exCxcel = new System.Windows.Forms.Button();
            this.exportlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(150, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // input1
            // 
            this.input1.BackColor = System.Drawing.SystemColors.Control;
            this.input1.Enabled = false;
            this.input1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input1.Location = new System.Drawing.Point(150, 219);
            this.input1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.input1.Name = "input1";
            this.input1.ReadOnly = true;
            this.input1.ShortcutsEnabled = false;
            this.input1.Size = new System.Drawing.Size(719, 27);
            this.input1.TabIndex = 2;
            this.input1.TabStop = false;
            this.input1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // input2
            // 
            this.input2.Enabled = false;
            this.input2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input2.Location = new System.Drawing.Point(150, 285);
            this.input2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.input2.Name = "input2";
            this.input2.ReadOnly = true;
            this.input2.Size = new System.Drawing.Size(719, 27);
            this.input2.TabIndex = 3;
            this.input2.TabStop = false;
            this.input2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // compare
            // 
            this.compare.Enabled = false;
            this.compare.Location = new System.Drawing.Point(1205, 18);
            this.compare.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(118, 34);
            this.compare.TabIndex = 1;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = true;
            this.compare.Visible = false;
            this.compare.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 99.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.BlueViolet;
            this.label1.Location = new System.Drawing.Point(298, 318);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 167);
            this.label1.TabIndex = 2;
            this.label1.Text = "Null";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(58, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(50, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input 1 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(50, 284);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Input 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(150, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 5;
            this.label5.Text = "Null";
            this.label5.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(110, 476);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 222;
            this.button3.TabStop = false;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(69, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "Bank :";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label7.Location = new System.Drawing.Point(272, 494);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // ManualRadioButton
            // 
            this.ManualRadioButton.AutoSize = true;
            this.ManualRadioButton.Checked = true;
            this.ManualRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManualRadioButton.Location = new System.Drawing.Point(50, 597);
            this.ManualRadioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ManualRadioButton.Name = "ManualRadioButton";
            this.ManualRadioButton.Size = new System.Drawing.Size(180, 24);
            this.ManualRadioButton.TabIndex = 10;
            this.ManualRadioButton.TabStop = true;
            this.ManualRadioButton.Text = "Manual Comparison";
            this.ManualRadioButton.UseVisualStyleBackColor = true;
            this.ManualRadioButton.CheckedChanged += new System.EventHandler(this.ManualRadioButton_CheckedChanged);
            // 
            // AutoRadioButton
            // 
            this.AutoRadioButton.AutoSize = true;
            this.AutoRadioButton.Enabled = false;
            this.AutoRadioButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoRadioButton.Location = new System.Drawing.Point(50, 630);
            this.AutoRadioButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AutoRadioButton.Name = "AutoRadioButton";
            this.AutoRadioButton.Size = new System.Drawing.Size(202, 24);
            this.AutoRadioButton.TabIndex = 11;
            this.AutoRadioButton.Text = "Automatic Comparison";
            this.AutoRadioButton.UseVisualStyleBackColor = true;
            this.AutoRadioButton.CheckedChanged += new System.EventHandler(this.AutoRadioButton_CheckedChanged);
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.step1.Location = new System.Drawing.Point(23, 559);
            this.step1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(209, 24);
            this.step1.TabIndex = 12;
            this.step1.Text = " * Comparison mode :";
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.BackColor = System.Drawing.Color.Transparent;
            this.step2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.step2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.step2.Location = new System.Drawing.Point(21, 16);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(435, 26);
            this.step2.TabIndex = 13;
            this.step2.Text = "Step 1   Fill in Your Name and Bank name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(24, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(319, 26);
            this.label8.TabIndex = 14;
            this.label8.Text = "Step 2   Scanning 2D barcode :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(24, 436);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(287, 26);
            this.label9.TabIndex = 15;
            this.label9.Text = "Step 3   Reset and Re-scan :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(210, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 35);
            this.label10.TabIndex = 16;
            this.label10.Text = "Result : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(299, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(321, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Attention!! Please fill in Your name";
            this.label11.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "  -- select --",
            "   CTBC中信",
            "   CUB國泰",
            "   CITI花旗"});
            this.comboBox1.Location = new System.Drawing.Point(150, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 32);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(300, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(335, 24);
            this.label12.TabIndex = 19;
            this.label12.Text = "Attention!! Please select Bank Name";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(150, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 27);
            this.label13.TabIndex = 223;
            this.label13.Text = "Null";
            this.label13.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(353, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 27);
            this.button2.TabIndex = 224;
            this.button2.TabStop = false;
            this.button2.Text = "Browser";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pathBox
            // 
            this.pathBox.BackColor = System.Drawing.Color.LightGray;
            this.pathBox.Enabled = false;
            this.pathBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pathBox.Location = new System.Drawing.Point(353, 588);
            this.pathBox.Name = "pathBox";
            this.pathBox.ReadOnly = true;
            this.pathBox.Size = new System.Drawing.Size(400, 25);
            this.pathBox.TabIndex = 226;
            this.pathBox.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(330, 559);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(153, 24);
            this.label14.TabIndex = 227;
            this.label14.Text = " * Log file path :";
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(5, 539);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(868, 3);
            this.label15.TabIndex = 228;
            this.label15.Text = "label15";
            // 
            // exCxcel
            // 
            this.exCxcel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exCxcel.Location = new System.Drawing.Point(353, 648);
            this.exCxcel.Name = "exCxcel";
            this.exCxcel.Size = new System.Drawing.Size(113, 30);
            this.exCxcel.TabIndex = 229;
            this.exCxcel.Text = "Export to Excel";
            this.exCxcel.UseVisualStyleBackColor = true;
            this.exCxcel.Click += new System.EventHandler(this.exCxcel_Click);
            // 
            // exportlabel
            // 
            this.exportlabel.AutoSize = true;
            this.exportlabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exportlabel.ForeColor = System.Drawing.Color.Black;
            this.exportlabel.Location = new System.Drawing.Point(353, 680);
            this.exportlabel.Name = "exportlabel";
            this.exportlabel.Size = new System.Drawing.Size(32, 17);
            this.exportlabel.TabIndex = 230;
            this.exportlabel.Text = "Null";
            this.exportlabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(883, 707);
            this.Controls.Add(this.exportlabel);
            this.Controls.Add(this.exCxcel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.step2);
            this.Controls.Add(this.step1);
            this.Controls.Add(this.AutoRadioButton);
            this.Controls.Add(this.ManualRadioButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "THALES Barcode Compare Utility v1.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton ManualRadioButton;
        private System.Windows.Forms.RadioButton AutoRadioButton;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button exCxcel;
        private System.Windows.Forms.Label exportlabel;
    }
}

