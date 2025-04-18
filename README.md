# Projeto do Robô Tupiniquim

O Robô Tupiniquim é um projeto de simulador de navegação de robô baseado em console, escrito em C#. O programa simula um robô se movendo em uma grade 2D com base em uma sequência de comandos. O robô pode girar à esquerda, girar à direita ou mover-se para frente na direção que está enfrentando.

## Visão Geral

O programa recebe uma posição inicial e uma sequência de comandos como entrada:

- **Posição inicial**: Definida como uma string no formato `"X Y D"`, onde:
  - `X` é a coordenada x (inteiro).
  - `Y` é a coordenada y (inteiro).
  - `D` é a direção (`N` para Norte, `S` para Sul, `O` para Oeste, `L` para Leste).
- **Comandos**: Uma string de instruções, onde:
  - `E`: Girar à esquerda (90 graus no sentido anti-horário).
  - `D`: Girar à direita (90 graus no sentido horário).
  - `M`: Mover uma unidade para frente na direção atual.

O programa processa os comandos e exibe a posição e direção finais do robô no formato `"X Y D"`.

## Explicação do Código

O código está implementado em um único arquivo C# (`Program.cs`) com a seguinte lógica:

1. **Análise da Entrada**:
   - A posição inicial (`"3 4 O"`) é dividida em coordenada x, coordenada y e direção.
   - A string de comandos (`"EMEMEMEMM"`) é convertida em um array de caracteres para processamento.
2. **Processamento dos Comandos**:
   - Para cada comando:
     - `E`: Atualiza a direção girando 90 graus à esquerda (por exemplo, Norte → Oeste).
     - `D`: Atualiza a direção girando 90 graus à direita (por exemplo, Norte → Leste).
     - `M`: Move o robô uma unidade na direção atual (por exemplo, Norte aumenta a coordenada y).
3. **Saída**:
   - A posição e direção finais são exibidas no console.

### Exemplo

**Entrada**:

- Posição inicial: `"3 4 O"` (x=3, y=4, direção=Oeste)
- Comandos: `"EMEMEMEMM"`

**Execução**:

- `E`: Oeste → Sul
- `M`: Move para Sul (y=4 → 3) → (3, 3, Sul)
- `E`: Sul → Leste
- `M`: Move para Leste (x=3 → 4) → (4, 3, Leste)
- `E`: Leste → Norte
- `M`: Move para Norte (y=3 → 4) → (4, 4, Norte)
- `E`: Norte → Oeste
- `M`: Move para Oeste (x=4 → 3) → (3, 4, Oeste)
- `M`: Move para Oeste (x=3 → 2) → (2, 4, Oeste)

**Saída**:

```
Posição final do robô: 2 4 O
```

## Como Executar

### Pré-requisitos

- .NET SDK (versão 6.0 ou superior recomendada).
- Um ambiente de desenvolvimento C# (por exemplo, Visual Studio, VS Code ou qualquer IDE que suporte .NET).

### Passos

1. **Clonar ou Criar o Projeto**:

   - Copie o código corrigido de `Program.cs` para um projeto C# novo ou existente.

2. **Garantir que o Código Está em** `Program.cs`:

   - O código deve estar no arquivo `Program.cs` do seu projeto.

3. **Compilar e Executar**:

   - Abra um terminal no diretório do projeto.

   - Execute os seguintes comandos:

     ```bash
     dotnet build
     dotnet run
     ```

4. **Visualizar a Saída**:

   - O console exibirá a posição final do robô, por exemplo, `Posição final do robô: 2 4 O`.

## Observações

- A grade é considerada infinita, sem limites.
- O programa não trata entradas inválidas (por exemplo, coordenadas não inteiras ou direções inválidas). Para uso em produção, considere adicionar validação de entrada.
- O código foi projetado para ser simples e claro, focando na lógica central de navegação do robô.

## Melhorias Futuras

- Adicionar validação de entrada para lidar com posições iniciais ou comandos malformados.
- Implementar uma grade com limites para evitar que o robô saia da área.
- Suportar comandos adicionais ou recursos, como movimento para trás ou múltiplos robôs.

## Licença

Este projeto é fornecido como está para fins educacionais. Sinta-se à vontade para modificá-lo e usá-lo conforme necessário.

## Tecnologias Utilizadas
![C#](https://skillicons.dev/icons?i=cs) ![.NET](https://skillicons.dev/icons?i=dotnet,git,github,vscode)