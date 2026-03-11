import tkinter as tk
from tkinter import messagebox
import random

class JogoDaVelha:
    def __init__(self):
        self.jogador_atual = "X"
        self.tabuleiro = [['', '', ''],
                          ['', '', ''],
                          ['', '', '']]
        self.janela = tk.Tk()
        self.janela.title("Jogo da Velha")
        self.janela.configure(bg="#FCE4EC")  # Cor de fundo rosa claro
        self.botoes = []

        for i in range(3):
            linha = []
            for j in range(3):
                botao = tk.Button(self.janela, text="", width=6, height=3, font=("Arial", 24),
                                  command=lambda row=i, column=j: self.clique_botao(row, column))
                botao.grid(row=i, column=j)
                linha.append(botao)
            self.botoes.append(linha)

    def clique_botao(self, row, column):
        if self.tabuleiro[row][column] == '':
            self.tabuleiro[row][column] = self.jogador_atual
            self.botoes[row][column].config(text=self.jogador_atual, state=tk.DISABLED)

            if self.jogador_atual == "X":
                self.botoes[row][column].config(foreground="red")
            else:
                self.botoes[row][column].config(foreground="blue")

            if self.verificar_vitoria():
                messagebox.showinfo("Fim de jogo", f"O jogador {self.jogador_atual} venceu!")
                self.reiniciar_jogo()
            elif self.verificar_empate():
                messagebox.showinfo("Fim de jogo", "Empate!")
                self.reiniciar_jogo()
            else:
                self.jogador_atual = "O" if self.jogador_atual == "X" else "X"
                if self.jogador_atual == "O":
                    self.realizar_jogada_ia()

    def realizar_jogada_ia(self):
        # Escolhe uma posição vazia aleatória para a jogada da IA
        posicoes_vazias = []
        for i in range(3):
            for j in range(3):
                if self.tabuleiro[i][j] == '':
                    posicoes_vazias.append((i, j))

        if posicoes_vazias:
            row, column = random.choice(posicoes_vazias)
            self.clique_botao(row, column)

    def verificar_vitoria(self):
        for i in range(3):
            if self.tabuleiro[i][0] == self.tabuleiro[i][1] == self.tabuleiro[i][2] != '':
                self.pintar_vitoria(i, 0, i, 1, i, 2)
                return True
            if self.tabuleiro[0][i] == self.tabuleiro[1][i] == self.tabuleiro[2][i] != '':
                self.pintar_vitoria(0, i, 1, i, 2, i)
                return True
        if self.tabuleiro[0][0] == self.tabuleiro[1][1] == self.tabuleiro[2][2] != '':
            self.pintar_vitoria(0, 0, 1, 1, 2, 2)
            return True
        if self.tabuleiro[0][2] == self.tabuleiro[1][1] == self.tabuleiro[2][0] != '':
            self.pintar_vitoria(0, 2, 1, 1, 2, 0)
            return True
        return False

    def pintar_vitoria(self, x1, y1, x2, y2, x3, y3):
        self.botoes[x1][y1].config(foreground="green")
        self.botoes[x2][y2].config(foreground="green")
        self.botoes[x3][y3].config(foreground="green")

    def verificar_empate(self):
        for linha in self.tabuleiro:
            if '' in linha:
                return False
        return True

    def reiniciar_jogo(self):
        self.janela.destroy()
        self.__init__()
        self.iniciar()

    def iniciar(self):
        self.janela.mainloop()

jogo = JogoDaVelha()
jogo.iniciar()
