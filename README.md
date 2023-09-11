# Padrão de projeto ou Design Pattern


## Introdução

[Meir Lehman](https://pt.wikipedia.org/wiki/Meir_M._Lehman) uma vez disse que "*grandes sistemas de software nunca são concluídos, eles simplesmente continuam evoluindo*". Pensando nesta ideia, percebemos que os problemas no desenvolvimento de softwares surgem cada vez mais. E foi assim alguns programadores mais experientes começaram a perceber que os mesmos problemas voltavam a aparecer varias e varias vezes; que a solução para eles eram sempre os mesmos e, então, começaram a catalogar esses "padrões". E foi em 1977 o conceito de *Design Pattern* foi apresentado por [Christopher Alexander](https://pt.wikipedia.org/wiki/Christopher_Alexander) e, em seus livros [Uma linguagem de padrões](https://www.amazon.com/-/pt/dp/B07J1T8P1W/), [Notas sobre a síntese da forma](https://www.amazon.com/-/pt/dp/B09Z9LNFG5/) e [A maneira atemporal de construir](https://www.amazon.com/-/pt/dp/0195024028/), ele estabelece o que um *Pattern* deve ter.


## O que é um padrão de projeto?

Padrão de Projeto ou Design Pattern é uma solução típica para um problema comum e/ou recorrente no desenvolvimento de software. Eles são como plantas de obra pré fabricadas que você pode customizar para resolver um problema de projeto em seu código.

Você não pode apenas encontrar um padrão e copiá-lo para dentro do seu programa, como você faz com funções e bibliotecas que encontra por aí. O padrão não é um pedaço de código específico, mas um conceito geral para resolver um problema em particular. Você pode seguir os detalhes do padrão e implementar uma solução que se adeque às realidades do seu próprio programa.

Os padrões as vezes são confundidos com algoritmos, porque ambos os conceitos descrevem soluções típicas para alguns problemas conhecidos. Enquanto um algoritmo sempre define um conjunto claro de ações para atingir uma meta, um padrão é mais uma descrição de alto nível de uma solução. O código do mesmo padrão aplicado para dois programas distintos pode ser bem diferente.

Uma analogia a um algoritmo é que ele seria uma receita de comida: ambos têm etapas claras para chegar a um objetivo. Por outro lado, um padrão é mais como uma planta de obras: você pode ver o resultado e suas funcionalidades, mas a ordem exata de implementação depende de você.


## Do que consiste um padrão?

A maioria dos padrões são descritos formalmente para que as pessoas possam reproduzi-los em diferentes contextos. Aqui estão algumas seções que são geralmente presentes em uma descrição de um padrão:

- O **Propósito** do padrão descreve brevemente o problema e a solução.
- A **Motivação** explica a fundo o problema e a solução que o padrão torna possível.
- As **Estruturas** de classes mostram cada parte do padrão e como se relacionam.
- **Exemplos de código** em uma das linguagens de programação populares tornam mais fácil compreender a ideia por trás do padrão.

Alguns catálogos de padrão listam outros detalhes úteis, tais como a aplicabilidade do padrão, etapas de implementação, e relações com outros padrões.


## História dos padrões

Quem inventou os padrões de projeto? Essa é uma boa pergunta, mas não muito precisa. Os padrões de projeto não são conceitos obscuros e sofisticados, é bem o contrário. Os padrões são soluções típicas e já consolidadas para problemas comuns em projetos orientados a objetos. Quando uma solução é repetida de novo e de novo em vários projetos, alguém vai eventualmente colocar um nome para ela e descrever a solução em detalhe. É basicamente assim que um padrão é descoberto.

O conceito de padrões foi primeiramente descrito por [Christopher Alexander](https://pt.wikipedia.org/wiki/Christopher_Alexander), em 1977 em seu livro [Uma linguagem de padrões](https://www.amazon.com/-/pt/dp/B07J1T8P1W/). O livro descreve uma “linguagem” para o projeto de um ambiente urbano. As unidades dessa linguagem são os padrões. Eles podem descrever quão alto as janelas devem estar, quantos andares um prédio deve ter, quão largas as áreas verdes de um bairro devem ser, e assim em diante. Posteriormente ele aborbou mais sobre "padrões" em [Notas sobre a síntese da forma](https://www.amazon.com/-/pt/dp/B09Z9LNFG5/) e [A maneira atemporal de construir](https://www.amazon.com/-/pt/dp/0195024028/), consolidando praticamente o que um *Pattern* deve ter.

A ideia foi seguida por quatro autores: [Erich Gamma](https://en.wikipedia.org/wiki/Erich_Gamma), [John Vlissides](https://en.wikipedia.org/wiki/John_Vlissides), [Ralph Johnson](https://en.wikipedia.org/wiki/Ralph_Johnson_(computer_scientist)), e [Richard Helm](https://en.wikipedia.org/wiki/Richard_Helm). E em 1994, antes mesmo de [James Gosling](https://pt.wikipedia.org/wiki/James_Gosling) apresentar a linguagem de programação Java para o mundo, eles publicaram o livro [Padrões de Projetos: Soluções Reutilizáveis de Software Orientados a Objetos](https://www.amazon.com.br/Padr%C3%B5es-Projetos-Solu%C3%A7%C3%B5es-Reutiliz%C3%A1veis-Orientados/dp/8573076100), no qual eles aplicaram o conceito de padrões de projeto para programação. O livro mostrava 23 padrões que resolviam vários problemas de projeto orientado a objetos e se tornou um best-seller rapidamente. Devido a seu longo título, as pessoas começaram a chamá-lo simplesmente de “o livro da gangue dos quatro (gang of four)” que logo foi simplificado para o “livro GoF”.

Desde então, dúzias de outros padrões orientados a objetos foram sendo catalogados. A “abordagem por padrões” se tornou muito popular em outros campos de programação, e muitos desses padrões agora também existem fora do projeto orientado a objetos. 


## Por que devo aprender padrões?

A verdade é que você pode conseguir trabalhar como um programador por muitos anos sem saber sobre um único padrão. Muitas pessoas fazem exatamente isso. Ainda assim, contudo, você estará implementando alguns padrões mesmo sem saber. Então, por que gastar tempo para aprender sobre eles?

Os padrões de projeto são um kit de ferramentas para soluções tentadas e testadas para problemas comuns em projeto de software. Mesmo que você nunca tenha encontrado esses problemas, saber sobre os padrões é ainda muito útil porque eles ensinam como resolver vários problemas usando princípios de projeto orientado a objetos.

Os padrões de projeto definem uma linguagem comum que você e seus colegas podem usar para se comunicar mais eficientemente. Você pode dizer, “Ah, é só usar um Singleton para isso,” e todo mundo vai entender a ideia por trás da sua sugestão. Não é preciso explicar o que um singleton é se você conhece o padrão e seu nome.


## Crítica dos padrões

Parece que apenas uma pessoa preguiçosa ainda não criticou os padrões de projeto. Vamos dar uma olhada aos argumentos mais típicos contra o uso de padrões:


### Gambiarras para uma linguagem de programação fraca 

Geralmente a necessidade de padrões surge quando as pessoas escolhem uma linguagem de programação ou uma tecnologia que tem uma deficiência no nível de abstração. Neste caso, os padrões se transformam em gambiarras que dão à linguagem superpoderes muito necessários.

Por exemplo, o padrão [Strategy]() pode ser implementado com uma simples função anônima (lambda) na maioria das linguagens de programação moderna.

> ℹ️ **Informação**  
> Esse ponto de vista foi primariamente expresso por [Paul Graham](https://pt.wikipedia.org/wiki/Paul_Graham) no estudo [Revenge of the Nerds](http://www.paulgraham.com/icad.html). Leia mais sobre isso na [Página Wiki](http://wiki.c2.com/?AreDesignPatternsMissingLanguageFeatures).


### Soluções ineficientes

Os padrões tentam sistematizar abordagens que já são amplamente usadas. Essa unificação é vista por muitos como um dogma e eles implementam os padrões “direto ao ponto”, sem adaptá-los ao contexto de seus projetos.


### Uso injustificável

```
Se tudo que você tem é um martelo, tudo parece com um prego.
```

Esse é o problema que assombra muitos novatos que acabaram de se familiarizar com os padrões. Tendo aprendido sobre eles, tentam aplicá-los em tudo, até mesmo em situações onde um código mais simples seria suficiente.


## Classificação dos padrões

Padrões de projeto diferem por sua complexidade, nível de detalhes, e escala de aplicabilidade ao sistema inteiro sendo desenvolvido. Eu gosto da analogia com a construção de uma rodovia: você sempre pode fazer uma intersecção mais segura instalando algumas sinaleiras ou construindo passarelas para pedestres.

Os padrões mais básicos e de baixo nível são comumente chamados idiomáticos. Eles geralmente se aplicam apenas à uma única linguagem de programação.

Os padrões mais universais e de alto nível são os padrões arquitetônicos; desenvolvedores podem implementar esses padrões em praticamente qualquer linguagem. Ao contrário de outros padrões, eles podem ser usados para fazer o projeto da arquitetura de toda uma aplicação.

Além disso, todos os padrões podem ser categorizados por seu propósito ou intenção. Aqui vamos tratar dos três grupos principais de padrões:

- **Os padrões criacionais** fornecem mecanismos de criação de objetos que aumentam a flexibilidade e a reutilização de código.
- **Os padrões estruturais** explicam como montar objetos e classes em estruturas maiores, enquanto ainda mantém as estruturas flexíveis e eficientes.
- **Os padrões comportamentais** cuidam da comunicação eficiente e da assinalação de responsabilidades entre objetos.

É importante comentar também que além das categorias, estes padrões podem ser classificados em relação ao seu escopo: Classe ou Objetos. 

- **Padrões com escopo de Classe** vão utilizar a herança para compor ou variar os objetos, mantendo a flexibilidade do sistema. 
- **Padrões com escopo de Objeto** vão delegar as suas responsabilidades para um objeto.

A tabela a seguir permite visualizar a classificação dos padrões de projeto, de acordo com os critérios falados:

<table style="width:100%">
	<thead>
		<tr> 
			<th colspan="2">&nbsp;</th>
			<th colspan="3" align="center">Proposito</th>
		</tr>
		<tr> 
			<th colspan="2">&nbsp;</th>
			<th align="center"><a href="https://github.com/alexandredorea/Demo.Design.Pattern/tree/master/src/1.%20Creational">Criação</a></th>
			<th align="center"><a href="http://example.com">Estrutura</a></th>
			<th align="center"><a href="http://example.com">Comportamento</a></th>
		</tr>
	</thead>
	<tbody>
		<tr> 
			<th rowspan="11" align="center">Escopo</th>
			<th align="center">Classe</th>
			<td><a href="http://example.com">Factory Method</a></td>
			<td><a href="http://example.com">Class Adapter</a></td>
			<td><a href="http://example.com">Interpreter <br> Template Method</a></td>
		</tr>
		<tr>
			<th rowspan="9" align="center">Objetos</th>
			<td><a href="http://example.com">Abstract Factory</a></td>
			<td><a href="http://example.com">Object Adapter</a></td>
			<td><a href="http://example.com">Chain of Reposponsability</a></td>
		</tr>
		<tr>
			<td><a href="http://example.com">Builder</a></td>
			<td><a href="http://example.com">Bridge</a></td>
			<td><a href="http://example.com">Command</a></td>
		</tr>
		<tr>
			<td><a href="http://example.com">Prototype</a></td>
			<td><a href="http://example.com">Composite</a></td>
			<td><a href="http://example.com">Iterator</a></td>
		</tr>
		<tr>
			<td><a href="http://example.com">Singleton</a></td>
			<td><a href="http://example.com">Decorator</a></td>
			<td><a href="http://example.com">Mediator</a></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td><a href="http://example.com">Facede</a></td>
			<td><a href="http://example.com">Memento</a></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td><a href="http://example.com">Flyweight</a></td>
			<td><a href="http://example.com">Observer</a></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td><a href="http://example.com">Proxy</a></td>
			<td><a href="http://example.com">State</a></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td><a href="http://example.com">Strategy</a></td>
		</tr>
		<tr>
			<td>&nbsp;</td>
			<td>&nbsp;</td>
			<td><a href="http://example.com">Visitor</a></td>
		</tr>
	</tbody>
</table>