
namespace pratica10
{
	partial class FrmPratica10
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
			this.components = new System.ComponentModel.Container();
			this.LblHora = new System.Windows.Forms.Label();
			this.RbtNegrito = new System.Windows.Forms.RadioButton();
			this.RbtItalico = new System.Windows.Forms.RadioButton();
			this.RbtSublinhado = new System.Windows.Forms.RadioButton();
			this.TmrRelogio = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// LblHora
			// 
			this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LblHora.Location = new System.Drawing.Point(24, 35);
			this.LblHora.Name = "LblHora";
			this.LblHora.Size = new System.Drawing.Size(228, 65);
			this.LblHora.TabIndex = 0;
			this.LblHora.Text = "label1";
			// 
			// RbtNegrito
			// 
			this.RbtNegrito.Location = new System.Drawing.Point(13, 118);
			this.RbtNegrito.Name = "RbtNegrito";
			this.RbtNegrito.Size = new System.Drawing.Size(89, 24);
			this.RbtNegrito.TabIndex = 1;
			this.RbtNegrito.TabStop = true;
			this.RbtNegrito.Text = "Negrito";
			this.RbtNegrito.UseVisualStyleBackColor = true;
			this.RbtNegrito.CheckedChanged += new System.EventHandler(this.RbtNegritoCheckedChanged);
			// 
			// RbtItalico
			// 
			this.RbtItalico.Location = new System.Drawing.Point(108, 118);
			this.RbtItalico.Name = "RbtItalico";
			this.RbtItalico.Size = new System.Drawing.Size(86, 24);
			this.RbtItalico.TabIndex = 2;
			this.RbtItalico.TabStop = true;
			this.RbtItalico.Text = "Itálico";
			this.RbtItalico.UseVisualStyleBackColor = true;
			this.RbtItalico.CheckedChanged += new System.EventHandler(this.RbtItalicoCheckedChanged);
			// 
			// RbtSublinhado
			// 
			this.RbtSublinhado.Location = new System.Drawing.Point(185, 118);
			this.RbtSublinhado.Name = "RbtSublinhado";
			this.RbtSublinhado.Size = new System.Drawing.Size(104, 24);
			this.RbtSublinhado.TabIndex = 3;
			this.RbtSublinhado.TabStop = true;
			this.RbtSublinhado.Text = "Sublinhado";
			this.RbtSublinhado.UseVisualStyleBackColor = true;
			this.RbtSublinhado.CheckedChanged += new System.EventHandler(this.RbtSublinhadoCheckedChanged);
			// 
			// TmrRelogio
			// 
			this.TmrRelogio.Enabled = true;
			this.TmrRelogio.Interval = 1000;
			this.TmrRelogio.Tick += new System.EventHandler(this.TmrRelogioTick);
			// 
			// FrmPratica10
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(294, 213);
			this.Controls.Add(this.RbtSublinhado);
			this.Controls.Add(this.RbtItalico);
			this.Controls.Add(this.RbtNegrito);
			this.Controls.Add(this.LblHora);
			this.Name = "FrmPratica10";
			this.Text = "Pratica 10 – Trabalhando com timer";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer TmrRelogio;
		private System.Windows.Forms.RadioButton RbtSublinhado;
		private System.Windows.Forms.RadioButton RbtItalico;
		private System.Windows.Forms.RadioButton RbtNegrito;
		private System.Windows.Forms.Label LblHora;
	}
}
