﻿namespace Therm
{
	partial class Main
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
			this.DeltaName = new System.Windows.Forms.TextBox();
			this.Units = new System.Windows.Forms.TextBox();
			this.DeltaH = new System.Windows.Forms.TextBox();
			this.DeltaS = new System.Windows.Forms.TextBox();
			this.DeltaG = new System.Windows.Forms.TextBox();
			this.DeltaGT = new System.Windows.Forms.TextBox();
			this.FormulaBox = new System.Windows.Forms.TextBox();
			this.GOButton = new System.Windows.Forms.Button();
			this.Output = new System.Windows.Forms.TextBox();
			this.GasConstant = new System.Windows.Forms.ComboBox();
			this.Requals = new System.Windows.Forms.TextBox();
			this.Temp = new System.Windows.Forms.TextBox();
			this.EqConstBox = new System.Windows.Forms.TextBox();
			this.KText = new System.Windows.Forms.TextBox();
			this.KunitsAbove = new System.Windows.Forms.TextBox();
			this.KunitsBelow = new System.Windows.Forms.TextBox();
			this.GasConstantGroup = new System.Windows.Forms.GroupBox();
			this.Kgroup = new System.Windows.Forms.GroupBox();
			this.Line = new System.Windows.Forms.PictureBox();
			this.helpButton = new System.Windows.Forms.Button();
			this.GasConstantGroup.SuspendLayout();
			this.Kgroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Line)).BeginInit();
			this.SuspendLayout();
			// 
			// DeltaName
			// 
			this.DeltaName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeltaName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeltaName.Location = new System.Drawing.Point(770, 12);
			this.DeltaName.Multiline = true;
			this.DeltaName.Name = "DeltaName";
			this.DeltaName.ReadOnly = true;
			this.DeltaName.Size = new System.Drawing.Size(45, 68);
			this.DeltaName.TabIndex = 0;
			this.DeltaName.Text = "ΔHᴼ  =\r\nΔSᴼ  =\r\nΔGᴼ  =\r\nΔG  =\r\nT  =";
			this.DeltaName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// Units
			// 
			this.Units.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Units.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Units.Location = new System.Drawing.Point(874, 12);
			this.Units.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.Units.Multiline = true;
			this.Units.Name = "Units";
			this.Units.ReadOnly = true;
			this.Units.Size = new System.Drawing.Size(54, 68);
			this.Units.TabIndex = 2;
			this.Units.Text = "kJ/mol\r\nJ/(mol*K)\r\nkJ/mol\r\nkJ/mol\r\n°K";
			// 
			// DeltaH
			// 
			this.DeltaH.AllowDrop = true;
			this.DeltaH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeltaH.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeltaH.Location = new System.Drawing.Point(817, 13);
			this.DeltaH.Margin = new System.Windows.Forms.Padding(0);
			this.DeltaH.Name = "DeltaH";
			this.DeltaH.Size = new System.Drawing.Size(54, 13);
			this.DeltaH.TabIndex = 3;
			this.DeltaH.Text = "Undefined";
			// 
			// DeltaS
			// 
			this.DeltaS.AllowDrop = true;
			this.DeltaS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeltaS.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeltaS.Location = new System.Drawing.Point(817, 26);
			this.DeltaS.Margin = new System.Windows.Forms.Padding(0);
			this.DeltaS.Name = "DeltaS";
			this.DeltaS.Size = new System.Drawing.Size(54, 13);
			this.DeltaS.TabIndex = 4;
			this.DeltaS.Text = "Undefined";
			// 
			// DeltaG
			// 
			this.DeltaG.AllowDrop = true;
			this.DeltaG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeltaG.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeltaG.Location = new System.Drawing.Point(817, 39);
			this.DeltaG.Margin = new System.Windows.Forms.Padding(0);
			this.DeltaG.Name = "DeltaG";
			this.DeltaG.Size = new System.Drawing.Size(54, 13);
			this.DeltaG.TabIndex = 5;
			this.DeltaG.Text = "Undefined";
			this.DeltaG.TextChanged += new System.EventHandler(this.DeltaG_TextChanged);
			// 
			// DeltaGT
			// 
			this.DeltaGT.AllowDrop = true;
			this.DeltaGT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeltaGT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DeltaGT.Location = new System.Drawing.Point(817, 52);
			this.DeltaGT.Margin = new System.Windows.Forms.Padding(0);
			this.DeltaGT.Name = "DeltaGT";
			this.DeltaGT.Size = new System.Drawing.Size(54, 13);
			this.DeltaGT.TabIndex = 6;
			this.DeltaGT.Text = "Undefined";
			// 
			// FormulaBox
			// 
			this.FormulaBox.AllowDrop = true;
			this.FormulaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FormulaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.FormulaBox.Location = new System.Drawing.Point(12, 12);
			this.FormulaBox.Name = "FormulaBox";
			this.FormulaBox.Size = new System.Drawing.Size(671, 30);
			this.FormulaBox.TabIndex = 8;
			this.FormulaBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormulaBox_KeyDown);
			// 
			// GOButton
			// 
			this.GOButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GOButton.Location = new System.Drawing.Point(689, 12);
			this.GOButton.Name = "GOButton";
			this.GOButton.Size = new System.Drawing.Size(75, 30);
			this.GOButton.TabIndex = 9;
			this.GOButton.Text = "GO";
			this.GOButton.UseVisualStyleBackColor = true;
			this.GOButton.Click += new System.EventHandler(this.GOButton_Click);
			// 
			// Output
			// 
			this.Output.AcceptsReturn = true;
			this.Output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Output.Location = new System.Drawing.Point(12, 99);
			this.Output.Multiline = true;
			this.Output.Name = "Output";
			this.Output.ReadOnly = true;
			this.Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.Output.Size = new System.Drawing.Size(916, 293);
			this.Output.TabIndex = 10;
			// 
			// GasConstant
			// 
			this.GasConstant.AllowDrop = true;
			this.GasConstant.FormattingEnabled = true;
			this.GasConstant.Items.AddRange(new object[] {
            "8,314 J/(mol*K)",
            "8,314 m³*Pa/(mol*K)",
            "8,314 L*kPa/(mol*K)",
            "8314 J/(kmol*K)",
            "8314 cm³*kPa/(mol*K)",
            "0,00008314 m³*bar/(mol*K)",
            "0,08314 L*bar/(mol*K)",
            "0,082057 L*atm/(mol*K)",
            "82,057 cm³*atm/(mol*K)"});
			this.GasConstant.Location = new System.Drawing.Point(31, 15);
			this.GasConstant.Name = "GasConstant";
			this.GasConstant.Size = new System.Drawing.Size(121, 21);
			this.GasConstant.TabIndex = 11;
			this.GasConstant.Text = "8,314 J/(mol*K)";
			// 
			// Requals
			// 
			this.Requals.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Requals.Location = new System.Drawing.Point(3, 18);
			this.Requals.Multiline = true;
			this.Requals.Name = "Requals";
			this.Requals.ReadOnly = true;
			this.Requals.Size = new System.Drawing.Size(22, 19);
			this.Requals.TabIndex = 12;
			this.Requals.Text = "R  =";
			this.Requals.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.Requals.TextChanged += new System.EventHandler(this.Requals_TextChanged);
			// 
			// Temp
			// 
			this.Temp.AllowDrop = true;
			this.Temp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Temp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Temp.Location = new System.Drawing.Point(817, 65);
			this.Temp.Margin = new System.Windows.Forms.Padding(0);
			this.Temp.Name = "Temp";
			this.Temp.Size = new System.Drawing.Size(54, 13);
			this.Temp.TabIndex = 7;
			this.Temp.Text = "298";
			this.Temp.TextChanged += new System.EventHandler(this.Temp_TextChanged);
			this.Temp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Temp_KeyDown);
			this.Temp.Leave += new System.EventHandler(this.Temp_Leave);
			// 
			// EqConstBox
			// 
			this.EqConstBox.AllowDrop = true;
			this.EqConstBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.EqConstBox.Location = new System.Drawing.Point(30, 17);
			this.EqConstBox.Margin = new System.Windows.Forms.Padding(0);
			this.EqConstBox.Name = "EqConstBox";
			this.EqConstBox.Size = new System.Drawing.Size(139, 13);
			this.EqConstBox.TabIndex = 13;
			this.EqConstBox.Text = "Undefined";
			this.EqConstBox.WordWrap = false;
			// 
			// KText
			// 
			this.KText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KText.Location = new System.Drawing.Point(7, 17);
			this.KText.Multiline = true;
			this.KText.Name = "KText";
			this.KText.ReadOnly = true;
			this.KText.Size = new System.Drawing.Size(20, 10);
			this.KText.TabIndex = 14;
			this.KText.Text = "K  =";
			this.KText.WordWrap = false;
			// 
			// KunitsAbove
			// 
			this.KunitsAbove.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KunitsAbove.Location = new System.Drawing.Point(173, 10);
			this.KunitsAbove.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.KunitsAbove.Multiline = true;
			this.KunitsAbove.Name = "KunitsAbove";
			this.KunitsAbove.ReadOnly = true;
			this.KunitsAbove.Size = new System.Drawing.Size(135, 13);
			this.KunitsAbove.TabIndex = 15;
			this.KunitsAbove.WordWrap = false;
			// 
			// KunitsBelow
			// 
			this.KunitsBelow.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.KunitsBelow.Location = new System.Drawing.Point(172, 26);
			this.KunitsBelow.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.KunitsBelow.Multiline = true;
			this.KunitsBelow.Name = "KunitsBelow";
			this.KunitsBelow.ReadOnly = true;
			this.KunitsBelow.Size = new System.Drawing.Size(135, 13);
			this.KunitsBelow.TabIndex = 16;
			this.KunitsBelow.WordWrap = false;
			// 
			// GasConstantGroup
			// 
			this.GasConstantGroup.Controls.Add(this.GasConstant);
			this.GasConstantGroup.Controls.Add(this.Requals);
			this.GasConstantGroup.Location = new System.Drawing.Point(406, 48);
			this.GasConstantGroup.Name = "GasConstantGroup";
			this.GasConstantGroup.Padding = new System.Windows.Forms.Padding(0);
			this.GasConstantGroup.Size = new System.Drawing.Size(160, 45);
			this.GasConstantGroup.TabIndex = 17;
			this.GasConstantGroup.TabStop = false;
			// 
			// Kgroup
			// 
			this.Kgroup.Controls.Add(this.EqConstBox);
			this.Kgroup.Controls.Add(this.KText);
			this.Kgroup.Controls.Add(this.KunitsBelow);
			this.Kgroup.Controls.Add(this.KunitsAbove);
			this.Kgroup.Controls.Add(this.Line);
			this.Kgroup.Location = new System.Drawing.Point(12, 48);
			this.Kgroup.Name = "Kgroup";
			this.Kgroup.Size = new System.Drawing.Size(310, 45);
			this.Kgroup.TabIndex = 18;
			this.Kgroup.TabStop = false;
			// 
			// Line
			// 
			this.Line.ErrorImage = null;
			this.Line.Image = global::Therm.Properties.Resources.Line;
			this.Line.Location = new System.Drawing.Point(172, 23);
			this.Line.Name = "Line";
			this.Line.Size = new System.Drawing.Size(123, 10);
			this.Line.TabIndex = 17;
			this.Line.TabStop = false;
			// 
			// helpButton
			// 
			this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpButton.Location = new System.Drawing.Point(689, 48);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(75, 30);
			this.helpButton.TabIndex = 20;
			this.helpButton.Text = "Help!";
			this.helpButton.UseVisualStyleBackColor = true;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 404);
			this.Controls.Add(this.helpButton);
			this.Controls.Add(this.Kgroup);
			this.Controls.Add(this.GasConstantGroup);
			this.Controls.Add(this.Output);
			this.Controls.Add(this.GOButton);
			this.Controls.Add(this.FormulaBox);
			this.Controls.Add(this.Temp);
			this.Controls.Add(this.DeltaGT);
			this.Controls.Add(this.DeltaG);
			this.Controls.Add(this.DeltaS);
			this.Controls.Add(this.DeltaH);
			this.Controls.Add(this.Units);
			this.Controls.Add(this.DeltaName);
			this.Name = "Main";
			this.Text = "Thermodynamics. Because you are lazy";
			this.GasConstantGroup.ResumeLayout(false);
			this.GasConstantGroup.PerformLayout();
			this.Kgroup.ResumeLayout(false);
			this.Kgroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Line)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox DeltaName;
		private System.Windows.Forms.TextBox Units;
		private System.Windows.Forms.TextBox DeltaH;
		private System.Windows.Forms.TextBox DeltaS;
		private System.Windows.Forms.TextBox DeltaG;
		private System.Windows.Forms.TextBox DeltaGT;
		private System.Windows.Forms.TextBox FormulaBox;
		private System.Windows.Forms.Button GOButton;
		public System.Windows.Forms.TextBox Output;
		private System.Windows.Forms.ComboBox GasConstant;
		private System.Windows.Forms.TextBox Requals;
		private System.Windows.Forms.TextBox Temp;
		private System.Windows.Forms.TextBox EqConstBox;
		private System.Windows.Forms.TextBox KText;
		private System.Windows.Forms.TextBox KunitsAbove;
		private System.Windows.Forms.TextBox KunitsBelow;
		private System.Windows.Forms.GroupBox GasConstantGroup;
		private System.Windows.Forms.GroupBox Kgroup;
		private System.Windows.Forms.PictureBox Line;
		private System.Windows.Forms.Button helpButton;
	}
}

