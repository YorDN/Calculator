using Microsoft.VisualBasic;
using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Linq;

namespace TheBESTcalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answerColor;
            string name;
            Console.WriteLine("Hello, user, welcome to the BEST calculator to" +
                " ever exist,first things first - what's your name?");
            name = Console.ReadLine();
            if (string.Equals(name, "yordan", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("The best name ;)");
            }
            Console.WriteLine("Before we really start do you want to change the text color?");
             answerColor = Console.ReadLine();
            if (string.Equals(answerColor, "yes", StringComparison.CurrentCultureIgnoreCase))
            {
                ChangeColor();
            }
            else if (string.Equals(answerColor, "no", StringComparison.CurrentCultureIgnoreCase))
            {
                
            }
            else if (answerColor == "No, God, please no!")
            {
                Console.WriteLine("Alright, alright, chill");
            }
            else
            {
                Console.WriteLine("Invalid answer from a stupid creature!");
            }
            Console.WriteLine("Press ENTER to continue!");
            string cont = Console.ReadLine();
            if (cont != "")
            {
                Console.WriteLine("Whats wrong with you? I'll continue either way!");
                
            }
            bool again = true;
            int n = 0;
            while (again) 
            {
                string welcome = "Hi";
                if(n >= 1)
                {
                    welcome = "Ok";
                }
                else
                {

                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"{welcome}, {name}, what do you want to do?");
                Console.WriteLine("For BASIC OPERATIONS type '1'");
                Console.WriteLine("For FIGURE OPERATIONS type '2'");
                Console.WriteLine("For MONEY OPERATIONS type '3'");
                Console.WriteLine("For DISTANCE CALCULATIONS type '4'");
                Console.WriteLine("For WEIGHT CALCULATIONS type '5'");
                Console.WriteLine("For TEXT COLOR CHANGE type '6'");
                Console.WriteLine("For SLOTS type '7'");                
                Console.WriteLine("For CREDITS and CHANGELOG type '8'");
                Console.WriteLine("To EXIT type '9'");
                Console.WriteLine("---------------------------------------------");
                int choice = 0;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine("That wasn't quite right");
                    
                    break;
                }
                if (choice == 1)
                {
                    Console.WriteLine($"What basic operations do you want to do, {name}?");
                    Console.WriteLine("For addition type '1'");
                    Console.WriteLine("For subtraction type '2'");
                    Console.WriteLine("For division type '3'");
                    Console.WriteLine("For multiplication type '4'");
                    int choice2 = 0;
                    try
                    {
                        choice2 = int.Parse(Console.ReadLine());
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("That wasn't quite right");

                        break;
                    }
                    int a;
                    int b;
                    switch (choice2)
                    {
                        case 1:
                            Addition();
                            break;
                        case 2:
                            Subtraction();
                            break;
                        case 3:
                            Console.WriteLine("Enter two numbers:");
                            a = int.Parse(Console.ReadLine());
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine(Divide(a, b));
                            break;
                        case 4:
                            Multiply();
                            break;
                        default:
                            Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                            break;
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"What shape do you want to caclulate, {name}?");
                    string shape = Console.ReadLine();
                    Console.WriteLine("To calculate the PERIMETER type '1'");
                    Console.WriteLine("To calculate the AREA type '2'");
                    Console.WriteLine("To calculate the BIGGEST SIDE type '3'");
                    int choice2 = int.Parse(Console.ReadLine());
                    int a;
                    int b;
                    int c;
                    int d;
                    int h;
                    int r;
                    double s;
                    int p;
                    switch (shape)
                    {
                        case "square":
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine($"Please enter the side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the {shape} is {4 * a} cm");
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter the side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {a * a} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine($"Please enter the side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The biggest side of the {shape} is {a} cm");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case "rectangle":
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the other");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the {shape} is {2 * a + 2 * b} cm");
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the other");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {a * b} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the other");
                                    b = int.Parse(Console.ReadLine());
                                    if (a > b)
                                    {
                                        Console.WriteLine($"The biggest side of the {shape} is {a} cm");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The biggest side of the {shape} is {b} cm");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case "triangle":
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the second");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the third");
                                    c = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the {shape} is {a + b + c} cm");
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter one of the sides of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now enter the height of the triangle");
                                    h = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {(a * h)/2} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the second");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the third");
                                    c = int.Parse(Console.ReadLine());
                                    int max = int.MinValue;
                                    if (a > max)
                                    {
                                        max = a;
                                    }
                                    if (b > max)
                                    {
                                        max = b;
                                    }
                                    if (c > max)
                                    {
                                        max = c;
                                    }
                                    Console.WriteLine($"The biggest side of the {shape} is {max} cm");
                                    break;

                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case "circle":
                            switch (choice2)
                            {

                                case 1:
                                    Console.WriteLine($"Please enter the radius of the {shape}");
                                    r = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the {shape} is {Math.PI * 2 * r} cm");
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter the radius of the {shape}");
                                    r = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {Math.PI * r * r} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine("Sorry, the circle does not have sides :/");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case "parallelogram":
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the other");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The perimeter of the {shape} is {2 * a + 2 * b} cm");
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter one of the sides of the {shape}");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Now enter the height of the {shape}");
                                    h = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {b * h} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the other");
                                    b = int.Parse(Console.ReadLine());
                                    if (a > b)
                                    {
                                        Console.WriteLine($"The biggest side of the {shape} is {a} cm");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"The biggest side of the {shape} is {b} cm");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                         
                            break;
                        case "trapezoid":
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine($"Is the {shape} isosceles?");
                                    string answer = Console.ReadLine();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"Please enter the first side of the {shape}");
                                        a = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the second");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the third (and forth)");
                                        c = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The perimeter of the {shape} is {a + b + 2 * c} cm");
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine($"Please enter the first side of the {shape}");
                                        a = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the second");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the third");
                                        c = int.Parse(Console.ReadLine());
                                        Console.WriteLine("And lastly the forth");
                                        d = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The perimeter of the {shape} is {a + b + c + d} cm");
                                    }
                                    else
                                    {
                                        Console.WriteLine("I do not understand your answer..");
                                    }
                                    break;
                                case 2:
                                    Console.WriteLine($"Please enter the first side of the {shape}");
                                    a = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Now the second");
                                    b = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"Now enter the height of the {shape}");
                                    h = int.Parse(Console.ReadLine());
                                    Console.WriteLine($"The area of the {shape} is {((a + b) * h) / 2} cm2");
                                    break;
                                case 3:
                                    Console.WriteLine($"Is the {shape} isosceles?");
                                    answer = Console.ReadLine();
                                    if (answer == "yes")
                                    {
                                        Console.WriteLine($"Please enter the first side of the {shape}");
                                        a = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the second");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the third (and forth)");
                                        c = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The perimeter of the {shape} is {a + b + 2 * c} cm");
                                        int max = int.MinValue;
                                        if (a > max)
                                        {
                                            max = a;
                                        }
                                        if (b > max)
                                        {
                                            max = b;
                                        }
                                        if (c > max)
                                        {
                                            max = c;
                                        }
                                        Console.WriteLine($"The biggest side of the {shape} is {max} cm");
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine($"Please enter the first side of the {shape}");
                                        a = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the second");
                                        b = int.Parse(Console.ReadLine());
                                        Console.WriteLine("Now the third");
                                        c = int.Parse(Console.ReadLine());
                                        Console.WriteLine("And lastly the forth");
                                        d = int.Parse(Console.ReadLine());
                                        Console.WriteLine($"The perimeter of the {shape} is {a + b + c + d} cm");
                                        int max = int.MinValue;
                                        if (a > max)
                                        {
                                            max = a;
                                        }
                                        if (b > max)
                                        {
                                            max = b;
                                        }
                                        if (c > max)
                                        {
                                            max = c;
                                        }
                                        if (d > max)
                                        {
                                            max = d;
                                        }
                                        Console.WriteLine($"The biggest side of the {shape} is {max} cm");
                                    }
                                    else
                                    {
                                        Console.WriteLine("I do not understand your answer..");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            
                            }
                            break;
                        default:
                            Console.WriteLine("Please enter a valid shape: square, rectangle, triangle, circle, " +
                                "parallelogram or trapezoid!");
                            break;
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine($"What currency do you want to convert, {name}");
                    Console.WriteLine("To convert USD type '1'");
                    Console.WriteLine("To convert JPY type '2'");
                    Console.WriteLine("To convert BGN type '3'");
                    Console.WriteLine("To convert EUR type '4'");
                    Console.WriteLine("To convert RUB type '5'");
                    Console.WriteLine("To convert GBP type '6'");
                    int choiceConvertOrg = int.Parse(Console.ReadLine());
                    if (choiceConvertOrg >= 7)
                    {
                        Console.WriteLine("You went out of the border!");
                        break;
                    }
                    Console.WriteLine($"To what currency do you want to convert?");
                    Console.WriteLine("For USD type '1'");
                    Console.WriteLine("For JPY type '2'");
                    Console.WriteLine("For BGN type '3'");
                    Console.WriteLine("For EUR type '4'");
                    Console.WriteLine("For RUB type '5'");
                    Console.WriteLine("For GBP type '6'");
                    int choiceConvertTo = int.Parse(Console.ReadLine());
                    if (choiceConvertTo >= 7)
                    {
                        Console.WriteLine("You went out of the border!");
                        break;
                    }
                    Console.WriteLine($"How much do you want to convert,{name}");
                    double ammount = double.Parse(Console.ReadLine());
                    switch (choiceConvertOrg)
                    {
                        case 1:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                case 2:
                                    Console.WriteLine($" {ammount} USD = {Currency(ammount, 148.14)} JPY"); 
                                    break;
                                case 3:
                                    Console.WriteLine($"{ammount} USD = {Currency(ammount, 1.80)} BGN"); 
                                    break;
                                case 4:
                                    Console.WriteLine($"{ammount} USD = {Currency(ammount, 0.92)} EUR"); 
                                    break;
                                case 5:
                                    Console.WriteLine($"{ammount} USD = {Currency(ammount, 89.43)} RUB");
                                    break;
                                case 6:
                                    Console.WriteLine($"{ammount} USD = {Currency(ammount, 0.79)} GBP");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case 2:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine($"{ammount} JPY = {Currency(ammount, 0.0068)} USD");
                                    break;
                                case 2:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                case 3:
                                    Console.WriteLine($"{ammount} JPY = {Currency(ammount, 0.012)} BGN");
                                    break;
                                case 4:
                                        Console.WriteLine($"{ammount} JPY = { Currency(ammount, 0.0062)} EUR");
                                    break;
                                case 5:
                                    Console.WriteLine($"{ammount} JPY = {Currency(ammount, 0.60)} RUB");
                                    break;
                                case 6:
                                    Console.WriteLine($"{ammount} JPY = {Currency(ammount, 0.0053)} GBP");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case 3:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine($"{ammount} BGN = {Currency(ammount, 0.56)} USD");
                                    break;
                                case 2:
                                    Console.WriteLine($"{ammount} BGN = {Currency(ammount, 82.52)} JPY");
                                    break;
                                case 3:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                case 4:
                                    Console.WriteLine($"{ammount} BGN = {Currency(ammount, 0.51)} EUR");
                                    break;
                                case 5:
                                    Console.WriteLine($"{ammount} BGN = {Currency(ammount, 49.82)} RUB");
                                    break;
                                case 6:
                                    Console.WriteLine($"{ammount} BGN = {Currency(ammount, 0.44)} GBP");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case 4:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine($"{ammount} EUR = {Currency(ammount, 1.09)} USD");
                                    break;
                                case 2:
                                    Console.WriteLine($"{ammount} EUR = {Currency(ammount, 161.70)} JPY");
                                    break;
                                case 3:
                                    Console.WriteLine($"{ammount} EUR = {Currency(ammount, 1.96)} BGN"); ;
                                    break;
                                case 4:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                case 5:
                                    Console.WriteLine($"{ammount} EUR = {Currency(ammount, 97.61)} RUB"); ;
                                    break;
                                case 6:
                                    Console.WriteLine($"{ammount} EUR = {Currency(ammount, 0.86)} GBP");;
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;

                        case 5:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine($"{ammount} RUB = {Currency(ammount, 0.011)} USD");
                                    break;
                                case 2:
                                    Console.WriteLine($"{ammount} RUB = {Currency(ammount, 1.68)} JPY");
                                    break;
                                case 3:
                                    Console.WriteLine($"{ammount} RUB = {Currency(ammount, 0.020)} BGN");
                                    break;
                                case 4:
                                    Console.WriteLine($"{ammount} RUB = {Currency(ammount, 0.010)} EUR");
                                    break;
                                case 5:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                case 6:
                                    Console.WriteLine($"{ammount} RUB = {Currency(ammount, 0.0089)} GBP");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        case 6:
                            switch (choiceConvertTo)
                            {
                                case 1:
                                    Console.WriteLine($"{ammount} GBP = {Currency(ammount, 1.27)} USD");
                                    break;
                                case 2:
                                    Console.WriteLine($"{ammount} GBP = {Currency(ammount, 188.32)} JPY");
                                    break;
                                case 3:
                                    Console.WriteLine($"{ammount} GBP = {Currency(ammount, 2.28)} BGN");
                                    break;
                                case 4:
                                    Console.WriteLine($"{ammount} GBP = {Currency(ammount, 1.16)} EUR");
                                    break;
                                case 5:
                                    Console.WriteLine($"{ammount} GBP = {Currency(ammount, 113.61)} RUB");
                                    break;
                                case 6:
                                    Console.WriteLine("You cannot convert same currencies!");
                                    break;
                                default:
                                    Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("You went out of the border, either by mistake or " +
                                "by sheer stupidity!");
                            break;
                    }
                }
                else if (choice == 4)
                {
                    Console.WriteLine($"What sistem do you want to use, {name}");
                    Console.WriteLine($"For METRIC type '1'");
                    Console.WriteLine($"For IMPERIAL type '2'");
                    int choiceNumber = int.Parse(Console.ReadLine());
                    if (choiceNumber == 1)
                    {
                        MetricDistance();
                    }
                    else if(choiceNumber == 2) 
                    {
                        ImperialDistance();
                    }
                    else
                    {
                        Console.WriteLine("You went out of range!");
                    }
                }
                else if (choice == 5)
                {
                    Console.WriteLine($"What system do you want to convert, {name}?");
                    Console.WriteLine("For Metric System of Measurements type '1'");
                    Console.WriteLine("For US Customary Units (Imperial) type '2'");
                    int choiceWeightSystem = int.Parse(Console.ReadLine());
                    if (choiceWeightSystem == 1) 
                    {
                        MetricWeight();
                    }
                    else if( choiceWeightSystem == 2) 
                    { 
                        UsWeight();
                    }
                    else
                    {
                        Console.WriteLine("Chouse one of these TWO numbers. You went out of border!");
                    }
                }
                else if (choice == 6)
                {
                    if (string.Equals(answerColor, "no", StringComparison.CurrentCultureIgnoreCase))
                    {
                        Console.WriteLine("Oh, so you changed your mind? No problem!");
                    }
                    ChangeColor();
                }
                else if (choice == 7)
                {
                    Slots();
                }
                else if (choice == 8)
                {
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine(" This calculator is made by the one and only Yordan G. Yordanov  ");
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine("                          VERSION: 1.1                           ");
                    Console.WriteLine("* Added try/catch on a couple of choices. More will come!        ");
                    Console.WriteLine("* Added the ability to change the console color.                 ");
                    Console.WriteLine("* Added changelog :)                                             ");
                    Console.WriteLine("* Added some 'eastereggs':O                                      ");
                    Console.WriteLine("* Improved the logic behind the math operations (except devision)");
                }
                else if (choice == 9)
                {
                    break;
                }
                Console.WriteLine("Again?");
                string answr = Console.ReadLine();
                if (string.Equals(answr, "yes", StringComparison.CurrentCultureIgnoreCase))
                {
                    again = true;
                }
                else if (string.Equals(answr, "no", StringComparison.CurrentCultureIgnoreCase))
                {
                    again = false;
                }
                else
                { 
                    Console.WriteLine("You're a stupid one, arents you? I'm going to take that as a no >:)");
                    again = false;
                }
                n++;
            }
            Console.WriteLine("Press ENTER to exit");
        }
        static void Addition() 
        {
            Console.WriteLine("Which data type do you want to use ('int' or 'double')?");
            string dataType = Console.ReadLine();
            byte numDataStorage = 0;
            if (string.Equals(dataType, "int", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 0;
            }
            else if (string.Equals(dataType, "double", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 1;
            }
            else
            {
                Console.WriteLine("Invalid data type!");
                return;
            }
            Console.WriteLine("Enter your numbers devided by ' + '");
            double sum = 0;
            double[] nums = Console.ReadLine().Split(" + ").Select(double.Parse).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine();
            for (int y = 0; y < nums.Length; y++)
            {
                if (y == nums.Length - 1)
                {
                    Console.Write(nums[y]);
                }
                else
                {
                    Console.Write(nums[y] + " + ");
                }
            }
            if (numDataStorage == 0)
            {
                Console.Write($" = {(int)sum}");
            }
            else
            {
                Console.Write($" = {sum:f2}");
            }
            Console.WriteLine();
        }
        static void Subtraction()
        {
            Console.WriteLine("Which data type do you want to use ('int' or 'double')?");
            string dataType = Console.ReadLine();
            byte numDataStorage = 0;
            if (string.Equals(dataType, "int", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 0;
            }
            else if (string.Equals(dataType, "double", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 1;
            }
            else
            {
                Console.WriteLine("Invalid data type!");
                return;
            }
            Console.WriteLine("Enter your numbers devided by ' - '");
            double[] nums = Console.ReadLine().Split(" - ").Select(double.Parse).ToArray();
            double result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result -= nums[i];
            }
            Console.WriteLine();
            for (int y = 0; y < nums.Length; y++)
            {
                if (y == nums.Length - 1)
                {
                    Console.Write(nums[y]);
                }
                else
                {
                    Console.Write(nums[y] + " - ");
                }
            }
            if (numDataStorage == 0)
            {
                Console.Write($" = {(int)result}");
            }
            else
            {
                Console.Write($" = {result:f2}");
            }
            Console.WriteLine();
        }
        static void Multiply() 
        {
            Console.WriteLine("Which data type do you want to use ('int' or 'double')?");
            string dataType = Console.ReadLine();
            byte numDataStorage = 0;
            if (string.Equals(dataType, "int", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 0;
            }
            else if (string.Equals(dataType, "double", StringComparison.CurrentCultureIgnoreCase))
            {
                numDataStorage = 1;
            }
            else
            {
                Console.WriteLine("Invalid data type!");
                return;
            }
            Console.WriteLine("Enter your numbers devided by ' * '");
            double[] nums = Console.ReadLine().Split(" * ").Select(double.Parse).ToArray();
            double sum = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                sum *= nums[i];
            }
            Console.WriteLine();
            for (int y = 0; y < nums.Length; y++)
            {
                if (y == nums.Length - 1)
                {
                    Console.Write(nums[y]);
                }
                else
                {
                    Console.Write(nums[y] + " * ");
                }
            }
            if (numDataStorage == 0)
            {
                Console.Write($" = {(int)sum}");
            }
            else
            {
                Console.Write($" = {sum:f2}");
            }
            Console.WriteLine();
        }
        static double Divide(int a, int b) 
        {
            double ans = 0.0;
            try
            {
                ans = a / b;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot devide by zero!");
                
            }
            return ans;
        }
        static double Currency(double ammount, double changeRate)
        {
            return ammount * changeRate;
        }
        static double Distance(double original, double converted)
        {
            return original * converted;
        }
        static double Weight(double ammount, double converted)
        {
            return ammount * converted;
        }
        static void Slots()
        {
            Console.Write("Enter your balance: ");
            double balance = 0.0;
            try
            {
                 balance = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException e)
            {

                Console.WriteLine("Wrong format, buddy!");
                return;
            }
            while (true)
            {
                Console.WriteLine($"Your balance is {balance}");
                Console.Write("Enter bet: ");
                double bet = 0.0;
                try
                {
                    bet = double.Parse(Console.ReadLine());
                }
                catch (System.FormatException e)
                {

                    Console.WriteLine("Wrong format, buddy!");
                    break;
                }
                Console.WriteLine("Press enter to spin.... or type 'exit' to exit");
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    break;
                }
                balance -= bet;
                string[] reel1 = Spin();
                string[] reel2 = Spin();
                string[] reel3 = Spin();
                Display(reel1, reel2, reel3);
                double win = CheckWin(reel1, reel2, reel3, bet);
                if (win > 0)
                {
                    Console.WriteLine($"Congatulations, you won {win} $");
                    balance += win;
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't win this time.");
                    Console.WriteLine(" ");
                }
                if (balance == 0)
                {
                    Console.WriteLine("Sorry you've lost all your balance!");
                    Console.WriteLine(" ");
                    break;
                }
                System.Threading.Thread.Sleep(1000);

            }
            Console.WriteLine($"Your final balance is {balance}");
        }
        static string[] Spin()
        {
            string[] symbols = { "Cherry", "Watermelon", "Plum", "Grape", "Lemon", "Orange", "Seven", "star"};
            Random random = new Random();
            return new[] { symbols[random.Next(symbols.Length)], symbols[random.Next(symbols.Length)], symbols[random.Next(symbols.Length)] };
        }
        static void Display(string[] reel1, string[] reel2, string[] reel3)
        {
            Console.WriteLine(string.Join(" ", reel1));
            Console.WriteLine(string.Join(" ", reel2));
            Console.WriteLine(string.Join(" ", reel3));
        }
        static double CheckWin(string[] reel1, string[] reel2, string[] reel3, double bet)
        {
            if (reel1[0] == reel2[0] && reel2[0] == reel3[0])
            {
                switch (reel1[0])
                {
                    case "Cherry":
                        return bet * 5;
                    case "Plum":
                    case "Lemon":
                    case "Orange":
                        return bet * 10;
                    case "Grape":
                    case "Watermelon":
                        return bet * 20;
                    case "Seven":
                        return bet * 50;
                    case "Star":
                        return bet * 100;
                    default:
                        return 0;
                }
            }
            return 0;
        }
        static void MetricDistance()
        {
            Console.WriteLine("Do you want to convert Metric to Imperial?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("What Metric unit do you want to convert?");
                Console.WriteLine("For MM (Milimeters) type '1'");
                Console.WriteLine("For CM (Centimeters) type '2'");
                Console.WriteLine("For M (Meters) type '3'");
                Console.WriteLine("For KM (Kilometers) type '4'");
                int answer2 = int.Parse(Console.ReadLine());
                if (answer2 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;
                    
                }
                Console.WriteLine("To what Imperial unit do you want to convert?");
                Console.WriteLine("For IN (Inches) type '1'");
                Console.WriteLine("For FT (Feet) type '2'");
                Console.WriteLine("For YD (Yards) type '3'");
                Console.WriteLine("For MI (Miles) type '4'");
                int answer3 = int.Parse(Console.ReadLine());
                if (answer3 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;
                }
                Console.WriteLine("How many units do you wish to convert?");
                double ammount = double.Parse(Console.ReadLine());
                switch (answer2)
                {
                    case 1:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} MM = {Distance(ammount, 0.0393700787)} IN");
                                break;
                            case 2:
                                Console.WriteLine($"{ammount} MM = {Distance(ammount, 0.00328084)} FT");
                                break;
                            case 3:
                                Console.WriteLine($"{ammount} MM = {Distance(ammount, 0.00109361)} YD");
                                break;
                            case 4:
                                Console.WriteLine($"{ammount} MM = {Distance(ammount, 0.0000006214)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} CM = {Distance(ammount, 0.393700787)} IN");
                                break;
                            case 2:
                                Console.WriteLine($"{ammount} CM = {Distance(ammount, 0.032808399)} FT");
                                break;
                            case 3:
                                Console.WriteLine($"{ammount} CM = {Distance(ammount, 0.010936133)} YD");
                                break;
                            case 4:
                                Console.WriteLine($"{ammount} CM = {Distance(ammount, 0.0000062137)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} M = {Distance(ammount, 39.3700787)} IN");
                                break;
                            case 2:
                                Console.WriteLine($"{ammount} M = {Distance(ammount, 3.2808399)} FT");
                                break;
                            case 3:
                                Console.WriteLine($"{ammount} M = {Distance(ammount, 1.0936133)} YD");
                                break;
                            case 4:
                                Console.WriteLine($"{ammount} M = {Distance(ammount, 0.000621371192)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} KM = {Distance(ammount, 39370.0787)} IN");
                                break;
                            case 2:
                                Console.WriteLine($"{ammount} KM = {Distance(ammount, 3280.8399)} FT");
                                break;
                            case 3:
                                Console.WriteLine($"{ammount} KM = {Distance(ammount, 1093.6133)} YD");
                                break;
                            case 4:
                                Console.WriteLine($"{ammount} KM = {Distance(ammount, 0.621371192)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if(answer == "no")
            {


                Console.WriteLine("What Metric unit do you want to convert?");
                Console.WriteLine("For MM (Milimeters) type '1'");
                Console.WriteLine("For CM (Centimeters) type '2'");
                Console.WriteLine("For M (Meters) type '3'");
                Console.WriteLine("For KM (Kilometers) type '4'");
                int answer2 = int.Parse(Console.ReadLine());
                if (answer2 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;

                }
                Console.WriteLine("To what Metric unit do you want to convert?");
                Console.WriteLine("For MM (Milimeters) type '1'");
                Console.WriteLine("For CM (Centimeters) type '2'");
                Console.WriteLine("For M (Meters) type '3'");
                Console.WriteLine("For KM (Kilometers) type '4'");
                int answer3 = int.Parse(Console.ReadLine());
                if (answer3 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;
                }
                Console.WriteLine("How many units do you wish to convert?");
                double ammount = double.Parse(Console.ReadLine());
                switch (answer2)
                {
                    case 1:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} MM = {Distance(ammount, 0.1)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} MM = {Distance(ammount, 0.001)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} MM = {Distance(ammount, 0.000001)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} CM = {Distance(ammount, 10)} MM");
                                break;
                            case 2:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} CM = {Distance(ammount, 0.01)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} CM = {Distance(ammount, 0.00001)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} M = {Distance(ammount, 1000.0)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} M = {Distance(ammount, 100.0)} CM");
                                break;
                            case 3:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} M = {Distance(ammount, 0.001)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} KM = {Distance(ammount, 1000000.0)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} KM = {Distance(ammount, 100000.0)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} KM = {Distance(ammount, 1000.0)} M");
                                break;
                            case 4:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("You had one job.. to type 'yes' or 'no', nothing more...yet you managed to f**k up even this!");
            }
        }
        static void ImperialDistance()
        {
            Console.WriteLine("Do you want to convert Imperial to Metric?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("What Imperial unit do you want to convert?");
                Console.WriteLine("For IN (Inches) type '1'");
                Console.WriteLine("For FT (Feet) type '2'");
                Console.WriteLine("For YD (Yards) type '3'");
                Console.WriteLine("For MI (Miles) type '4'");
                int answer2 = int.Parse(Console.ReadLine());
                if (answer2 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;

                }
                Console.WriteLine("To what Metric unit do you want to convert?");
                Console.WriteLine("For MM (Milimeters) type '1'");
                Console.WriteLine("For CM (Centimeters) type '2'");
                Console.WriteLine("For M (Meters) type '3'");
                Console.WriteLine("For KM (Kilometers) type '4'");
                int answer3 = int.Parse(Console.ReadLine());
                if (answer3 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;

                }
                Console.WriteLine("How many units do you wish to convert?");
                double ammount = double.Parse(Console.ReadLine());
                switch (answer2)
                {
                    case 1:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 25.4)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 2.54)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 0.0254)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 0.0000254)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 304.8)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 30.48)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 0.3048)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 0.0003048)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 914.4)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 91.44)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 0.9144)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 0.0009144)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 1609344)} MM");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 160934.4)} CM");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 1609.344)} M");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 1.609344)} KM");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else if(answer == "no") 
            {
                Console.WriteLine("What Imperial unit do you want to convert?");
                Console.WriteLine("For IN (Inches) type '1'");
                Console.WriteLine("For FT (Feet) type '2'");
                Console.WriteLine("For YD (Yards) type '3'");
                Console.WriteLine("For MI (Miles) type '4'");
                int answer2 = int.Parse(Console.ReadLine());
                if (answer2 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;

                }
                Console.WriteLine("To what Imperial unit do you want to convert?");
                Console.WriteLine("For IN (Inches) type '1'");
                Console.WriteLine("For FT (Feet) type '2'");
                Console.WriteLine("For YD (Yards) type '3'");
                Console.WriteLine("For MI (Miles) type '4'");
                int answer3 = int.Parse(Console.ReadLine());
                if (answer3 >= 5)
                {
                    Console.WriteLine("You went out of the border!");
                    return;

                }
                Console.WriteLine("How many units do you wish to convert?");
                double ammount = double.Parse(Console.ReadLine());
                switch (answer2)
                {
                    case 1:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 0.0833333333)} FT");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 0.0277777778)} YD");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} IN = {Distance(ammount, 0.0000157828)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 12)} IN");
                                break;
                            case 2:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 0.3333333333)} YD");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} FT = {Distance(ammount, 0.0001893939)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 3:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 36)} IN");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 3)} FT");
                                break;
                            case 3:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            case 4:
                                Console.WriteLine($" {ammount} YD = {Distance(ammount, 0.0005681818)} MI");
                                break;
                            default:
                                break;
                        }
                        break;
                    case 4:
                        switch (answer3)
                        {
                            case 1:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 63360.0)} IN");
                                break;
                            case 2:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 5280.0)} FT");
                                break;
                            case 3:
                                Console.WriteLine($" {ammount} MI = {Distance(ammount, 1760.0)} YD");
                                break;
                            case 4:
                                Console.WriteLine("You cannot convert same units!");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("You had one job.. to type 'yes' or 'no', nothing more...yet you managed to f**k up even this!");
            }
        }
        static void MetricWeight()
        {
            Console.WriteLine("Do you want to convert METRIC to IMPERIAL units");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                MetricToUS();
            }
            else if (answer == "no") 
            {
                MetricToMetric();
            }
            else 
            {
                Console.WriteLine("You had to answer with a simple YES or NO, but you couldn't do even that!");
                return;
            }
        }
        static void MetricToUS()
        {
            Console.WriteLine("Which METRIC unit do you want to use?");
            Console.WriteLine("For grams (g) type '1'");
            Console.WriteLine("For kilograms (kg) type '2'");
            Console.WriteLine("For tons type '3'");
            int choiceMetric = int.Parse(Console.ReadLine());
            if (choiceMetric >= 4)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("To what IMPERIAL unit do you want to convert?");
            Console.WriteLine("For ounces (oz) type '1'");
            Console.WriteLine("For pounds (lb) type '2'");
            int choiceImperial = int.Parse(Console.ReadLine());
            if (choiceImperial >= 3)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("How many units do you want to convert?");
            double ammount = double.Parse(Console.ReadLine());
            switch (choiceMetric)
            {
                case 1:
                    switch(choiceImperial)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} g = {Weight(ammount, 0.035274)} oz");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} g = {Weight(ammount, 0.0022046226)} lb");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (choiceImperial)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} kg = {Weight(ammount, 35.2739619)} oz");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} kg = {Weight(ammount, 2.20462262)} lb");
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (choiceImperial)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} tons = {Weight(ammount, 32000.0)} oz");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} tons = {Weight(ammount, 2000.0)} lb");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        static void MetricToMetric()
        {
            Console.WriteLine("Which METRIC unit do you want to use?");
            Console.WriteLine("For grams (g) type '1'");
            Console.WriteLine("For kilograms (kg) type '2'");
            Console.WriteLine("For tons type '3'");
            int choiceMetric1 = int.Parse(Console.ReadLine());
            if (choiceMetric1 >= 4)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("To what METRIC unit do you want to convert?");
            Console.WriteLine("For grams (g) type '1'");
            Console.WriteLine("For kilograms (kg) type '2'");
            Console.WriteLine("For tons type '3'");
            int choiceMetric2 = int.Parse(Console.ReadLine());
            if (choiceMetric2 >= 4)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("How many units do you want to convert?");
            double ammount = double.Parse(Console.ReadLine());
            switch(choiceMetric1) 
            {
                case 1:
                    switch (choiceMetric2)
                    {
                        case 1:
                            Console.WriteLine("You cannot convert same units!");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} g = {Weight(ammount, 0.001)} kg");
                            break;
                        case 3:
                            Console.WriteLine($" {ammount} g = {Weight(ammount, 0.000001)} tons");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (choiceMetric2)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} kg = {Weight(ammount, 1000.0)} g");
                            break;
                        case 2:
                            Console.WriteLine("You cannot convert same units!");
                            break;
                        case 3:
                            Console.WriteLine($" {ammount} kg = {Weight(ammount, 0.001)} tons");
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    switch (choiceMetric2)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} tons = {Weight(ammount, 100000.0)} g");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} tons = {Weight(ammount, 1000.0)} kg");
                            break;
                        case 3:
                            Console.WriteLine("You cannot convert same units!");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }   
        }
        static void UsToUs()
        {
            Console.WriteLine("Which IMPERIAL unit do you want to use?");
            Console.WriteLine("For ounces (oz) type '1'");
            Console.WriteLine("For pounds (lb) type '2'");
            int choiceImperial1 = int.Parse(Console.ReadLine());
            if (choiceImperial1 >= 3)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("To what IMPERIAL unit do you want to convert?");
            Console.WriteLine("For ounces (oz) type '1'");
            Console.WriteLine("For pounds (lb) type '2'");
            int choiceImperial2 = int.Parse(Console.ReadLine());
            if (choiceImperial2 >= 3)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("How many units do you want to convert?");
            double ammount = double.Parse(Console.ReadLine());
            switch (choiceImperial1)
            {
                case 1:
                    switch (choiceImperial2)
                    {
                        case 1:
                            Console.WriteLine("You cannot convert same units!");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} oz = {Weight(ammount, 0.0625)} lb");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (choiceImperial2)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} lb = {Weight(ammount, 16.0)} oz");
                            break;
                        case 2:
                            Console.WriteLine("You cannot convert same units!");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        static void UsToMetric()
        {
            Console.WriteLine("Which IMPERIAL unit do you want to use?");
            Console.WriteLine("For ounces (oz) type '1'");
            Console.WriteLine("For pounds (lb) type '2'");
            int choiceImperial = int.Parse(Console.ReadLine());
            if (choiceImperial >= 3)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("To what METRIC unit do you want to convert?");
            Console.WriteLine("For grams (g) type '1'");
            Console.WriteLine("For kilograms (kg) type '2'");
            Console.WriteLine("For tons type '3'");
            int choiceMetric = int.Parse(Console.ReadLine());
            if (choiceMetric >= 4)
            {
                Console.WriteLine("You went out of the border!");
                return;

            }
            Console.WriteLine("How many units do you want to convert?");
            double ammount = double.Parse(Console.ReadLine());
            switch (choiceImperial)
            {
                case 1:
                    switch (choiceMetric)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} oz = {Weight(ammount, 28.3495231)} g");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} oz = {Weight(ammount, 0.0283495231)} kg");
                            break;
                        case 3:
                            Console.WriteLine($" {ammount} oz = {Weight(ammount, 0.0000283495)} tons");
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    switch (choiceMetric)
                    {
                        case 1:
                            Console.WriteLine($" {ammount} lb = {Weight(ammount, 453.59237)} g");
                            break;
                        case 2:
                            Console.WriteLine($" {ammount} lb = {Weight(ammount, 0.45359237)} kg");
                            break;
                        case 3:
                            Console.WriteLine($" {ammount} lb = {Weight(ammount, 0.0004535924)} tons");
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        static void UsWeight()
        {
            Console.WriteLine("Do you want to convert IMPERIAL to METRIC units");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                UsToMetric();
            }
            else if (answer == "no")
            {
                UsToUs();
            }
            else
            {
                Console.WriteLine("You had to answer with a simple YES or NO, but you couldn't do even that!");
                return;
            }
        }
        static void ChangeColor()
        {
  
            Console.WriteLine($"Choose between: \n'magenta', 'black' (who hurt you?), \n'red', 'yellow', \n'green', 'cyan', \n'blue', 'dark blue', \ndark cyan'" +
                "'dark red', \n'dark yellow', 'gray' \nor 'dark gray'");
            Console.WriteLine("Or if you want to be as is (you're boring) type 'white'");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "black":
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("Color of background set to WHITE (because the text would be invicible :) )");
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "dark blue":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "dark cyan":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "dark red":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "dark yellow":
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "gray":
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "dark gray":
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case "white":
                    break;
                default:
                    Console.WriteLine("Not a valid color! Color set to WHITE!");
                    break;
            }
            if (answer != "black")
            {
                Console.BackgroundColor = ConsoleColor.Black;
            }
        }
    }
}