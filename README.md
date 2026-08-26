# Coleção de Exercícios em C#

Coleção de projetos desenvolvidos em **C#** com foco no aprendizado de lógica de programação, estruturas de dados, validações, programação orientada a objetos e manipulação de coleções com **LINQ**.

Os projetos são aplicações de console independentes, cada uma explorando um conceito ou situação prática diferente.

## 📂 Projetos

### 📊 Media Salarial

O programa recebe os nomes e salários de funcionários, realiza validações e calcula estatísticas relacionadas aos salários.

**Funcionalidades:**

* Cadastro do nome dos funcionários.
* Entrada e validação dos salários.
* Validação de salário mínimo de **R$ 1.400,00**.
* Cálculo da média salarial.
* Identificação do maior salário.
* Exibição dos funcionários que recebem acima da média.
* Funções auxiliares para validação de números e respostas.

A soma dos salários é utilizada para calcular a média, enquanto o maior salário e seu respectivo funcionário são identificados durante a leitura dos dados.

---

### 💰 Folha de Pagamento

Aplicação para cálculo simplificado de uma folha de pagamento, considerando salário bruto, descontos de INSS e IRRF e salário líquido.

**Funcionalidades:**

* Entrada do nome do funcionário.
* Entrada e validação do salário bruto.
* Cálculo do desconto do INSS.
* Cálculo do desconto do IRRF.
* Cálculo do salário líquido.
* Exibição detalhada da folha.
* Possibilidade de realizar novos cálculos.

O programa valida se o salário informado é maior que zero e utiliza diferentes faixas para calcular o desconto do INSS.

O salário líquido é calculado pela fórmula:

```text
Salário Líquido = Salário Bruto - INSS - IRRF
```

As taxas utilizadas estão implementadas diretamente nas funções de cálculo do programa.

---

### ⚔️ Loja RPG

Simulação de um sistema simples de gerenciamento de itens para uma loja de RPG.

O projeto utiliza uma classe `ItemRPG` com propriedades para representar:

* Nome do item.
* Preço.
* Estoque.

A criação do item possui validações para impedir nomes vazios e preços negativos.

**Operações disponíveis:**

* Reabastecimento do estoque.
* Venda de itens.
* Validação de quantidade.
* Verificação de estoque insuficiente.
* Exibição do estado final do produto.

O método `Reabastecer` aumenta a quantidade disponível no estoque, enquanto `RealizarVenda` reduz o estoque somente quando existe quantidade suficiente para realizar a operação.

---

### 🎵 Catálogo de Músicas

Aplicação de análise de um catálogo musical utilizando **List**, objetos e recursos do **LINQ**.

Cada música possui informações como:

* ID.
* Nome.
* Artista.
* Gênero.
* Duração em segundos.
* Número de reproduções.

O catálogo inicial contém 10 músicas cadastradas.

**Funcionalidades:**

* Buscar músicas por gênero.
* Exibir o Top 3 de músicas mais reproduzidas.
* Calcular a média de duração das músicas.
* Verificar se determinado artista está presente no catálogo.
* Encerrar o sistema.

O projeto utiliza operações LINQ como `Where`, `OrderByDescending`, `Take`, `Average` e `Any`.

---

### 📚 Pilha de Objetos

Implementação manual de uma **estrutura de dados do tipo Pilha (Stack)** em C#.

A estrutura utiliza uma classe `Pilha` contendo um valor inteiro (`info`) e uma referência para o próximo elemento (`next`).

O projeto implementa as principais operações de uma pilha:

* **Push:** insere um elemento no topo.
* **Pop:** remove e retorna o elemento do topo.
* **Peek / Consulta:** consulta o elemento do topo sem removê-lo.
* **Listar:** percorre e exibe todos os elementos.

A operação `Pop` também possui tratamento para impedir a remoção quando a pilha está vazia.

A aplicação possui um menu interativo para executar as operações da pilha diretamente pelo terminal.

## 🛠️ Tecnologias utilizadas

* **C#**
* **.NET**
* Programação Orientada a Objetos
* Estruturas de dados
* LINQ
* Coleções (`List`)
* Validação de entrada
* Tratamento de exceções
* Aplicações de console

## 🎯 Objetivos

Este repositório reúne exercícios práticos desenvolvidos para reforçar conceitos fundamentais da programação em C#, incluindo:

* Variáveis e tipos de dados.
* Estruturas condicionais.
* Estruturas de repetição.
* Métodos e funções.
* Classes e objetos.
* Encapsulamento.
* Validação de dados.
* Tratamento de exceções.
* Manipulação de listas.
* Consultas utilizando LINQ.
* Implementação manual de estruturas de dados.

## 🚀 Como executar

### 1. Pré-requisitos

É necessário ter o **.NET SDK** instalado na máquina.

### 2. Clone o repositório

```bash
git clone https://github.com/luf3ds/fundamentos-csharp.git
```

### 3. Acesse a pasta do projeto

```bash
cd fundamentos-csharp
```

### 4. Execute o arquivo desejado

Cada exercício pode ser executado como uma aplicação C# independente, utilizando o ambiente de desenvolvimento ou a configuração de projeto correspondente.

## 📁 Estrutura do repositório

```text
.
├── catalogoMusicas.cs
├── folhaDePagamento.cs
├── lojaRPG.cs
├── mediaSalarial.cs
└── pilhaObjeto.cs
```

## 📌 Observações

Os projetos possuem finalidade educacional e foram desenvolvidos para praticar diferentes conceitos da linguagem C#.

Cada arquivo apresenta uma proposta independente, permitindo estudar os conceitos separadamente e comparar diferentes formas de resolver problemas utilizando programação estruturada, orientação a objetos, coleções, LINQ e estruturas de dados.

## 👨‍💻 Autor

Projeto desenvolvido para fins de estudo e prática de programação em **C#**.
