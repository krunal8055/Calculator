using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Starting();
            while (true)
            {
                //Calculator Menu
                      ChangeColor("-------------------------------------- Calculator Menu -----------------------------",ConsoleColor.Red);
                Console.WriteLine("-------------------------------------- (1) Addition  -------------------------------");
                Console.WriteLine("-------------------------------------- (2) Subtraction  ----------------------------");
                Console.WriteLine("-------------------------------------- (3) Multiplication  -------------------------");
                Console.WriteLine("-------------------------------------- (4) Division  -------------------------------");
                Console.WriteLine("-------------------------------------- (5) Modules  --------------------------------");
                Console.WriteLine("-------------------------------------- (6) Exit  -----------------------------------");
                //User Choice 
                String UserChoice = Console.ReadLine();
                int choice;

                //Check User enters number or not
                if (Int32.TryParse(UserChoice, out choice))
                {
                    //Switch case for Choice
                    switch (choice)
                    {
                        case 1:
                            Addition();
                            break;
                        case 2:
                            Subtraction();
                            break;
                        case 3:
                            Multiplication();
                            break;
                        case 4:
                            Division();
                            break;
                        case 5:
                            Modulas();
                            break;
                        case 6:
                            return;
                        default:
                            ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                            break;
                    }
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                }
            }

        }

        //Starting of Program
        static void Starting()
        {
            ChangeColor("Welcome To My Calculator \n Version 1.0",ConsoleColor.Green);
        }

        //Method For Add
        static void Addition()
        {
         Console.WriteLine("Addition!");
            int number1, number2, Answer;

            //First Number
            Console.WriteLine("First Number");
            while(true)
            {
                String demo1 = Console.ReadLine();
                if (CheckNumberInt(demo1) == true)
                {
                    number1 = Convert.ToInt32(demo1);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }
            
            //Second Number
            Console.WriteLine("Second Number");
            while (true)
            {
                String demo2 = Console.ReadLine();
                if (CheckNumberInt(demo2) == true)
                {
                    number2 = Convert.ToInt32(demo2);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }
     
            Answer = number1 + number2;
            ChangeColor("                                      Answer :" + Answer, ConsoleColor.Yellow);
            
        }

        //Method For Subtract
        static void Subtraction()
        {
            Console.WriteLine("Subtraction!");
            int number1, number2, Answer;

            //First Number
            Console.WriteLine("First Number");
            while (true)
            {
                String demo1 = Console.ReadLine();
                if (CheckNumberInt(demo1) == true)
                {
                    number1 = Convert.ToInt32(demo1);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            //Second Number
            Console.WriteLine("Second Number");
            while (true)
            {
                String demo2 = Console.ReadLine();
                if (CheckNumberInt(demo2) == true)
                {
                    number2 = Convert.ToInt32(demo2);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            Answer = number1 - number2;
            ChangeColor("                                      Answer :" + Answer, ConsoleColor.Yellow);

        }

        //Method For Multiply
        static void Multiplication()
        {
            Console.WriteLine("Multiplication!");
            int number1, number2, Answer;

            //First Number
            Console.WriteLine("First Number");
            while (true)
            {
                String demo1 = Console.ReadLine();
                if (CheckNumberInt(demo1) == true)
                {
                    number1 = Convert.ToInt32(demo1);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            //Second Number
            Console.WriteLine("Second Number");
            while (true)
            {
                String demo2 = Console.ReadLine();
                if (CheckNumberInt(demo2) == true)
                {
                    number2 = Convert.ToInt32(demo2);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            Answer = number1 * number2;
            ChangeColor("                                      Answer :" + Answer, ConsoleColor.Yellow);

        }

        //Method For Divide
        static void Division()
        {
            Console.WriteLine("Division!");
            int number1, number2, Answer;

            //First Number
            Console.WriteLine("First Number");
            while (true)
            {
                String demo1 = Console.ReadLine();
                if (CheckNumberInt(demo1) == true)
                {
                    number1 = Convert.ToInt32(demo1);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            //Second Number
            Console.WriteLine("Second Number");
            while (true)
            {
                String demo2 = Console.ReadLine();
                if (CheckNumberInt(demo2) == true)
                {
                    number2 = Convert.ToInt32(demo2);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            Answer = number1 / number2;
            ChangeColor("                                      Answer :" + Answer, ConsoleColor.Yellow);

        }

        static void Modulas()
        {
            Console.WriteLine("Modulas!");
            int number1, number2, Answer;

            //First Number
            Console.WriteLine("First Number");
            while (true)
            {
                String demo1 = Console.ReadLine();
                if (CheckNumberInt(demo1) == true)
                {
                    number1 = Convert.ToInt32(demo1);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            //Second Number
            Console.WriteLine("Second Number");
            while (true)
            {
                String demo2 = Console.ReadLine();
                if (CheckNumberInt(demo2) == true)
                {
                    number2 = Convert.ToInt32(demo2);
                    break;
                }
                else
                {
                    ChangeColor("Bad input.Please Try Again!!!", ConsoleColor.Red);
                    continue;
                }
            }

            Answer = number1 % number2;
            ChangeColor("                                      Answer :" + Answer, ConsoleColor.Yellow);

        }

        //Method For Change Text Color
        static void ChangeColor(String Text,ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Text);
            Console.ResetColor();
        }

        //Method to Check User's Input is Integer or not
        static bool CheckNumberInt(String TextNumber)
        {
            int IntegerNumber ;
            if (Int32.TryParse(TextNumber, out IntegerNumber))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
