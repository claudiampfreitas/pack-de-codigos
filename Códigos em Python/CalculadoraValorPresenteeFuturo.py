def calcular_valor_presente(valor_futuro, taxa_juros, periodo):
    valor_presente = valor_futuro / (1 + taxa_juros) ** periodo
    return round(valor_presente, 2)

def calcular_valor_futuro(valor_presente, taxa_juros, periodo):
    valor_futuro = valor_presente * (1 + taxa_juros) ** periodo
    return round(valor_futuro, 2)

# Solicitar escolha ao usuário
escolha = int(input("Escolha uma opção:\n1 - Calcular Valor Presente\n2 - Calcular Valor Futuro\n"))

if escolha == 1:
    valor_futuro = float(input("Digite o valor futuro: "))
    taxa_juros = float(input("Digite a taxa de juros (em decimal): "))
    periodo = int(input("Digite o período: "))

    valor_presente = calcular_valor_presente(valor_futuro, taxa_juros, periodo)
    print("Valor Presente:", valor_presente)

elif escolha == 2:
    valor_presente = float(input("Digite o valor presente: "))
    taxa_juros = float(input("Digite a taxa de juros (em decimal): "))
    periodo = int(input("Digite o período: "))

    valor_futuro = calcular_valor_futuro(valor_presente, taxa_juros, periodo)
    print("Valor Futuro:", valor_futuro)

else:
    print("Opção inválida. Por favor, escolha 1 ou 2.")
