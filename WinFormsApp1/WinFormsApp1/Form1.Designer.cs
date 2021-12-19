using System;
using System.Windows.Forms;
using System.Drawing;


namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnsL = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.SymbOper = new System.Windows.Forms.TextBox();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.MaxI = new System.Windows.Forms.Label();
            this.MaxB = new System.Windows.Forms.Label();
            this.MaxU = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.MinI = new System.Windows.Forms.Label();
            this.MinB = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MinU = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.DMT = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.D_M = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "integer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.AnsL);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.SecondNum);
            this.panel1.Controls.Add(this.SymbOper);
            this.panel1.Controls.Add(this.FirstNum);
            this.panel1.Controls.Add(this.textBox9);
            this.panel1.Controls.Add(this.MaxI);
            this.panel1.Controls.Add(this.MaxB);
            this.panel1.Controls.Add(this.MaxU);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.MinI);
            this.panel1.Controls.Add(this.MinB);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.MinU);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 434);
            this.panel1.TabIndex = 1;
            // 
            // AnsL
            // 
            this.AnsL.AutoSize = true;
            this.AnsL.Location = new System.Drawing.Point(138, 289);
            this.AnsL.MinimumSize = new System.Drawing.Size(38, 15);
            this.AnsL.Name = "AnsL";
            this.AnsL.Size = new System.Drawing.Size(38, 15);
            this.AnsL.TabIndex = 22;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.Location = new System.Drawing.Point(112, 256);
            this.linkLabel1.MinimumSize = new System.Drawing.Size(60, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(90, 15);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Опять работа...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // SecondNum
            // 
            this.SecondNum.Location = new System.Drawing.Point(200, 218);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(93, 23);
            this.SecondNum.TabIndex = 19;
            // 
            // SymbOper
            // 
            this.SymbOper.Location = new System.Drawing.Point(141, 218);
            this.SymbOper.Name = "SymbOper";
            this.SymbOper.Size = new System.Drawing.Size(23, 23);
            this.SymbOper.TabIndex = 18;
            // 
            // FirstNum
            // 
            this.FirstNum.Location = new System.Drawing.Point(12, 218);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(94, 23);
            this.FirstNum.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox9.Location = new System.Drawing.Point(12, 185);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(36, 16);
            this.textBox9.TabIndex = 16;
            this.textBox9.Text = "Calc";
            // 
            // MaxI
            // 
            this.MaxI.AutoSize = true;
            this.MaxI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxI.Location = new System.Drawing.Point(265, 152);
            this.MaxI.MinimumSize = new System.Drawing.Size(38, 15);
            this.MaxI.Name = "MaxI";
            this.MaxI.Size = new System.Drawing.Size(38, 17);
            this.MaxI.TabIndex = 15;
            // 
            // MaxB
            // 
            this.MaxB.AutoSize = true;
            this.MaxB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxB.Location = new System.Drawing.Point(138, 151);
            this.MaxB.MinimumSize = new System.Drawing.Size(38, 15);
            this.MaxB.Name = "MaxB";
            this.MaxB.Size = new System.Drawing.Size(38, 17);
            this.MaxB.TabIndex = 14;
            // 
            // MaxU
            // 
            this.MaxU.AutoSize = true;
            this.MaxU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxU.Location = new System.Drawing.Point(12, 152);
            this.MaxU.MinimumSize = new System.Drawing.Size(38, 15);
            this.MaxU.Name = "MaxU";
            this.MaxU.Size = new System.Drawing.Size(38, 17);
            this.MaxU.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox8.Location = new System.Drawing.Point(265, 129);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(47, 16);
            this.textBox8.TabIndex = 12;
            this.textBox8.Text = "int";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox7.Location = new System.Drawing.Point(138, 129);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(78, 16);
            this.textBox7.TabIndex = 11;
            this.textBox7.Text = "byte";
            // 
            // MinI
            // 
            this.MinI.AutoSize = true;
            this.MinI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinI.Location = new System.Drawing.Point(265, 73);
            this.MinI.MinimumSize = new System.Drawing.Size(38, 15);
            this.MinI.Name = "MinI";
            this.MinI.Size = new System.Drawing.Size(38, 17);
            this.MinI.TabIndex = 10;
            // 
            // MinB
            // 
            this.MinB.AutoSize = true;
            this.MinB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinB.Location = new System.Drawing.Point(138, 74);
            this.MinB.MinimumSize = new System.Drawing.Size(38, 15);
            this.MinB.Name = "MinB";
            this.MinB.Size = new System.Drawing.Size(38, 17);
            this.MinB.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox6.Location = new System.Drawing.Point(265, 48);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(47, 16);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "int";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox5.Location = new System.Drawing.Point(12, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(78, 16);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "uint";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(12, 106);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Max";
            this.textBox4.Size = new System.Drawing.Size(36, 16);
            this.textBox4.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(12, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Min";
            this.textBox3.Size = new System.Drawing.Size(26, 16);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox2.Location = new System.Drawing.Point(12, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 16);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "uint";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox1.Location = new System.Drawing.Point(138, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 16);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "byte";
            // 
            // MinU
            // 
            this.MinU.AutoSize = true;
            this.MinU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinU.Location = new System.Drawing.Point(12, 73);
            this.MinU.MinimumSize = new System.Drawing.Size(38, 15);
            this.MinU.Name = "MinU";
            this.MinU.Size = new System.Drawing.Size(38, 17);
            this.MinU.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, -73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.D_M);
            this.panel2.Controls.Add(this.textBox12);
            this.panel2.Controls.Add(this.DMT);
            this.panel2.Controls.Add(this.textBox11);
            this.panel2.Controls.Add(this.textBox10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(402, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 434);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "real";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox10.Location = new System.Drawing.Point(15, 26);
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "Min";
            this.textBox10.Size = new System.Drawing.Size(26, 16);
            this.textBox10.TabIndex = 6;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBox11.Location = new System.Drawing.Point(15, 48);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(78, 16);
            this.textBox11.TabIndex = 7;
            this.textBox11.Text = "double";
            // 
            // DMT
            // 
            this.DMT.AutoSize = true;
            this.DMT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DMT.Location = new System.Drawing.Point(15, 73);
            this.DMT.MinimumSize = new System.Drawing.Size(200, 15);
            this.DMT.Name = "DMT";
            this.DMT.Size = new System.Drawing.Size(200, 17);
            this.DMT.TabIndex = 8;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox12.Location = new System.Drawing.Point(15, 106);
            this.textBox12.Name = "textBox12";
            this.textBox12.PlaceholderText = "Max";
            this.textBox12.Size = new System.Drawing.Size(26, 16);
            this.textBox12.TabIndex = 9;
            // 
            // D_M
            // 
            this.D_M.AutoSize = true;
            this.D_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.D_M.Location = new System.Drawing.Point(15, 151);
            this.D_M.MinimumSize = new System.Drawing.Size(200, 15);
            this.D_M.Name = "D_M";
            this.D_M.Size = new System.Drawing.Size(200, 17);
            this.D_M.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button2;
        private Label MinU;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label MinI;
        private Label MinB;
        private Label MaxI;
        private Label MaxB;
        private Label MaxU;
        private TextBox SecondNum;
        private TextBox SymbOper;
        private TextBox FirstNum;
        private TextBox textBox9;
        private LinkLabel linkLabel1;
        private Label AnsL;
        private Label D_M;
        private TextBox textBox12;
        private Label DMT;
        private TextBox textBox11;
        private TextBox textBox10;
    }
}

