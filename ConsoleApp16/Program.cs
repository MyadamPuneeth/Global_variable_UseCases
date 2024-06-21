using System;
using System.Diagnostics.CodeAnalysis;

/* Showcasing the use of public variables in a class, by using a Program to calculate the avg marks of the class. */

namespace ConsoleApp16
{
    class Program
    {
        // Main Class
        static void Main(string[] args)
        {
            anotherProgram ap = new anotherProgram();
            ap.readInput();
            ap.totalMarks();
            ap.avgMarks();
        }
    }

    /*
     Class named anotheProgram.
     This is where the actual code for the program is.
     */

    class anotherProgram
    {

        /*
         
          declaring Global variable
          input, n, array - arr, sum and avg.

          We'll see how we can use these global variables in various classes.
        
         */


        public string input;
        int n; 
        int[] arr = new int[1];
        int sum = 0;
        float avg;

        // Constructor class called

        public anotherProgram()
        {
            /* 
              taking the number of students in a classroom.
              and reinitializing the array with the change in the size of the array.

              Now later we'll be able to see how the changes done to the array will not just be permitted to the scope of this constructor.

             */

            Console.WriteLine("Enter number of students");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
        }


        public void readInput()
        {
            
            Console.WriteLine("Enter the student marks");

            int i = 0;

            /*
             
            As mentioned before here I have lets say the 'n' value is 20 the arr has been renitialized. Otherwise it will throw a 'array index out of bounds' exeception.
             
             */

            while (i < n)
            {
                input = Console.ReadLine();
                int appendValue = Convert.ToInt32(input);
                arr[i] = appendValue;
                i++;

            }


        }

        public void totalMarks()
        {
            int i = 0;

            /*
             
            As we can see we are able to use the sum variable and the array arr as they were declared globally.
             
             */

            while (i< arr.Length)
            { 
                sum = sum+arr[i];
                i++;
            }
        }

        public void avgMarks()
        {

            /*
             
             Similarly here we can see the sum variable being used again to calculate the avg marks of the classroom.
             
             */

            avg = sum/(arr.Length);
            Console.WriteLine("Average marks = "+avg);
        }

    }
}