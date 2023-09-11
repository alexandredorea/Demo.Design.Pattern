namespace Demo.Design.Pattern.FactoryMethod.Interfaces;

/// <summary>
/// A Creator Class CreditCardFactory declara o método fábrica que retornará um objeto de uma classe Produto.
/// As subclasses CreditCardFactory geralmente fornecem a implementação do método MakeProduct.
/// </summary>
internal abstract class CreditCardFactory
{
    protected abstract ICreditCard MakeProduct();

    /// <summary>
    /// Observe também que a principal responsabilidade do Criador não é criar produtos.
    /// Geralmente, ele contém alguma lógica de negócios central que depende de objetos Product, retornados pelo método factory.
    /// </summary>
    /// <returns></returns>
    internal ICreditCard CreateProduct()
    {
        // Chama o método MakeProduct que irá criar e retornar o objeto apropriado.
        ICreditCard creditCard = MakeProduct();
        // Devolve o objeto ao cliente
        return creditCard;
    }
}