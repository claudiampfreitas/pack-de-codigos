using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pratica08
{
	public partial class FrmPratica08 : Form
	{
		public FrmPratica08()
		{
			InitializeComponent();
		}
		
		void FrmPratica08Load(object sender, EventArgs e)
		{
			CMBTAMANHO.Items.Add("Pequena – R$ 15,00");
			CMBTAMANHO.Items.Add("Média – R$ 20,00");
			CMBTAMANHO.Items.Add("Grande – R$ 25,00");
		}
		
		void BTNCALCULARClick(object sender, EventArgs e)
		{
			double VPIZZA=0, VOPCIONAIS=0, VTOTAL=0;
			if (CMBTAMANHO.SelectedIndex == 0)
				VPIZZA = 15;
			else if (CMBTAMANHO.SelectedIndex == 1)
				VPIZZA = 20;
			else if (CMBTAMANHO.SelectedIndex == 2)
				VPIZZA = 25;
			if (CHKBORDA.Checked == true)
				VOPCIONAIS = VOPCIONAIS + 5;
			if (CHKBACON.Checked == true)
				VOPCIONAIS = VOPCIONAIS + 4;
			if (CHKMILHO.Checked == true)
				VOPCIONAIS = VOPCIONAIS + 2.5;
			if (CHKOVO.Checked == true)
				VOPCIONAIS = VOPCIONAIS + 1.75;
			VTOTAL = VPIZZA + VOPCIONAIS;
			TXTPIZZA.Text = Convert.ToString(VPIZZA);
			TXTOPCIONAIS.Text = Convert.ToString(VOPCIONAIS);
			TXTTOTAL.Text = Convert.ToString(VTOTAL);
		}
		
		void BTNLIMPARClick(object sender, EventArgs e)
		{
			CMBTAMANHO.SelectedIndex = -1;
			CMBTAMANHO.Text = "Escolha tamanho da pizza";
			TXTPIZZA.Clear();
			TXTOPCIONAIS.Clear();
			TXTTOTAL.Clear();
			CHKBORDA.Checked = false;
			CHKBACON.Checked = false;
			CHKMILHO.Checked = false;
			CHKOVO.Checked = false;
		}
		
		void BTNSAIRClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
