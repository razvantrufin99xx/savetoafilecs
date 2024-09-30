/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/29/2024
 * Time: 3:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace xmlreader
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			setlabelText("Nume : ",ref this.label1);
			setlabelText("Prenume : ",ref this.label2);
			setlabelText("Telefon : ",ref this.label3);
			
		}
		
		public bool setlabelText(string s, ref Label l)
		{
			l.Text = s;
			
			return true;
		}
		void Button1Click(object sender, EventArgs e)
		{
			FileStream f;
			try{
			f = new FileStream(this.textBox4.Text,FileMode.CreateNew);
			f.Close();
			}
			catch{};
			
			f = new FileStream(this.textBox4.Text,FileMode.Append);
			char[] x = new char[this.textBox1.Left + this.textBox2.Left + this.textBox3.Left + 10];
			string y = this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text + ";";
			
			x = y.ToCharArray();
			
			
			for(int i = 0 ; i < x.Length;  i++)
			{
				f.WriteByte((byte)x[i]);
			}
			f.Close();
		
		}
		
	}
}
