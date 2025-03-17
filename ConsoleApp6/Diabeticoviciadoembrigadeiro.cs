using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Diabeticoviciadoembrigadeiro
    {
        static void Main(string[] args)
        {
            Console.WriteLine("|---------------------------------------------------------------------------------------------------------|");
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Oi {nome}, oque você gostaria de fazer? ");
            Console.Write("Você gostaria de Sair ou Entrar?");
            string escolha = Console.ReadLine();

            
           //verificaçao de enter e entrar

            if (escolha == "entrar" || escolha == "Entrar" || escolha == "ENTRAR") // esses 8 comerciais && sao o and do python
            {
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine("1- Somar");
                Console.WriteLine("2- Multiplicar");
                Console.WriteLine("3- Subtrair");
                Console.WriteLine("4- Dividir");
                Console.WriteLine("5- Tabela de multiplicaçaõ ");
                string opçao = Console.ReadLine();

                if (opçao == "Somar")
                {
                    Console.Write("Digite um numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite mais um numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
                }

                if (opçao == "Multiplicar")
                {
                    Console.Write("Digite um numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite mais um numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{n1} x {n2} = {n1 * n2}");
                }


                if (opçao == "Subtrair")
                {
                    Console.Write("Digite um numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite mais um numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
                }


                if (opçao == "Dividir")
                {
                    Console.Write("Digite um numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    Console.Write("Digite mais um numero: ");
                    int n2 = int.Parse(Console.ReadLine());

                    if (n1 != 0 && n2 != 0)
                    {
                        Console.WriteLine($"{n1} \u00f7 {n2} = {n1 / n2}");
                    }

                    else
                    {
                        Console.WriteLine("Digite um numero que nao seja 0");
                    }


                }


                if (opçao == "Tabela")
                {
                    Console.Write("Digite um numero: ");
                    int n1 = int.Parse(Console.ReadLine());

                    for (int contador = 1; contador <= 10; contador++)
                    {
                        Console.WriteLine($"{n1} x {contador} = {n1 * contador}");
                    }


                }


            }

           
            //verificaçao de exit ou sair
            
            else if (escolha == "Exit" || escolha == "Sair") // essas barras || sao o or do python
            {
                Console.WriteLine("Saindo do programa........");
                Console.WriteLine("Aguarde um instante.....");

                Environment.Exit(0); //sempre que eu querer que o codigo saia,eu tenho que escrever saporra
            }

            else
            {
                Console.WriteLine("Opção invalida, escolha Sair ou Entrar");
            }

        }
    }
}
