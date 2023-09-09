using Demo.Design.Pattern.Simplefactory.Enumerators;
using Demo.Design.Pattern.Simplefactory.Factories;
using Demo.Design.Pattern.Simplefactory.Interfaces;

// Instanciado a fabrica
IFanFactory simpleFactory = new FanFactory();

// Criação de um ventilador usando Simple Factory
IFan fan = simpleFactory.CreateFan(FanType.TableFan);

// Usando o objeto criado
fan.SwitchOn();

Console.ReadKey();