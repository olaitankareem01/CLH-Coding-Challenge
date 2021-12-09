using System;

namespace CodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[,] matrix =
            {
                {2,3,4,5 },
                {3,4,5,6 },
                {4,5,6,7 },
                {2,3,4,5 }

            };

            /*  matrixRotation(matrix, 2);*/
            Console.WriteLine(countPalindrome("aa"));

        }


        static void matrixRotation(int[,] matrix, int r)
        {
            int[,] rotatedArray = new int[matrix.GetLength(0), matrix.GetLength(1)];
          /*  int TotalNoOFElements = matrix.GetLength(0) + matrix.GetLength(1);*/

            for(int i = 0; i< matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    rotatedArray[i, j] = matrix[i - j - 1, i];
                }
            }
         
            

            for (int col = 0, row = 0; row < rotatedArray.GetLength(0) && col < rotatedArray.GetLength(1); row++, col++)
            {

                Console.WriteLine(matrix[row, col]);
            }

        }

        static int countPalindrome(string GivenString)
        {
            int palindromeCount = 0;
            
            for(int i = 0; i < GivenString.Length; i++)
            {
                if(GivenString.Length == 2)
                {
                    if(GivenString[i] == GivenString[GivenString.Length - 1])
                    {
                        palindromeCount++;
                    }
                }
                else
                {
                    for(int j = i+2; j<= GivenString.Length; j++)
                    {
                       palindromeCount += CheckPalindrome(GivenString.Substring(i, j));
                    }
                }

                
            }
            return palindromeCount;
        }


        static int CheckPalindrome(string substring)
        {
             for(int k=0; k < substring.Length/2; k++)
            {
                if(substring[k] != substring[substring.Length - 1 - k]){
                    return 0;
                }
       
            }
            return 1;
        }
    }
}
