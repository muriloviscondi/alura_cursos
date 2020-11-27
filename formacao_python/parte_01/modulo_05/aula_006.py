numero_secreto = 46
total_de_tentativas = 3

print("*" * 41)
print(' ' * 3, "Bem vindo ao jogo de Adivinhação!", ' ' * 3)
print("*" * 41)

for rodada in range(1, total_de_tentativas):
    print('=' * 15, f'{rodada}a Rodada', '=' * 15)
    chute_srt = input('Digite o seu número: ')

    print(f'Você digitou: {chute_srt}')

    chute = int(chute_srt)

    acertou = numero_secreto == chute
    maior = numero_secreto < chute
    menor = numero_secreto > chute

    if acertou:
        print("Você acertou!")
        break
    elif menor:
        print("Você errou! O seu chute foi menor que o número secreto.")
    elif maior:
        print("Você errou! O seu chute foi maior que o número secreto.")

    total_de_tentativas -= 1

    print(f'{total_de_tentativas} Tentativas restantes')
print('=' * 14, 'Fim do Jogo', '=' * 14)
