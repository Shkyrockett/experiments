// <copyright file="BitTwiddler.Designer.cs" company="Shkyrockett">
//     Copyright (C) Shkyrockett. All rights reserved.
// </copyright>
// <author>Shkyrockett</author>
namespace Bit_Twiddler
{
    /// <summary>
    /// 
    /// </summary>
    partial class BitTwiddler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.RadioButton rad1;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.RadioButton rad2;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.RadioButton rad3;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.CheckBox chkReverseBits;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.NumericUpDown num1;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.NumericUpDown Label1;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.TextBox txt1;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.ListBox cmbMode;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.GroupBox groupBox1;
        
        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.NumericUpDown num2;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.NumericUpDown Label2;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.TextBox txt2;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.TextBox num3;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.TextBox Label3;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.TextBox txt3;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.Label label8;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.Button button2;

        /// <summary>
        /// 
        /// </summary>
        private System.Windows.Forms.NumericUpDown NumShift;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.chkReverseBits = new System.Windows.Forms.CheckBox();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.Label1 = new System.Windows.Forms.NumericUpDown();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.cmbMode = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.NumericUpDown();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NumShift = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumShift)).BeginInit();
            this.SuspendLayout();
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Checked = true;
            this.rad1.Location = new System.Drawing.Point(12, 12);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(61, 17);
            this.rad1.TabIndex = 0;
            this.rad1.TabStop = true;
            this.rad1.Text = "Value &1";
            this.rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Location = new System.Drawing.Point(12, 176);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(61, 17);
            this.rad2.TabIndex = 1;
            this.rad2.Text = "Value &2";
            this.rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(12, 199);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(60, 17);
            this.rad3.TabIndex = 2;
            this.rad3.Text = "Res&ults";
            this.rad3.UseVisualStyleBackColor = true;
            // 
            // chkReverseBits
            // 
            this.chkReverseBits.AutoSize = true;
            this.chkReverseBits.Location = new System.Drawing.Point(12, 250);
            this.chkReverseBits.Name = "chkReverseBits";
            this.chkReverseBits.Size = new System.Drawing.Size(86, 17);
            this.chkReverseBits.TabIndex = 3;
            this.chkReverseBits.Text = "&Reverse Bits";
            this.chkReverseBits.UseVisualStyleBackColor = true;
            this.chkReverseBits.CheckedChanged += new System.EventHandler(this.chkReverseBits_CheckedChanged);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(79, 12);
            this.num1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(84, 20);
            this.num1.TabIndex = 4;
            this.num1.ValueChanged += new System.EventHandler(this.num1_ValueChanged);
            // 
            // Label1
            // 
            this.Label1.Hexadecimal = true;
            this.Label1.Location = new System.Drawing.Point(169, 12);
            this.Label1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Label1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(125, 20);
            this.Label1.TabIndex = 5;
            this.Label1.ValueChanged += new System.EventHandler(this.Label1_ValueChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(300, 11);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(199, 20);
            this.txt1.TabIndex = 6;
            this.txt1.Text = "00000000000000000000000000000000";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // cmbMode
            // 
            this.cmbMode.FormattingEnabled = true;
            this.cmbMode.Items.AddRange(new object[] {
            "& And",
            "| Or",
            "^ Xor",
            "~ Not1",
            "~ Not2",
            "&& AndAlso",
            "|| OrElse"});
            this.cmbMode.Location = new System.Drawing.Point(67, 19);
            this.cmbMode.Name = "cmbMode";
            this.cmbMode.Size = new System.Drawing.Size(62, 95);
            this.cmbMode.TabIndex = 7;
            this.cmbMode.SelectedIndexChanged += new System.EventHandler(this.cmbMode_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbMode);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 128);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Opperator";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(79, 173);
            this.num2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(83, 20);
            this.num2.TabIndex = 9;
            this.num2.ValueChanged += new System.EventHandler(this.num2_ValueChanged);
            // 
            // Label2
            // 
            this.Label2.Hexadecimal = true;
            this.Label2.Location = new System.Drawing.Point(168, 173);
            this.Label2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.Label2.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(126, 20);
            this.Label2.TabIndex = 10;
            this.Label2.ValueChanged += new System.EventHandler(this.Label2_ValueChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(300, 172);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(199, 20);
            this.txt2.TabIndex = 11;
            this.txt2.Text = "00000000000000000000000000000000";
            this.txt2.TextChanged += new System.EventHandler(this.txt2_TextChanged);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(79, 198);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(83, 20);
            this.num3.TabIndex = 12;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(168, 198);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(126, 20);
            this.Label3.TabIndex = 13;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(300, 198);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(199, 20);
            this.txt3.TabIndex = 14;
            this.txt3.TextChanged += new System.EventHandler(this.txt3_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bit Shifting";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "&<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "&>>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumShift
            // 
            this.NumShift.Location = new System.Drawing.Point(168, 227);
            this.NumShift.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumShift.Name = "NumShift";
            this.NumShift.Size = new System.Drawing.Size(63, 20);
            this.NumShift.TabIndex = 18;
            this.NumShift.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BitTwiddler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 273);
            this.Controls.Add(this.NumShift);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.chkReverseBits);
            this.Controls.Add(this.rad3);
            this.Controls.Add(this.rad2);
            this.Controls.Add(this.rad1);
            this.Name = "BitTwiddler";
            this.Text = "Bit Twiddler";
            this.Load += new System.EventHandler(this.BitTwiddler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
