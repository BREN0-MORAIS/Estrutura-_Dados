using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciocios_Fixacao.Exercicios
{
    public class Vetores
    {
        /*----------------------------------Exercicio 1-----------------------------------------------*/
        public static void exe1()
        {
            //exercicio-1

            /* 1- Crie um algoritmo que leia um vetor de 10
            números inteiros. Em seguida, calcule e escreva
            o somatório dos valores deste vetor. */
            try
            {

                int[] num = new int[11];
                int i = 0;
                int soma = 0;

                for (i = 1; i <= num.Length; i++)
                {
                    Console.WriteLine("Insira um Numero para o Vetor \n");
                    num[i] = int.Parse(Console.ReadLine());

                    soma = soma + num[i];

                    if (i >= 10)
                    {
                        i = num.Length;
                        Console.WriteLine("Somatória dos indice " + soma);
                    }
                }

            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato de entrada invalida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }


        }
        /*----------------------------------Exercicio 2-----------------------------------------------*/
        public static void exe2()
        {
            /*
                2- Escreva um algoritmo que leia um vetor com
                15 posições de números inteiros. Em seguida,
                escreva somente os números positivos que se
                encontram no vetor.
             
             
             */

            try
            {
                int[] num = new int[16];
                int i = 0;
                int soma = 0;

                for (i = 1; i <= num.Length; i++)
                {
                    Console.WriteLine("Insira um Numero para o Vetor \n");
                    num[i] = int.Parse(Console.ReadLine());

                    soma = soma + num[i];

                    if (i >= 15)
                    {
                        i = num.Length;

                        Console.WriteLine("Lista de números: \n");
                        foreach (int nume in num)
                        {
                            if (nume > 0)
                            {
                                Console.WriteLine(nume);
                            }
                            continue;
                        }

                    }
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato de entrada invalida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }


        }
        /*----------------------------------Exercicio 3-----------------------------------------------*/
        public static void exe3()
        {
            /*
             Escreva um algoritmo que leia um vetor com
            8 posições de números inteiros. Em seguida, leia
            um novo valor do usuário e verifique se valor se
            encontra no vetor. Se estiver, informe a posição
            desse elemento no vetor. Caso o elemento não
            esteja no vetor, apresente uma mensagem
            informando “O número não se encontra no
            vetor”.
             */

            try
            {
                int[] num = new int[9];
                int i = 0;
                int soma = 0;

                for (i = 1; i <= num.Length; i++)
                {
                    Console.WriteLine("Insira um Numero para o Vetor \n");
                    num[i] = int.Parse(Console.ReadLine());
                    soma = soma + num[i];
                    if (i >= 8)
                    {
                        i = num.Length;
                        Console.WriteLine("Qual volor deseja encontrar ? \n");
                        int numero = int.Parse(Console.ReadLine());
                        int count = 0;
                        var mensagem = "";
                        foreach (int nume in num)
                        {
                            count = count + 1;
                            if (nume == numero)
                            {
                                count = count - 2;
                                mensagem = $"Numero encontrado no indice  [{count.ToString()}]";
                            }
                        }
                        Console.WriteLine(mensagem);

                    }
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato de entrada invalida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }
        }

        /*----------------------------------Exercicio 4-----------------------------------------------*/
        public static void exe4()
        {
            /*
             4- Escreva um algoritmo que leia dois vetores de
            10 posições e faça a soma dos elementos de
            mesmo índice, colocando o resultado em um
            terceiro vetor. Mostre o vetor resultante.
             
             */
            try
            {
                int[] num = new int[5];
                int[] num2 = new int[5];
                int[] calulo = new int[5];

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Insira um Numero para o Vetor1 \n");
                    num[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira um Numero para o Vetor2 \n");

                    num2[i] = int.Parse(Console.ReadLine());

                    //soma os vetores
                    calulo[i] = num[i] + num2[i];

                    if (i >= 4)
                    {
                        foreach (int calc in calulo)
                        {
                            Console.WriteLine(calc);
                        }

                    }


                }

            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato de entrada invalida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }


        }

        /*----------------------------------Exercicio 5-----------------------------------------------*/
        public static void exe5()
        {
            /*
             5- Crie um algoritmo que leia um vetor de 20
                posições e informe:
                
                a)Quantos números pares existem no vetor
                
                b)Quantos números ímpares existem no vetor
                
                c)Quantos números maiores do que 50
                
                d)Quantos números menores do que 7
             */
            try
            {
                int[] num = new int[4];
                int i = 0;
                int soma = 0;

                for (i = 0; i <= 3; i++)
                {
                    Console.WriteLine("Insira um Numero para o Vetor \n");
                    num[i] = int.Parse(Console.ReadLine());
                    if (i == 3)
                    {
                        int par = 0;
                        int impar = 0;
                        int maior50 = 0;
                        int menor7 = 0;

                        foreach (int nume in num)
                        {
                            if (nume > 50)
                            {
                                maior50 = maior50 + 1;
                            }
                            else
                            if (nume > 7 && nume <= 50)
                            {
                                menor7 = menor7 + 1;
                            }
                            else
                            if (nume % 2 == 0)
                            {
                                par = par + 1;
                            }
                            else
                            if (nume % 2 >= 1)
                            {
                                impar = impar + 1;

                            }
                        }
                        Console.WriteLine("Quantidade de numeros pares:   " + par);
                        Console.WriteLine("Quantidade de numeros impares: " + impar);
                        Console.WriteLine("Quantidade de numeros Maior 50: " + maior50);
                        Console.WriteLine("Quantidade de numeros Menor que 7: " + menor7);
                    }
                }
            }
            catch (System.FormatException e)
            {
                Console.WriteLine("Formato de entrada invalida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e);
            }
        }
    }

}
