from random import randrange


def jogar():
    print("*" * 41)
    print(' ' * 3, "Bem vindo ao jogo de Adivinhação!", ' ' * 3)
    print("*" * 41)

    pontos = 1000
    numero_secreto = int(randrange(1, 101))
    total_de_tentativas = 0

    print("Qual o nível de dificuldade?")
    print("(1) Fácil (2) Médio (3) Difícil")

    nivel = int(input("Defina o nível: "))

    if nivel == 1:
        total_de_tentativas = 20
    elif nivel == 2:
        total_de_tentativas = 10
    else:
        total_de_tentativas = 5

    for rodada in range(1, total_de_tentativas + 1):
        print('=' * 15, f'{rodada}a Rodada', '=' * 15)
        chute_srt = input('Digite o seu número entre 1 e 100: ')

        print(f'Você digitou: {chute_srt}')

        chute = int(chute_srt)

        numero_invalido = 0 < chute < 101

        if not numero_invalido:
            print("Você deve digitar um número entre 1 e 100!")
            continue

        acertou = numero_secreto == chute
        maior = numero_secreto < chute
        menor = numero_secreto > chute

        if acertou:
            print(f"Você acertou e fez {pontos} pontos!")
            break
        elif menor:
            print("Você errou! O seu chute foi menor que o número secreto.")
        elif maior:
            print("Você errou! O seu chute foi maior que o número secreto.")

        pontos_perdidos = abs(numero_secreto - chute)
        pontos = pontos - pontos_perdidos

        total_de_tentativas -= 1
        print(f'{total_de_tentativas} Tentativas restantes')

    print(f'\nO número secreto é: {numero_secreto}')
    print('=' * 14, 'Fim do Jogo', '=' * 14)
