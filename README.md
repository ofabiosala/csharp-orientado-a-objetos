# C# - Orientado a Objetos

Este repositório tem por objetivo registrar anotações e armazenar projetos práticos pertinentes aos meus estudos da linguagem de programação C# orientado a objetos no curso [C# - Aplicando a Orientação a Objetos](https://www.alura.com.br/curso-online-csharp-aplicando-orientacao-objetos) da plataforma de estudos [Alura](https://www.alura.com.br/).

### Sumário

- [Classes](#classes)
- [Objetos](#objetos)
- [Atribuição de Valores](#atribuição-de-valores)
- [Invocação de Métodos](#invocação-de-métodos)

### Classes

A declaração de uma nova classe em C# deve seguir a seguinte regra:

```C#
Class nome
{
    // Atributos

    visibilidade tipo nome;

    // Métodos

    visibilidade nome()
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

    public ExibirNome()
    {
        Console.WriteLine(nome);
    }

    public ExibirIdade()
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