# Factory Method

Também conhecido como: Método fábrica, Construtor virtual


## Propósito

O Factory Method é um padrão criacional de projeto que fornece uma interface para criar um objeto, mas deixa que as subclasses decidirem qual classe instanciar. 
O Factory Method permite que uma classe adie a instanciação para subclasses.

> ✅ Para ser claro sobre esta definição, entenderemos ela definição dividindo-a em partes.


## Problema

Tomando como base o exemplo aplicado no [Single Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory). 
Digamos que a aplicação começa a crescer e agora a `FanFactory` precisa que fazer um novo tipo de ventilador chamado `WallFan`. 
Para adotar este novo requisito, temos que alterar o método `CreateFan` e adicionar um `switch case` para o tipo `WallFan`. Se novamente um novo tipo de ventilador for introduzido, mais um caso precisará ser adicionado. 
Isto será uma violação do `Princípio Aberto-Fechado (Open Close Principle)` dos princípios SOLID. Com a ajuda do Factory Method Pattern podemos superar esse problema desta violação (já que cada padrão tem seu próprio lugar, vantagens e restrições).


## Solução

Vamos começar com o mesmo código. Usaremos a mesma interface chamada `IFan` que tinha dois métodos conforme mostrado abaixo.

```csharp
interface IFan
{
    void SwitchOn();
    void SwitchOff();
}
```

Inicialmente nossa empresa pretendia criar apenas três tipos de ventiladores chamados TableFan, CeilingFan e ExhaustFan. Todos os ventiladores terão os métodos SwitchOn() e SwitchOff(), mas suas implementações podem ser diferentes. 
Vamos usar as mesmas classes e implementar interfaces `IFan`.

```csharp
class TableFan : IFan { ... }

class CeilingFan : IFan { ... }

class ExhaustFan : IFan { ... }
```


O código é o mesmo usado no exemplo [Single Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory).

Quando implementamos o **Factory Method Pattern**, temos que seguir seu design conforme mostrado no diagrama abaixo:

![image](https://github.com/alexandredorea/desafio-05/assets/11574354/6d215a12-9fe3-489b-977e-a73327239bf9)

Portanto, seguiremos seu design e explicaremos a definição do Factory Method Pattern.

De acordo com a definição ele "**fornece uma interface para criar objetos...**" então vamos definir a interface que terá um método para criar Ventiladores. A implementação deste método em subclasses terá lógica para criar objetos concretos. 

```csharp
interface IFanFactory
{
    IFan CreateFan();
}
```

> ⚠️ **Observação**  
> Neste exemplo estamos usando uma interface chamada `IFanFactory`, mas ao invés de usamos uma interface, também podemos usar uma classe abstrata em seu lugar. A classe abstrata precisa ter pelo menos um método abstrato não implementado que será implementado na subclasse para criar o objeto.

> ℹ️ **Importante**  
> Como os padrões de design são apenas uma forma particular de design e são independentes de linguagem, também podemos usar outra abordagem para definir o contato base para a criação de objetos, que seria "Definir uma interface para criar um objeto". Por exemplo, em JavaScript não temos conceito de classe ou interface abstrata, mas ainda podemos usar padrões de design. Para mais informações, dê uma olhada nesta postagem do [blog de Rob Dodson](https://robdodson.me/posts/javascript-design-patterns-factory/).

Continuemos com a definição: **..., mas deixa que as subclasses decidirem qual classe instanciar**. Vamos criar subclasses que decidirão qual classe concreta será usada para criar a instância.

Para criar três tipos de objetos, nomeadamente TableFan, CeilingFan e ExhaustFan, precisamos criar três tipos de fábricas ou subclasses de `IFanFactory`. Essas três fábricas implementarão a interface `IFanFactory`.

```csharp
class TableFanFactory : IFanFactory { ... }

class CeilingFanFactory : IFanFactory { ... }

class ExhaustFanFactory : IFanFactory { ... }
```


Novamente, continuemos com a definição: **...Factory Method permite que uma classe adie a instanciação para subclasses**. Aqui `IFan CreateFan();` é um Factory Method. 
Dentro do método CreateFan (que é o Factory Method) em uma classe Factory concreta (TableFanFactory, etc.), especificamos qual classe exata irá ser instanciado para criar o objeto `Fan`. 
Portanto, `IFanFactory` está adiando a tomada de decisão da classe concreta para suas subclasses, ou seja, TableFanFactory, CeilingFanFactory e ExhaustFanFactory.

## Quando usar o padrão de método de fábrica

A complexidade aumentou. 
Para criar três tipos de objetos (TableFan, CeilingFan e ExhaustFan), tivemos de criar três classes Factories, enquanto no [Simple Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory) criamos apenas uma Factory. 

Agora surge a pergunta: por que precisamos usar o Factory Method Pattern, já que podemos conseguir o mesmo resultado com o [Simple Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory)? 

Simples. 
Na [definição do problema](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/FactoryMethod/Version%2001#problema) foi mencionando um dos motivos e vimos todo o problema que se desdobraria por conta de um novo requisito. 
Usando o Factory Method Pattern, **não adicionamos novas condições no `switch case`** como pode ser visto no [Simple Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory) (vide [Prós e contras do Factory Method Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/FactoryMethod/Version%2001#pr%C3%B3s-e-contras-do-factory-method-pattern)). 


```csharp
class WallFan : IFan { ... }
```

Agora a implementação do cliente fica:

```csharp
// O código do cliente é o seguinte:
static void Main(string[] args)
{
     // A interface para criar um objeto IFanFactory, mas deixa que as subclasses decidirem qual classe instanciar.
     IFanFactory fanFactory = new WallFanFactory();
	 
	 // Adie a instanciação para subclasses que será criada apenas no CreateFan().
     IFan fan = fanFactory.CreateFan();

     // Usando o objeto criado seguindo a regra de negócio.
     fan.SwitchOn();

     Console.ReadLine();
 }
```

## Prós e contras do Factory Method Pattern

|Prós   |Contras|
|-------|-------|
| Mantemos o Princípio de Responsabilidade Única (Single Responsibility Principle), ou seja, você move o código de criação de um "produto" para um único local do programa, facilitando a manutenção do código. | O código pode se tornar mais complicado, pois você precisa introduzir muitas subclasses novas para implementar o padrão. O melhor cenário é quando você está introduzindo o padrão em uma hierarquia existente de classes "criadoras". |
| Mantemos o Princípio Aberto-Fechado (Open Close Principle), ou seja, quando surgiu um novo requisito, não fizemos alterações no código existente, criamos apenas uma Factory adicional sem quebrar o código cliente existente. | |
| Escrever casos de teste de unidade é fácil com o Factory Method Pattern em comparação com o [Simple Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory), uma vez que o `switch case` (ou blocos longos de if-else) não é usado. | |
| Para oferecer suporte a produtos adicionais, não modificamos o código existente, apenas adicionamos uma nova classe Factory, portanto, não há necessidade de executar novamente os testes de unidade antigos existentes. | |
| O cliente chama `CreateFan` (Factory Method) sem saber como e qual tipo real de objeto foi criado. | |
| Se estivermos usando uma classe abstrata como `BaseFanFactory` (em vez de `IFanFactory`), podemos fornecer implementação de métodos comuns na classe abstrata `BaseFanFactory`, apenas declarar o método `CreateFan` como abstrato. Com base nos requisitos, podemos ter métodos mais abstratos em `BaseFanFactory`. | |

## Conclusão

Entendemos o uso do Factory Method Pattern com um passo a passo. Compreendemos o contexto do Factory Method Pattern e como ele é diferente do [Simple Factory Pattern](https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory). 
Mas ele só pode criar apenas um tipo de produto (que implementa `IFan` em nosso exemplo), então como podemos criar um conjunto/coleção de produtos relacionados? Para resolver isto o [Abstract Factory Pattern]() tem essa resposta e proposito.

## Fontes

- https://www.pentalog.com/blog/design-patterns/factory-method-design-pattern/
- https://stackoverflow.com/questions/20848082/motivation-for-simple-factory-and-factory-method-pattern
- https://www.oodesign.com/factory-method-pattern
- https://web.archive.org/web/20170821180919/https://coding-geek.com/design-pattern-factory-patterns/
- https://web.archive.org/web/20161027171211/http://corey.quickshiftconsulting.com/blog/first-post
- https://dotnettutorials.net/lesson/factory-method-design-pattern-csharp/
- https://github.com/AbstractSoft/design_patterns/tree/main/FactoryMethod