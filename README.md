# C# - Orientado a Objetos

Este repositório tem por objetivo registrar anotações e armazenar projetos práticos pertinentes aos meus estudos da linguagem de programação C# orientado a objetos no curso [C# - Aplicando a Orientação a Objetos](https://www.alura.com.br/curso-online-csharp-aplicando-orientacao-objetos) da plataforma de estudos [Alura](https://www.alura.com.br/).

### Sumário

- [Modificadores de Acesso](#modificadores-de-acesso)
- [Classes](#classes)
- [Objetos](#objetos)
- [Atribuição de Valores](#atribuição-de-valores)
- [Invocação de Métodos](#invocação-de-métodos)
- [Atributos e Propriedades](#atributos-e-propriedades)
- [Métodos "get" e "set"](#métodos-get-e-set)
- [Funções Anônimas](#funções-anônimas)
- [Lambda](#lambda)

### Modificadores de Acesso

Os principais modificadores de acesso em C# são:

#### Public

O membro da classe é acessível a partir de qualquer outro código, sem restrições.

#### Private

O membro da classe é acessível apenas dentro da própria classe ou estrutura onde está definido.

#### Protected

O membro da classe é acessível dentro da própria classe e por classes derivadas (herança).

### Classes

A declaração de uma nova classe em C# deve seguir a seguinte regra:

```C#
Class nome
{
    // Atributos

    visibilidade tipo nome;

    // Métodos

    visibilidade tipo nome()
    {
        // Código ...
    }
}
```

**Exemplo:**

```C#
Class Pessoa
{
    public string nome;
    public int idade;

    public void ExibirNome()
    {
        Console.WriteLine(nome);
    }

    public void ExibirIdade()
    {
        Console.WriteLine(idade);
    }
}
```

### Objetos

A instanciação de um novo objeto em C# deve seguir a seguinte regra:

```C#
tipo nome = new tipo();
```

**Exemplo:**

> Para este exemplo, irei "aproveitar" a classe "Pessoa" criada no exemplo do tópico anterior.

```C#
Pessoa pessoaUm = new Pessoa();
```

### Atribuição de Valores

A atribuição de um valor a um atributo de um objeto em C# deve seguir a seguinte regra:

```C#
objeto.atributo = valor;
```

**Exemplo:**

> Para este exemplo, irei "aproveitar" o objeto "pessoaUm" instanciado a partir da classe "Pessoa" no exemplo do tópico anterior.

```C#
pessoaUm.nome = "Fábio";
pessoaUm.idade = 30;
```

### Invocação de Métodos

A invocação de um método em um objeto em C# deve seguir a seguinte regra:

```C#
objeto.metodo();
```

**Exemplo:**

> Para este exemplo, irei "aproveitar" o objeto "pessoaUm" instanciado a partir da classe "Pessoa" no exemplo do tópico anterior.

```C#
pessoaUm.ExibirNome(); // Fábio
pessoaUm.ExibirIdade(); // 30
```

### Atributos e Propriedades

#### Atributos (Fields)

São variáveis que são declaradas dentro de uma classe para armazenar dados sobre um objeto. Eles representam o estado interno do objeto e podem ser acessados e modificados diretamente. 

> O nome de um atributo deve seguir o padrão **CamelCase**. Isso significa que se o nome do atributo for composto deve-se iniciar a primeira palavra com a letra **minúscula** e as demais iniciar com a letra **maiúscula**.

#### Propriedades (Properties)

Fornecem uma forma de acessar e modificar os atributos de uma classe de maneira controlada. Elas encapsulam a lógica de acesso aos atributos e podem incluir lógica adicional na forma de métodos ``get`` para leitura e ``set`` para escrita, permitindo maior controle sobre como os valores são acessados e modificados.

> O nome de uma propriedade deve seguir o padrão **PascalCase**. Isso significa que se o nome da propriedade for composto todas as palavras devem iniciar com letra **maiúscula**.

### Métodos "get" e "set"

Os métodos ``get`` e ``set`` são usados dentro de propriedades para controlar o acesso a um atributo privado de uma classe. Eles proporcionam uma forma de encapsular a leitura e a escrita dos valores dos atributos, permitindo a implementação de lógica adicional quando necessário.

#### get

O método ``get`` é usado para acessar o valor de uma propriedade. Quando você lê o valor de uma propriedade, o método ``get`` é invocado. Ele retorna o valor atual do atributo associado à propriedade.

#### set

O método ``set`` é usado para modificar o valor de uma propriedade. Quando você atribui um valor a uma propriedade, o método ``set`` é invocado. Ele define o valor do atributo associado à propriedade e pode incluir lógica para validar ou transformar o valor antes de atribuí-lo.

**Exemplo:**

#### Modelo 1 - Propriedade Auto-Implementada

```C#
public class Pessoa
{
    // Atributo
    // Não explicitamente declarado, ou seja, gerado automaticamente pelo compilador.

    // Propriedade
    public string Nome { get; set; }
}
```

> Este modelo utiliza uma propriedade auto-implementada, ou seja, o compilador do C# cria automaticamente um campo privado que não é visível no código fonte para armazenar o valor da propriedade. Esse campo é acessado e modificado internamente pela propriedade.

> Por ser uma forma mais simples e direta de definir propriedades, é ideal quando não há necessidade de lógica adicional para o acesso ou modificação dos dados.

> Porém, não há controle sobre como o valor é armazenado ou validado. Caso seja necessário adicionar lógica extra (como validação ou manipulação), precisará alterar para o **Modelo 2**.

#### Modelo 2 - Propriedade Com Campo Privado

```C#
public class Pessoa
{
    // Atributo
    private string nome;

    // Propriedade
    public string Nome
    {
        get { return nome; }  // O método "get" retorna o valor do atributo privado "nome".
        set { nome = value; } // O método "set" define o valor do atributo privado "nome".
    }
}
```

> Este modelo define um campo privado denominado ``nome`` para armazenar o valor da propriedade. A propriedade ``Nome`` fornece acesso controlado a esse campo.

> Isso permite que haja um controle total sobre como o valor é acessado e modificado. Isso é útil se precisar incluir uma lógica adicional nos métodos ``get`` ou ``set``, como validação, transformação ou logging, pois é possível fazê-lo diretamente dentro da propriedade.

> O campo privado ``nome`` é visível apenas dentro da classe ``Pessoa``. O acesso a esse campo é feito por meio da propriedade ``Nome``, que pode ser facilmente ajustada se a lógica de armazenamento precisar ser alterada.

```C#
// Cria uma nova instância da classe Pessoa.
Pessoa pessoa = new Pessoa();
        
// Atribui um valor ao atributo privado "nome" usando o método "set" da propriedade "Nome".
pessoa.Nome = "Fábio";
        
// Exibe o valor do atributo privado "nome" usando o método "get" da propriedade "Nome".
Console.WriteLine($"Nome: {pessoa.Nome}");
```

> Não é obrigatória a criação de um atributo e uma propriedade para cada campo em uma classe, mas é uma prática comum e recomendada na linguagem C# utilizando o paradigma de orientação a objetos para garantir o encapsulamento e controle sobre o acesso aos dados da classe.

> Caso não seja necessário o uso de lógica adicional ou controle sobre como um campo é acessado e modificado, pode-se optar por usar campos públicos diretamente.

> Apenas para "reforçar" o conceito quanto a utilização de propriedades, a manipulação de um atributo deve ser feita a partir da propriedade e não através do atributo diretamente.

### Funções Anônimas

Uma função anônima é uma função sem um nome definido. Esta pode ser uilizada em locais onde uma função é necessária, mas não é necessário (ou desejado) nomeá-la explicitamente.

### Lambda

Uma expressão ou função lambda é uma forma de definir uma função anônima de maneira concisa usando o operador ``=>``.

**Exemplo:**

```C#
public int Soma(int numeroA, int numeroB) => numeroA + numeroB;
```

#### Vantagens

**Concisão:** Permite escrever código de forma mais concisa, eliminando a necessidade de definir métodos separados para funções simples.

**Legibilidade:** São mais fáceis de ler e entender, especialmente quando o critério de filtragem ou a lógica do código é curto e direto.

**Flexibilidade:** Podem ser usadas em várias situações, como filtrar, ordenar, mapear ou reduzir coleções de dados. Elas permitem que você especifique a lógica do código diretamente no local onde é necessário, sem a necessidade de criar métodos adicionais.

**Encerramento de Escopo:** Têm acesso às variáveis do escopo em que são definidas, o que permite que você capture e utilize valores externos dentro da expressão lambda. Isso pode ser útil em casos onde você precisa fazer referência a variáveis externas dentro de um loop, por exemplo.

#### Quando não é recomendado o uso de código lambda?

Embora as funções lambda sejam uma ferramenta poderosa e muito usada no mundo de desenvolvimento C#, há situações em que é mais apropriado evitar o seu uso, como mostra os pontos abaixo:

**Complexidade Excessiva:** Se a lógica da expressão lambda se tornar muito complexa ou difícil de entender, é preferível usar métodos ou blocos de código separados para manter a clareza e legibilidade do código.

**Reutilização de Código:** Se você precisa reutilizar a lógica em várias partes do seu código, é mais adequado criar um método separado em vez de usar uma função lambda repetidamente. Isso promove a reutilização do código e torna mais fácil a manutenção.

**Aumento da Complexidade do Código:** Em alguns casos, o uso excessivo de expressões lambda pode tornar o código mais difícil de entender e dar manutenção, especialmente quando as expressões lambdas são aninhadas. Nesses casos, pode ser melhor dividir o código em partes menores e mais legíveis.