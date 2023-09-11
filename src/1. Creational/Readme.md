## Padrões de Criação

### Conceito 

Os padrões de criação tem como intenção principal abstrair o processo de criação de objetos, ou seja, a sua instanciação. Desta maneira o sistema não precisa se preocupar com questões sobre, como o objeto é criado, como é composto, qual a sua representação real. 

Quando se diz que o sistema não precisa se preocupar com a instanciação do objeto quer dizer que, se ocorrer alguma mudança neste ponto, o sistema em geral não será afetado. Isso é a famosa flexibilidade que os padrões de projeto buscam.

Os padrões de projeto criacionais podem ser categorizados em dois tipos:

- Com Escopo de Classe vão utilizar herança para garantir que a flexibilidade. Por exemplo, o padrão Factory Method pode criar várias subclasses para criar o produto. 
- Com Escopo de Objeto, como o Prototype, delegam para um objeto (no caso o protótipo) a responsabilidade de instanciar novos objetos.


#### Quando devemos usar esses padrões?

Na maioria das aplicações do mundo real um projeto é criado com diversas classes, e muitas classes significa que nós vamos tratar com muitos objetos. Se as criações desses objetos estiverem espalhadas pelo código. Isso vai levar a uma lógica mais complexa dificultando a manutenção da aplicação.

Então os padrões de projeto criacionistas eles nos ajudam a centralizar a lógica de criação de objetos facilitando a manutenção e tornando o código menos acoplado e mais coeso.

Lembrando que menos acoplado significa ser menos dependente de outros módulos e mais coeso significa ter responsabilidades mais definidas.

### Os padrões de projetos

- [x] [**Simple Factory**][simple_factory_pattern]
- [x] [**Factory Method**][factory_method_pattern]
- [ ] [**Abstract Factory**][abstract_factory_pattern]
- [ ] [**Builder**][builder_pattern]
- [ ] [**Prototype**][prototype_pattern]
- [ ] [**Singleton**][singleton_pattern]


[simple_factory_pattern]: <https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/SimpleFactory>
[factory_method_pattern]: <https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational/FactoryMethod>
[abstract_factory_pattern]: <>
[builder_pattern]: <>
[prototype_pattern]: <>
[singleton_pattern]: <>

