using Demo.Design.Pattern.FactoryMethod.Application.Factories;
using Demo.Design.Pattern.FactoryMethod.Application.Interfaces;

IFanFactory fanFactory = new WallFanFactory();

// Criação de um ventilador usando Factory Method Pattern
IFan fan = fanFactory.CreateFan();

// Usando o objeto criado
fan.SwitchOn();

Console.ReadLine();