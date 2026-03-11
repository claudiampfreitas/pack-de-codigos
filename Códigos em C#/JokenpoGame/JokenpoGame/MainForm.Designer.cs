/*
 * Criado por SharpDevelop.
 * Usuário: Diogo Freitas
 * Data: 04/06/2023
 * Hora: 16:49
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace JokenpoGame
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnPaper;
		private System.Windows.Forms.Button btnRock;
		private System.Windows.Forms.Button btnScissors;
		private System.Windows.Forms.Label lbResult;
		private System.Windows.Forms.Label lbEscolhaJogador;
		private System.Windows.Forms.Label lbEscolhaComputador;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnRock = new System.Windows.Forms.Button();
			this.btnScissors = new System.Windows.Forms.Button();
			this.lbResult = new System.Windows.Forms.Label();
			this.btnPaper = new System.Windows.Forms.Button();
			this.lbEscolhaJogador = new System.Windows.Forms.Label();
			this.lbEscolhaComputador = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRock
			// 
			this.btnRock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRock.BackgroundImage")));
			this.btnRock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnRock.Location = new System.Drawing.Point(186, 106);
			this.btnRock.Name = "btnRock";
			this.btnRock.Size = new System.Drawing.Size(115, 109);
			this.btnRock.TabIndex = 1;
			this.btnRock.UseVisualStyleBackColor = true;
			this.btnRock.Click += new System.EventHandler(this.BtnRockClick);
			// 
			// btnScissors
			// 
			this.btnScissors.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnScissors.BackgroundImage")));
			this.btnScissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnScissors.Location = new System.Drawing.Point(351, 106);
			this.btnScissors.Name = "btnScissors";
			this.btnScissors.Size = new System.Drawing.Size(124, 109);
			this.btnScissors.TabIndex = 2;
			this.btnScissors.UseVisualStyleBackColor = true;
			this.btnScissors.Click += new System.EventHandler(this.BtnScissorsClick);
			// 
			// lbResult
			// 
			this.lbResult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbResult.Location = new System.Drawing.Point(13, 241);
			this.lbResult.Name = "lbResult";
			this.lbResult.Size = new System.Drawing.Size(462, 23);
			this.lbResult.TabIndex = 5;
			this.lbResult.Text = "Resultado do jogo:";
			// 
			// btnPaper
			// 
			this.btnPaper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaper.BackgroundImage")));
			this.btnPaper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnPaper.Location = new System.Drawing.Point(12, 106);
			this.btnPaper.Name = "btnPaper";
			this.btnPaper.Size = new System.Drawing.Size(125, 109);
			this.btnPaper.TabIndex = 0;
			this.btnPaper.UseVisualStyleBackColor = true;
			this.btnPaper.Click += new System.EventHandler(this.BtnPaperClick);
			// 
			// lbEscolhaJogador
			// 
			this.lbEscolhaJogador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEscolhaJogador.Location = new System.Drawing.Point(23, 34);
			this.lbEscolhaJogador.Name = "lbEscolhaJogador";
			this.lbEscolhaJogador.Size = new System.Drawing.Size(299, 27);
			this.lbEscolhaJogador.TabIndex = 8;
			this.lbEscolhaJogador.Text = "O jogador escolheu:";
			// 
			// lbEscolhaComputador
			// 
			this.lbEscolhaComputador.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbEscolhaComputador.Location = new System.Drawing.Point(23, 61);
			this.lbEscolhaComputador.Name = "lbEscolhaComputador";
			this.lbEscolhaComputador.Size = new System.Drawing.Size(299, 27);
			this.lbEscolhaComputador.TabIndex = 9;
			this.lbEscolhaComputador.Text = "O computador escolheu:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(496, 292);
			this.Controls.Add(this.lbEscolhaComputador);
			this.Controls.Add(this.lbEscolhaJogador);
			this.Controls.Add(this.lbResult);
			this.Controls.Add(this.btnScissors);
			this.Controls.Add(this.btnRock);
			this.Controls.Add(this.btnPaper);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pedra, papel, tesoura";
			this.ResumeLayout(false);

		}
	}
}
