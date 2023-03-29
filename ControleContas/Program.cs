
using ControleContas.Model;
using System.ComponentModel;

Cliente cliente1 = new Cliente("Fred", "12345678912", 2000);
Conta conta = new Conta("1234", cliente1);
Conta conta2 = new Conta("4321", 1000.99m, cliente1);
Conta conta3 = new Conta("654321", 2341.42m, cliente1);

Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");

Console.WriteLine($"O saldo total é {conta2.SaldoTotal}");

Console.WriteLine($"A conta de maior saldo é {conta3.ContaMaiorSaldo}");

conta.Titular = cliente1;

Console.WriteLine($"O titular da conta {conta.Numero} é o cliente {conta.Titular.Nome}");

// 29 de Março de 2023
Console.WriteLine($"Saldo da conta {conta2.Numero} antes o deposito: {conta2.Saldo}!!");
conta2.Deposito(99.42m);
Console.WriteLine($"Saldo da conta {conta2.Numero} após o deposito: {conta2.Saldo}!!");
conta2.Deposito(-99.42m);
Console.WriteLine($"Saldo da conta {conta2.Numero} após o deposito inválido: {conta2.Saldo} !!");

conta2.Saque(100.10m);
Console.WriteLine($"O saldo da conta {conta2.Numero} após o saque de: {conta2.Saldo}!!");
