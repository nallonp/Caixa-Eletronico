using CaixaEletronico;
using CaixaEletronico.Tesouro;
using System;
using System.Collections.Generic;

namespace view
{
    class Program
    {
        static void Main(string[] args)
        {
            var cofre = new Cofre(new Dictionary<ENota, uint>());
            //cofre.Armazenar(ENota.VINTE, 2);
            cofre.Armazenar(ENota.CINQUENTA, 3);
            cofre.Armazenar(ENota.DEZ, 1);
            var retirada = 100;
            Console.WriteLine($"Antes da retirada.");
            Imprimir(cofre);
            try
            {
                cofre.Retirar((uint)retirada);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine($"Depois da retirada: ({retirada}).");
            Imprimir(cofre);
        
            //    ConsoleKey key;
            //    var tesouraria = new Tesouraria(new Cofre(), new List<RegistroDeTransacao>());

            //    var opcoesDoMenu = new Dictionary<ConsoleKey, String>();
            //    opcoesDoMenu.Add(ConsoleKey.F1, "Depositar 10");
            //    opcoesDoMenu.Add(ConsoleKey.F2, "Depositar 20");
            //    opcoesDoMenu.Add(ConsoleKey.F3, "Depositar 50");
            //    opcoesDoMenu.Add(ConsoleKey.F4, "Realizar Saque");
            //    opcoesDoMenu.Add(ConsoleKey.F5, "Verificar Saldo");
            //    opcoesDoMenu.Add(ConsoleKey.F10, "Sair");
            //    do
            //    {
            //        Console.Clear();
            //        Console.WriteLine("*** CAIXA ELETRONICO ***");
            //        Console.WriteLine("*** DIGITE A OPÇÃO DE ATENDIMENTO ***");
            //        foreach (var opcao in opcoesDoMenu)
            //        {
            //            Console.WriteLine(opcao.Key + " - " + opcao.Value);
            //        }
            //        key = Console.ReadKey(true).Key;
            //        Console.Clear();
            //        if (key != ConsoleKey.F10)
            //            switch (key)
            //            {
            //                case ConsoleKey.F1:
            //                    Console.WriteLine("Quantas notas deseja depositar?");
            //                    tesouraria.ProcessarTransacao(new Deposito(new Montante(ENota.DEZ,Convert.ToUInt32(Console.ReadLine()))));
            //                    break;
            //                case ConsoleKey.F2:
            //                    Console.WriteLine("Quantas notas deseja depositar?");
            //                    tesouraria.ProcessarTransacao(new Deposito(new Montante(ENota.VINTE, Convert.ToUInt32(Console.ReadLine()))));
            //                    break;
            //                case ConsoleKey.F3:
            //                    Console.WriteLine("Quantas notas deseja depositar?");
            //                    tesouraria.ProcessarTransacao(new Deposito(new Montante(ENota.CINQUENTA, Convert.ToUInt32(Console.ReadLine()))));
            //                    break;
            //                case ConsoleKey.F4:
            //                    Console.WriteLine("Digite o valor: ");
            //                    Console.ReadKey(true);
            //                    break;
            //                case ConsoleKey.F5:
            //                    Console.WriteLine("Relatório de notas: ");
            //                    Console.ReadKey(true);
            //                    break;
            //                default:
            //                    Console.WriteLine("Digite uma opção válida.\nPressione qualquer tecla para continuar...");
            //                    Console.ReadKey(true);
            //                    break;
            //            }
            //    } while (key != ConsoleKey.F10);
        }
        static void Imprimir(Cofre cofre)
        {
            foreach (var item in cofre._Reservas)
            {
                Console.WriteLine($"K: {item.Key} - V: {item.Value}");
            }
        }
    }
}