/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 04/06/2023
 * Hora: 20:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JogoSnake
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panelSnake;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnStart;
		
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
			this.panelSnake = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panelSnake
			// 
			this.panelSnake.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.panelSnake.Location = new System.Drawing.Point(23, 70);
			this.panelSnake.Name = "panelSnake";
			this.panelSnake.Size = new System.Drawing.Size(555, 287);
			this.panelSnake.TabIndex = 0;
			this.panelSnake.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelSnakePaint);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(425, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Jogo da Cobrinha - Versão moderna";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(476, 25);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 33);
			this.btnStart.TabIndex = 2;
			this.btnStart.Text = "Iniciar";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStartClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(599, 390);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panelSnake);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Jogo Snake";
			this.ResumeLayout(false);

		}
	}
}
