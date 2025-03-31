# Robo Tupiniquim

## Introdução

Aplicação desenvolvida como Trabalho Avaliativo para a Academia do Programador 2025, onde podemos pilotar um robô em uma área definida de um plano cartesiano e enviar comandos para que ande pela área de exploração.

### Exemplo

![](https://imgur.com/rS5HFA9.gif)

### Funcionalidades

- Definição  da área de exploração via um plano cartesiano (x, y) de coordenadas
- Envio de comandos ('D' para direita, 'E' para esquerda e 'M' para mover para frente) para que o robô avance pela área de exploração definida
- Caso o robô extrapole a área de exploração, uma mensagem de erro será enviada.

### Como utilizar:
1. Clone o repositório ou baixe o código fonte
2. Abre o terminal ou prompt de comando e navegue até a pasta raiz
3. Utilize o comando abaixo para restaurar as depências do projeto

```
dotnet restore
```
4. Em seguida, compile a solução utilizando o comando:
```
dotnet build --configuration Release
```
5. Para Executar o projeto compilando em tempo real
```
dotnet run --project Robo Tupiniquim
```
6. Para executar o arquivo compilado, navegue até a pasta ./Robo Tupiniquim/bin/Release/net8.0/ e execute o arquivo:
```
Robo Tupiniquim.exe
```

## Requisitos

- .NET SDK (recomendado .NET 8.0 ou superior) para compilação e execução do projeto.