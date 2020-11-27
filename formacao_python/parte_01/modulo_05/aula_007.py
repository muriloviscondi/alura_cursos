total_de_tentativas = 3

print("*" * 41)
print(' ' * 3, "Bem vindo ao jogo de Adivinhação!", ' ' * 3)
print("*" * 41)

for rodada in range(1, total_de_tentativas + 1):
    print('=' * 15, f'{rodada}a Tentativa', '=' * 15)
    chute_str = input("Digite um número entre 1 e 100: ")
    print(f"Você digitou: {chute_str}")
    chute = int(chute_str)

    acertou = 0 < chute < 101

    if not acertou:
        print("Você deve digitar um número entre 1 e 100!")
        continue

    if acertou:
        print("Você acertou!")
        break
