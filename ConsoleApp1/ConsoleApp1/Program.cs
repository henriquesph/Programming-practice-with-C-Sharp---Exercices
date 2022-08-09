using System;
using System.Globalization;

//namespace Primeiro
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Digite seu nome");
//            string nome = Console.ReadLine();

//            Console.WriteLine("Digite sua idade");
//            int idade = int.Parse(Console.ReadLine());

//            Console.WriteLine("Digite seu sexo");
//            char sexo = char.Parse(Console.ReadLine());

//            Console.WriteLine("Digite sua altura");
//            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // isso aceita tanto virgula quanto ponto - using System.Globalization;

//            Console.WriteLine("Seu nome é " + nome + " ele(a) tem " + idade + " é so sexo " + sexo + " e sua altura é " + altura);


//            Console.WriteLine("----------------------//-------------------------");

//            string[] vetor = Console.ReadLine().Split(" ");
//            string n = vetor[0];
//            int i = int.Parse(vetor[1]);
//            char s = char.Parse(vetor[2]);
//            double a = double.Parse(vetor[3], CultureInfo.InvariantCulture);

//            Console.WriteLine(n);
//            Console.WriteLine(i);
//            Console.WriteLine(s);
//            Console.WriteLine(a);
//        }
//    }
//}


//namespace valorTerreno
//{
//    class Calculo
//        //calcula a area do terreno e o valor
//    {
//        static void Main(string[] args)
//        {
//            double largura, comprimento, precoMetro, area, valor;

//            Console.WriteLine("Digite a largura");
//            largura = double.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o comprimento");
//            comprimento = double.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o valor do metro quadrado");
//            precoMetro = double.Parse(Console.ReadLine());

//            area = largura * comprimento;
//            valor = area * precoMetro;

//            Console.WriteLine("O Terreno de área " + area + " tem o valor de " + valor);
//        }
//    }
//}


//namespace valorTerreno
//{
//    class Calculo
//    //calcula a area do terreno e o valor
//    {
//        static void Main(string[] args)
//        {
//            double base1, altura, area, perimetro, diagonal;

//            Console.WriteLine("Base: ");
//            base1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("Altura: ");
//            altura = double.Parse(Console.ReadLine());

//            area = base1 * altura;

//            perimetro = (2 * base1) + (2 * altura);

//            diagonal = Math.Sqrt(Math.Pow(base1, 2) + Math.Pow(altura, 2));

//            Console.WriteLine("Area: " + area);
//            Console.WriteLine("Perímetro: " + perimetro);
//            Console.WriteLine("Diagonal: " + diagonal);
//        }
//    }
//}


//namespace mediaIdade
//{
//    class mediaIdade
//    //calcula a media de idade de 2 pessoas
//    // input: henrique 10
//    //        poliana 5
//    {
//        static void Main(string[] args)
//        {
//            string nome1, nome2;
//            int idade1, idade2;
//            double media;
//            string[] vet;

//            Console.WriteLine("Nome e idade, primeira pessoa: ");
//            vet = Console.ReadLine().Split(" ");
//            nome1 = vet[0];
//            idade1 = int.Parse(vet[1]);

//            Console.WriteLine("Nome e idade, segunda pessoa: ");
//            vet = Console.ReadLine().Split(" ");
//            nome2 = vet[0];
//            idade2 = int.Parse(vet[1]);

//            media = (double) (idade1 + idade2) / 2;

//            Console.WriteLine("A média de idade entre " + nome1 + " e " + nome2 + "é de: " + media);
//        }
//    }
//}

//namespace ConversorTempo
//{
//    class ConversorTempo
//    // pega o tempo em segundos e transforma em horas, minutos e segundos
//    {
//        static void Main(string[] args)
//        {
//            int segundosEntrada, horas, minutos, segundos, resto;

//            Console.WriteLine("Digite o tempo em segundos: ");
//            segundosEntrada = int.Parse(Console.ReadLine());

//            horas = segundosEntrada / 3600;

//            resto = segundosEntrada % 3600;

//            minutos = resto / 60;

//            segundos = resto % 60;

//            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

//            Console.WriteLine(resto);
//        }
//    }
//}


//namespace Horas
//{
//    class Horas
//    {
//        static void Main(string[] args)
//        {
//            int horas;
//            Console.WriteLine("Que horas? ");
//            horas = int.Parse(Console.ReadLine());

//            if(horas < 12)
//            {
//                Console.WriteLine("bom dia");
//            }
//            else if(horas < 18)
//            {
//                Console.WriteLine("boa tarde");
//            }
//            else if(horas >= 18)
//            {
//                Console.WriteLine("boa noite");
//            }
//        }
//    }
//}


//namespace media
//{
//    class media
//    {
//        static void Main(string[] args)
//        {
//            double nota1, nota2, media;

//            Console.WriteLine("nota1: ");
//            nota1 = double.Parse(Console.ReadLine());

//            Console.WriteLine("nota2: ");
//            nota2 = double.Parse(Console.ReadLine());

//            media = (nota1 + nota2) / 2;

//            Console.WriteLine("nota final: " + media);

//            if (media < 60)
//            {
//                Console.WriteLine("REPROVADO");
//            }
//            else
//            {
//                Console.WriteLine("APROVADO");
//            }
//        }
//    }
//}

//namespace equacaoSegundoGrau
//{
//    class EquacaoSegundoGrau
//    {
//        static void Main(string[] args)
//        {
//            double a, b, c, delta, x1, x2;
//            string[] vet = Console.ReadLine().Split(" ");

//            a = double.Parse(vet[0], CultureInfo.InvariantCulture);

//            b = double.Parse(vet[1], CultureInfo.InvariantCulture);

//            Console.WriteLine("Digite o valor de C: ");
//            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

//            delta = Math.Pow(b, 2) - (4 * a * c);

//            if (delta < 0 || delta == 0)
//            {
//                Console.WriteLine("O valor não pode ser calculado");
//            }
//            else
//            {
//                x1 = (-b + Math.Sqrt(delta)) / 2 * a;

//                x2 = (-b - Math.Sqrt(delta)) / 2 * a;

//                Console.WriteLine("O valor de X1 é: " + x1.ToString("F5", CultureInfo.InvariantCulture));
//                Console.WriteLine("O valor de X2 é: " + x2.ToString("F5", CultureInfo.InvariantCulture));
//            }
//        }
//    }
//}


//namespace menorNumero
//{
//    class menorNumero
//    {
//        static void Main(string[] args)
//        {
//            int n1, n2, n3, menor;

//            Console.WriteLine("Digite o primeiro valor: ");
//            n1 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o segundo valor: ");
//            n2 = int.Parse(Console.ReadLine());

//            Console.WriteLine("Digite o terceiro valor: ");
//            n3 = int.Parse(Console.ReadLine());

//            menor = n1;

//            if (n1 > n2)
//            {
//                menor = n2;
//            }
//            else if (menor > n3)
//            {
//                menor = n3;
//            }

//            Console.WriteLine("O menor número é: " + menor);

//        }
//    }
//}


//namespace planoTelefone
//{
//    class PlanoTelefone
//    {
//        static void Main(string[] args)
//        {
//            int mensalidade, minutos, diferenca;

//            mensalidade = 50;

//            Console.WriteLine("Minutos utilizados");
//            minutos = int.Parse(Console.ReadLine());

//            if (minutos > 100)
//            {
//                diferenca = minutos - 100;
//                mensalidade += diferenca * 2;
//            }

//            Console.WriteLine("O valor da mensalidade foi: " + mensalidade);

//        }
//    }
//}


//namespace DiaDaSemana
//{
//    class DiaDaSemana
//    {
//        static void Main(string[] args)
//        {
//            int x;
//            string dia;
//            Console.WriteLine("Dia da semana, de 1 a 7: ");
//            x = int.Parse(Console.ReadLine());

//            switch (x)
//            {
//                case 1:
//                    dia = "Domingo";
//                    break;
//                case 2:
//                    dia = "Segunda";
//                    break;
//                case 3:
//                    dia = "Terça";
//                    break;
//                case 4:
//                    dia = "Quarta";
//                    break;
//                case 5:
//                    dia = "Quinta";
//                    break;
//                case 6:
//                    dia = "Sexta";
//                    break;
//                case 7:
//                    dia = "Sábado";
//                    break;
//                default:
//                    dia = "Valor inválido";
//                    break;
//            }
//            Console.WriteLine("Dia da semana: " + dia);
//        }
//    }
//}


//namespace Ordem
//{
//    class Ordem
//    {
//        static void Main(string[] args)
//        {
//            string[] n;
//            int x, y;
//            Console.WriteLine("Digite 2 números, te direi se a ordem é crescente ou decrescente, números iguais para finalizar: ");
//            n = Console.ReadLine().Split(" ");
//            x = int.Parse(n[0]);
//            y = int.Parse(n[1]);

//            while (x != y)
//            {
//                if (x > y)
//                {
//                    Console.WriteLine("Decrescente");
//                }
//                else if (x < y)
//                {
//                    Console.WriteLine("Crescente");
//                }

//                Console.WriteLine("Digite 2 números, te direi se a ordem é crescente ou decrescente, números iguais para finalizar: ");
//                n = Console.ReadLine().Split(" ");
//                x = int.Parse(n[0]);
//                y = int.Parse(n[1]);
//            }
//        }
//    }
//}

//namespace Ordem
//{
//    class Ordem
//    {
//        static void Main(string[] args)
//        {
//            double n, media, contador, soma;
//            n = 0;
//            soma = 0;
//            contador = 0;
//            while (n >= 0)
//            {
//                Console.WriteLine("Digite a idade: ");
//                n = double.Parse(Console.ReadLine());
//                if (n > 0)
//                {
//                    contador += 1;
//                    soma += n;
//                }
//            }

//            media = soma / contador;

//            Console.WriteLine("soma: " + soma);
//            Console.WriteLine("contador: " + contador);

//            Console.WriteLine("A media de idade é: " + media);
//        }
//    }
//}

//namespace Tabuada
//{
//    class Tabuada
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            Console.WriteLine("Digite um valor p/ calcular a tabuada: ");
//            n = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= 10; i++)
//            {
//                Console.WriteLine(i + " x " + n + " = " + i*n);
//            }
//        }
//    }
//}

//namespace SomaImpar
//{
//    class SomaImpar
//    {
//        static void Main(string[] args)
//        {
//            int x, y, soma;
//            soma = 0;
//            Console.WriteLine("Digite um número: ");
//            x = int.Parse(Console.ReadLine());

//            Console.WriteLine("Digite outro número número: ");
//            y = int.Parse(Console.ReadLine());

//            for(int i = x - 1; i > y; i--)
//            {
//                if (i % 2 == 1 || i % 2 == -1)
//                {
//                    soma += i;
//                    Console.WriteLine(i);
//                }
//            }

//            Console.WriteLine("a soma dos números é: " + soma);
//        }
//    }
//}


//namespace ConversorTemperatura
//{
//    class ConversorTemperatura
//    {
//        static void Main(string[] args)
//        {
//            double c, f;
//            string r;
//            do
//            {
//                Console.WriteLine("Digite a temperatura em Celcius: ");
//                c = float.Parse(Console.ReadLine());

//                f = (9.0 * c) / 5.0 + 32.0;
//                Console.WriteLine("Equivalente em Fahreneith: " + f);
//                Console.WriteLine("Deseja repetir? [s/n]");
//                r = Console.ReadLine();
//            } while (r == "s");
//        }
//    }
//}

//namespace SoImpar
//{
//    class SoImpar
//    {
//        static void Main(string[] args)
//        {
//            int n, num;
//            int[] vetor;

//            Console.WriteLine("Digite a quantidade de números a serem lidos: ");
//            n = int.Parse(Console.ReadLine());
//            vetor = new int[n];

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine("Digite um número: ");
//                num = int.Parse(Console.ReadLine());
//                vetor[i] = num;
//            }

//            Console.WriteLine("******************************************");

//            for (int i = 0; i < vetor.Length; i++)
//            {
//                if (vetor[i] < 0)
//                {
//                    Console.WriteLine(vetor[i]);
//                }
//            } 
//        }
//    }
//}

//namespace somaMedia
//{
//    class somaMedia
//    {
//        static void Main(string[] args)
//        {
//            int n;
//            double soma, media;
//            double[] vetor;
//            string[] s;

//            Console.WriteLine("Digite a quantidade de números a serem lidos: ");
//            n = int.Parse(Console.ReadLine());
//            vetor = new double[n];
//            s = new string[n];

//            s = Console.ReadLine().Split(" ");

//            for(int i = 0; i < n; i++)
//            {
//                vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
//            }

//            soma = 0;
//            for(int i = 0; i < n; i++)
//            {
//                soma += vetor[i];
//            }

//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(vetor[i] + " ");
//            }

//            media = 0;
//            media = soma / n;

//            Console.WriteLine("soma: " + soma);
//            Console.WriteLine("media: " + media);
//        }
//    }
//}

//namespace ColetorDados
//{
//    class ColetorDados
//    {
//        static void Main(string[] args)
//        {
//            int N;
//            double alturaMedia, somaAltura, count, porcentagem;
//            N = int.Parse(Console.ReadLine());

//            string[] nomes = new string[N];
//            int[] idades = new int[N];
//            double[] alturas = new double[N];

//            for(int i = 0; i < N; i++)
//            {
//                string[] s = Console.ReadLine().Split(' ');
//                nomes[i] = s[0];
//                idades[i] = int.Parse(s[1]);
//                alturas[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
//            }

//            count = 0;
//            somaAltura = 0;
//            for(int i = 0; i < N; i++)
//            {
//                somaAltura = alturas[i];

//                if (idades[i] < 16 )
//                {
//                    count += 1;
//                }

//            }

//            alturaMedia = somaAltura / N;
//            porcentagem = (double)count / N * 100;


//            Console.WriteLine("media da altura: " + alturaMedia);
//            Console.WriteLine("porcentagem de pessoas com menos de 16 anos: " + porcentagem);
//        }
//    }
//}

//namespace forEachLoop
//{
//    class forEachLoop
//    {
//        static void Main(string[] args)
//        {
//            int N;
//            N = int.Parse(Console.ReadLine());
//            string[] vet = new string[N];
//            for (int i = 0; i < N; i++)
//            {
//                vet[i] = Console.ReadLine();
//            }

//            Console.WriteLine("Nomes lidos");

//            foreach(string x in vet)
//            {
//                Console.WriteLine(x);
//            }

//        }
//    }
//}


//namespace MatrizQuadrada
//{
//    class MatrizQuadrada
//    {
//        static void Main(string[] args)
//        {
//            int n, num, cont;
//            int[,] a;

//            Console.WriteLine("Digite o quantidade de linhas e colunas");
//            n = int.Parse(Console.ReadLine());
//            a = new int[n, n];

//            for (int i = 0; i < n; i++)
//            {
//                string[] s = Console.ReadLine().Split(" ");
//                for (int j = 0; j < n; j++)
//                {
//                    a[i, j] = int.Parse(s[j]);
//                }
//            }

//            Console.WriteLine("*************************");

//            cont = 0;
//            num = 0;
//            for(int i = 0; i < n; i++)
//            {
//                for(int j = 0; j < n; j++)
//                {
//                    num = a[i, j];

//                    if (num < 0)
//                    {
//                        cont += 1;
//                    }

//                    Console.Write(num + " ");
//                }

//                Console.WriteLine(" ");
//            }

//            Console.WriteLine("A matriz possui " + cont + "negativos");
//            Console.WriteLine("Números da diagonal");
//            for(int i = 0; i < n; i++)
//            {
//                Console.Write(a[i, i] + " ");
//            }
//        }
//    }
//}


namespace MatrizQuadrada
{
    class MatrizQuadrada
    {
        static void Main(string[] args)
        {
            int l, c, somatorio;
            int[,] matriz;
            int[] soma;

            Console.WriteLine("Digite o número de linhas: ");
            l = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas: ");
            c = int.Parse(Console.ReadLine());

            matriz = new int[l, c];

            somatorio = 0;
            soma = new int[c];
            for (int i = 0; i < l; i++)
            {
                string[] s = Console.ReadLine().Split(" ");

                for (int j = 0; j < c; j++)
                {
                    matriz[i, j] = int.Parse(s[j]);
                    somatorio += matriz[i, j];
                }
                soma[i] = somatorio;
                somatorio = 0;
            }

            for(int i = 0; i < l; i++)
            {
                Console.WriteLine(soma[i]);
            }
            
        }
    }
}