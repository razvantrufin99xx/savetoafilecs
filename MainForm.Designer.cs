﻿/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 3:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace xmlreader
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "save to file ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(181, 103);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(289, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "nume";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(47, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(47, 146);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "label2";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(181, 146);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(289, 20);
			this.textBox2.TabIndex = 3;
			this.textBox2.Text = "prenume";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(47, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "label3";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(181, 201);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(289, 20);
			this.textBox3.TabIndex = 5;
			this.textBox3.Text = "telefon";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(181, 38);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(289, 20);
			this.textBox4.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1245, 606);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "xmlreader";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
