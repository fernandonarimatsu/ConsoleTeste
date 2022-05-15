using ConsoleTeste.SistemaBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTeste {
    public class Program {
        public static void Main(string[] args) {
            var conta = new Conta();
            conta.NomeConta = "Conta Teste";
            conta.NumeroConta = 970069;
            conta.Agencia = 4355;
            conta.Saldo = 1000;

            conta.Titular = new Titular() {
                Cpf = "03904529986",
                Rg = "49805594",
                Endereco = "Rua Patagonia",
                Nome = "Fernando"

            };

            Console.WriteLine("Olá " + conta.Titular.Nome);
            Console.WriteLine();

            Console.WriteLine("Seu saldo atual é R$: " + conta.VerSaldo());
            Console.WriteLine("-----------------------------");

            string sair;

            do {

                Console.WriteLine("Digite 1 para SAQUE \tDigite 2 para DEPÓSITO:");
                int opcao = Convert.ToInt16(Console.ReadLine());
                if (opcao == 1) {
                    Console.WriteLine("Qual o valor do saque? ");
                    conta.Sacar(Convert.ToDouble(Console.ReadLine()));

                }
                else {
                    Console.WriteLine("Qual o valor do depósito? ");
                    conta.Depositar(Convert.ToDouble(Console.ReadLine()));
                    Console.WriteLine("-----------------------------");
                }
                Console.WriteLine("Seu saldo após o depósito é R$: " + conta.VerSaldo());
                Console.WriteLine("-----------------------------");

                Console.WriteLine("Deseja Sair? SIM - NAO");
                sair = Console.ReadLine().ToUpper();

            } while (sair != "SIM");
            Console.Clear();
            Console.WriteLine("Fim da execução.....");
            Console.ReadKey();

        }
    }
}
