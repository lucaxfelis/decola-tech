# Introdução a Resolução de Desafios com C#

## Múltiplos

### Desafio

Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem **"Sao Multiplos"** ou **"Nao sao Multiplos"**, indicando se os valores lidos são múltiplos entre si.

### Entrada

A entrada contém valores inteiros.

### Saída

A saída deve conter uma das mensagens conforme descrito acima.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
5 24               | Sao Multiplos
5 25               | Nao Sao Multiplos

#### Solução

[Clique aqui para acessar código da solução](./Multiplos)

## Números Ímpares

### Desafio

Leia um valor inteiro **X** (1 <= **X** <= 1000). Em seguida mostre os ímpares de 1 até **X**, um valor por linha, inclusive o **X**, se for o caso.

### Entrada

O arquivo de entrada contém 1 valor inteiro qualquer.

### Saída

Imprima todos os valores ímpares de 1 até **X**, inclusive **X**, se for o caso.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
8                  | 1<br>3<br>5<br>7

#### Solução

[Clique aqui para acessar código da solução](./NumerosImpares)

## Conversão de Tempo

### Desafio

Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

### Entrada

O arquivo de entrada contém um valor inteiro **N**.

### Saída

Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
556                | 0:9:16
1                  | 0:0:1

#### Solução

[Clique aqui para acessar código da solução](./ConversaoTempo)

## Tempo do Dobby

### Desafio

Para dar conta de toda a fabricação dos presentes de Natal, por várias vezes os elfos precisam ficar até tarde trabalhando para que tudo possa ser terminado a tempo.

Para melhor gerenciar seus cronogramas, os elfos estipularam quantos minutos são necessários para fabricar cada presente.

Já está quase no final do expediente, e um dos elfos pediu sua ajuda.

Faltam **N** minutos para a hora de ir embora, e restam dois presentes para o elfo Dobby fabricar. Ajude-o a descobrir se ele conseguirá fabricar os dois ainda hoje, ou se deve deixar o trabalho para amanhã.

### Entrada

Cada caso de teste inicia com um inteiro **N**, indicando quantos minutos faltam para o final do expediente (2 <= **N** <= 100).

Em seguida haverá dois inteiros **A** e **B**, indicando quantos minutos são necessários para fabricar os dois presentes que Dobby precisa fabricar (1 <= **A**, **B** <= 100).

### Saída

Imprima uma linha, contendo a frase "Farei hoje!" caso seja possível fabricar os dois presentes antes do final do expediente, ou "Deixa para amanha!" caso contrário.

### Exemplo

Exemplo de entrada | Exemplo de saída
-------------------|-----------------
20<br>15 6         | Deixa para amanhã!
20<br>10 10        | Farei hoje!

#### Solução

[Clique aqui para acessar código da solução](./TempoDobby)
