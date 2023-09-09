# Factory Method

Tamb�m conhecido como: M�todo f�brica, Construtor virtual


## Prop�sito

O Factory Method � um padr�o criacional de projeto que fornece uma interface para criar objetos, mas deixa que as subclasses decidirem qual classe instanciar. 
O Factory Method permite que uma classe adie a instancia��o para subclasses.

> Para ser claro sobre esta defini��o, entenderemos ela defini��o dividindo-a em partes.


## Problema

Tomando como base o exemplo aplicado no [Single Factory Pattern](). Digamos que a aplica��o come�a a crescer e agora a `FanFactory` precisa que fazer um novo tipo de ventilador chamado `WallFan`. 
Para adotar este novo requisito, temos que alterar o m�todo `CreateFan` e adicionar um `switch case` para o tipo `WallFan`. Se novamente um novo tipo de ventilador for introduzido, mais um caso precisar� ser adicionado. 
Isto ser� uma viola��o do `Princ�pio Aberto-Fechado (Open Close Principle)` dos princ�pios SOLID. Com a ajuda do Factory Method Pattern podemos superar esse problema desta viola��o (j� que cada padr�o tem seu pr�prio lugar, vantagens e restri��es).


## Solu��o

Vamos come�ar com o mesmo c�digo. Usaremos a mesma interface chamada `IFan` que tinha dois m�todos conforme mostrado abaixo.

```csharp
interface IFan
{
    void SwitchOn();
    void SwitchOff();
}
```

Inicialmente nossa empresa pretendia criar apenas tr�s tipos de ventiladores chamados TableFan, CeilingFan e ExhaustFan. Todos os ventiladores ter�o os m�todos SwitchOn() e SwitchOff(), mas suas implementa��es podem ser diferentes. 
Vamos usar as mesmas classes e implementar interfaces `IFan`.

```csharp
class TableFan : IFan { ... }

class CeilingFan : IFan { ... }

class ExhaustFan : IFan { ... }
```


O c�digo � o mesmo usado no exemplo [Single Factory Pattern]().

Quando implementamos o **Factory Method Pattern**, temos que seguir seu design conforme mostrado no diagrama abaixo:

![image](https://github.com/alexandredorea/desafio-05/assets/11574354/6d215a12-9fe3-489b-977e-a73327239bf9)

Portanto, seguiremos seu design e explicaremos a defini��o do Factory Method Pattern.

De acordo com a defini��o ele "**fornece uma interface para criar objetos...**" ent�o vamos definir a interface que ter� um m�todo para criar Ventiladores. A implementa��o deste m�todo em subclasses ter� l�gica para criar objetos concretos. 

```csharp
interface IFanFactory
{
    IFan CreateFan();
}
```

> Observa��o:
> Neste exemplo estamos usando uma interface chamada `IFanFactory`, mas ao inv�s de usamos uma interface, tamb�m podemos usar uma classe abstrata em seu lugar. A classe abstrata precisa ter pelo menos um m�todo abstrato n�o implementado que ser� implementado na subclasse para criar o objeto.

> Importante:
> Como os padr�es de design s�o apenas uma forma particular de design e s�o independentes de linguagem, tamb�m podemos usar outra abordagem para definir o contato base para a cria��o de objetos, que seria "Definir uma interface para criar um objeto". Por exemplo, em JavaScript n�o temos conceito de classe ou interface abstrata, mas ainda podemos usar padr�es de design. Para mais informa��es, d� uma olhada nesta postagem do [blog de Rob Dodson](https://robdodson.me/posts/javascript-design-patterns-factory/).

Continuemos com a defini��o: **..., mas deixa que as subclasses decidirem qual classe instanciar**. Vamos criar subclasses que decidir�o qual classe concreta ser� usada para criar a inst�ncia.

Para criar tr�s tipos de objetos, nomeadamente TableFan, CeilingFan e ExhaustFan, precisamos criar tr�s tipos de f�bricas ou subclasses de `IFanFactory`. Essas tr�s f�bricas implementar�o a interface `IFanFactory`.

```csharp
class TableFanFactory : IFanFactory { ... }

class CeilingFanFactory : IFanFactory { ... }

class ExhaustFanFactory : IFanFactory { ... }
```


Novamente, continuemos com a defini��o: **...Factory Method permite que uma classe adie a instancia��o para subclasses**. Aqui `IFan CreateFan();` � um Factory Method. 
Dentro do m�todo CreateFan (que � o Factory Method) em uma classe Factory concreta (TableFanFactory, etc.), especificamos qual classe exata ir� ser instanciado para criar o objeto `Fan`. 
Portanto, `IFanFactory` est� adiando a tomada de decis�o da classe concreta para suas subclasses, ou seja, TableFanFactory, CeilingFanFactory e ExhaustFanFactory.

## Quando usar o padr�o de m�todo de f�brica

A complexidade aumentou. Para criar tr�s tipos de objetos (TableFan, CeilingFan e ExhaustFan), tivemos de criar tr�s classes Factories, enquanto no [Simple Factory Pattern]() criamos apenas uma Factory. 

Agora surge a pergunta: por que precisamos usar o Factory Method Pattern, j� que podemos conseguir o mesmo resultado com o [Simple Factory Pattern]()? 

Simples. Na [defini��o do problema]() foi mencionando um dos motivos: suponha que a empresa v� lan�ar um novo ventilador chamado `WallFan`. Este � um novo requisito. 
Usando o Factory Method Pattern, **n�o adicionamos novas condi��es no `switch case`** como pode ser visto no [Simple Factory Pattern]() (vide [Pr�s e contras do Factory Method Pattern]()). 


```csharp
class WallFan : IFan { ... }
```

Agora a implementa��o do cliente fica:

```csharp
// O c�digo do cliente � o seguinte:
static void Main(string[] args)
{
     // Cria��o de um ventilador usando Factory Method Pattern
     IFanFactory fanFactory = new WallFanFactory();
     IFan fan = fanFactory.CreateFan();

     // Usando o objeto criado
     fan.SwitchOn();

     Console.ReadLine();
 }
```

## Pr�s e contras do Factory Method Pattern

|Pr�s   |Contras|
|-------|-------|
| Mantemos o Princ�pio de Responsabilidade �nica (Single Responsibility Principle), ou seja, voc� move o c�digo de cria��o de um "produto" para um �nico local do programa, facilitando a manuten��o do c�digo. | O c�digo pode se tornar mais complicado, pois voc� precisa introduzir muitas subclasses novas para implementar o padr�o. O melhor cen�rio � quando voc� est� introduzindo o padr�o em uma hierarquia existente de classes "criadoras". |
| Mantemos o Princ�pio Aberto-Fechado (Open Close Principle), ou seja, quando surgiu um novo requisito, n�o fizemos altera��es no c�digo existente, criamos apenas uma Factory adicional sem quebrar o c�digo cliente existente. | |
| Escrever casos de teste de unidade � f�cil com o Factory Method Pattern em compara��o com o [Simple Factory Pattern](), uma vez que o `switch case` (ou blocos longos de if-else) n�o � usado. | |
| Para oferecer suporte a produtos adicionais, n�o modificamos o c�digo existente, apenas adicionamos uma nova classe Factory, portanto, n�o h� necessidade de executar novamente os testes de unidade antigos existentes. | |
| O cliente chama `CreateFan` (Factory Method) sem saber como e qual tipo real de objeto foi criado. | |
| Se estivermos usando uma classe abstrata como BaseFanFactory (em vez de IFanFactory), podemos fornecer implementa��o de m�todos comuns na classe abstrata BaseFanFactory, apenas declarar o m�todo CreateFan como abstrato. Com base nos requisitos, podemos ter m�todos mais abstratos em BaseFanFactory. | |

## Conclus�o

Entendemos o uso do Factory Method Pattern com um passo a passo. Compreendemos o contexto do Factory Method Pattern e como ele � diferente do [Simple Factory Pattern](). 
Mas ele s� pode criar apenas um tipo de produto (que implementa `IFan` em nosso exemplo), ent�o como podemos criar um conjunto/cole��o de produtos relacionados? Para resolver isto o [Abstract Factory Pattern]() tem essa resposta e proposito.

## Fontes

- https://www.pentalog.com/blog/design-patterns/factory-method-design-pattern/
- https://stackoverflow.com/questions/20848082/motivation-for-simple-factory-and-factory-method-pattern
- https://web.archive.org/web/20170821180919/https://coding-geek.com/design-pattern-factory-patterns/
- https://web.archive.org/web/20161027171211/http://corey.quickshiftconsulting.com/blog/first-post
- https://www.oodesign.com/factory-method-pattern
- https://github.com/AbstractSoft/design_patterns/tree/main/FactoryMethod