/*
 * Created by SharpDevelop.
 * User: POLIMIG
 * Date: 06/03/2023
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Pratica05
{
	partial class FrmPratica05
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TXTVALOR = new System.Windows.Forms.TextBox();
			this.TXTIPVA = new System.Windows.Forms.TextBox();
			this.BTNCALCULAR = new System.Windows.Forms.Button();
			this.BTNNOVO = new System.Windows.Forms.Button();
			this.BTNSAIR = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.OPTCAT4 = new System.Windows.Forms.RadioButton();
			this.OPTCAT3 = new System.Windows.Forms.RadioButton();
			this.OPTCAT2 = new System.Windows.Forms.RadioButton();
			this.OPTCAT1 = new System.Windows.Forms.RadioButton();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Digite o valor do veículo";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(44, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Valor do IPVA";
			// 
			// TXTVALOR
			// 
			this.TXTVALOR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXTVALOR.Location = new System.Drawing.Point(44, 69);
			this.TXTVALOR.Name = "TXTVALOR";
			this.TXTVALOR.Size = new System.Drawing.Size(180, 26);
			this.TXTVALOR.TabIndex = 2;
			// 
			// TXTIPVA
			// 
			this.TXTIPVA.Enabled = false;
			this.TXTIPVA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TXTIPVA.Location = new System.Drawing.Point(44, 145);
			this.TXTIPVA.Name = "TXTIPVA";
			this.TXTIPVA.Size = new System.Drawing.Size(180, 26);
			this.TXTIPVA.TabIndex = 3;
			// 
			// BTNCALCULAR
			// 
			this.BTNCALCULAR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNCALCULAR.Location = new System.Drawing.Point(44, 254);
			this.BTNCALCULAR.Name = "BTNCALCULAR";
			this.BTNCALCULAR.Size = new System.Drawing.Size(88, 28);
			this.BTNCALCULAR.TabIndex = 4;
			this.BTNCALCULAR.Text = "Calcular";
			this.BTNCALCULAR.UseVisualStyleBackColor = true;
			this.BTNCALCULAR.Click += new System.EventHandler(this.BTNCALCULARClick);
			// 
			// BTNNOVO
			// 
			this.BTNNOVO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNNOVO.Location = new System.Drawing.Point(223, 254);
			this.BTNNOVO.Name = "BTNNOVO";
			this.BTNNOVO.Size = new System.Drawing.Size(88, 28);
			this.BTNNOVO.TabIndex = 5;
			this.BTNNOVO.Text = "Novo";
			this.BTNNOVO.UseVisualStyleBackColor = true;
			this.BTNNOVO.Click += new System.EventHandler(this.BTNNOVOClick);
			// 
			// BTNSAIR
			// 
			this.BTNSAIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BTNSAIR.Location = new System.Drawing.Point(409, 254);
			this.BTNSAIR.Name = "BTNSAIR";
			this.BTNSAIR.Size = new System.Drawing.Size(88, 28);
			this.BTNSAIR.TabIndex = 6;
			this.BTNSAIR.Text = "Sair";
			this.BTNSAIR.UseVisualStyleBackColor = true;
			this.BTNSAIR.Click += new System.EventHandler(this.BTNSAIRClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.OPTCAT4);
			this.groupBox1.Controls.Add(this.OPTCAT3);
			this.groupBox1.Controls.Add(this.OPTCAT2);
			this.groupBox1.Controls.Add(this.OPTCAT1);
			this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(259, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 140);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Selecione categoria do veículo";
			// 
			// OPTCAT4
			// 
			this.OPTCAT4.Location = new System.Drawing.Point(23, 104);
			this.OPTCAT4.Name = "OPTCAT4";
			this.OPTCAT4.Size = new System.Drawing.Size(215, 24);
			this.OPTCAT4.TabIndex = 3;
			this.OPTCAT4.TabStop = true;
			this.OPTCAT4.Text = "Ônibus/ Caminhão/ Trator";
			this.OPTCAT4.UseVisualStyleBackColor = true;
			// 
			// OPTCAT3
			// 
			this.OPTCAT3.Location = new System.Drawing.Point(23, 83);
			this.OPTCAT3.Name = "OPTCAT3";
			this.OPTCAT3.Size = new System.Drawing.Size(223, 24);
			this.OPTCAT3.TabIndex = 2;
			this.OPTCAT3.TabStop = true;
			this.OPTCAT3.Text = "Taxi/ Escolar/ Moto";
			this.OPTCAT3.UseVisualStyleBackColor = true;
			// 
			// OPTCAT2
			// 
			this.OPTCAT2.Location = new System.Drawing.Point(23, 63);
			this.OPTCAT2.Name = "OPTCAT2";
			this.OPTCAT2.Size = new System.Drawing.Size(161, 24);
			this.OPTCAT2.TabIndex = 1;
			this.OPTCAT2.TabStop = true;
			this.OPTCAT2.Text = "Pickup/ Furgão";
			this.OPTCAT2.UseVisualStyleBackColor = true;
			// 
			// OPTCAT1
			// 
			this.OPTCAT1.Location = new System.Drawing.Point(23, 43);
			this.OPTCAT1.Name = "OPTCAT1";
			this.OPTCAT1.Size = new System.Drawing.Size(175, 24);
			this.OPTCAT1.TabIndex = 0;
			this.OPTCAT1.TabStop = true;
			this.OPTCAT1.Text = "Passeio/ Utilitário";
			this.OPTCAT1.UseVisualStyleBackColor = true;
			// 
			// FrmPratica05
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSalmon;
			this.ClientSize = new System.Drawing.Size(580, 315);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BTNSAIR);
			this.Controls.Add(this.BTNNOVO);
			this.Controls.Add(this.BTNCALCULAR);
			this.Controls.Add(this.TXTIPVA);
			this.Controls.Add(this.TXTVALOR);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmPratica05";
			this.Text = "Cálculo de IPVA";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RadioButton OPTCAT1;
		private System.Windows.Forms.RadioButton OPTCAT2;
		private System.Windows.Forms.RadioButton OPTCAT3;
		private System.Windows.Forms.RadioButton OPTCAT4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BTNSAIR;
		private System.Windows.Forms.Button BTNNOVO;
		private System.Windows.Forms.Button BTNCALCULAR;
		private System.Windows.Forms.TextBox TXTIPVA;
		private System.Windows.Forms.TextBox TXTVALOR;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
