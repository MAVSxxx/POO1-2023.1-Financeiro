
using ControleContas.Model;
using System.ComponentModel;

Conta conta = new Conta("1234", 2500.20m);
Conta conta2 = new Conta("4321", 1000.99m);
Conta conta3 = new Conta("654321", 2341.42m);

Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");

Console.WriteLine($"O saldo total é {conta2.SaldoTotal}");

Console.WriteLine($"A conta de maior saldo é {conta3.ContaMaiorSaldo}");
