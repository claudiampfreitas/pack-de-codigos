using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pratica05
{
	public partial class FrmPratica05 : Form
	{
		public FrmPratica05()
		{
			InitializeComponent();
		}
		
		void BTNCALCULARClick(object sender, EventArgs e)
		{
			double VALOR, IPVA=0;
			VALOR = Convert.ToDouble(TXTVALOR.Text);
			if (OPTCAT1.Checked == true)
				IPVA = VALOR * 0.04;
			else if (OPTCAT2.Checked == true)
				IPVA = VALOR * 0.03;
			else if (OPTCAT3.Checked == true)
				IPVA = VALOR * 0.02;
			else if (OPTCAT4.Checked == true)
				IPVA = VALOR * 0.01;
			TXTIPVA.Text = Convert.ToString(IPVA);
		}
		
		void BTNNOVOClick(object sender, EventArgs e)
		{
			TXTVALOR.Clear();
			TXTIPVA.Clear();
			OPTCAT1.Checked = false;
			OPTCAT2.Checked = false;
			OPTCAT3.Checked = false;
			OPTCAT4.Checked = false;
			TXTVALOR.Focus();
		}
		
		void BTNSAIRClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
