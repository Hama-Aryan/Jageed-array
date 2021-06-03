using System;

namespace karwan_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] frutis = new int[2][];
            arr_rows(ref frutis);
            
            for (int i = 0; i < frutis.Length; i++)
            {
                for (int j = 0; j < frutis[i].Length; j++)
                {
                    Console.Write("Please inter {0},{1} :",i,j);
                    frutis[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            display(frutis);
            int sum_arr = sum(frutis);
            Console.WriteLine(sum_arr);
        }
        static void arr_rows(ref int[][] arr)
        {
            int N_elements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("write number of element of Row{0} :",i);
                N_elements = Int32.Parse(Console.ReadLine());
                arr[i] = new int[N_elements];
            }
        }
        static void display(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j <arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }



        }

        static int sum (int[][] arr)
        {
            int total = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                foreach (int temp in arr[i])
                {
                    total += temp;
                }
                

            }
            return total;
        }

    }

}
