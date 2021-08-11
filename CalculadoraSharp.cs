using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            byte escolha = 0;

            do
            {
                Console.WriteLine("1 ... Somar.");
                Console.WriteLine("2 ... subtrair.");
                Console.WriteLine("3 ... multiplicar.");
                Console.WriteLine("4 ... dividir.");
                Console.WriteLine("0 ... Sair.");
                Console.WriteLine("Escolha -> ");
                
                escolha = byte.Parse(Console.ReadLine());

            
                    switch (escolha)
                    {
                        case 1:
                            {
                                Console.WriteLine("Digite o número 1: ");
                                double n1 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o número 2: ");
                                double n2 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Resultado: " + somar(n1, n2));
                                break;
                            }

                        case 2:
                            {
                                Console.WriteLine("Digite o número 1: ");
                                double n1 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o número 2: ");
                                double n2 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Resultado: " + subtracao(n1, n2));
                                break;
                            }

                        case 3:
                            {
                                Console.WriteLine("Digite o número 1: ");
                                double n1 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o número 2: ");
                                double n2 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Resultado: " + multiplicacao(n1, n2));
                                break;
                            }

                        case 4:
                            {
                                Console.WriteLine("Digite o número 1: ");
                                double n1 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Digite o número 2: ");
                                double n2 = double.Parse(Console.ReadLine());

                                Console.WriteLine("Resultado: " + divisao(n1, n2));
                                break;
                            }

	                case 0:
        	            {
                	    	Console.WriteLine("Saindo!");
                        	break;
                       	    }

                    	default:
                            {
                                Console.WriteLine("Não reconheci sua escolha, tente novamente!");
                                break;
                            }

                } 

            } while (escolha != 0);
        }

        static double somar(double n1, double n2)
        {
            return n1 + n2;
        }

        static double subtracao(double n1, double n2)
        {
            return n1 - n2;
        }

        static double multiplicacao(double n1, double n2)
        {
            return n1 * n2;
        }

        static double divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
