/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 15/11/2018
 * Time: 23:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TesteResort
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
		void Button1Click(object sender, EventArgs e)
		{	
			Form1 frmIni = new Form1();
			frmIni.ShowDialog();
			
			
	
		}
		void BtnSairClick(object sender, EventArgs e)
		{
			this.Dispose();
		}
	}
}
