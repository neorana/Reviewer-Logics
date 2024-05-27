using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string result = "12345";
            var intList = result.Select(digit => int.Parse(digit.ToString()));
            var mysum = intList.Sum();
            
            
            //Other Approach
            int num = 485;
            List<int> listOfInts = new List<int>();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num = num / 10;
            }
            listOfInts.Reverse();
            int ans = listOfInts.Sum();
            //return listOfInts.ToArray();

            //Console.WriteLine(ans);
            
            //Fibonacci_Iterative(10);
            //Console.ReadLine();


            SumInt_Iterative(5);
            ReverseWord("myword");
            Console.ReadLine();


           
           
        }

        public static void Fibonacci_Iterative(int nth)
        {
            int myItereative = 9;
            int a = 0, b = 1, c = 0;
            //Console.Write("{0} {1}", a,b) ;

            //Console.Write("{0} ", a);
            //for (int i = 0; i < myItereative; i++)

            for (int i = 0; i < nth; i++)
            {
                c = a + b;
                Console.Write(" {0}", c) ;
                a = b;
                b = c;
            }

            Console.WriteLine("\n" + c);


            //int d = 14, e = 10, f = 0, g = 0;
            //f = d / e;
            //Console.WriteLine(f);

            //g = d % e;
            //Console.WriteLine(g);
            
       }


        // 1. Using any programming language, create a function that takes an integer parameter (x) and adds up all the numbers from 1 
        //    to x and returns the final value. 
        public static int SumInt_Iterative(int x)
        {
            int sum = 0;
            for (int i = 1; i <= x; i++)
            {
                //Console.Write(" {0}", i);
                sum += i;
            }
            Console.WriteLine("\n" + sum);
            return sum;

            ////snippet
            //int sum = 0;
            //for (int i = 1; i <= x; i++)
            //{
            //    sum += i;
            //}
            //return sum;

        }

        // 2. Using any programming language, create a function that takes a string parameter (word) and returns the word in reversed order. 
        public static string ReverseWord(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            return new string(charArray);

            ////snippet
            //char[] charArray = str.ToCharArray();
            //Array.Reverse(charArray);
            //return new string(charArray);
        }

        // 3. Using any programming language, create a function that takes a string parameter (sentence) 
        //    and return the largest word in the string. 
        //    If there are two or more words that are the same length, return the first word from the string with that length. 
       
       //public static string LargestWord(string sentence)
       // {
       //     
            string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";

        // Splitting the string into words based on spaces and storing them in an array
        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        string word = ""; // Initializing an empty string to store the word with the maximum length
        int ctr = 0; // Initializing a counter variable to keep track of the maximum length

        // Looping through each word in the words array
        foreach (String s in words)
        {
            // Checking if the length of the current word is greater than the stored maximum length
            if (s.Length > ctr)
            {
                word = s; // If the current word's length is greater, update the 'word' variable
                ctr = s.Length; // Update the maximum length counter
            }
        }

        Console.WriteLine(word); // Displaying the word with the maximum length
        //return new string sentence;
       // }
    }
}
