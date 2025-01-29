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
            // Ex:
            //  Input:
            //   5
            //1 3 2 3 1
            //Output:
            //   YES


            #endregion

            #region Given a Queue, implement a function to reverse the elements of a queue using a stack.

            #endregion


            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
            //Ex:
            //Input:
            //    [()] { }
            //Output:
            //    Balanced


            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            #endregion

            #region 6. Given an array list , implement a function to remove all odd numbers from it.

            #endregion

            #region 7- Implement a queue that can hold different data types. 

            #endregion


            #region 8- Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            #endregion

            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays..

            #endregion

            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            #endregion

            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            #endregion
        }
    }
}
