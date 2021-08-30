using System;
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
                            aula24Exercicio01();
                        else if (exercicio == 2)
                            aula24Exercicio02();
                        else if (exercicio == 3)
                            aula24Exercicio03();
                        else if (exercicio == 4)
                            aula24Exercicio04();
                        else if (exercicio == 5)
                            aula24Exercicio05();
                        else if (exercicio == 6)
                            aula24Exercicio06();

                        Console.WriteLine();
                    }
                    else if (aula == 29)
                    {
                        Console.Write("Qual exercício você quer executar? ");
                        int exercicio = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (exercicio == 1)
                            aula29Exercicio01();
                        else if (exercicio == 2)
                            aula29Exercicio02();
                        else if (exercicio == 3)
                            aula29Exercicio03();
                        else if (exercicio == 4)
                            aula29Exercicio04();
                        else if (exercicio == 5)
                            aula29Exercicio05();
                        else if (exercicio == 6)
                            aula29Exercicio06();
                        else if (exercicio == 7)
                            aula29Exercicio07();
                        else if (exercicio == 8)
                            aula29Exercicio08();

                        Console.WriteLine();
                    }
                    else if (aula == 33)
                    {
                        Console.Write("Qual exercício você quer executar? ");
                        int exercicio = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (exercicio == 1)
                            aula33Exercicio01();
                        else if (exercicio == 2)
                            aula33Exercicio02();
                        else if (exercicio == 3)
                            aula33Exercicio03();
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

        private static void aula24Exercicio01()
        {
            Console.Write("Informe o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);
        }

        private static void aula24Exercicio02()
        {
            double pi = 3.14159;

            Console.Write("Informe o raio do círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.WriteLine($"A = {area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
        private static void aula24Exercicio03()
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

        private static void aula24Exercicio04()
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

        private static void aula24Exercicio05()
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

        private static void aula24Exercicio06()
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

        private static void aula29Exercicio01()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0)
                Console.Write("NEGATIVO");
            else if (numero >= 0)
                Console.Write("NÃO NEGATIVO");
        }

        private static void aula29Exercicio02()
        {
            Console.Write("Informe um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.Write("PAR");
            else
                Console.Write("ÍMPAR");
        }

        private static void aula29Exercicio03()
        {
            Console.Write("Informe o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.Write("Informe o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            int resto = 0;

            if (primeiroNumero >= segundoNumero)
                resto = primeiroNumero % segundoNumero;
            else
                resto = segundoNumero % primeiroNumero;
            
            if (resto == 0)
                Console.Write("São múltiplos");
            else
                Console.Write("Não são múltiplos");
        }

        private static void aula29Exercicio04()
        {
            Console.Write("Informe a hora inicial: ");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.Write("Informe a hora final: ");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;

            if (horaInicial < horaFinal)
                duracao = horaFinal - horaInicial;
            else if (horaInicial > horaFinal)
                duracao = (24 - horaInicial) + horaFinal;
            else if (horaInicial == horaFinal)
                duracao = 24;

            Console.Write("O JOGO DUROU " + duracao + " HORA(S)");
        }

        private static void aula29Exercicio05()
        {
            Console.Write("Informe o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            double valorProduto = 0.00;
            double valorTotal = 0.00;

            if (codigo == 1)
                valorProduto = 4.00;
            else if (codigo == 2)
                valorProduto = 4.50;
            else if (codigo == 3)
                valorProduto = 5.00;
            else if (codigo == 4)
                valorProduto = 2.00;
            else if (codigo == 5)
                valorProduto = 1.50;

            valorTotal = valorProduto * quantidade;

            Console.Write($"Total: R$ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void aula29Exercicio06()
        {
            Console.Write("Informe um valor: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0.00 && valor <= 25.00)
                Console.Write("Intervalo [0,25]");
            else if (valor >= 25.01 && valor <= 50.00)
                Console.Write("Intervalo [25,50]");
            else if (valor >= 50.01 && valor <= 75.00)
                Console.Write("Intervalo [50,75]");
            else if (valor >= 75.01 && valor <= 100.00)
                Console.Write("Intervalo [75,100]");
            else
                Console.Write("Fora do intervalo");
        }

        private static void aula29Exercicio07()
        {
            Console.Write("Informe o valor de X: ");
            double X = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe o valor de Y: ");
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X == 0.0 && Y == 0.0)
                Console.Write("Origem");
            else if (X > 0.0 && Y > 0.0)
                Console.Write("Q1");
            else if (X < 0.0 && Y > 0.0)
                Console.Write("Q2");
            else if (X < 0.0 && Y < 0.0)
                Console.Write("Q3");
            else if (X > 0.0 && Y < 0.0)
                Console.Write("Q4");
        }

        private static void aula29Exercicio08()
        {
            Console.Write("Informe o salário: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorIsento = 2000.00;
            double valorImposto = 0.0;
            double baseCalculo = 0.0;

            if (salario >= 2000.01 && salario <= 3000.00){
                baseCalculo = salario - valorIsento;
                valorImposto = baseCalculo * 0.08;
            } else if (salario >= 3000.01 && salario <= 4500.00){
                baseCalculo = salario - valorIsento;
                valorImposto = (999.99 * 0.08) + ((baseCalculo - 999.99) * 0.18);
            } else if (salario > 4500.01)
            {
                baseCalculo = salario - valorIsento;
                valorImposto = (999.99 * 0.08) + (1499.99 * 0.18) + ((baseCalculo - 2499.98) * 0.28);
            }

            if (valorImposto == 0.00)
                Console.Write("Isento");
            else
                Console.Write($"R$ {valorImposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        private static void aula33Exercicio01()
        {
            Console.Write("Informe a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002){
                Console.WriteLine("Senha Inválida");
                Console.WriteLine();

                Console.Write("Informe a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }

        private static void aula33Exercicio02()
        {
            Console.Write("Informe o valor de X: ");
            int X = int.Parse(Console.ReadLine());

            Console.Write("Informe o valor de Y: ");
            int Y = int.Parse(Console.ReadLine());

            while (X != 0 && Y != 0)
            {
                if (X > 0 && Y > 0)
                    Console.WriteLine("Primeiro");
                else if (X < 0 && Y > 0)
                    Console.WriteLine("Segundo");
                else if (X < 0 && Y < 0)
                    Console.WriteLine("Terceiro");
                else if (X > 0 && Y < 0)
                    Console.WriteLine("Quarto");

                Console.WriteLine();

                Console.Write("Informe o valor de X: ");
                X = int.Parse(Console.ReadLine());

                Console.Write("Informe o valor de Y: ");
                Y = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Programa encerrado...");
            Console.WriteLine();
        }

        private static void aula33Exercicio03()
        {
            Console.Write("Informe o código do produto: ");
            int codigo = int.Parse(Console.ReadLine());

            int qtdeAlcool = 0;
            int qtdeGasolina = 0;
            int qtdeDiesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1 || codigo == 2 || codigo == 3)
                {
                    if (codigo == 1)
                        qtdeAlcool += 1;
                    else if (codigo == 2)
                        qtdeGasolina += 1;
                    else if (codigo == 3)
                        qtdeDiesel += 1;
                }
                else 
                { 
                    Console.WriteLine("Código inválido...");
                }

                Console.WriteLine();

                Console.Write("Informe o código do produto: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Álcool: " + qtdeAlcool);
            Console.WriteLine("Gasolina: " + qtdeGasolina);
            Console.WriteLine("Diesel: " + qtdeDiesel);
            Console.WriteLine();
        }
    }
}
