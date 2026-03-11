import tkinter as tk
from tkinter import messagebox

class RestaUmGame:
    def __init__(self):
        self.board = [
            [-1, -1,  1,  1,  1, -1, -1],
            [-1, -1,  1,  1,  1, -1, -1],
            [ 1,  1,  1,  1,  1,  1,  1],
            [ 1,  1,  1,  0,  1,  1,  1],
            [ 1,  1,  1,  1,  1,  1,  1],
            [-1, -1,  1,  1,  1, -1, -1],
            [-1, -1,  1,  1,  1, -1, -1]
        ]
        self.selected_piece = None

    def get_valid_moves(self, row, col):
        valid_moves = []

        # Check left move
        if col >= 2 and self.board[row][col - 2] == 1 and self.board[row][col - 1] == 1:
            valid_moves.append((row, col - 2))

        # Check right move
        if col <= 4 and self.board[row][col + 2] == 1 and self.board[row][col + 1] == 1:
            valid_moves.append((row, col + 2))

        # Check up move
        if row >= 2 and self.board[row - 2][col] == 1 and self.board[row - 1][col] == 1:
            valid_moves.append((row - 2, col))

        # Check down move
        if row <= 4 and self.board[row + 2][col] == 1 and self.board[row + 1][col] == 1:
            valid_moves.append((row + 2, col))

        return valid_moves

    def make_move(self, row, col):
        if self.selected_piece:
            valid_moves = self.get_valid_moves(self.selected_piece[0], self.selected_piece[1])
            if (row, col) in valid_moves:
                # Remove jumped piece
                jumped_row = (self.selected_piece[0] + row) // 2
                jumped_col = (self.selected_piece[1] + col) // 2
                self.board[jumped_row][jumped_col] = 0

                # Move selected piece
                self.board[row][col] = 1
                self.board[self.selected_piece[0]][self.selected_piece[1]] = 0
                self.selected_piece = None

                # Check if game over
                if self.is_game_over():
                    messagebox.showinfo("Game Over", "Parabéns! Você venceu o jogo.")
        else:
            if self.board[row][col] == 1:
                self.selected_piece = (row, col)

    def is_game_over(self):
        for row in range(7):
            for col in range(7):
                if self.board[row][col] == 1:
                    valid_moves = self.get_valid_moves(row, col)
                    if valid_moves:
                        return False
        return True

class Application(tk.Tk):
    def __init__(self, game):
        super().__init__()
        self.game = game
        self.title("Resta Um")
        self.create_widgets()

    def create_widgets(self):
        self.buttons = []
        for row in range(7):
            self.grid_rowconfigure(row, weight=1)  # Redimensionar linhas
            row_buttons = []
            for col in range(7):
                self.grid_columnconfigure(col, weight=1)  # Redimensionar colunas
                button = tk.Button(self, width=4, height=2)
                button.grid(row=row, column=col, sticky="nsew")
                button.config(command=lambda r=row, c=col: self.on_button_click(r, c))
                row_buttons.append(button)
            self.buttons.append(row_buttons)
        self.update_buttons()

    def update_buttons(self):
        for row in range(7):
            for col in range(7):
                if self.game.board[row][col] == -1:
                    self.buttons[row][col].config(text="")
                    self.buttons[row][col].config(state=tk.DISABLED)
                elif self.game.board[row][col] == 0:
                    self.buttons[row][col].config(text="")
                    self.buttons[row][col].config(state=tk.NORMAL)
                elif self.game.board[row][col] == 1:
                    self.buttons[row][col].config(text="O")
                    self.buttons[row][col].config(state=tk.NORMAL)
        if self.game.selected_piece:
            row, col = self.game.selected_piece
            self.buttons[row][col].config(bg="yellow")

    def on_button_click(self, row, col):
        self.game.make_move(row, col)
        self.update_buttons()

if __name__ == "__main__":
    game = RestaUmGame()
    app = Application(game)
    app.mainloop()
