using CalculaArea.Classes;
using System;

namespace CalculaArea
{
    class Program
    {
        static void Main(string[] args)
        {
            bool resp = true;
            string opcao1;
            int opcao1Numero;
            string opcao2;
            int opcao2Numero;

            Console.ForegroundColor = ConsoleColor.Yellow;
         
            do
            {
                Menu();
                Console.WriteLine();
                Console.Write("Opção: ");
                opcao1 = Console.ReadLine();

                if (Verificacao.Numero(opcao1))
                {
                    opcao1Numero = int.Parse(opcao1);

                    if (Verificacao.NumeroMenu(opcao1Numero))
                    {
                        Console.WriteLine("É necessário digitar um número entre 1 e 7");
                        Console.ReadLine();
                        LimparTela();
                    }
                    else
                    {
                        switch (opcao1Numero)
                        {
                            case 1:
                                bool respCirculo = true;

                                do
                                {
                                    LimparTela();
                                    Console.Write("Digite o raio: ");
                                    string raio = Console.ReadLine();
                                    string numeroRaio = Verificacao.NumeroQuebrado(raio); 

                                    if (Verificacao.Numero(numeroRaio))
                                    {
                                        Circulo circulo = new Circulo(double.Parse(raio));
                                        circulo.CalculaArea();
                                        Console.WriteLine(circulo.ToString());

                                        respCirculo = RespostaSN();
                                    }
                                    else
                                    {
                                        Console.WriteLine("É necessário digitar números");
                                        Console.ReadLine();
                                    }

                                } while (respCirculo == true);     
                                break;

                            case 2:
                                bool respQuadrado = true;

                                do
                                {
                                    LimparTela();
                                    Console.Write("Digite o lado do quadrado: ");
                                    string lado = Console.ReadLine();
                                    string ladoQuadrado = Verificacao.NumeroQuebrado(lado);

                                    if (Verificacao.Numero(ladoQuadrado))
                                    {
                                        Quadrado quadrado = new Quadrado(double.Parse(lado), double.Parse(lado));
                                        quadrado.CalcularArea();
                                        Console.WriteLine(quadrado.ToString());

                                        respQuadrado = RespostaSN();

                                    }
                                    else
                                    {
                                        Console.WriteLine("É necessário digitar números");
                                        Console.ReadLine();
                                    }



                                } while (respQuadrado == true);
                                break;

                            case 3:
                                bool respRetangulo = true;

                                do
                                {
                                    LimparTela();
                                    Console.Write("Digite o primeiro lado: ");
                                    string ladoR1 = Console.ReadLine();
                                    Console.Write("Digite o segundo lado: ");
                                    string ladoR2 = Console.ReadLine();

                                    string ladoR11 = Verificacao.NumeroQuebrado(ladoR1);
                                    string ladoR22 = Verificacao.NumeroQuebrado(ladoR2);

                                    if(Verificacao.Numero(ladoR11) && Verificacao.Numero(ladoR22))
                                    {
                                        Retangulo retangulo = new Retangulo(double.Parse(ladoR1), double.Parse(ladoR2));
                                        retangulo.CalcularArea();
                                        Console.WriteLine(retangulo.ToString());

                                        respRetangulo = RespostaSN();

                                    }
                                    else
                                    {
                                        Console.WriteLine("É necessário digitar números");
                                        Console.ReadLine();
                                    }

                                } while (respRetangulo == true);
                                break;

                            case 4:
                                bool respTrapezio = true;

                                do
                                {
                                    LimparTela();
                                    Console.Write("Base maior: ");
                                    string baseMaior = Console.ReadLine();
                                    Console.Write("Base menor: ");
                                    string baseMenor = Console.ReadLine();
                                    Console.Write("Altura: ");
                                    string altura = Console.ReadLine();

                                    string baseMaior1 = Verificacao.NumeroQuebrado(baseMaior);
                                    string baseMenor1 = Verificacao.NumeroQuebrado(baseMenor);
                                    string altura1 = Verificacao.NumeroQuebrado(altura);

                                    if(Verificacao.Numero(baseMaior1) && Verificacao.Numero(baseMenor1) && Verificacao.Numero(altura1))
                                    {
                                        Trapezio trapezio = new Trapezio(double.Parse(baseMaior), double.Parse(baseMenor), double.Parse(altura));
                                        trapezio.CalcularArea();
                                        Console.WriteLine(trapezio.ToString());

                                        respTrapezio = RespostaSN();
                                    }
                                    else
                                    {
                                        Console.WriteLine("É necessário digitar números");
                                        Console.ReadLine();
                                    }


                                } while (respTrapezio == true);
                                break;

                            case 5:
                                bool respTriangulo = true;

                                do
                                {
                                    LimparTela();
                                    Console.Write("Base: ");
                                    string baseTriangulo = Console.ReadLine();
                                    Console.Write("Altura: ");
                                    string alturaTriangulo = Console.ReadLine();

                                    string baseTriangulo1 = Verificacao.NumeroQuebrado(baseTriangulo);
                                    string alturaTriangulo1 = Verificacao.NumeroQuebrado(alturaTriangulo);

                                    if(Verificacao.Numero(baseTriangulo1) && Verificacao.Numero(alturaTriangulo1))
                                    {
                                        Triangulo triangulo = new Triangulo(double.Parse(baseTriangulo), double.Parse(alturaTriangulo));
                                        triangulo.CalcularArea();
                                        Console.WriteLine(triangulo.ToString());

                                        respTriangulo = RespostaSN();
                                    }
                                    else
                                    {
                                        Console.WriteLine("É necessário digitar números");
                                        Console.ReadLine();
                                    }

                                } while (respTriangulo == true);
                                break;

                            case 6:
                                LimparTela();
                                MenuCores();
                                Console.WriteLine();
                                Console.Write("Opção: ");
                                opcao2 = Console.ReadLine();

                                if (Verificacao.Numero(opcao2))
                                {
                                    opcao2Numero = int.Parse(opcao2);

                                    if (Verificacao.NumeroMenuCores(opcao2Numero))
                                    {

                                        Console.WriteLine("É necessário digitar um número entre 0 e 14");
                                        Console.ReadLine();
                                        LimparTela();
                                    }
                                    else
                                    {
                                        MudarCorLetra(opcao2Numero);
                                        LimparTela();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("As funções do menu são números inteiros");
                                    Console.ReadLine();
                                    LimparTela();
                                }
                                break;

                            case 7:
                                Console.WriteLine("");
                                Console.Write("Deseja realmente sair do programa? [S/N] ");
                                char respSN = char.Parse(Console.ReadLine());
                                if (respSN == 'S' || respSN == 's')
                                {
                                    Console.WriteLine("\tSaindo do programa...");
                                    resp = false;
                                }
                                else
                                {
                                    LimparTela();
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("As funções do menu são números inteiros");
                    Console.ReadLine();
                    LimparTela();
                }

            } while (resp == true);
           
        }

        static void Menu()
        {
            Console.WriteLine("****Cálculo das Áreas****");
            Console.WriteLine("  [1] Círculo");
            Console.WriteLine("  [2] Quadrado");
            Console.WriteLine("  [3] Retângulo");
            Console.WriteLine("  [4] Trapézio");
            Console.WriteLine("  [5] Triângulo");
            Console.WriteLine("  [6] Mudar cor da letra");
            Console.WriteLine("  [7] Sair");
        }

        static void MenuCores()
        {
            Console.WriteLine("[0]  Preto");
            Console.WriteLine("[1]  Azul Escuro");
            Console.WriteLine("[2]  Verde Escuro");
            Console.WriteLine("[3]  Ciano Escuro");
            Console.WriteLine("[4]  Vermelho Escuro");
            Console.WriteLine("[5]  Mangenta Escuro");
            Console.WriteLine("[6]  Amarelo Escuro");
            Console.WriteLine("[7]  Cinza");
            Console.WriteLine("[8]  Cinza Escuro");
            Console.WriteLine("[9]  Azul");
            Console.WriteLine("[10] Verde");
            Console.WriteLine("[11] Ciano");
            Console.WriteLine("[12] Vermelho");
            Console.WriteLine("[13] Mangenta");
            Console.WriteLine("[14] Branco");
        }

        static void MudarCorLetra(int valor)
        {
            switch (valor)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;

                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;

                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;

                case 5:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;

                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;

                case 7:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;

                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;

                case 9:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                case 10:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;

                case 11:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;

                case 12:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;

                case 13:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;

                case 14:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;


            }
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static bool RespostaSN()
        {
            bool resposta = true;

            Console.Write("\nDeseja realizar um novo cálculo? [S/N] ");
            char respSN = char.Parse(Console.ReadLine());
            if (respSN == 'N' || respSN == 'n')
            {
                LimparTela();
                return resposta = false;
            }

            return resposta;
        }
    }
}
