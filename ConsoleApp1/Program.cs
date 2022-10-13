using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question15(121);
        }

        static void Question1()
        {
            string name = "Tadas";
            for (int i = 0; i != 101; i++)
            {
                Console.WriteLine("Hi my name is: " + name + " : " + i);
            }
        }

        static void Question2()
        {
            for (int i = 0; i < 78; i++)
            {
                string even = i % 2 == 0 ? i.ToString() : "";
                Console.WriteLine(even);
            }
        }
        static void Question3(int num=0)
        {
            int start = 0;
            while (start < num)
            {
                Console.WriteLine(start);
                start++;
            }
        }

        static void Question4(int start=5, int end=10)
        {
            while (start <= end)
            {
                Console.WriteLine(start++);
            }
        }

        static void Question5()
        {
            for(int i = 0; i <= 100; i++)
            {
                string oddEven = i % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine(i + " : " + oddEven );
            }
        }

        static void Question6()
        {
            for (int i = 0; i <= 500; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
            }
        }

        static void Question7(int x=15, int y=21)
        {
            int goal = 1;
            int sum = x + y;
            while (sum >= goal)
            {
                Console.WriteLine(sum--);
            }
        }

        static void Question8()
        {
            double popStart = 15.6;
            int year = 0;
            int growthRate = 10;
            while (year != 5)
            {
                popStart += popStart * growthRate / 100;
                Console.WriteLine("Year: "+year++ +" Mexico Pop: " + popStart);
            }
        }

        static void Question9()
        {
            double popStart = 15.6;
            int yearStart = 1;
            int growthRate = 4;
            int yearEnd = 5;
            while (yearStart <= yearEnd)
            {
                popStart += popStart * growthRate / 100;
                Console.WriteLine("Year: {0} Mexico Pop: {1}", yearStart++, popStart);
            }
        }

        static void Question10()
        {
            int evenSum = 0;
            int oddProduct = 1;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0) 
                    evenSum += i;
                else 
                    oddProduct = oddProduct * i;
            }
            Console.WriteLine("Even Sum: {0}\nOdd Product: {1}", evenSum,oddProduct);
        }
        
        static void Question11(int start=1, int end=3)
        {
            int sum = 0;
            for (var i = start; i <= end; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum: " + sum);
        }

        static void Question13()
        {
            double startSavings = 1000;
            int years = 6;
            int interestRate = 5;
            double deposit = 1000;
            for (int i = 1; i <= years; i++)
            {
                startSavings += startSavings * interestRate / 100;
                startSavings += deposit;
                Console.WriteLine("Year: {0}  Sum: {1}", i, startSavings);

            }
        }

        static void Question14()
        {
            double population = 4.8;
            int growthRate = 20;
            int yearTime = 10;
            int yearsSum = 0;
            for (int i = 0; i <= yearTime; i++)
            {
                if (population >= 5)
                    yearsSum++;
                population += population * growthRate / 100;
            }
            Console.WriteLine("Population: {0} Years Exceeded: {1}", population, yearsSum);
        }

        static void Question15(int num)
        {
            int r, sum = 0, temp;
            temp = num;
            while(num>0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
                Console.WriteLine("{0} Is Palindrome", temp);
            else
                Console.WriteLine("{0} Is not Palindrome", temp);
        }
    }

}

/*1.In pairs - print out both of your names 100 times!
2.	Print out every even number between 0 and 77 (inclusive).
3.  Print out all the numbers less than ‘x’ where x is a variable you have set to a particular value outside of the loop.
4.	Print out all the numbers from ‘y’ to ‘z’ where these are variables you have assigned values to outside of the loop.
5.	Print out every number from 1 to 100 – indicating  if each number is odd or if it is even
6.	Output the numbers from 1 to 500 that are divisible by 5
7.	In pairs - print out all the numbers from 1 to the sum of both your ages (in reverse order).
8.  The population of Mexico City is 15.6 million and growing at a rate of 10% per year. Write a program to determine and display the population in 4 years time.
9.	The population of Mexico City is 15.6 million and growing at a rate of 4% per year. Write a program to determine and display the year and the population at the end of each of the next 5 years.
10.	Write a program that displays the sum of the even numbers and the product of the odd numbers between 1 and 10.  Use two loops. Can you solve the problem with one loop?


11.	Write a program that displays the average of the integers between 5 and 17

12.	Write a program that displays the average of the integers between 1 and a value entered by the user.

13.	€1000 is deposited in a savings account and $1000 is deposited at the end of each year. If the interest rate is 5% calculate and display the amount in the account after 6 years.

14.	The population of Ireland is 4.8 million and growing at a rate of 20% per year. Write a program to determine and display the population in 10 years time. Your program should also display the number of years that the population exceeds 5 million.

15.	A palindrome is a number or a text phrase that reads the same backwards as forwards. For example, each of the following five-digit integers is a palindrome: 12321, 55555, 45554 and 11611.Write a program that reads in a five-digit integer and determines whether it is a palindrome. (Hint: Use the division and modulus operators to separate the number into its individual.


16.	Write a program that reads 5 sets of three nonzero integers and determines and prints if they could be the sides of a right triangle.

17.	Write a program that calculates and prints the average of several integers. Assume the last value read is the sentinel 9999. A typical input sequence might be 10 8 11 7 9 9999 indicating that the average of all the values preceding 9999 is to be calculated.

18.	One interesting application of computers is drawing graphs and bar charts (sometimes called “histograms”). Write a program that reads five numbers (each between 1 and 30). For each number read, your program should print a line containing that number of adjacent asterisks. For example, if your program reads the number seven, it should print *******.

19.	Write a program that allows a user to enter 10 numbers between 1 and 100 and displays, the total of the numbers, the smallest and largest numbers entered and the average of the numbers entered.

20.	Write a C# program that utilizes looping and the tab escape sequence \t to print the following table of values:

N 	10*N 	100*N 	1000*N
1 	10 	100	 1000
2	 20 	200 	2000
3	30	300 	3000
4 	40 	400 	4000
5		50 	500 	5000

21.	Develop a C# program that will determine the gross pay for each of several employees. The company pays “straight-time” for the first 40 hours worked by each employee and pays “time-and-a-half” for all hours worked in excess of 40 hours. You are given a list of the employees of the company, the number of hours each employee worked last week and the hourly rate of each employee. Your program should input this information for each employee and should determine and display the employee's grosspay.

*/
