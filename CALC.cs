using System;

namespace CALC
{
    class Program
    {

        enum menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }


        static void Soma()
        {

            Console.WriteLine("Será realizada a soma de dois números!");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Será realizada a subtração de dois números!");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("O resultado da subtração é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Será realizada a divisão de dois números!");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b; //cast para conversão de tipo!
            Console.WriteLine("O resultado da divisão é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Será realizada a multiplicação de dois números!");
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("O resultado da multiplicação é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Será realizada a potência de dois números!");
            Console.Write("Digite o número desejado: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Digite a potência ao qual quer elevá-lo: ");
            double b = int.Parse(Console.ReadLine());
            double resultado = 0;
            resultado = Math.Pow(a, b);
            Console.WriteLine("O resultado da potência é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Será calculada a raíz quadrada de um número!");
            Console.Write("Digite o número desejado: ");
            double a = int.Parse(Console.ReadLine());
            double resultado = 0;
            resultado = Math.Sqrt(a);
            Console.WriteLine("O resultado da raíz quadrada é: " + resultado);
            Console.WriteLine("Aperte ENTER para retornar ao menu inicial. :D");
            Console.ReadLine();

        }
        static void Main(string[] args)
        {

           

            //menu que sempre reseta!

            bool escolhas = false;
            while (!escolhas) //(!) = inverte a condição.
            {
                Console.WriteLine("Seja bem vindo(a) ao CALC!\nSelecione uma das opções abaixo:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                menu opcao = (menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case menu.Soma:
                        Soma();
                        break;
                    case menu.Subtracao:
                        Subtracao();
                        break;
                    case menu.Divisao:
                        Divisao();
                        break;
                    case menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case menu.Potencia:
                        Potencia();
                        break;
                    case menu.Raiz:
                        Raiz();
                        break;
                    case menu.Sair:
                        escolhas = true;
                        break;
                }

                Console.Clear();
            }

            
        }
    }
}
