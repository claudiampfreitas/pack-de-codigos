using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace JogoSnake
{
	public partial class MainForm : Form
	{
		private const int CellSize = 20; // Tamanho de cada célula do campo de jogo
		private const int FieldWidth = 555 / CellSize; // Largura do campo de jogo em células
		private const int FieldHeight = 287 / CellSize; // Altura do campo de jogo em células

		private List<Point> snake; // Lista de pontos que representa a cobra
		private Point food; // Posição da comida
		private Direction direction; // Direção atual da cobra

		private enum Direction
		{
			Up,
			Down,
			Left,
			Right
		}

		public MainForm()
		{
			InitializeComponent();

			this.KeyDown += MainForm_KeyDown;

			// Inicialize a lista de pontos da cobra com um ponto inicial
			snake = new List<Point>();
			snake.Add(new Point(FieldWidth / 2, FieldHeight / 2));

			// Defina a posição inicial da comida
			food = GenerateFoodPosition();

			// Defina a direção inicial da cobra
			direction = Direction.Right;

			panelSnake.Paint += PanelSnakePaint;
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Up:
					direction = Direction.Up;
					break;
				case Keys.Down:
					direction = Direction.Down;
					break;
				case Keys.Left:
					direction = Direction.Left;
					break;
				case Keys.Right:
					direction = Direction.Right;
					break;
			}
		}

		private Point GenerateFoodPosition()
		{
			Random random = new Random();
			int x = random.Next(0, FieldWidth);
			int y = random.Next(0, FieldHeight);
			return new Point(x, y);
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			// Atualize a posição da cabeça da cobra com base na direção atual
			Point head = snake[0];
			switch (direction)
			{
				case Direction.Up:
					head.Y--;
					break;
				case Direction.Down:
					head.Y++;
					break;
				case Direction.Left:
					head.X--;
					break;
				case Direction.Right:
					head.X++;
					break;
			}

			// Verifique se a cobra colidiu com a comida
			if (head == food)
			{
				// Aumente o tamanho da cobra e gere uma nova posição para a comida
				snake.Insert(0, head);
				food = GenerateFoodPosition();
			}
			else
			{
				// Remova a última parte da cauda da cobra
				snake.RemoveAt(snake.Count - 1);

				// Verifique se a cobra colidiu consigo mesma
				if (snake.Contains(head))
				{
					// A cobra colidiu consigo mesma, termina o jogo
					// Exiba uma mensagem de fim de jogo e reinicie o jogo.
					timer1.Stop();
					MessageBox.Show("Game Over");
					RestartGame();
					return;
				}
				else if (head.X < 0 || head.X >= FieldWidth || head.Y < 0 || head.Y >= FieldHeight ||
				         head.X >= panelSnake.Width / CellSize || head.Y >= panelSnake.Height / CellSize)
				{
					// A cobra colidiu com as bordas do campo ou com as bordas da panel, termina o jogo
					// Exiba uma mensagem de fim de jogo e reinicie o jogo.
					timer1.Stop();
					MessageBox.Show("Game Over");
					RestartGame();
					return;
				}
				else
				{
					// A cobra não colidiu com a comida nem consigo mesma nem com as bordas do campo,
					// então atualize a posição da cabeça da cobra
					snake.Insert(0, head);
				}
			}

			// Redesenha o campo de jogo
			panelSnake.Invalidate();
		}

		private void RestartGame()
		{
			// Reinicialize a posição inicial da cobra, comida e direção
			snake.Clear();
			snake.Add(new Point(FieldWidth / 2, FieldHeight / 2));
			food = GenerateFoodPosition();
			direction = Direction.Right;

			// Reinicie o temporizador
			timer1.Start();
		}

		void PanelSnakePaint(object sender, PaintEventArgs e)
		{
			// Limpe o campo de jogo
			e.Graphics.Clear(Color.White);

			// Desenhe a cobra
			foreach (Point point in snake)
			{
				Rectangle rect = new Rectangle(point.X * CellSize, point.Y * CellSize, CellSize, CellSize);
				e.Graphics.FillRectangle(Brushes.Green, rect);
			}

			// Desenhe a comida
			Rectangle foodRect = new Rectangle(food.X * CellSize, food.Y * CellSize, CellSize, CellSize);
			e.Graphics.FillEllipse(Brushes.Red, foodRect);
		}

		private void BtnStartClick(object sender, EventArgs e)
		{
			StartGame();
			btnStart.Enabled = false; // Desabilita o botão "Iniciar" após o início do jogo
		}

		private void StartGame()
		{
			// Inicie o temporizador para atualizar o movimento da cobra
			timer1.Interval = 200; // Intervalo em milissegundos
			timer1.Tick += Timer1_Tick;
			timer1.Start();

			// Associe o evento KeyDown do formulário novamente após iniciar o jogo
			this.KeyDown += MainForm_KeyDown;
		}
	}
}