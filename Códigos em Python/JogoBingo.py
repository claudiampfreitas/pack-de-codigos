import tkinter as tk
from tkinter import messagebox
import random

class BingoGame:
    def __init__(self, master):
        self.master = master
        self.master.title("Jogo de Bingo")
        self.master.resizable(False, False)
        
        self.numbers = list(range(1, 76))
        random.shuffle(self.numbers)
        
        self.create_widgets()
        self.create_bingo_cards()
        self.current_number = None
        self.master.after(5000, self.next_number)
    
    def create_widgets(self):
        self.number_label = tk.Label(self.master, text="Aguardando próximo número...", font=('Helvetica', 14))
        self.number_label.pack(pady=10)
        
        self.bingo_button = tk.Button(self.master, text="Bingo!", command=self.check_bingo)
        self.bingo_button.pack(pady=10)
    
    def create_bingo_cards(self):
        self.bingo_card_player = self.create_bingo_card()
    
    def create_bingo_card(self):
        bingo_card = tk.Frame(self.master)
        bingo_card.pack(pady=10)
        
        cells = []
        used_numbers = set()
        for row in range(5):
            row_cells = []
            for col in range(15):
                while True:
                    number = random.randint(1, 75)
                    if number not in used_numbers:
                        used_numbers.add(number)
                        break
                cell = tk.Label(bingo_card, text=str(number), width=5, height=2, relief="solid", padx=5, pady=5)
                cell.grid(row=row, column=col, padx=2, pady=2)
                cell.bind("<Button-1>", self.mark_number)
                row_cells.append(cell)
            cells.append(row_cells)
        
        return cells
    
    def next_number(self):
        if self.numbers:
            self.current_number = self.numbers.pop()
            self.number_label.config(text="Número sorteado: " + str(self.current_number))
            
            self.update_bingo_card(self.bingo_card_player, self.current_number)
            
            if not self.numbers:
                self.number_label.config(text="Acabaram os números!")
            else:
                self.master.after(5000, self.next_number)
    
    def update_bingo_card(self, card, number):
        for row in card:
            for cell in row:
                if cell.cget('text') == str(number):
                    cell.config(bg='green', fg='white')
    
    def mark_number(self, event):
        cell = event.widget
        if cell.cget('text') == '':
            cell.config(bg='green', fg='white')
        else:
            cell.config(bg='', fg='black')
    
    def check_bingo(self):
        marked_numbers = []
        for row in self.bingo_card_player:
            for cell in row:
                if cell.cget('text') != '':
                    marked_numbers.append(int(cell.cget('text')))
        
        if set(marked_numbers) == set(self.numbers):
            messagebox.showinfo("Bingo!", "Parabéns, você tem bingo!")
        else:
            messagebox.showinfo("Bingo!", "Você não tem bingo!")
    
root = tk.Tk()
bingo_game = BingoGame(root)

root.mainloop()
