using System;
using System.ComponentModel;
using System.Net.WebSockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Transactions;

namespace csharpnotes
{

    class TestWithoutStatic
    {
        public void something()
        {
            Console.WriteLine("something");
        }
    }
    class Program
    {

        struct Person
        {
            public string name;
            public int age;
            public int birthMonth;

            public Person(string name, int age, int birthMonth)
            {
                this.name = name;
                this.age = age;
                this.birthMonth = birthMonth;
            }
        }
        static void Main(string[] args)
        {

            // ---------------------------------------------------------- basics

            Console.WriteLine("hello world!");


            int age = 22;
            int x;
            x = 23;
            x = 24;

            Console.WriteLine(age);

            /*double negative = -5.2D;
            float precision = 5.000001F;
            decimal money = 14.99M;
            long bigNumber = 111100000L;
            */
            //int a;
            //int b;
            //int c;
            int a, b, c;
            // int a = 10 , 
            //     b = 20 , 
            //     c = 30 ; 
            string name1 = "uygar";
            char letter = 'A';
            Console.Write("your name is :");
            Console.Write(name1);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MinValue);
            string textAge = "23";   // if its "23h" we get error 
            age = Convert.ToInt32(textAge);
            bool value = true;

            age++;
            age = age + 1;
            age += 1;
            // +  -  *  /  %
            string namef = "baba";
            namef += "is here";

            var something = "something";

            const int vat = 20;  // we can not change value of vat , bc of constant 

            // ---------------------------------------------------------- Console.Readline()

            Console.WriteLine("enter your name");
            string name2 = Console.ReadLine();

            Console.WriteLine("enter your age : ");
            string ageInput = Console.ReadLine();
            int age1 = Convert.ToInt32(ageInput);

            Console.WriteLine();
            Console.WriteLine("your name is :" + name2 + "and your age is : " + ageInput);

            // ----------------------------------------------------------  If statements 
            // !=  ==  > >= ||  &&

            Console.Write("enter the first number");
            string numberAInput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAInput);

            Console.Write("enter the second number");
            string numberBInput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberBInput);

            int answer = numberA * numberB;

            Console.WriteLine("value of " + numberA + "x" + numberB + ":");
            string answerInput = Console.ReadLine();
            int actualAnswer = Convert.ToInt32(answerInput);

            if (actualAnswer == answer)
            {
                Console.WriteLine("well done!");
            }
            else
            {
                Console.WriteLine("close but its wrong!");
            }




            // ---------------------------------------------------------- switch case 

            Console.WriteLine("enter day of the week");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("mon");
                    break;
                case 2:
                    Console.WriteLine("tue");
                    break;
                case 3:
                    Console.WriteLine("wed");
                    break;
                case 4:
                    Console.WriteLine("thu");
                    break;
                default:
                    Console.WriteLine("invalid, pls enter a value between 1 and 7");
                    break;

            }




            // ---------------------------------------------------------- for loop


            Console.Write("what do you want to repeat ? : ");
            string message = Console.ReadLine();

            Console.Write("and how many times do you want to repeat it?:");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("sorry, please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }

            }



            // ---------------------------------------------------------- while loops

            int abc = 0;

            while (abc < 10) // condition
            {
                Console.WriteLine(abc);
                abc++;
            }

            // ---------------------------------------------------------- conditional operator



            int age3 = -10;

            // condition ? true : false

            string result = age >= 0 ? "valid" : "invalid";
            Console.WriteLine(result);


            // ---------------------------------------------------------- numeric formatting


            // ---------------------------------------------------------- tryParse function

            Console.WriteLine("enter a number:");
            string numInput = Console.ReadLine(); //10h
            int num = 0;

            bool success = int.TryParse(numInput, out num); //false

            if (success)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine("failed to convert!");
            }

            // ---------------------------------------------------------- times table exercises

            Console.WriteLine("enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }


            // ---------------------------------------------------------- verbatim string literal 


            // \t \n \" \\ = \
            string speech = "he said \"something\"";
            string path = "C:\\Users\\CoffeeNCode\\Desktop\\C# course\nNew line test";
            Console.WriteLine(path);
            Console.WriteLine(speech);

            //$ + 
            //$"your name is {name}"
            //"your name is " + name

            // .... 

            // ---------------------------------------------------------- string formatting 

            Console.WriteLine("your name is " + name1 + ", and your age is : " + age);
            Console.WriteLine("Name: " + name1 + "\nAge: " + age);
            Console.WriteLine("your name is {0}\nAge:{1}", name1, age);
            Console.WriteLine("Name:{0}\nAge:{1}", name1, age);
            Console.WriteLine($"your name is {name1} and your age is {age}");

            // ---------------------------------------------------------- string concatenation

            string test = string.Concat("your name is", name1, " and your age is", age);

            // ---------------------------------------------------------- empty string 

            // string name = "";    string name = string.Empty;    these are same

            string name;

            // ---------------------------------------------------------- string equals function
            message = "C# is awesome ";
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(1000); // 1000ms = 1sec
            }


            // ---------------------------------------------------------- string isNullOrEmpty function

            if (!string.IsNullOrEmpty(name1)) // null , ""
            {
                if (name1 == "uygar")
                {
                    Console.WriteLine("correct");
                }
            }


            // ----------------------------------------------------------  arrays 

            //int num1 = 10;
            //int num2 = 15;
            //int num3 = 20;
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("enter a number:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
            }

            /*  foreach (int num in numbers)
                {
                    Console.WriteLine(num);
                }           */

            // another ex array 

            const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"enter angle {i + 1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }
            int angleSum = 0;

            foreach (int angle1 in angles)
            {
                angleSum += angle1;
            }

            Console.WriteLine(angleSum == 180 ? "valid" : "invalid!");


            // ---------------------------------------------------------- array sorting 


            int[] numbersSorted = new int[] {
                6,7,9,2,1,2,8
            };
            Array.Sort(numbersSorted);
            foreach (int numSorted in numbersSorted)
            {
                Console.WriteLine(numSorted);
            }


            // ---------------------------------------------------------- array reversal 

            int[] numbers3 = new int[]
            {
                0,1,2,3,4,5
            };

            int[] sortedNumbers = new int[numbers3.Length];

            x = 0;

            for (int i = numbers3.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = numbers3[i];
                x++;
            }
            foreach (var num3 in sortedNumbers)
            {
                Console.WriteLine($"{num3}");
            }

            // or 

            Array.Reverse(numbers3);

            // ---------------------------------------------------------- array clearing 

            int[] numbers4 = new int[]
            {
                0,1,2,3,4,5,6,7,8,9,10
            };

            //Array.Clear(numbers4, 0, numbers4.Length);
            //Array.Clear(numbers4, 5,5);

            for (int i = 5; i < 10; i++) // 5 6 7 8 9
            {
                numbers4[i] = default; //or 0;
            }

            foreach (int num4 in numbers4)
            {
                Console.WriteLine($"{num4}");
            }

            // ---------------------------------------------------------- array indexOf

            int[] numbers5 = new int[]{
                90,199,22,50,33
            };

            Console.WriteLine("enter number to search : ");
            int search = Convert.ToInt32(Console.ReadLine());
            int position = Array.IndexOf(numbers5, search);

            if (position < -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"number{search} has not been found");
            }

            // or 

            /*int position = -1;
            for (int i = 0; i < numbers5.Length; i++){
            if(numbers5[i] == search){
                    position = i;
                }
            }
            if (position > -1)  //0 ->
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else{
                Console.WriteLine($"Number {search} has not been found ");
            }

            */

            // ---------------------------------------------------------- lists


            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("enter a number : ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            listNumbers.Remove(0);

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }

            // ---------------------------------------------------------- dictionary 

            /*Dictionary<int, string> names = new Dictionary<int, string>
            {
                // key value pair
                { 1, "uygar" },
                { 2, "muntas" },
                { 3 , "code"}
            };

            for (int i = 0; i < names.Count; i++)
            {
                //Console.WriteLine(names[i]); it gives an error 
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} {pair.Value}");
            }

            foreach (KeyValuePair<int, string> item in names)
            {
                Console.WriteLine($"{item.Key} {item.Value} ");
            }/*

            /* another ex */


            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "Uygar"},
                {"History", "Emir"}
            };
            Console.WriteLine(teachers["Math"]); // returns "uygar"
            Console.WriteLine(teachers["MATH"]); // returns error 


            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);  // output : Uygar
                teachers["Math"] = "joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach (var item in teachers)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
                // Math Joe
                // History Emir

            }


            // ---------------------------------------------------------- functions

            WelcomeMessage();

            TestWithoutStatic test1 = new TestWithoutStatic(); // you should declare like that bc of this class without static
            test1.something(); // if its static we can write just that one 


            // ---------------------------------------------------------- void functions

            // if its void , you dont need to return anything


            // ---------------------------------------------------------- return type functions

            Console.Title = $"{ReturnName()} - {ReturnAge()}";
            PrintIntroduction();

            // ---------------------------------------------------------- function parameters 

            int numP = ReadInt("enter a number");
            Console.WriteLine(numP);

            int angle = ReadInt("Angle ");
            Console.WriteLine(angle);

            int firstNum = ReadInt("enter the first number");
            int secondNum = ReadInt("enter the second number");
            int resultP = Add(firstNum, secondNum);

            Console.WriteLine(resultP);


            // ---------------------------------------------------------- optional parameters 

            //static int Add(int a,[Optional] int b) // it might be also int b = default , int b = 0;
            //{
            //  return a + b;
            //}


            //static int Add(int a,int b = 5) // it might be also int b = default , int b = 0;
            //{
            //  return a + b;
            //}
            //Add(5, 10); if you dont write b parameter it will be 5


            // ---------------------------------------------------------- named parameters

            string nameInputP = "uygar";
            int ageInputP = 23;
            string addressInputP = "1 something road";

            PrintDetails(address: addressInputP,
            age: ageInputP, name: nameInputP);

            // ---------------------------------------------------------- out parameters

            // the parameter's value is determined within the function itself

            /*static void GetAge(out int age)
            {
                age = 42;
            }

            static void Main()
            {
                int a;
                GetAge(out a);
                Console.WriteLine(a);
            } */

            // ---------------------------------------------------------- reference parameters

            // --- ref allows us to change the value of the parameter within the function

            // ---------------------------------------------------------- exception handling

            Console.WriteLine("enter a number");
            int numtc = Convert.ToInt32(Console.ReadLine()); // if we enter for ex: {} or smthng we get an error

            // ---------------------------------------------------------- try catch and printing error message

            bool looping = true;

            while (looping)
            {
                try
                {
                    Console.WriteLine("enter a number");
                    int numw = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numw);

                    looping = false;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("please only a number less than 2 billion");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("please only enter numbers!");
                    Console.WriteLine($"error : {e.Message}"); // error messages
                }
                catch (Exception e)
                {
                    Console.WriteLine("something has went wrong");
                    Console.WriteLine($"error : {e.Message}");
                }

            }

            // ---------------------------------------------------------- debugging

            // debugging system

            // ---------------------------------------------------------- local/auto window

            // ---------------------------------------------------------- structure and constructor

            // you can not declare different data type in one array ,
            // 

            Person person = ReturnPerson();
            Console.WriteLine($" {person.name} - {person.age} {person.birthMonth}");

            // ---------------------------------------------------------- classes




            // ---------------------------------------------------------- end 

            Console.ReadLine(); // when we press enter, program closes



        }
        static void WelcomeMessage()
        {
            Console.WriteLine("welcome message");
        }
        static string ReturnName()
        {
            return "aba";
        }
        static int ReturnAge()
        {
            return 23;
        }
        static void PrintIntroduction()
        {
            Console.WriteLine($"hello my name is {ReturnName()} and my age is {ReturnAge()}");
        }
        static string ReadString(string message)
        {
            Console.WriteLine($"{message}: ");
            return Console.ReadLine();
        }
        static int ReadInt(string message)
        {
            Console.WriteLine($"{message}");
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine($"name : {name}");
            Console.WriteLine($"age : {age}");
            Console.WriteLine($"address : {address}");
        }
        static Person ReturnPerson()
        {
            Console.WriteLine("enter your name : ");
            string namest = Console.ReadLine();

            Console.WriteLine("enter your age : ");
            int agest = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter you birthmonth : ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            /*Person person;

            person.name = namest;
            person.age = agest;
            person.birthMonth = birthMonth;*/

            return new Person(namest, agest, birthMonth);
        }
    }
}
