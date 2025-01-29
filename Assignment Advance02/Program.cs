using System.Collections;

namespace Assignment_Advance02
{
    internal class Program
    {

        public static int PrintNumbers(List<int> list)
        {
            int x;
            if (list?.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {

                }
            }
            return x;
        }
        static void Main(string[] args)
        {
            #region Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //        Ex:
            //            Input
            //3 3                    //Size of array , number of queries
            //11 5 3             //Array 
            //1                      //Query1
            //5                     //Query2
            //13                  //Query 3
            //Output
            //3                   //11,5,3
            //           1                  //11
            //0
            List<int> list = new List<int>();
            list = new List<int>() { 11,5,3 };
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.TrimExcess();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

            #endregion

            #region Given a number N and an array of N numbers. Determine if it's palindrome or not.

            #endregion
        }
    }
}
