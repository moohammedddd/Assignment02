using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        public static void ReverseArrayLIst(ArrayList Numbers)
        {
            object temp;
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count / 2; i++)
                {
                    temp = Numbers[i];
                    Numbers[i] = Numbers[Numbers.Count - i - 1];
                    Numbers[Numbers.Count - i - 1] = temp;
                }

            }

        }

        public static List<int> EvenNUmber(List<int> Even)
        {
            List<int> NewEven = new List<int>();

            for (int i = 0; i < Even.Count; i++)
            {
                if (Even[i] % 2 == 0)
                {
                    NewEven.Add(Even[i]);
                }
            }
            return NewEven;
        }
        static void Main(string[] args)
        {
            #region Q1 You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //ArrayList Reverses = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            //ReverseArrayLIst(Reverses);
            //foreach (var item in Reverses)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Q2 You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.
            List <int> Even = new List<int> { 1, 2, 3, 4, 5 }; List<int> NewEven = EvenNUmber(Even);
            foreach (var item in NewEven)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
