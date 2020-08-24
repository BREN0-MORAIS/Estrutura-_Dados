using System;
using System.Collections.Generic;
using System.Text;

namespace Exerciocios_Fixacao.Exercicios
{
    class Matrizes
    {
        private static Random aletorio = new Random();

        /*----------------------------------Exercicio 1-----------------------------------------------*/
        public static void exe1()
        {
            int[,] Mat = new int[5, 5];
            int Neutro = 0;
            int count = 0;

            #region Coluna 0
            Mat[0, 0] = 1; //coluna 0
            Mat[0, 1] = 2;
            Mat[0, 2] = 2;
            Mat[0, 3] = 1;
            Mat[0, 4] = 1;
            #endregion

            #region Coluna 1
            Mat[1, 0] = 1; //coluna 1
            Mat[1, 1] = 1;
            Mat[1, 2] = 2;
            Mat[1, 3] = 1;
            Mat[1, 4] = 1;
            #endregion

            #region Coluna 2
            Mat[2, 0] = 2; //coluna 2
            Mat[2, 1] = 0;
            Mat[2, 2] = 2;
            Mat[2, 3] = 2;
            Mat[2, 4] = 2;
            #endregion

            #region Coluna 3
            Mat[3, 0] = 3; //coluna 3
            Mat[3, 1] = 3;
            Mat[3, 2] = 3;
            Mat[3, 3] = 3;
            Mat[3, 4] = 3;
            #endregion

            #region Coluna 4
            Mat[4, 0] = 4; //coluna 4
            Mat[4, 1] = 4;
            Mat[4, 2] = 4;
            Mat[4, 3] = 0;
            Mat[4, 4] = 4;
            #endregion

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine($"{Mat[0, i]} {Mat[1, i]}  {Mat[2, i]}  {Mat[3, i]}  {Mat[4, i]}");
                if (Mat[0, i] % 2 == 0)
                {
                    if (Mat[0, i] == 0)
                    {
                        Neutro = Neutro + 1;

                    }
                    else
                    {
                        count = count + 1;
                    }

                }
                if (Mat[1, i] % 2 == 0)
                {
                    if (Mat[1, i] == 0)
                    {
                        Neutro = Neutro + 1;

                    }
                    else
                    {
                        count = count + 1;
                    }
                }
                if (Mat[2, i] % 2 == 0)
                {
                    if (Mat[2, i] == 0)
                    {
                        Neutro = Neutro + 1;

                    }
                    else
                    {
                        count = count + 1;
                    }
                }
                if (Mat[3, i] % 2 == 0)
                {
                    if (Mat[3, i] == 0)
                    {
                        Neutro = Neutro + 1;

                    }
                    else
                    {
                        count = count + 1;
                    }
                }
                if (Mat[4, i] % 2 == 0)
                {
                    if (Mat[4, i] == 0)
                    {
                        Neutro = Neutro + 1;

                    }
                    else
                    {
                        count = count + 1;
                    }
                }
            }

            Console.WriteLine("\nPares " + count);
            Console.WriteLine("Neutros " + Neutro);

        }
        /*----------------------------------Exercicio 2-----------------------------------------------*/
        public static void exe2()
        {
            int[,] Mat = new int[3, 3];
            int i = 0;

            int col1 = 0;
            int col2 = 0;
            int col3 = 0;

            #region coluna 1
            Mat[0, 0] = 1;
            Mat[0, 1] = 3;
            Mat[0, 2] = 4;
            #endregion

            #region coluna 2
            Mat[1, 0] = 2;
            Mat[1, 1] = 2;
            Mat[1, 2] = 1;
            #endregion

            #region coluna 3
            Mat[2, 0] = 2;
            Mat[2, 1] = 3;
            Mat[2, 2] = 1;
            #endregion

            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{Mat[0, i]} {Mat[1, i]} {Mat[2, i]}");

                col1 = col1 + Mat[0, i];
                col2 = col2 + Mat[1, i];
                col3 = col3 + Mat[2, i];
            }

            Console.WriteLine("Coluna 1 " + col1);
            Console.WriteLine("Coluna 2 " + col2);
            Console.WriteLine("Coluna 3 " + col3);
        }
        /*----------------------------------Exercicio 3-----------------------------------------------*/
        public static void exe3()
        {
            double[,] Mat = new double[5, 5];
            int i = 0;

            double media = 0.0;

            #region coluna 1
            Mat[0, 0] = aletorio.NextDouble();
            Mat[0, 1] = aletorio.NextDouble();
            Mat[0, 2] = aletorio.NextDouble();
            Mat[0, 3] = aletorio.NextDouble();
            Mat[0, 4] = aletorio.NextDouble();
            #endregion

            #region coluna 2
            Mat[1, 0] = aletorio.NextDouble();
            Mat[1, 1] = aletorio.NextDouble();
            Mat[1, 2] = aletorio.NextDouble();
            Mat[1, 3] = aletorio.NextDouble();
            Mat[1, 4] = aletorio.NextDouble();
            #endregion

            for (i = 0; i <= 4; i++)
            {
                media = (Mat[0, i] + Mat[1, i]) / 2;
                Console.WriteLine($"| {Mat[0, i].ToString("F2")} | {Mat[1, i].ToString("F2")}| = {media.ToString("F2")} |");
            }
        }
        /*----------------------------------Exercicio 4-----------------------------------------------*/
        public static void exe4()
        {
            int[,] mat = new int[6, 6];
            int i = 0;
            int maior = 0;
            int menor = 0;

            #region coluna 1
            mat[0, 0] = aletorio.Next();
            mat[0, 1] = aletorio.Next();
            mat[0, 2] = aletorio.Next();
            mat[0, 3] = aletorio.Next();
            mat[0, 4] = aletorio.Next();
            mat[0, 5] = aletorio.Next();
            #endregion

            #region coluna 2
            mat[1, 0] = aletorio.Next();
            mat[1, 1] = aletorio.Next();
            mat[1, 2] = aletorio.Next();
            mat[1, 3] = aletorio.Next();
            mat[1, 4] = aletorio.Next();
            mat[1, 5] = aletorio.Next();

            #endregion

            #region coluna 3
            mat[2, 0] = aletorio.Next();
            mat[2, 1] = aletorio.Next();
            mat[2, 2] = aletorio.Next();
            mat[2, 3] = aletorio.Next();
            mat[2, 4] = aletorio.Next();
            mat[2, 5] = aletorio.Next();
            #endregion

            for (i = 0; i <= 5; i++)
            {
                Console.WriteLine($"{mat[0, i]} {mat[1, i]} {mat[2, i]}");
                //maior
                if (mat[0, i] > mat[1, i])
                {
                    maior = mat[0, i];
                }
                if (mat[1, i] > mat[1, i])
                {
                    maior = mat[0, i];
                }
                if (mat[2, i] > maior)
                {
                    maior = mat[2, i];
                }
                //menor
                if (mat[0, i] < mat[1, i])
                {
                    menor = mat[0, i];
                }
                if (mat[1, i] < mat[1, i])
                {
                    menor = mat[0, i];
                }
                if (mat[2, i] < menor)
                {
                    menor = mat[2, i];
                }
            }

            Console.WriteLine("Maior :" + maior);
            Console.WriteLine("Menor :" + menor);
        }
        /*----------------------------------Exercicio 5-----------------------------------------------*/
        public static void exe5()
        {
            int[,] mat = new int[3, 3];
            int i = 0;

            //  Tabela 1

            #region coluna 1
            mat[0, 0] = 1;
            mat[0, 1] = 4;
            mat[0, 2] = 7;
            #endregion

            #region coluna 2
            mat[1, 0] = 2;
            mat[1, 1] = 5;
            mat[1, 2] = 8;


            #endregion

            #region coluna 3
            mat[2, 0] = 3;
            mat[2, 1] = 6;
            mat[2, 2] = 9;
            #endregion

            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{ mat[0, i]} { mat[1, i]} {mat[2, i]}");
            }
            Console.WriteLine("---------------------------------------------------------");
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine($"{ mat[i, 0]} { mat[i, 1]} {mat[i, 2]}");
            }
        }
        /*----------------------------------Exercicio 6-----------------------------------------------*/
        public static void exe6()
        {
            int i = 0;
            int[,] Mat1 = new int[5, 5];
            int[,] Mat2 = new int[5, 5];
            int[,] Mat3 = new int[5, 5];

            //matriz 1

            #region coluna 1
            Mat1[0, 0] = 1;
            Mat1[0, 1] = 1;
            Mat1[0, 2] = 1;
            Mat1[0, 3] = 1;
            Mat1[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat1[1, 0] = 2;
            Mat1[1, 1] = 2;
            Mat1[1, 2] = 2;
            Mat1[1, 3] = 2;
            Mat1[1, 4] = 2;
            #endregion

            //matriz 2
            #region coluna 1
            Mat2[0, 0] = 1;
            Mat2[0, 1] = 1;
            Mat2[0, 2] = 1;
            Mat2[0, 3] = 1;
            Mat2[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat2[1, 0] = 2;
            Mat2[1, 1] = 2;
            Mat2[1, 2] = 2;
            Mat2[1, 3] = 2;
            Mat2[1, 4] = 2;
            #endregion

            //matriz 3
            #region coluna 1
            Mat3[0, 0] = 1;
            Mat3[0, 1] = 1;
            Mat3[0, 2] = 1;
            Mat3[0, 3] = 1;
            Mat3[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat3[1, 0] = 2;
            Mat3[1, 1] = 2;
            Mat3[1, 2] = 2;
            Mat3[1, 3] = 2;
            Mat3[1, 4] = 2;
            #endregion

            Console.WriteLine("\nMatriz 1  Matriz 2");
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"|{ Mat1[0, i]}| { Mat1[1, i]}| +  |{ Mat2[0, i]}| { Mat2[1, i]}|");

                //somando e adicionando na posição da matriz
                Mat3[0, i] = Mat1[0, i] + Mat2[0, i];
                Mat3[1, i] = Mat1[1, i] + Mat2[1, i];
            }
            Console.WriteLine("\nMatriz 3");
            for (i = 0; i <= 4; i++)
            {
                //mostrando o Resultado da soma das Matriz
                Console.WriteLine($"|{ Mat3[0, i]}| { Mat3[1, i]}|");
            }


        }
        /*----------------------------------Exercicio 7-----------------------------------------------*/
        public static void exe7()
        {
            int i = 0;
            int[,] Mat = new int[5, 5];
            int soma = 0;

            #region coluna 1
            Mat[0, 0] = 0;
            Mat[0, 1] = 1;
            Mat[0, 2] = 1;
            Mat[0, 3] = 1;
            Mat[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat[0, 0] = 2;
            Mat[0, 1] = 3;
            Mat[0, 2] = 2;
            Mat[0, 3] = 2;
            Mat[0, 4] = 2;
            #endregion

            #region coluna 3
            Mat[2, 0] = 3;
            Mat[2, 1] = 3;
            Mat[2, 2] = 9;
            Mat[2, 3] = 3;
            Mat[2, 4] = 3;
            #endregion

            #region coluna 4
            Mat[3, 0] = 4;
            Mat[3, 1] = 4;
            Mat[3, 2] = 4;
            Mat[3, 3] = 7;
            Mat[3, 4] = 4;
            #endregion

            #region coluna 5
            Mat[4, 0] = 5;
            Mat[4, 1] = 5;
            Mat[4, 2] = 5;
            Mat[4, 3] = 5;
            Mat[4, 4] = 6;
            #endregion


            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine($"| {Mat[0, i]} | {Mat[1, i]} | {Mat[2, i]} | {Mat[3, i]} | {Mat[4, i]} |");
            }
            soma = Mat[0, 0] + Mat[1, 1] + Mat[2, 2] + Mat[3, 3] + Mat[4, 4];
            Console.WriteLine(soma);
        }
        /*----------------------------------Exercicio 8-----------------------------------------------*/
        public static void exe8()
        {
            int i = 0;
            int[,] Mat = new int[5, 5];
            int soma = 0;

            #region coluna 1
            Mat[0, 0] = 1;
            Mat[0, 1] = 1;
            Mat[0, 2] = 1;
            Mat[0, 3] = 1;
            Mat[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat[1, 0] = 2;
            Mat[1, 1] = 3;
            Mat[1, 2] = 2;
            Mat[1, 3] = 2;
            Mat[1, 4] = 2;
            #endregion

            #region coluna 3
            Mat[2, 0] = 3;
            Mat[2, 1] = 3;
            Mat[2, 2] = 9;
            Mat[2, 3] = 3;
            Mat[2, 4] = 3;
            #endregion

            #region coluna 4
            Mat[3, 0] = 4;
            Mat[3, 1] = 4;
            Mat[3, 2] = 4;
            Mat[3, 3] = 7;
            Mat[3, 4] = 4;
            #endregion

            #region coluna 5
            Mat[4, 0] = 5;
            Mat[4, 1] = 5;
            Mat[4, 2] = 5;
            Mat[4, 3] = 5;
            Mat[4, 4] = 6;
            #endregion


            for (i = 0; i <= 4; i++)
            {
                int count = i + 1;
                int count1 = i + 2;
                int count2 = i + 3;
                int count3 = i + 4;

                if (count <= 0 && count <= 4)
                {
                    Mat[0, count] = 0;
                }
                if (count1 >= 0 && count1 <= 4)
                {
                    Mat[1, count1] = 0;
                }
                if (count2 >= 0 && count2 <= 4)
                {
                    Mat[2, count2] = 0;
                }
                if (count3 >= 0 && count3 <= 4)
                {
                    Mat[3, count3] = 0;
                }

                Console.WriteLine($"| {Mat[0, i]} | {Mat[1, i]} | {Mat[2, i]} | {Mat[3, i]} | {Mat[4, i]} |");
            }
        }
        /*----------------------------------Exercicio 9-----------------------------------------------*/
        public static void exe9()
        {
            int i = 0;
            int[,] Mat = new int[5, 5];
            int soma = 0;

            #region coluna 1
            Mat[0, 0] = 1;
            Mat[0, 1] = 1;
            Mat[0, 2] = 1;
            Mat[0, 3] = 1;
            Mat[0, 4] = 1;
            #endregion

            #region coluna 2
            Mat[1, 0] = 2;
            Mat[1, 1] = 3;
            Mat[1, 2] = 2;
            Mat[1, 3] = 2;
            Mat[1, 4] = 2;
            #endregion

            #region coluna 3
            Mat[2, 0] = 3;
            Mat[2, 1] = 3;
            Mat[2, 2] = 9;
            Mat[2, 3] = 3;
            Mat[2, 4] = 3;
            #endregion

            #region coluna 4
            Mat[3, 0] = 4;
            Mat[3, 1] = 4;
            Mat[3, 2] = 4;
            Mat[3, 3] = 7;
            Mat[3, 4] = 4;
            #endregion

            #region coluna 5
            Mat[4, 0] = 5;
            Mat[4, 1] = 5;
            Mat[4, 2] = 5;
            Mat[4, 3] = 5;
            Mat[4, 4] = 6;
            #endregion


            for (i = 0; i <= 4; i++)
            {
                int count = i + 1;
                int count1 = i + 2;
                int count2 = i + 3;
                int count3 = i + 4;

                if (i == 0)
                {
                    Mat[1, i] = 0;
                }
                if (i >= 0 && i <= 1)
                {
                    Mat[2, i] = 0;
                }
                if (i >= 0 && i <= 2)
                {
                    Mat[3, i] = 0;
                }
                if (i >= 0 && i <= 3)
                {
                    Mat[4, i] = 0;
                }
                Console.WriteLine($"| {Mat[0, i]} | {Mat[1, i]} | {Mat[2, i]} | {Mat[3, i]} | {Mat[4, i]} |");
            }
        }
    }
}
