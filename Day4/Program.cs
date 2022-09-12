using System;
using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter any positive integer");
            var number = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine(i+1);
            }
            */

            /*
            Console.WriteLine("Enter any positive integer");
            var number = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= number; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();

            for (int i = 0; i < sentence.Length; i++)
            {
                char symbol = sentence[i];
                Console.WriteLine(symbol);
            }
            */

            /*
            for(;;)
            {
            Console.WriteLine("Enter any positive integer");
            var number = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} x {i+1} = {number*(i+1)});
            }
            Console.WriteLine("Do you want to continue y/n");
            if(Console.ReadLine() == "y")
            {
               Continue; 
            }
            else break;
            }
            */

            /*
            Console.WriteLine("Enter any positive number");
            var number = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number; i++)
            {
                Thread.Sleep(500);
                sum += i;
                System.Console.Write(sum);
            }
            */

            /*
            Console.WriteLine("Enter the number of rows");
            int number = Int32.Parse(Console.ReadLine());
            int number_copy = number;

            for (int j = 1; j <= number; j++)
            {
                for(int k = 1; k <= number_copy; k++)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                number_copy--;
            }
            */

            /*
            Console.WriteLine("Enter a sentence");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(" ");
            //or Array.Reverse(words);
            int kiek = words.Count();
            kiek--;
            for(int i = kiek; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
            */

            /*
            while (true)
            {
                Console.WriteLine("Enter the first number");
                var num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the second number");
                var num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter one of the following four operations: | + | - | * | / |");

                string opera = Console.ReadLine();

                switch (opera)
                {
                    case "+":
                        Console.WriteLine($"{num1} {opera} {num2} = {(num1 + num2)}");
                        break;
                    case "-":
                        Console.WriteLine($"{num1} {opera} {num2} = {(num1 - num2)}");
                        break;
                    case "*":
                        Console.WriteLine($"{num1} {opera} {num2} = {(num1 * num2)}");
                        break;
                    case "/":
                        Console.WriteLine($"{num1} {opera} {num2} = {(num1 / num2)}");
                        break;
                }
               
                Console.WriteLine("Do you want to continue y/n");
                if (Console.ReadLine() == "y")
                {
                    continue;
                }
                else break;
            }
            */

            /*            
              //Initiation of an array//
              int[] skMasyvas = new int[5];
              Random random = new Random();
              for(int i = 0; i < skMasyvas.Length; i++)
              {
                  skMasyvas[i] = random.Next(1, 100);
              }
              Console.Write("Random numbers: ");
              foreach (int skaicius in skMasyvas)
              {
                  Console.Write(skaicius + " ");
              }
              Console.WriteLine();
              //Reversing the initial array//
              int[] revMasyvas = skMasyvas.Reverse().ToArray();
              Console.Write("Reverse  order: ");
              foreach (int revSkaicius in revMasyvas)
              {
                  Console.Write(revSkaicius + " ");
              }
              Console.WriteLine();
              //The sum of array//
              Console.WriteLine("The sum is: " + skMasyvas.Sum());
              //Copying an array//
              int[] skMasyvas_copy = skMasyvas;
              Console.Write("The copy of initial array: ");
              foreach (int skaicius_copy in skMasyvas_copy)
              {
                  Console.Write(skaicius_copy + " ");
              }
              Console.WriteLine();
              //Finding the biggest and lowest elements
              int skaicius_min = skMasyvas[0];
              int skaicius_max = skMasyvas[0];
              for (int l = 0; l < skMasyvas.Length; l++)
              {
                  if(skMasyvas[l] < skaicius_min)
                  {
                      skaicius_min = skMasyvas[l];
                  }
                  if(skMasyvas[l] > skaicius_max)
                  {
                      skaicius_max = skMasyvas[l];
                  }
              }
              Console.WriteLine($"Min element: {skaicius_min}");
              Console.WriteLine($"Max element: {skaicius_max}");
              //Sorting the elements
              int tempor;
              for (int m = 0; m < skMasyvas.Length; m++)
              {
                  for(int n = m; n < skMasyvas.Length; n++)
                  { 
                      if (skMasyvas[n] < skMasyvas[m])
                      {
                          tempor = skMasyvas[m];
                          skMasyvas[m] = skMasyvas[n];
                          skMasyvas[n] = tempor;
                      }
                  }
              }
              Console.Write("Sorted array: ");
              foreach (int sk in skMasyvas)
              {
                  Console.Write(sk + " ");
              }
              Console.WriteLine();
              //Merging two array
              //Solution 1: arr1 = arr1.Concat(arr2).ToArray();
              //Solution 2: Array.Copy() method
              //Solution 3: Array.Resize() method
              //Long solution for merging:
              int[] concatMasyvas = new int[skMasyvas.Length + revMasyvas.Length];
              for(int p = 0; p < skMasyvas.Length; p++)
              {
                  concatMasyvas[p] = skMasyvas[p];
              }
              for (int q = skMasyvas.Length; q < revMasyvas.Length + skMasyvas.Length; q++)
              {
                  concatMasyvas[q] = revMasyvas[q - skMasyvas.Length];
              }
              //Sorting the concatenated array
              int temp;
              for (int m = 0; m < concatMasyvas.Length; m++)
              {
                  for (int n = m; n < concatMasyvas.Length; n++)
                  {
                      if (concatMasyvas[n] < concatMasyvas[m])
                      {
                          temp = concatMasyvas[m];
                          concatMasyvas[m] = concatMasyvas[n];
                          concatMasyvas[n] = temp;
                      }
                  }
              }
              Console.Write("Sorting the merged array: ");
              foreach (int sk in concatMasyvas)
              {
                  Console.Write(sk + " ");
              }
              Console.WriteLine();
            */

            /*
              //Element repetitions in an array of integers
              int[] arr1 = new int[50];
              Random rnd = new Random();
              for(int t = 0; t < arr1.Length; t++)
              {
                  arr1[t] = rnd.Next(0, 10);
              }
              Console.WriteLine("Generated random array:");
              for (int a =0; a < arr1.Length; a++)
              {
                  Console.Write(arr1[a] + " ");
              }
              int rep = 0;
              string repString = "";
              //Checking if there are some zero elements
              for (int r = 0; r < arr1.Length; r++)
              {
                 if (arr1[r] == 0)
                  {
                      rep++;
                  }
              }
              if (rep > 0)
              {
                  repString = "0:" + Convert.ToString(rep) + ",";
              }
              //Counting repetetive elements
              for (int r = 0; r < arr1.Length; r++)
              {
                  if (arr1[r] != 0)
                  {
                      string tmp = Convert.ToString(arr1[r]);
                      rep = 0;
                      for (int s = arr1.Length - 1; s >= r; s--)
                      {
                          if (arr1[r] == arr1[s])
                          {
                              rep++;
                              arr1[s] = 0;
                          }
                      }
                      repString = repString + tmp + ":" + Convert.ToString(rep) + ",";
                      arr1[r] = 0;
                  }
              }
              //Final data output
              string[] repOut = repString.Split(",");
              Console.WriteLine();
              foreach (string s in repOut)
              {
                  Console.WriteLine(s);
              }
            */

            /*
              //Deleting one array element
              //Filling in the array
              Random rnd = new Random();
              int[] arr2 = new int[10];
              for (int v = 0; v < arr2.Length; v++)
              {
                  arr2[v] = rnd.Next(1,10);
              }
              Console.WriteLine("The original array:");
              for (int v = 0; v < arr2.Length; v++)
              {
                  Console.Write(arr2[v] + " ");
              }
              Console.WriteLine();
              //Random array index for value elimination
              int elim = rnd.Next(0,11);
              Console.WriteLine("The element No. " + (elim + 1) + " will be eliminated");
              //Creating the second array
              int[] arr3 = new int[10];
              //Copying the first array w/o one element
              for (int v = 0; v < arr2.Length; v++)
              {
                  if(v != elim)
                  {
                      arr3[v] = arr2[v];
                  }
              }
              //Data output
              Console.WriteLine("The copy w/o one element");
              for (int v = 0; v < arr3.Length; v++)
              {
                  Console.Write(arr3[v] + " ");
              }
              Console.WriteLine();
            */

            /*
              //Second highest and secong lowest values in an array
              //Initiating an array with random elements
              int[] arr4 = new int[20];
              Random rnd = new Random();
              for(int i = 0; i < arr4.Length; i++)
              {
                  arr4[i] = rnd.Next(0,100);
              }
              Console.WriteLine("Array with random elements:");
              for(int i = 0; i < arr4.Length; i++)
              {
                  Console.Write(arr4[i] + " ");
              }
              //Sorting array elements by value
              int temp;
              for (int m = 0; m < arr4.Length; m++)
              {
                  for (int n = m; n < arr4.Length; n++)
                  {
                      if (arr4[n] < arr4[m])
                      {
                          temp = arr4[m];
                          arr4[m] = arr4[n];
                          arr4[n] = temp;
                      }
                  }
              }
              //Element repetitions in an array of integers
              int rep = 0;
              string repString = "";
              //Checking if there are some zero elements
              for (int r = 0; r < arr4.Length; r++)
              {
                  if (arr4[r] == 0)
                  {
                      rep++;
                  }
              }
              if (rep > 0)
              {
                  repString = "0:" + Convert.ToString(rep) + " ";
              }
              //Counting repetetive elements
              for (int r = 0; r < arr4.Length; r++)
              {
                  if (arr4[r] != 0)
                  {
                      string tmp = Convert.ToString(arr4[r]);
                      rep = 0;
                      for (int s = arr4.Length - 1; s >= r; s--)
                      {
                          if (arr4[r] == arr4[s])
                          {
                              rep++;
                              arr4[s] = 0;
                          }
                      }
                      repString = repString + tmp + ":" + Convert.ToString(rep) + " ";
                      arr4[r] = 0;
                  }
              }
              //Showing element repetitions
              string[] repOut = repString.Split(" ");
              Console.WriteLine();
              foreach (string s in repOut)
              {
                  Console.Write(s + " ");
              }
              Console.WriteLine();
              //How many different elements
              int kiek = repOut.Count() - 1;
              //Second lowest
              string[] temp1 = repOut[1].Split(":");
              string low2 = temp1[0];
              Console.WriteLine("Second lowest value: " + low2);
              //Second highest
              string[] temp2 = repOut[(kiek - 1)-1].Split(":");
              string high2 = temp2[0];
              Console.WriteLine("Second highest value: " + high2);
            */


        }

    }
}






