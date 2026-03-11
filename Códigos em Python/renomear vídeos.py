import os
import re

def sanitize_filename(filename, max_length=255):
    """
    Remove caracteres especiais de um nome de arquivo e ajusta seu comprimento.
    """
    # Remove caracteres especiais exceto -_.()
    sanitized = re.sub(r'[^\w\-_().]', '_', filename)
    # Limita o comprimento do nome do arquivo
    if len(sanitized) > max_length:
        sanitized = sanitized[:max_length]
    return sanitized

def truncate_path(path, max_length):
    """
    Trunca um caminho para que fique dentro do limite permitido.
    """
    if len(path) <= max_length:
        return path

    directory, filename = os.path.split(path)
    excess_length = len(path) - max_length
    truncated_filename = filename[:-excess_length]
    return os.path.join(directory, truncated_filename)

def process_directory(directory, max_filename_length=255, max_path_length=260):
    """
    Verifica e corrige os nomes dos arquivos em um diretório.
    """
    problematic_files = []

    for root, _, files in os.walk(directory):
        for file in files:
            original_path = os.path.join(root, file)
            sanitized_name = sanitize_filename(file, max_filename_length)
            sanitized_path = os.path.join(root, sanitized_name)

            # Verifica se o caminho completo ultrapassa o limite permitido
            errors = []

            if len(sanitized_path) > max_path_length:
                errors.append("Caminho muito longo")
                sanitized_path = truncate_path(sanitized_path, max_path_length)

            if sanitized_name != file:
                errors.append("Caracteres especiais detectados")

            if errors:
                # Adiciona à lista de arquivos problemáticos e seus erros
                problematic_files.append((original_path, errors))

            # Renomeia o arquivo, se necessário
            if sanitized_path != original_path:
                try:
                    os.rename(original_path, sanitized_path)
                    print(f"Renomeado: {original_path} -> {sanitized_path}")
                except Exception as e:
                    print(f"Erro ao renomear {original_path}: {e}")

    return problematic_files

if __name__ == "__main__":
    # Caminho do diretório com os vídeos
    directory_path = input("Digite o caminho da pasta com os vídeos: ").strip()

    if os.path.exists(directory_path):
        problematic_files = process_directory(directory_path)

        if problematic_files:
            print("\nArquivos problemáticos encontrados:")
            for file, errors in problematic_files:
                print(f"{file}")
                for error in errors:
                    print(f"  - {error}")
        else:
            print("\nNenhum arquivo problemático encontrado.")
    else:
        print("Caminho do diretório inválido.")
