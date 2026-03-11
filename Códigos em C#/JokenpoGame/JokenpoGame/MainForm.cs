using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JokenpoGame
{
	public partial class MainForm : Form
	{
		private string[] choices = { "Pedra", "Papel", "Tesoura" };
		
		public MainForm()
		{
			InitializeComponent();
		}
		void BtnRockClick(object sender, EventArgs e)
		{
			PlayGame("Pedra");
		}
		void BtnPaperClick(object sender, EventArgs e)
		{
			PlayGame("Papel");
		}
		void BtnScissorsClick(object sender, EventArgs e)
		{
			PlayGame("Tesoura");
		}
		private void PlayGame(string playerChoice)
        {
            Random random = new Random();
            int index = random.Next(choices.Length);
            string computerChoice = choices[index];

            // Exibir as escolhas do jogador e do computador nas Labels
            lbEscolhaJogador.Text = "O jogador escolheu: " + playerChoice;
            lbEscolhaComputador.Text = "O computador escolheu: " + computerChoice;

            // Determinar o resultado do jogo
            if (playerChoice == computerChoice)
            {
                lbResult.Text = "Empate!";
            }
            else if (
                (playerChoice == "Pedra" && computerChoice == "Tesoura") ||
                (playerChoice == "Papel" && computerChoice == "Pedra") ||
                (playerChoice == "Tesoura" && computerChoice == "Papel")
            )
            {
                lbResult.Text = "Você venceu!";
            }
            else
            {
                lbResult.Text = "Você perdeu!";
            }
        }
	}
}
