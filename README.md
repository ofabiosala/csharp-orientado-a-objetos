# C# - Orientado a Objetos

Este repositório tem por objetivo registrar anotações e armazenar projetos práticos pertinentes aos meus estudos da linguagem de programação C# orientado a objetos nos cursos [C# - Aplicando a Orientação a Objetos](https://www.alura.com.br/curso-online-csharp-aplicando-orientacao-objetos) e [C# - Dominando a Orientação a Objetos](https://www.alura.com.br/curso-online-csharp-dominando-orientacao-objetos) da plataforma de estudos [Alura](https://www.alura.com.br/).

### Sumário

- [Modificadores de Acesso](#modificadores-de-acesso)
- [Classes](#classes)
- [Objetos](#objetos)
- [Atribuição de Valores](#atribuição-de-valores)
- [Invocação de Métodos](#invocação-de-métodos)
- [Atributos e Propriedades](#atributos-e-propriedades)
- [Atributos e Propriedades Estáticas](#atributos-e-propriedades-estáticas)
- [Métodos "get" e "set"](#métodos-get-e-set)
- [Métodos Estáticos](#métodos-estáticos)
- [Construtores](#construtores)
- [Inicializadores](#inicializadores)
- [Funções Anônimas](#funções-anônimas)
- [Lambda](#lambda)
- [Namespaces](#namespaces)
- [Aliases](#aliases)
- [Herança](#herança)
- [Sobrescrita](#sobrescrita)
- [Interface](#interface)

### Modificadores de Acesso

Os principais modificadores de acesso em C# são:

#### Public

O membro da classe é acessível a partir de qualquer outro código, sem restrições.

#### Private

O membro da classe é acessível apenas dentro da própria classe ou estrutura onde está definido.

#### Protected

O membro da classe é acessível dentro da própria classe e por classes derivadas (herança).

#### Internal

O membro da classe é acessível apenas no mesmo escopo de projeto (namespace).

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

### Atributos e Propriedades Estáticas

Em C#, um atributo ou propriedade ``static`` é um membro da classe que é compartilhado por todas as instâncias da classe, em vez de ter um valor diferente para cada instância. Isso significa que um atributo ou propriedade ``static`` pertence à própria classe e não a objetos individuais.

- Atributo static: Um campo que é compartilhado por todas as instâncias da classe. Isso significa que há apenas uma cópia desse campo para toda a classe, e todas as instâncias da classe acessam e modificam essa mesma cópia.

- Propriedade static: Similar a um campo static, mas fornece acesso controlado aos dados por meio de métodos ``get`` e ``set``. Também é compartilhada por todas as instâncias da classe.

**Exemplo:**

```C#
// Atributo Estático
private static int totalContadores = 0;

// Propriedade Estática
public static int TotalContadores
{
    get { return totalContadores; }
}

// Método Construtor
public Contador()
{
    // Incrementa o atributo estático sempre que um novo objeto é instânciado.
    totalContadores++;
}
```

```C#
Contador c1 = new Contador();
Contador c2 = new Contador();
Contador c3 = new Contador();

Console.WriteLine($"Número total de contadores: {Contador.TotalContadores}."); // Número total de contadores: 3.
```

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

### Métodos Estáticos

Em C#, um método ``static`` pertence propriamente à classe em vez de a uma instância específica da classe. Isso significa que um método ``static`` pode ser utilizado sem a necessidade de criar uma instância da classe.

**Exemplo:**

```C#
class Calculadora
{
    public static int Soma(int a, int b)
    {
        return a + b;
    }
}
```

```C#
int resultado = Calculadora.Somar(5, 7);

Console.WriteLine($"O resultado da soma é {resultado}"); // O resultado da soma é 12.
```

### Construtores

Para utilizar um construtor em uma classe C# deve seguir a seguinte regra:

```C#
visibilidade nome(tipo nome, ...)
{
        // Código ...
}
```

**Exemplo:**

```C#
public class Pessoa
{
    // Propriedade
    public string Nome { get; set; }

    // Construtor
    public Pessoa(string nome)
    {
        Nome = nome;
    }
}
```

```C#
Pessoa pessoaUm = new Pessoa("Fábio");

Console.WriteLine(pessoaUm.Nome); // Fábio
```

### Inicializadores

Em C#, utilizamos inicializadores quando necessitamos definir valores simples e não há necessidade de lógica adicional.

**Exemplo:**

```C#
public class Pessoa
{
    // Propriedade
    public string Nome { get; set; }
}
```

```C#
Pessoa pessoaUm = new Pessoa
{
    Nome = "Fábio"
};

Console.WriteLine(pessoaUm.Nome); // Fábio
```

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

### Namespaces

Em C#, um **namespace** é uma forma de organizar e agrupar classes, interfaces, structs e outros tipos. Isso ajuda a evitar conflitos de nomes e a estruturar o código de forma mais clara e modular. Usar namespaces ajuda a manter o código organizado e evita conflitos de nomes, especialmente em projetos grandes.

**Sintaxe Básica:**

```C#
namespace Namespace;

class Classe
{
    // Código ...
}
```

```C#
using Namespace;

// Código ...

```

**Exemplo:**

```C#
namespace Biblioteca.Modelos;

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
    }
}
```

```C#
using Biblioteca.Modelos;

Livro livro1 = new Livro("1984", "George Orwell");

Console.WriteLine($"{livro1.Titulo} - {livro1.Autor}"); // 1984 - George Orwell
```

> A palavra chave ``namespace`` é usada para definir um escopo, agrupar e identificar tipos (classes, interfaces, structs, enums) em um projeto.

> A palavra chave ``using`` é usada para importar namespaces e facilitar o uso dos tipos definidos neles.

> Se a palavra chave ``using`` não for utilizada para referenciar um ``namespace``, será necessário qualificar o nome completo do tipo com o namespace **(FQN-Fully Qualified Name)**, como mostra o exemplo abaixo:

```C#
Biblioteca.Modelos.Livro livro1 = new Biblioteca.Modelos.Livro("1984", "George Orwell");

Console.WriteLine($"{livro1.Titulo} - {livro1.Autor}"); // 1984 - George Orwell
```

> Cada segmento do namespace deve seguir o padrão **PascalCase**. Isso significa que se o nome do segmento for composto todas as palavras devem iniciar com letra **maiúscula**.

> Os segmentos são conectados pelo caractere "." (ponto).

> Uma regra geral para a nomeação de namespaces com diferentes segmentos é começar com o **nome da empresa**, em seguida o **produto** ou **tecnologia**, depois o **módulo** ou **função** e eventualmente um quarto segmento para o **submódulo** ou **subfunção**. Exemplo: ``Microsoft.AspNetCore.Mvc``.

> Para mais informações, é recomendada a leitura da [documentação oficial](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/namespaces) e do [guia de boas práticas](https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/names-of-namespaces).

#### Aliases

Quando em um projeto existem classes com o mesmo nome porém, em diferentes namespaces, podemos utilizar o recurso de **aliases** pois, este nos ajuda a diferenciar e evitar ambiguidade.

**Exemplo:**

```C#
namespace BibliotecaA;

class Cliente
{
    public string Nome { get; set; }
}
```

```C#
namespace BibliotecaB;

class Cliente
{
    public string Nome { get; set; }
}
```

```C#
using ClienteA = BibliotecaA.Cliente;
using ClienteB = BibliotecaB.Cliente;

ClienteA clienteA = new ClienteA
{
    Nome = "João"
};

ClienteA clienteB = new ClienteB
{
    Nome = "Maria"
};

Console.WriteLine($"Cliente da Biblioteca A: {clienteA.Nome}"); // João
Console.WriteLine($"Cliente da Biblioteca B: {clienteB.Nome}"); // Maria

```

### Herança

O conceito de "herança" é fundamental na programação orientada a objetos, pois permite que uma nova classe seja criada baseando-se em uma classe já existente.

A classe que é herdada é chamada de **classe base (ou superclasse)**, enquanto a nova classe que herda é chamada de **classe derivada (ou subclasse)**. A classe derivada herda membros (como métodos e propriedades) da classe base, podendo também adicionar novos membros ou sobrescrever os existentes.

**Exemplo:**

```C#
// Classe Base
class Animal
{
    public string Nome { get; set; }

    public void Comer()
    {
        Console.WriteLine($"{Nome} está comendo.");
    }
}
```

```C#
// Classe Derivada
class Cachorro : Animal
{
    public void Latir()
    {
        Console.WriteLine($"{Nome} está latindo.");
    }
}
```

```C#
Cachorro cachorro = new Cachorro();

cachorro.Nome = "Rex";

cachorro.Comer(); // Rex está comendo.

cachorro.Latir(); // Rex está latindo.
```

> A herança permite a reutilização do código da classe base, evitando a duplicação de código em várias classes.

> A classe derivada pode acessar atributos, propriedades ou métodos públicos e protegidos da classe base. Porém, não é possível acessar estes quando privados, pois não são acessíveis diretamente.

> Construtores da classe base não são herdados pela classe derivada.

### Sobrescrita

Em C#, sobrescrita (ou override) é um conceito da programação orientada a objetos que permite que uma classe derivada forneça uma implementação específica de um método que já foi definido na sua classe base. A sobrescrita é um aspecto importante do polimorfismo, permitindo que métodos em classes derivadas alterem o comportamento de métodos herdados de suas classes base.

Para sobrescrever um método em C#, é necessário seguir algumas etapas:

- Definir o método na classe base, ou seja, o método na classe base deve ser marcado com a palavra-chave ``virtual``, indicando que ele pode ser sobrescrito por classes derivadas.

- Implementar o método na classe derivada, ou seja, a classe derivada usa a palavra-chave ``override`` para fornecer uma nova implementação do método.

**Exemplo:**

```C#
// Classe Base
class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}
```

```C#
// Classe Derivada
class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}
```

```C#
Animal cachorro = new Cachorro();
cachorro.FazerSom(); // O cachorro late.
```

> O método sobrescrito deve ter a mesma assinatura (nome, tipo de retorno e parâmetros) do método na classe base.

> A palavra-chave ``sealed`` evita que uma classe derivada sobrescreva um método que já foi sobrescrito.

**Exemplo:**

```C#
// Classe Base
class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}
```

```C#
// Classe Derivada
class Cachorro : Animal
{
    public override void FazerSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}
```

```C#
// Classe Derivada
class Bulldog : Cachorro
{
    public sealed override void FazerSom()
    {
        Console.WriteLine("O bulldog faz um som característico.");
    }
}
```

```C#
// Classe Derivada
class Beagle : Bulldog
{
    // Tentativa de sobrescrever método resultará em erro de compilação
    // public override void FazerSom()
    // {
    //     Console.WriteLine("O beagle late.");
    // }
}
```

```C#
Animal bulldog = new Bulldog();
bulldog.FazerSom(); // O bulldog faz um som característico.
```

> A palavra chave ``base`` é utilizada para invocar o método da classe base dentro da implementação sobrescrita. Isso é útil quandoé necessário adicionar o comportamento adicional à implementação existente, mantendo a funcionalidade da classe base.

**Exemplo:**

```C#
// Classe Base
class Animal
{
    public virtual void FazerSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}
```

```C#
// Classe Derivada
class Cachorro : Animal
{
    public override void FazerSom()
    {
        base.FazerSom();
        Console.WriteLine("O cachorro late.");
    }
}
```

```C#
Animal cachorro = new Cachorro();
cachorro.FazerSom(); // O animal faz um som.
                     // O cachorro late.
```

> A sobrescrita é uma ferramenta poderosa para criar hierarquias de classes flexíveis e extensíveis, permitindo que você modifique e especialize o comportamento herdado de maneira controlada e previsível.

### Interface

Em C#, uma interface é um tipo que define um "contrato" ou uma "promessa" de métodos e propriedades que uma classe deve implementar. Interfaces são usadas para garantir que classes diferentes possam implementar o mesmo conjunto de métodos, proporcionando um meio de "intercambiar" objetos de diferentes classes de maneira previsível e consistente.

No entanto, a interface em si não fornece a implementação desses métodos, ou seja, isso fica a cargo das classes que implementam a interface.

**Exemplo:**

```C#
interface IAnimal
{
    void Comer();
    void Dormir();
}
```

```C#
class Cachorro : IAnimal
{
    public void Comer()
    {
        Console.WriteLine("O cachorro está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine("O cachorro está dormindo.");
    }
}
```

```C#
class Gato : IAnimal
{
    public void Comer()
    {
        Console.WriteLine("O gato está comendo.");
    }

    public void Dormir()
    {
        Console.WriteLine("O gato está dormindo.");
    }
}
```

```C#
IAnimal cachorro = new Cachorro();
cachorro.Comer(); //
cachorro.Dormir(); //

IAnimal gato = new Gato();
gato.Comer(); //
gato.Dormir(); //
```

#### Declarando Tipo Como Interface

Quando é declarada uma variável usando o tipo da interface, pode-se apenas acessar os membros da interface que foram implementados pela classe.

#### Declarando Tipo Como Classe

Quando é declarada uma variável usando o tipo da classe, pode-se acessar a todos os métodos e propriedades definidos na classe, incluindo aqueles que são específicos da classe e não são parte das interfaces implementadas.