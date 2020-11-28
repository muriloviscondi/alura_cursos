import forca
import adivinhacao

print("*" * 41)
print(' ' * 8, "Escolha o seu jogo!")
print("*" * 41)

print('(1) Forca (2) Adivinhação')

jogo = int(input('Qual jogo? '))

if jogo == 1:
    print('Jogando forca')
    forca.jogar()
elif jogo == 2:
    print('Jogando adivinhação')
    adivinhacao.jogar()
