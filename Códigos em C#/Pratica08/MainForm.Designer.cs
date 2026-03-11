/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 13/03/2023
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pratica08
{
	partial class FrmPratica08
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.CMBTAMANHO = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TXTPIZZA = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TXTOPCIONAIS = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TXTTOTAL = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.CHKOVO = new System.Windows.Forms.CheckBox();
			this.CHKMILHO = new System.Windows.Forms.CheckBox();
			this.CHKBACON = new System.Windows.Forms.CheckBox();
			this.CHKBORDA = new System.Windows.Forms.CheckBox();
			this.BTNCALCULAR = new System.Windows.Forms.Button();
			this.BTNLIMPAR = new System.Windows.Forms.Button();
			this.BTNSAIR = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CMBTAMANHO
			// 
			this.CMBTAMANHO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CMBTAMANHO.FormattingEnabled = true;
			this.CMBTAMANHO.Location = new System.Drawing.Point(26, 23);
			this.CMBTAMANHO.Name = "CMBTAMANHO";
			this.CMBTAMANHO.Size = new System.Drawing.Size(217, 26);
			this.CMBTAMANHO.TabIndex = 0;
			this.CMBTAMANHO.Text = "Escolha tamanho da pizza";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Valor da pizza";
			// 
			// TXTPIZZA
			// 
			this.TXTPIZZA.Enabled = false;
			this.TXTPIZZA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXTPIZZA.Location = new System.Drawing.Point(12, 152);
			this.TXTPIZZA.Name = "TXTPIZZA";
			this.TXTPIZZA.Size = new System.Drawing.Size(141, 26);
			this.TXTPIZZA.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 179);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Valor dos opcionais";
			// 
			// TXTOPCIONAIS
			// 
			this.TXTOPCIONAIS.Enabled = false;
			this.TXTOPCIONAIS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXTOPCIONAIS.Location = new System.Drawing.Point(12, 206);
			this.TXTOPCIONAIS.Name = "TXTOPCIONAIS";
			this.TXTOPCIONAIS.Size = new System.Drawing.Size(141, 26);
			this.TXTOPCIONAIS.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 233);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Total a pagar";
			// 
			// TXTTOTAL
			// 
			this.TXTTOTAL.Enabled = false;
			this.TXTTOTAL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXTTOTAL.Location = new System.Drawing.Point(12, 260);
			this.TXTTOTAL.Name = "TXTTOTAL";
			this.TXTTOTAL.Size = new System.Drawing.Size(141, 26);
			this.TXTTOTAL.TabIndex = 6;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.CHKOVO);
			this.groupBox1.Controls.Add(this.CHKMILHO);
			this.groupBox1.Controls.Add(this.CHKBACON);
			this.groupBox1.Controls.Add(this.CHKBORDA);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(276, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(269, 145);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Escolha opcionais";
			// 
			// CHKOVO
			// 
			this.CHKOVO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CHKOVO.Location = new System.Drawing.Point(16, 95);
			this.CHKOVO.Name = "CHKOVO";
			this.CHKOVO.Size = new System.Drawing.Size(144, 24);
			this.CHKOVO.TabIndex = 3;
			this.CHKOVO.Text = "Ovo – R$ 1,75";
			this.CHKOVO.UseVisualStyleBackColor = true;
			// 
			// CHKMILHO
			// 
			this.CHKMILHO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CHKMILHO.Location = new System.Drawing.Point(16, 75);
			this.CHKMILHO.Name = "CHKMILHO";
			this.CHKMILHO.Size = new System.Drawing.Size(144, 24);
			this.CHKMILHO.TabIndex = 2;
			this.CHKMILHO.Text = "Milho – R$ 2,50";
			this.CHKMILHO.UseVisualStyleBackColor = true;
			// 
			// CHKBACON
			// 
			this.CHKBACON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CHKBACON.Location = new System.Drawing.Point(16, 51);
			this.CHKBACON.Name = "CHKBACON";
			this.CHKBACON.Size = new System.Drawing.Size(156, 24);
			this.CHKBACON.TabIndex = 1;
			this.CHKBACON.Text = "Bacon – R$ 4,00";
			this.CHKBACON.UseVisualStyleBackColor = true;
			// 
			// CHKBORDA
			// 
			this.CHKBORDA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CHKBORDA.Location = new System.Drawing.Point(16, 30);
			this.CHKBORDA.Name = "CHKBORDA";
			this.CHKBORDA.Size = new System.Drawing.Size(219, 24);
			this.CHKBORDA.TabIndex = 0;
			this.CHKBORDA.Text = "Borda recheada – R$5,00";
			this.CHKBORDA.UseVisualStyleBackColor = true;
			// 
			// BTNCALCULAR
			// 
			this.BTNCALCULAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNCALCULAR.Location = new System.Drawing.Point(278, 182);
			this.BTNCALCULAR.Name = "BTNCALCULAR";
			this.BTNCALCULAR.Size = new System.Drawing.Size(85, 30);
			this.BTNCALCULAR.TabIndex = 8;
			this.BTNCALCULAR.Text = "Calcular";
			this.BTNCALCULAR.UseVisualStyleBackColor = true;
			this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULARClick);
			// 
			// BTNLIMPAR
			// 
			this.BTNLIMPAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNLIMPAR.Location = new System.Drawing.Point(369, 182);
			this.BTNLIMPAR.Name = "BTNLIMPAR";
			this.BTNLIMPAR.Size = new System.Drawing.Size(85, 30);
			this.BTNLIMPAR.TabIndex = 9;
			this.BTNLIMPAR.Text = "Novo";
			this.BTNLIMPAR.UseVisualStyleBackColor = true;
			this.BTNLIMPAR.Click += new System.EventHandler(this.BTNLIMPARClick);
			// 
			// BTNSAIR
			// 
			this.BTNSAIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNSAIR.Location = new System.Drawing.Point(460, 182);
			this.BTNSAIR.Name = "BTNSAIR";
			this.BTNSAIR.Size = new System.Drawing.Size(85, 30);
			this.BTNSAIR.TabIndex = 10;
			this.BTNSAIR.Text = "Sair";
			this.BTNSAIR.UseVisualStyleBackColor = true;
			this.BTNSAIR.Click += new System.EventHandler(this.BTNSAIRClick);
			// 
			// FrmPratica08
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(561, 309);
			this.Controls.Add(this.BTNSAIR);
			this.Controls.Add(this.BTNLIMPAR);
			this.Controls.Add(this.BTNCALCULAR);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.TXTTOTAL);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.TXTOPCIONAIS);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TXTPIZZA);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CMBTAMANHO);
			this.Name = "FrmPratica08";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pizzaria X";
			this.Load += new System.EventHandler(this.FrmPratica08Load);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button BTNSAIR;
		private System.Windows.Forms.Button BTNLIMPAR;
		private System.Windows.Forms.Button BTNCALCULAR;
		private System.Windows.Forms.CheckBox CHKBORDA;
		private System.Windows.Forms.CheckBox CHKBACON;
		private System.Windows.Forms.CheckBox CHKMILHO;
		private System.Windows.Forms.CheckBox CHKOVO;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TXTTOTAL;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TXTOPCIONAIS;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TXTPIZZA;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CMBTAMANHO;
	}
}
