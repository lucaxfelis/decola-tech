# Desafios numéricos em C#

## Tipo de Combustível

### Desafio

Você recebeu desafio para determinar qual dos produtos é o preferêncial dos clientes de um posto de abastecimento de combustível. Para isso você deve escrever um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até que seja válido). O programa será encerrado quando o código informado for o número 4.

### Entrada

A entrada contém apenas valores inteiros e positivos.

### Saída

Deve ser escrito a mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo.

### Exemplo

Exemplo de entrada         | Exemplo de saída
---------------------------|--------------------------------------------------------
8<br>1<br>7<br>2<br>2<br>4 | MUITO OBRIGADO<br>Alcool: 1<br>Gasolina: 2<br>Diesel: 0

#### Solução

[Clique aqui para acessar código da solução](./TipoCombustivel)

## O Maior

### Desafio

Desenvolva um programa capaz de ler três valores e apresentar o maior deles e adicionar a mensagem “eh o maior”. Use a seguinte forma como base:

![fórmula](https://resources.urionlinejudge.com.br/gallery/images/problems/UOJ_1013.png)

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

### Entrada

O arquivo de entrada contém três valores inteiros.

### Saída

Imprima o maior dos três valores seguido pela mensagem " eh o maior".

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
7 14 106           | 106 eh o maior
217 14 6           | 217 eh o maior

#### Solução

[Clique aqui para acessar código da solução](./OMaior)

## Validação de Nota

### Desafio

Para ajudar a calcular as notas referentes às duas avaliações dos alunos, uma professora pediu para que você desenvolva um programa que calcule e imprima a média semestral. Faça com que o algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.

### Entrada

A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

### Saída

Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas após o ponto decimal.

### Exemplo

Exemplo de entrada          | Exemplo de saída
----------------------------|-----------------------------------------------
-3.5<br>3.5<br>11.0<br>10.0 | nota invalida<br>nota invalida<br>media = 6.75

#### Solução

[Clique aqui para acessar código da solução](./ValidacaoNota)

## Tipos de Triângulos

### Desafio

Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

* se A ≥ B+C, apresente a mensagem: **NAO FORMA TRIANGULO**
* se A2 = B2 + C2, apresente a mensagem: **TRIANGULO RETANGULO**
* se A2 > B2 + C2, apresente a mensagem: **TRIANGULO OBTUSANGULO**
* se A2 < B2 + C2, apresente a mensagem: **TRIANGULO ACUTANGULO**
* se os três lados forem iguais, apresente a mensagem: **TRIANGULO EQUILATERO**
* se apenas dois dos lados forem iguais, apresente a mensagem: **TRIANGULO ISOSCELES**

### Entrada

A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

### Saída

Imprima todas as classificações do triângulo especificado na entrada.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
7.0 5.0 7.0        | TRIANGULO ACUTANGULO<br>TRIANGULO ISOSCELES
6.0 6.0 10.0       | TRIANGULO OBTUSANGULO<br>TRIANGULO ISOSCELES
6.0 6.0 6.0        | TRIANGULO ACUTANGULO<br>TRIANGULO EQUILATERO
5.0 7.0 2.0        | NAO FORMA TRIANGULO
6.0 8.0 10.0       | TRIANGULO RETANGULO

#### Solução

[Clique aqui para acessar código da solução](./TiposTriangulos)

## Sequência Lógica 2

### Desafio

Você terá desafio de escrever um programa que leia dois valores **X** e **Y**. A seguir, mostre uma sequência de 1 até **Y**, passando para a próxima linha a cada **X** números.

### Entrada

O arquivo de entrada contém dois valores inteiros, (1 < X < 20) e (X < Y < 100000).

### Saída

Cada sequência deve ser impressa em uma linha apenas, com 1 espaço em branco entre cada número, conforme exemplo abaixo. Não deve haver espaço em branco após o último valor da linha.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
3 99               | 1 2 3<br>4 5 6<br>7 8 9<br>10 11 12<br>...<br>97 98 99

#### Solução

[Clique aqui para acessar código da solução](./SequenciaLogica)

## Coordenadas de um Ponto

### Desafio

Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

![Plano Cartesiano](https://resources.urionlinejudge.com.br/gallery/images/problems/UOJ_1041.png)

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

### Entrada

A entrada contem as coordenadas de um ponto.

### Saída

A saída deve apresentar o quadrante em que o ponto se encontra.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
4.5 -2.2           | Q4
0.1 0.1            | Q1
0.0 0.0            | Origem

#### Solução

[Clique aqui para acessar código da solução](./CoordenadasPonto)

