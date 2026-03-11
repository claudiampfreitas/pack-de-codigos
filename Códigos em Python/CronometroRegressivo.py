import tkinter as tk
from tkinter import messagebox
import time

def start_countdown():
    tempo = entry.get()

    if tempo.isdigit():
        tempo = int(tempo)
        if tempo > 0:
            countdown(tempo * 60)  # Converter para minutos
        else:
            messagebox.showwarning("Valor Inválido", "Por favor, insira um valor positivo.")
    else:
        messagebox.showwarning("Valor Inválido", "Por favor, insira um número inteiro positivo.")

def countdown(t):
    while t:
        mins, secs = divmod(t, 60)
        timer = '{:02d}:{:02d}'.format(mins, secs)
        label.config(text=timer)
        label.update()
        time.sleep(1)
        t -= 1

    messagebox.showinfo("Concluído", "Contagem regressiva concluída!")

# Configuração da janela principal
window = tk.Tk()
window.title("Cronômetro de Contagem Regressiva")

# Label
label = tk.Label(window, text="00:00", font=("Helvetica", 48))
label.pack(pady=20)

# Entry
entry = tk.Entry(window, font=("Helvetica", 20))
entry.pack(pady=10)

# Button
button = tk.Button(window, text="Iniciar", font=("Helvetica", 20), command=start_countdown)
button.pack(pady=10)

# Execução da janela principal
window.mainloop()
