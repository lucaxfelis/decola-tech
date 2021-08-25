# Primeiros desafios Matemáticos em C#

## Soma Simples

### Desafio

Leia dois valores inteiros identificados como variáveis A e B. Calcule a soma entre elas e chame essa variável de **SOMA**.
A seguir escreva o valor desta variável.

#### Entrada

O arquivo de entrada contém 2 valores inteiros.

#### Saída

Imprima a variável **SOMA** com todas as letras maiúsculas, inserindo um espaço em branco antes e depois do símbolo de igualdade, seguido pelo valor correspondente à soma de A e B.

#### Exemplo

Exemplos de entrada | Exemplos de saída
--------------------|------------------
30<br>10            | SOMA = 40<br>
-30<br>10           | SOMA = -20<br>
0<br>0              | SOMA = 0<br>

#### Solução

[Clique aqui para acessar código da solução](./SomaSimples)

## DDD

### Desafio

Leia um número inteiro que representa um código de DDD para discagem interurbana. Em seguida, informe à qual cidade o DDD pertence, considerando a tabela abaixo:

DDD | Destino
----|--------
61  | Brasilia
71  | Salvador
11  | Sao Paulo
21  | Rio de Janeiro
32  | Juiz de Fora
19  | Campinas
27  | Vitoria
31  | Belo Horizonte

Se a entrada for qualquer outro DDD que não esteja presente na tabela acima, o programa deverá informar:
DDD nao cadastrado

#### Entrada

A entrada consiste de um único valor inteiro.

#### Saída

Imprima o nome da cidade correspondente ao DDD existente na entrada. Imprima DDD nao cadastrado caso não existir DDD correspondente ao número digitado.

#### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
11                 | Sao Paulo


#### Solução

[Clique aqui para acessar código da solução](./DDD)
