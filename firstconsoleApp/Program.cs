using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstconsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double a =5;
            double b =7;
            int sum;
            int sub;
            int multi;
            double divsion;
            sum = Convert.ToInt32( a + b);
            sub = Convert.ToInt32( a - b);
            multi = Convert.ToInt32( a * b);
            divsion = Math.Round((a / b),2);

            Console.WriteLine($" {a} + {b} = {sum}");
            Console.WriteLine($" {a} - {b} = {sub}");
            Console.WriteLine($" {a} * {b} = {multi}");
            Console.WriteLine($" {a} / {b} = {divsion}");*/

            /*double a;
            double b;
            int sum;
            int sub;
            int multi;
            double divsion;

            Console.WriteLine("Enter value of A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B");
            b = Convert.ToInt32(Console.ReadLine());

            sum = Convert.ToInt32(a + b);
            sub = Convert.ToInt32(a - b);
            multi = Convert.ToInt32(a * b);
            divsion = Math.Round((a / b), 2);

            Console.WriteLine($" {a} + {b} = {sum}");
            Console.WriteLine($" {a} - {b} = {sub}");
            Console.WriteLine($" {a} * {b} = {multi}");
            Console.WriteLine($" {a} / {b} = {divsion}");*/

            /*string operater;
            int a;
            int b;
            int sum;
            int sub;
            int multi;
            double divsion;

            Console.WriteLine("Enter value of A in Number");
            while (!int.TryParse(Console.ReadLine(), out a)) {
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of A in Number");
            };
            Console.WriteLine("Enter value of B in Number");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                
                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of B in Number");
            };

            Console.WriteLine("Enter Operator + - * /");
            operater = Console.ReadLine();

            sum = Convert.ToInt32(a + b);
            sub = Convert.ToInt32(a - b);
            multi = Convert.ToInt32(a * b);
            divsion = Convert.ToDouble(a / b);

            if (operater == "+")
            {
                Console.WriteLine($" {a} + {b} = {sum}");
            }else if(operater == "-")
            {
                Console.WriteLine($" {a} - {b} = {sub}");
            }
            else if(operater == "*")
            {
                Console.WriteLine($" {a} * {b} = {multi}");
            }
            else if(operater == "/")
            {
                Console.WriteLine($" {a} / {b} = {divsion}");
            }
            else
            {
                Console.WriteLine("Pleae enter valid number");
            }*/

            /*int operater;
            int a;
            int b;
            int sum;
            int sub;
            int multi;
            double divsion;

            Console.WriteLine("Enter value of A in Number");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of A in Number");
            };
            Console.WriteLine("Enter value of B in Number");
            while (!int.TryParse(Console.ReadLine(), out b))
            {

                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of B in Number");
            };

            sum = Convert.ToInt32(a + b);
            sub = Convert.ToInt32(a - b);
            multi = Convert.ToInt32(a * b);
            divsion =(double) a / b;


            do
            {
                do
                {
                    Console.WriteLine("Enter 1 for Sum");
                    Console.WriteLine("Enter 2 for Subtraction");
                    Console.WriteLine("Enter 3 for multiple");
                    Console.WriteLine("Enter 4 for Division");
                    Console.WriteLine("Enter 5 for Exit");
                } while (!int.TryParse(Console.ReadLine(), out operater));

                switch (operater)
                {
                    case 1:
                        Console.WriteLine($" {a} + {b} = {sum}");
                        break;
                    case 2:
                        Console.WriteLine($" {a} - {b} = {sub}");
                        break;
                    case 3:
                        Console.WriteLine($" {a} * {b} = {multi}");
                        break;
                    case 4:
                        Console.WriteLine($" {a} / {b} = {Math.Round(divsion, 2)}");
                        break;
                }

            }
            while (operater != 5);

            Console.WriteLine("Are You Sure want to exit Press Enter");*/

            int pattern;
            do
            {
                Console.WriteLine("Enter Number of Pattern 1-11 for Exit Enter 0");
                while (!int.TryParse(Console.ReadLine(), out pattern))
                {
                    Console.Clear();
                    Console.WriteLine("You entered an invalid number");
                    Console.Write("Enter Number of Pattern 1-11 for Exit Enter 0");
                };

                if (pattern == 1)
                {
                    Console.WriteLine("Pattern - 1");
                    int a;
                    int b;
                    for (a = 8; a >= 1; --a)
                    {
                        for (b = 1; b <= a; ++b)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                }
                else if (pattern == 2)
                {
                    Console.WriteLine("Pattern - 2");
                    int c;
                    int d;
                    for (c = 1; c <= 8; ++c)
                    {
                        for (d = 1; d <= c; ++d)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                }
                else if (pattern == 3)
                {
                    Console.WriteLine("Pattern - 3");
                    int c;
                    int d;
                    for (c = 1; c <= 8; ++c)
                    {
                        for (d = 1; d <= c; ++d)
                        {
                            Console.Write('*');
                        }
                        Console.Write(' ');
                        for (d = 1; d <= c; ++d)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                }
                else if (pattern == 4)
                {
                    Console.WriteLine("Pattern - 4");
                    int c;
                    int d;
                    int e;
                    int endnum = 8;
                    for (c = 1; c <= endnum; ++c)
                    {
                        for (d = 1; d <= endnum - c; ++d)
                        {
                            Console.Write(' ');
                        }
                        for (e = 1; e <= endnum - d; ++e)
                        {
                            Console.Write('*');
                        }

                        Console.WriteLine();
                    }
                }
                else if (pattern == 5)
                {
                    Console.WriteLine("Pattern - 5");
                    int n = 8;
                    for (int i = 0; i < n; ++i)
                    {
                        for (int st = 0; st < i+1; ++st)
                        {
                            Console.Write("*");
                        }
                        for (int sp = 0; sp < n - i - 1; ++sp)
                        {
                            Console.Write(" ");
                        }
                        for (int st = 0; st < n - i + 1; ++st)
                        {
                            Console.Write("*");
                        }
                        for (int sp = 0; sp < 2 * i; ++sp)
                        {
                            Console.Write(" ");
                        }
                        for (int st = 0; st < n - i; ++st)
                        {
                            Console.Write("*");
                        }
                        for (int sp = 0; sp < n - i - 1; ++sp)
                        {
                            Console.Write(" ");
                        }
                        for (int st = 0; st < i + 1; ++st)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }

                }
                else if (pattern == 6)
                {
                    Console.WriteLine("Pattern - 6");
                    int c;
                    int d;
                    int e;
                    int endnum = 8;
                    for (c = 1; c <= endnum; ++c)
                    {
                        if (c == 1 || c == 8)
                        {
                            for (d = 1; d <= 7; ++d)
                            {
                                Console.Write('*');
                            }
                        }
                        else
                        {
                            for (e = 1; e <= 1; ++e)
                            {
                                Console.Write('*');
                                for (int j = 1; j <= 5; ++j)
                                {
                                    Console.Write(' ');
                                }
                                Console.Write('*');
                            }
                        }
                        Console.WriteLine(' ');
                    }
                }
                else if (pattern == 7)
                {
                    Console.WriteLine("Pattern - 7");
                    int c;
                    int d;
                    int endnum = 8;
                    int e = endnum - 1;
                    for (c = 1; c <= endnum; c++)
                    {
                        for (d = 1; d <= e; d++)
                            Console.Write(" ");
                        e--;
                        for (d = 1; d <= 2 * c - 1; d++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    int ex = 1;
                    for (c = 1; c <= endnum - 1; c++)
                    {
                        for (d = 1; d <= ex; d++)
                            Console.Write(" ");
                        ex++;
                        for (d = 1; d <= 2 * (endnum - c) - 1; d++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                }
                else if (pattern == 8)
                {
                    Console.WriteLine("Pattern - 8");
                    int i, j;
                    int space = 10;
                    int MAX = space;

                    for (i = 0; i < MAX; i++)
                    {

                        for (j = 0; j < space; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 0; j <= i; j++)
                        {
                            Console.Write("* ");
                        }

                        Console.WriteLine();
                        space--;
                    }
                }
                else if (pattern == 9)
                {
                    Console.WriteLine("Pattern - 9");
                    int i, j;
                    int space = 10;
                    int MAX = space;

                    for (i = 0; i < MAX; i++)
                    {

                        for (j = 0; j < space; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 0; j <= i; j++)
                        {
                            Console.Write("* ");
                        }

                        Console.WriteLine();
                        space--;
                    }
                    space = 0;
                    for (i = MAX; i > 0; i--)
                    {

                        for (j = 0; j <= space; j++)
                        {
                            Console.Write(" ");
                        }
                        for (j = 0; j < i; j++)
                        {
                            Console.Write("* ");
                        }

                        Console.WriteLine();
                        space++;
                    }
                }
                else if (pattern == 10)
                {
                    Console.WriteLine("Pattern - 10");
                    int c;
                    int d;
                    for (c = 1; c <= 8; ++c)
                    {
                        for (d = 1; d <= c; ++d)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                    int a;
                    int b;
                    for (a = 7; a >= 1; --a)
                    {
                        for (b = 1; b <= a; ++b)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();
                    }
                }
                else if (pattern == 11)
                {
                    Console.WriteLine("Pattern - 11");
                    int a;
                    int b;

                    for (a = 0; a <= 9; a++)
                    {
                        for (b = 9; b >= a; b--)
                        {
                            Console.Write('*');
                        }
                        for (int i = 1; i <= a; i++)
                        {
                            Console.Write(' ');
                        }

                        for (b = 9; b >= a; b--)
                        {
                            Console.Write('*');
                        }
                        Console.WriteLine();


                    }

                }

            } while (pattern != 0);





            Console.ReadLine();
        }
    }
}
