using System;
using System.Collections.Generic;
using CaixaEletronico;

namespace view
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey key;
            var cofre = new CofreV2();
            var opcoesDoMenu = new Dictionary<ConsoleKey, String>();
            opcoesDoMenu.Add(ConsoleKey.F1, "Depositar 10");
            opcoesDoMenu.Add(ConsoleKey.F2, "Depositar 20");
            opcoesDoMenu.Add(ConsoleKey.F3, "Depositar 50");
            opcoesDoMenu.Add(ConsoleKey.F4, "Realizar Saque");
            opcoesDoMenu.Add(ConsoleKey.F5, "Verificar Saldo");
            opcoesDoMenu.Add(ConsoleKey.F10, "Sair");
            do
            {
                Console.Clear();
                Console.WriteLine("*** CAIXA ELETRONICO ***");
                Console.WriteLine("*** DIGITE A OPÇÃO DE ATENDIMENTO ***");
                foreach (var opcao in opcoesDoMenu)
                {
                    Console.WriteLine(opcao.Key + " - " + opcao.Value);
                }
                key = Console.ReadKey(true).Key;
                Console.Clear();
                if (key != ConsoleKey.F10)
                    switch (key)
                    {
                        case ConsoleKey.F1:
                            cofre.Armazenar(ENota.DEZ, 1);
                            break;
                        case ConsoleKey.F2:
                            cofre.Armazenar(ENota.VINTE, 1);
                            break;
                        case ConsoleKey.F3:
                            cofre.Armazenar(ENota.CINQUENTA, 1);
                            break;
                        case ConsoleKey.F4:
                            Console.WriteLine("Digite o valor: ");
                            Console.ReadKey(true);
                            break;

                        case ConsoleKey.F5:
                            Console.WriteLine("Relatório de notas: ");
                            var relatorios = cofre.Relatorios;
                            Console.WriteLine("Saldo total: " + cofre.RetornarSaldo().ToString());
                            Console.ReadKey(true);
                            break;
                        default:
                            Console.WriteLine("Digite uma opção válida.\nPressione qualquer tecla para continuar...");
                            Console.ReadKey(true);
                            break;
                    }
            } while (key != ConsoleKey.F10);
        }
    }
}