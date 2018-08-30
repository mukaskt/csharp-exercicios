using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercicio 1
            Console.WriteLine("1. Escreva um aplicativo que apresente os números de 1 a 40 separados por um espaço em branco, da seguinte maneira:");
            Console.WriteLine("\nA. Use uma única instrução Console.Write:");
            Console.Write("1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28 29 30 31 32 33 34 35 36 37 38 39 40");
           
            //B
            Console.WriteLine("\nB. Use quatro instruções Console.Write:");
            Console.Write(" 1 2 3 4 5 6 7 8 9 10");
            Console.Write(" 11 12 13 14 15 16 17 18 19 20");
            Console.Write(" 21 22 23 24 25 26 27 28 29 30");
            Console.Write(" 31 32 33 34 35 36 37 38 39 40");
            Console.ReadKey();
            Console.Clear();


            // Exercicio 2
            int x = 2;
            int y = 3;

            Console.WriteLine("2. O que aparece na janela do console, quando cada uma das instruções C# abaixo são executadas, para x = 2 e y = 3 ? ");
            Console.WriteLine("\na. Console.WriteLine(“x = ” + x);");
            Console.WriteLine("x = " + x);

            Console.WriteLine("\nb. Console.WriteLine(“O valor de x + x é ” + (x + x));");
            Console.WriteLine("O valor de x + x é " + (x + x));

            Console.WriteLine("\nc. Console.WriteLine(“x = ”);");
            Console.WriteLine("x = ");

            Console.WriteLine("\nd. Console.WriteLine((x + y) + “ = “ + (y + x));");
            Console.WriteLine((x + y) + " = " + (y + x));


            Console.WriteLine("\n\n\n");
            Console.ReadKey();

            Console.Clear();

            // Exercicio 3
            Console.WriteLine(@"3. O que o código a seguir imprime? Console.WriteLine(“*\n**\n***\n****\n*****”);");
            Console.WriteLine("*\n**\n***\n****\n*****");
            Console.ReadKey();
            Console.Clear();


            // Exercicio 4  
            Console.WriteLine("4. O que o código a seguir imprime?");
            Console.WriteLine("Console.Write(“*”);\nConsole.Write(“***”);\nConsole.WriteLine(“*****”);\nConsole.Write(“****”);\nConsole.WriteLine(“**”);\n");
            Console.Write("*");
            Console.Write("***");
            Console.WriteLine("*****");
            Console.Write("****");
            Console.WriteLine("**");
            Console.ReadKey();
            Console.Clear();

            // Exercicio 5
            Console.WriteLine("5. Escreva um programa que leia o nome, o sobrenome e o número de matrícula de um estudante. Em seguida, formate e imprima os dados " +
                "lidos da seguinte forma: 99999 - nome sobrenome, onde, o número de matrícula e nome deverão ter cores de fonte diferentes à sua escolha. Dica: " +
                "pesquise pela propriedade Console.ForegroundColor");

            Console.WriteLine("\nBem vindo");
            Console.WriteLine("\nDigite seu nome");
            var nome = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            var sobrenome = Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("\nDigite seu numero da matricula");
            var matricula = Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("\nBem Vindo");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write($"{matricula}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" - ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"{nome}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" {sobrenome}");
            Console.ResetColor();
            Console.Write("\nPress any key to exit..");

            Console.ReadKey(true);
            Console.Clear();

            // Exercicio 6
            Console.WriteLine("6. Escreva um programa que solicite do usuário dois números, e imprima o resultado da soma, subtração, multiplicação e divisão.");
            Console.WriteLine("Digite um número positivo inteiro, diferente de zero");

            int n1, n2;
            int soma, sub, div, mult;

            Console.WriteLine("Digite um número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            soma = n1 + n2;
            sub = n1 - n2;
            div = n1 / n2;
            mult = n1 * n2;

            Console.WriteLine("A soma é: " + soma);
            Console.WriteLine(" A subtração é: " + sub);
            Console.WriteLine(" A divisão é " + div);
            Console.WriteLine(" A multiplicação é " + mult);

            Console.ReadKey();
            Console.Clear();

            // Exercicio 7
            Console.WriteLine("Escreva um programa que receba como entrada o raio de um círculo e imprima o diâmetro, a circunferência e a área. " +
                "Para isso, utilize as fórmulas: diâmetro = 2r; circunferência = 2πr, área = πr² ");

            const double PI = 3.14D;
            double area = 0;
            double raio = 0;
            double diam = 0;
            double circ = 0;

            Console.Write("Qual o valor de raio? ");
            raio = double.Parse(Console.ReadLine());

            area = PI * raio * raio;
            diam = 2 * raio;
            circ = PI * diam;

            Console.Write("\n\tA área do circulo é: " + area);
            Console.Write("\n\tO diâmetro do circulo é: " + diam);
            Console.Write("\n\tA circunferência do circulo é" + circ);

            Console.ReadKey();
            Console.Clear();


            // Exercicio 8
            /*
             * 8. Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. 
             * Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro 
             * número não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.
             */

            Console.WriteLine("Escreva um programa que leia dois números inteiros e determine e verifique se o primeiro é um múltiplo do segundo. " +
                "Por exemplo: se o usuário digitar 15 e 3, o primeiro número será múltiplo do segundo; se o usuário digitar 2 e 4, o primeiro número " +
                "não será múltiplo do segundo. Dica: use o operador módulo para obter o resto da divisão.");
            Console.WriteLine("Digite um número positivo inteiro, diferente de zero");


            int s;
            int f;
            int resto = 0;

            Console.WriteLine("Informe um valor para a:");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe um valor para b:");
            f = Convert.ToInt32(Console.ReadLine());

            resto = s % f;

            if (resto == 0)
            {

                Console.WriteLine($"{s} é divisivel de {f}");

            }


            else
            {

                Console.WriteLine($"{s} não é divisivel de {f}");

                Console.ReadKey();
                Console.Clear();



                // Exercicio 9

                /*
             * 9. Escreva um programa que receba como entrada um número de 5 dígitos, separe o número em dígitos individuais e os imprima separados por 
             * 3 espaços cada um. Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4    2    3    3    9. Dica: utilize as operações
             * de divisão e módulo para extrair cada dígito do número.
             */
                Console.WriteLine("9. Escreva um programa que receba como entrada um número de 5 dígitos, separe o número em dígitos individuais e os imprima " +
                    "separados por 3 espaços cada um. Por exemplo, se o usuário digitar 42339, o programa deverá imprimir: 4    2    3    3    9. Dica: utilize " +
                    "as operações de divisão e módulo para extrair cada dígito do número.");


                int unidade = 0;
                int dezena = 0;
                int centena = 0;
                int unidadeDeMilhar = 0;
                int DezenaDeMilhar = 0;
                int restoDivisao = 0;
                int quociente = 0;

                const int DECIMAL = 10;

                // Lè dado do usuario
                Console.WriteLine("Digite um número de cinco digitos: ");
                Console.Write("\nNúmero: ");
                int numeroCincoDigitos = Int32.Parse(Console.ReadLine());

                //Obtem digitos das unidades
                restoDivisao = numeroCincoDigitos % DECIMAL;
                quociente = numeroCincoDigitos / DECIMAL;
                unidade = restoDivisao;


                //Obtem digitos das dezenas 
                restoDivisao = numeroCincoDigitos % DECIMAL;
                quociente = numeroCincoDigitos / DECIMAL;
                dezena = restoDivisao;

                //Obtem digitos das centenas
                restoDivisao = numeroCincoDigitos % DECIMAL;
                quociente = numeroCincoDigitos / DECIMAL;
                centena = restoDivisao;

                //Obtem digitos das unidades de milhar  
                restoDivisao = numeroCincoDigitos % DECIMAL;
                quociente = numeroCincoDigitos / DECIMAL;
                unidadeDeMilhar = restoDivisao;

                //Obtem digitos das dezenas de milhar
                DezenaDeMilhar = quociente;
                Console.WriteLine("Número espaçado: {0}   {1}   {2}   {3}   {4}", DezenaDeMilhar, unidadeDeMilhar, centena, dezena, unidade);

                Console.WriteLine("\n\n");

                Console.ReadKey();
                Console.Clear();



                // Exercicio 10

                /*
            * 10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.
            */
                Console.WriteLine("10. Escreva um programa que calcule o quadrado e o cubo dos números de 0 a 10, e imprima os valores em forma de tabela.");

                Console.WriteLine("\n Número Quadrado Cubo");

                // Condição
                for (int i = 0; i <= 10; i++)

                    Console.WriteLine((i) + "\t" + (i * i) + "\t" + (i * i * i));


                Console.ReadKey(true);






            }
        }


    }
}