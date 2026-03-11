# Dicionário com as matérias de cada módulo
materias_modulo1 = {
    "Inglês técnico": 0,
    "Lógica de programação": 0,
    "Informática aplicada": 0,
    "Banco de dados": 0,
    "Arquitetura de computadores": 0,
    "Economia e finanças": 0
}

materias_modulo2 = {
    "Desenho assistido por computador": 0,
    "Redes de computadores": 0,
    "Fundamentos de programação": 0,
    "Programação WEB": 0
}

materias_modulo3 = {
    "Programação multiplataforma": 0,
    "Programação Desktop": 0,
    "Empreendedorismo": 0,
    "Análise de sistemas": 0
}

# Função para obter as notas de cada módulo
def obter_notas_modulo(materias):
    for materia in materias:
        nota = float(input(f"Informe a nota de {materia}: "))
        materias[materia] = nota

# Função para calcular a soma das notas de um módulo
def calcular_soma_notas(materias):
    soma = sum(materias.values())
    return soma

# Função para verificar a situação do aluno em um módulo
def verificar_situacao_modulo(soma_notas):
    if soma_notas >= 70:
        return "Aprovado"
    elif 60 <= soma_notas < 70:
        return "Recuperação"
    else:
        return "Reprovado"

# Informações da escola e curso
nome_escola = "Polimig"
nome_curso = "Técnico em informática"

# Obtenção do nome do aluno
nome_aluno = input("Informe o nome do aluno: ")

# Obtenção das notas do módulo 1
print("\n--- Módulo 1 ---")
obter_notas_modulo(materias_modulo1)

# Cálculo da soma das notas do módulo 1 e verificação da situação
soma_modulo1 = calcular_soma_notas(materias_modulo1)
situacao_modulo1 = verificar_situacao_modulo(soma_modulo1)

# Obtenção das notas do módulo 2
print("\n--- Módulo 2 ---")
obter_notas_modulo(materias_modulo2)

# Cálculo da soma das notas do módulo 2 e verificação da situação
soma_modulo2 = calcular_soma_notas(materias_modulo2)
situacao_modulo2 = verificar_situacao_modulo(soma_modulo2)

# Obtenção das notas do módulo 3
print("\n--- Módulo 3 ---")
obter_notas_modulo(materias_modulo3)

# Cálculo da soma das notas do módulo 3 e verificação da situação
soma_modulo3 = calcular_soma_notas(materias_modulo3)
situacao_modulo3 = verificar_situacao_modulo(soma_modulo3)

# Exibição dos resultados
print("\n----- Boletim -----")
print("Escola:", nome_escola)
print("Curso:", nome_curso)
print("Aluno:", nome_aluno)

print("\n--- Módulo 1 ---")
for materia, nota in materias_modulo1.items():
    print(f"{materia}: {nota}")
print("Situação:", situacao_modulo1)

print("\n--- Módulo 2 ---")
for materia, nota in materias_modulo2.items():
    print(f"{materia}: {nota}")
print("Situação:", situacao_modulo2)

print("\n--- Módulo 3 ---")
for materia, nota in materias_modulo3.items():
    print(f"{materia}: {nota}")
print("Situação:", situacao_modulo3)

input("Pressione Enter para sair.")
