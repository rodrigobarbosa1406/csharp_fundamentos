﻿using System;
using System.Globalization;

namespace Secao03 {
    class Secao03 {
        static void Main(string[] args)
        {
            int aula = 99;

            while (aula > 0)
            {
                Console.Write("Qual aula você quer acessar? Para encerrar digite zero...");
                aula = int.Parse(Console.ReadLine());

                if (aula > 0)
                {
                    if (aula == 18)
                    {
                        aula18();
                        Console.WriteLine();
                    }
                    else if (aula == 24)
                    {
                        Console.Write("Qual exercício você quer executar? ");
                        int exercicio = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (exercicio == 1)
                            exercicio01();
                        else if (exercicio == 2)
                            exercicio02();
                        else if (exercicio == 3)
                            exercicio03();
                        else if (exercicio == 4)
                            exercicio04();
                        else if (exercicio == 5)
                            exercicio05();
                        else if (exercicio == 6)
                            exercicio06();

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write("Aula inválida! ");
                        Console.WriteLine();
                    }
                } else
                {
                    Console.WriteLine();
                    Console.Write("Programa finalizado... ");
                }

                Console.WriteLine();
            }
        }

        private static void aula18()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é $ {preco2:F2}");
            Console.WriteLine();

            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }

        private static void exercicio01()
        {
            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
        }

        private static void exercicio02()
        {
            double pi = 3.14159;

            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        private static void exercicio03()
        {
            Console.WriteLine("Informe os valores de A, B, C e D...");
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b - c * d);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }

        private static void exercicio04()
        {
            Console.Write("Informe o número do funcionário: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor do salário por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = valorHora * horas;

            Console.WriteLine();
            Console.WriteLine("NÚMERO = " + numero);
            Console.WriteLine($"SALÁRIO = R$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void exercicio05()
        {
            Console.Write("Informe o código, a quantidade e o valor unitário da peça 1: ");
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(peca1[0]);
            int qtde1 = int.Parse(peca1[1]);
            double valorUnit1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            Console.Write("Informe o código, a quantidade e o valor unitário da peça 2: ");
            string[] peca2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(peca2[0]);
            int qtde2 = int.Parse(peca2[1]);
            double valorUnit2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorPagar = ((qtde1 * valorUnit1) + (qtde2 * valorUnit2));

            Console.WriteLine();
            Console.WriteLine($"VALOR A PAGAR: R$ {valorPagar.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void exercicio06()
        {
            Console.WriteLine("Informe os valores de A, B e C...");
            string[] valores = Console.ReadLine().Split(' ');
            double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"TRIÂNGULO: {triangulo(a, c).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {circulo(c).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPÉZIO: {trapezio(a, b, c).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {quadrado(b).ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETÂNGULO: {retangulo(a, b).ToString("F3", CultureInfo.InvariantCulture)}");
        }

        public static double triangulo(double _base, double altura)
        {
            double triangulo = ((_base * altura) / 2);

            return triangulo;
        }

        public static double circulo(double raio)
        {
            double pi = 3.14159;
            double area = pi * Math.Pow(raio, 2);
            
            return area;
        }

        public static double trapezio(double _base1, double _base2, double altura)
        {
            double trapezio = ((_base1 + _base2) / 2) * altura;
            
            return trapezio;
        }

        public static double quadrado(double lado)
        {
            double quadrado = Math.Pow(lado, 2);
            
            return quadrado;
        }

        public static double retangulo(double lado1, double lado2)
        {
            double retangulo = lado1 * lado2;
            
            return retangulo;
        }
    }
}