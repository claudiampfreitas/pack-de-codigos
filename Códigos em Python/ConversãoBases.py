def decimal_to_binary(decimal):
    return bin(decimal)[2:]

def decimal_to_octal(decimal):
    return oct(decimal)[2:]

def decimal_to_hexadecimal(decimal):
    return hex(decimal)[2:]

def binary_to_decimal(binary):
    return int(binary, 2)

def octal_to_decimal(octal):
    return int(octal, 8)

def hexadecimal_to_decimal(hexadecimal):
    return int(hexadecimal, 16)

def convert_number():
    number = input("Digite um número: ")
    base = input("É um número decimal, binário, octal ou hexadecimal? ")

    try:
        if base == "decimal":
            decimal = int(number)
            binary = decimal_to_binary(decimal)
            octal = decimal_to_octal(decimal)
            hexadecimal = decimal_to_hexadecimal(decimal)
        elif base == "binário":
            decimal = binary_to_decimal(number)
            binary = number
            octal = decimal_to_octal(decimal)
            hexadecimal = decimal_to_hexadecimal(decimal)
        elif base == "octal":
            decimal = octal_to_decimal(number)
            binary = decimal_to_binary(decimal)
            octal = number
            hexadecimal = decimal_to_hexadecimal(decimal)
        elif base == "hexadecimal":
            decimal = hexadecimal_to_decimal(number)
            binary = decimal_to_binary(decimal)
            octal = decimal_to_octal(decimal)
            hexadecimal = number
        else:
            print("Entrada inválida.")
            return
    except ValueError:
        print("Número inválido.")
        return

    print("Número convertido:")
    print("Decimal:", decimal)
    print("Binário:", binary)
    print("Octal:", octal)
    print("Hexadecimal:", hexadecimal)

convert_number()
input("Pressione Enter para sair.")
