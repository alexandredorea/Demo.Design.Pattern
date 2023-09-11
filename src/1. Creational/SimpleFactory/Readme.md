# Simple Factory

**Também conhecido como**: Simple Factory Pattern


## Propósito

A Simple Factory é um padrão criacional que não se encontra catalogado no Livro Padrões de Projetos. 
Este padrão fornece uma classe de fábrica que possui um método que retorna diferentes tipos de objetos com base em um determinado parâmetros de entrada.

As pessoas geralmente confundem Simple Factory Pattern com Factory ou com um dos padrões de projeto criacional. 
Na maioria dos casos, um Simple Factory é uma etapa intermediária na introdução dos padrões criacionais Factory Method ou Abstract Factory.

Simple Factory geralmente não têm subclasses. Mas após extrair subclasses de uma Simple Factory, ela começa a se parecer como um padrão Factory Method clássico.

A propósito, se você declarar uma Simple Factory como abstract, ela não se torna um padrão Abstract Factory magicamente.

> ℹ️ **Nota**  
> O padrão Simple Factory foi definido no livro [Use a Cabeça!: Padrões de Projetos](https://www.amazon.com.br/-/dp/8576081741/).


## Visão geral com exemplo

Para entender o Simple Factory Pattern de forma prática, vejamos um exemplo de uma empresa que fabrica diversos tipos de ventiladores.


### Exemplo sem Simple Factory Pattern

Mas primeiro implementaremos este cenário sem usar o Simple Factory Pattern, depois veremos os problemas e como eles podem ser resolvidos com este Pattern.

O programa abaixo é um aplicação de console simples, neste programa, o método `Main` é usado como cliente que cria um `TableFan` (ventilador de mesa). Na implementação mais simples, podemos ver que o cliente é capaz de criar/instanciar um `TableFan` diretamente conforme a necessidade (sem nenhuma fábrica).

```csharp
class Program
{
   static void Main(string[] args)
    {
           TableFan fan = new TableFan();
           fan.SwitchOn();
     }
}

class TableFan 
{ 
    public void SwitchOn(){ }
    public void SwitchOff() { }
}
```


No exemplo acima, não usamos nenhum padrão e a aplicação está funcionando bem. Mas se pensarmos nas possíveis mudanças futuras e olharmos com atenção, podemos prever os seguintes problemas com a implementação atual:

- Na aplicação atual, sempre que um ventilador específico for necessário, ele será criado usando uma classe concreta. No futuro, se houver alguma alteração no nome da classe ou classe diferente for proposta, você deverá fazer alterações em toda a aplicação. Por exemplo, em vez de ter a classe `TableFan`, precisamos introduzir as classes `BasicTableFan` (que deve ser usada agora no lugar da antiga classe `TableFan`) e `PowerTableFan`. Portanto, quaisquer alterações em relação às classes `Fan` dificultarão a manutenção do código e exigirão muitas alterações em muitos lugares.
 
- Atualmente, quando o cliente cria o objeto `TableFan`, o construtor da classe `TableFan` não aceita nenhum argumento, portanto o processo de criação do `Fan` é fácil. Porém, posteriormente, o processo de criação do objeto `TableFan` é alterado e se o construtor da classe `Fan` estiver esperando dois objetos como argumentos. Então, cada lugar no código do cliente precisa fazer alterações onde quer que o objeto Fan tenha sido criado. Por exemplo:

```csharp
TableFan fan = new TableFan(Moter moter, BladType bladType);
```

- Em `TableFan fan = new TableFan(Moter moter, BladType bladType);` código quando o objeto `fan` é criado, são necessários dois tipos `Moter`, `BladType`. No código acima, o cliente conhece as classes e também conhece o processo de criação do objeto, que deve ser um detalhe interno do `FanFactory`. Devemos evitar expor esses detalhes de criação de objetos e classes internas à aplicação cliente.
 
- Em certos casos, a gestão vitalícia dos objetos criados deve ser centralizada para garantir um comportamento consistente dentro da aplicação. Isso não pode ser feito se o cliente for livre para criar objetos concretos da maneira que desejar. Esse cenário ocorre frequentemente em gerenciamento de `Cache Management` e `DI Framework`.

- Em C# e Java, o construtor de uma classe deve ter o mesmo nome que o nome dessa classe. Digamos que seja necessário ter nomes descritivos para o construtor como `CreateTableFanByModelNumber(int modelNumber)`. Na classe `TableFan`, na melhor das hipóteses, podemos ter um construtor como `Fan(int modelNumber)` mas o nome não é tão descritivo quanto sua intenção. Outro exemplo semelhante sobre a questão do nome descritivo também está [disponível aqui](https://pt.wikipedia.org/wiki/F%C3%A1brica_(programa%C3%A7%C3%A3o_orientada_a_objetos)#Nomes_descritivos).


### Exemplo com Simple Factory Pattern

Para resolver os problemas acima, podemos usar o Simple Factory Pattern porque esse padrão é adequado para resolver as perguntas feitas acima. Além disso, continuaremos com o mesmo exemplo e modificaremos o código existente.

Quando implementamos o Simple Factory Pattern, é necessário criar uma classe que terá um método para retornar a instância solicitada de um objeto. Vamos criar uma classe chamada `FanFactory` que implementará uma interface chamada `IFanFactory`. Esta interface possui um método chamado `IFan CreateFan(FanType type);` que recebe `enum FanType` e retorna a respectiva instância de um `Fan` (ventilador).

Agora o cliente não terá conhecimento das classes concretas como `TableFan` ou `RoofFan`. O cliente usará `FanType` enum e interface `IFan`. Com base no enum passado como argumento ao chamar o método `CreateFan`, a `FanFactory` retornará a instância do ventilador desejado. A seguir está o código modificado do aplicativo:

```csharp
enum FanType
{
    TableFan,
    CeilingFan,
    ExhaustFan
}

interface IFan
{
    void SwitchOn();
    void SwitchOff();
}

class TableFan : IFan { ... }

class CeilingFan : IFan { ... }

class ExhaustFan : IFan { ... }

interface IFanFactory
{
    IFan CreateFan(FanType type);
}

class FanFactory : IFanFactory
{
    public IFan CreateFan(FanType type)
    {
        switch (type)
        {
            case FanType.TableFan:
                return new TableFan();
            case FanType.CeilingFan:
                return new CeilingFan();
            case FanType.ExhaustFan:
                return new ExhaustFan();
            default:
                throw new NotSupportedException("Tipo não suportado");
        }
    }
}

static void Main(string[] args)
{
        IFanFactory simpleFactory = new FanFactory();
        // Criação de um ventilador usando Simple Factory
        IFan fan = simpleFactory.CreateFan(FanType.TableFan);
        // Usando o objeto criado
        fan.SwitchOn();

        Console.ReadLine();
 }
```

### Diagrama de classes do Simple Factory Pattern

![image](https://github.com/alexandredorea/Demo.Design.Pattern/assets/11574354/d2363228-7d8e-4501-8844-72b971eeb93c)

## Conclusão

Sabemos, portanto, como o Simple Factory Pattern resolve todos os problemas mencionados acima na seção "Exemplo sem Simple Factory Pattern":

- Agora o cliente está usando interfaces e `FanFactory`, então se mudarmos o nome da classe concreta de `Fan` que é criada para um determinado valor enum, precisamos mudar em apenas um lugar, ou seja, dentro do método `CreateFan` de `FanFactory`. O código do cliente não é afetado de forma alguma.
 
- Se posteriormente o processo de criação do objeto `Fan` for alterado e o construtor da classe `Fan` estiver esperando dois ou mais objetos como argumentos, precisaremos alterar apenas dentro do método `CreateFan` de `FanFactory`. O código do cliente não é afetado de forma alguma.
 
- Usando `FanFactory`, todos os detalhes internos serão ocultados do cliente. Portanto, é bom em termos de abstrações e segurança.
 
- Se necessário, podemos escrever lógica para gerenciamento vitalício junto com a criação de objetos na `FanFactory` centralizada.
 
- Ao usar `FanFactory` podemos simplesmente ter métodos com nomes diferentes e mais descritivos que retornariam um objeto `IFan`. Em nosso aplicativo de exemplo, `FanFactory` pode ter um método público `CreateTableFanByModelNumber(int modelNumber)` exposto ao cliente.


Mas, digamos que no futuro, se a `FanFactory` também tiver que fazer um novo tipo de ventilador chamado `WallFan`. Para adotar este novo requisito, temos que alterar o método `CreateFan` e adicionar um `switch case` para o tipo `WallFan`. Se novamente um novo tipo de ventilador for introduzido, mais um caso precisará ser adicionado. Isto será uma violação do `Princípio Aberto Fechado` dos princípios SOLID. Com a ajuda do [Factory Method Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/FactoryMethod) podemos superar esse problema desta violação.


## Fontes:

- https://dotnettutorials.net/lesson/factory-design-pattern-csharp/
- https://web.archive.org/web/20161027171211/http://corey.quickshiftconsulting.com/blog/first-post
- https://www.oodesign.com/factory-pattern
- http://wiki.c2.com/?FactoryPattern