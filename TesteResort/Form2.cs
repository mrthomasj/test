/*
 * Created by SharpDevelop.
 * User: dell i5
 * Date: 23/11/2018
 * Time: 03:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TesteResort
{
	/// <summary>
	/// Description of Form2.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            btnRes.Height = pnClick.Height;
            pnClick.Top = btnRes.Top;
            controleReserva1.BringToFront();
            panelRes.BringToFront();

        }

        private void btnQrt_Click(object sender, EventArgs e)
        {
            quartos1.BringToFront();
                
            btnQrt.Height = pnClick.Height;
            pnClick.Top = btnQrt.Top;
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            btnEx.Height = pnClick.Height;
            pnClick.Top = btnEx.Top;
            extras1.BringToFront();
        }

     
        private void btnPac_Click(object sender, EventArgs e)
        {
            btnPac.Height = pnClick.Height;
            pnClick.Top = btnPac.Top;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cadFunc1.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
            btnHome.Height = pnClick.Height;
            pnClick.Top = btnHome.Top;
            panelIni.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadFunc1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            controleReserva1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reserva1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }
    }
}
