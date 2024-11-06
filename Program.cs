namespace Assignment_1_3_3
{
    internal class Program
    {
        static void Main(string[] args)
        //Assignment 1_3_3
        //Write a program in C# to read n number of values in an array and display it in reverse order. 
        {
            int[] presetArray = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine("Input the number of elements to read from the array (1-8)");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i >= 0; i--)
            {
               Console.WriteLine(presetArray[i]); 
            }

            {
                
            }
        }
        }
    }

