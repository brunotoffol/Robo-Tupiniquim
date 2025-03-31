# Robo Tupiniquim

## Introdu��o

Aplica��o desenvolvida como Trabalho Avaliativo para a Academia do Programador 2025, onde podemos pilotar um rob� em uma �rea definida de um plano cartesiano e enviar comandos para que ande pela �rea de explora��o.

### Exemplo

![](https://imgur.com/rS5HFA9.gif)

### Funcionalidades

- Defini��o  da �rea de explora��o via um plano cartesiano (x, y) de coordenadas
- Envio de comandos ('D' para direita, 'E' para esquerda e 'M' para mover para frente) para que o rob� avance pela �rea de explora��o definida
- Caso o rob� extrapole a �rea de explora��o, uma mensagem de erro ser� enviada.

### Como utilizar:
1. Clone o reposit�rio ou baixe o c�digo fonte
2. Abre o terminal ou prompt de comando e navegue at� a pasta raiz
3. Utilize o comando abaixo para restaurar as dep�ncias do projeto

```
dotnet restore
```
4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project Robo Tupiniquim
```
6. Para executar o arquivo compilado, navegue at� a pasta ./Robo Tupiniquim/bin/Release/net8.0/ e execute o arquivo:
```
Robo Tupiniquim.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compila��o e execu��o do projeto.