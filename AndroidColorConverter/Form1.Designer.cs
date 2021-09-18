namespace ColorConverter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnColor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtHex = new System.Windows.Forms.TextBox();
			this.txtAndroidInt = new System.Windows.Forms.TextBox();
			this.btnConvert = new System.Windows.Forms.Button();
			this.txtIntInput = new System.Windows.Forms.TextBox();
			this.txtHexOut = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnConvertInt = new System.Windows.Forms.Button();
			this.pnlColor = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(49, 18);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(75, 23);
			this.btnColor.TabIndex = 0;
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Color: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Opacity";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(55, 49);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(69, 20);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "HEX Code (AARRGGBB)";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(86, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Android Int Code";
			// 
			// txtHex
			// 
			this.txtHex.Location = new System.Drawing.Point(141, 84);
			this.txtHex.Name = "txtHex";
			this.txtHex.ReadOnly = true;
			this.txtHex.Size = new System.Drawing.Size(100, 20);
			this.txtHex.TabIndex = 5;
			// 
			// txtAndroidInt
			// 
			this.txtAndroidInt.Location = new System.Drawing.Point(141, 110);
			this.txtAndroidInt.Name = "txtAndroidInt";
			this.txtAndroidInt.ReadOnly = true;
			this.txtAndroidInt.Size = new System.Drawing.Size(100, 20);
			this.txtAndroidInt.TabIndex = 5;
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(141, 18);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(100, 51);
			this.btnConvert.TabIndex = 0;
			this.btnConvert.Text = "Convert";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
			// 
			// txtIntInput
			// 
			this.txtIntInput.Location = new System.Drawing.Point(138, 13);
			this.txtIntInput.Name = "txtIntInput";
			this.txtIntInput.Size = new System.Drawing.Size(100, 20);
			this.txtIntInput.TabIndex = 8;
			// 
			// txtHexOut
			// 
			this.txtHexOut.Location = new System.Drawing.Point(138, 36);
			this.txtHexOut.Name = "txtHexOut";
			this.txtHexOut.ReadOnly = true;
			this.txtHexOut.Size = new System.Drawing.Size(100, 20);
			this.txtHexOut.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 16);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(86, 13);
			this.label5.TabIndex = 6;
			this.label5.Text = "Android Int Code";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 39);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(126, 13);
			this.label6.TabIndex = 7;
			this.label6.Text = "HEX Code (AARRGGBB)";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.btnColor);
			this.groupBox1.Controls.Add(this.btnConvert);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtAndroidInt);
			this.groupBox1.Controls.Add(this.numericUpDown1);
			this.groupBox1.Controls.Add(this.txtHex);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 141);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color to Int";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pnlColor);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.btnConvertInt);
			this.groupBox2.Controls.Add(this.txtIntInput);
			this.groupBox2.Controls.Add(this.txtHexOut);
			this.groupBox2.Location = new System.Drawing.Point(12, 159);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(250, 100);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Int to Color";
			// 
			// btnConvertInt
			// 
			this.btnConvertInt.Location = new System.Drawing.Point(138, 62);
			this.btnConvertInt.Name = "btnConvertInt";
			this.btnConvertInt.Size = new System.Drawing.Size(100, 32);
			this.btnConvertInt.TabIndex = 0;
			this.btnConvertInt.Text = "Convert";
			this.btnConvertInt.UseVisualStyleBackColor = true;
			this.btnConvertInt.Click += new System.EventHandler(this.btnConvertInt_Click);
			// 
			// pnlColor
			// 
			this.pnlColor.Location = new System.Drawing.Point(2, 62);
			this.pnlColor.Name = "pnlColor";
			this.pnlColor.Size = new System.Drawing.Size(130, 32);
			this.pnlColor.TabIndex = 10;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(268, 273);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Color Converter";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtHex;
		private System.Windows.Forms.TextBox txtAndroidInt;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.TextBox txtIntInput;
		private System.Windows.Forms.TextBox txtHexOut;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnConvertInt;
		private System.Windows.Forms.Panel pnlColor;
	}
}

