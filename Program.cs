using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoP_Assignment_BORDAS_Alexandre
{
    class Program
    {
        static void Main(string[] args)
        {
            // ALL THE INFO NEEDED FOR A STUDENT
            bool check = true;
            string fName = "";
            string lName = "";
            string number = "";
            int age = 0;
            int addressNumber = 0;
            string street = "";
            string city = "";
            string country = "";

            
            SetupMsg();

            //ASKING ABOUT A STUDENT INFO

            //FIRST NAME
            while (check)
            {               
                Console.Write("(string) First name : ");
                string input = Console.ReadLine();

                if (input.All(Char.IsLetter) == false || input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    fName = input;
                    check = false;
                }
            }
            check = true;

            //LAST NAME
            while (check)
            {
                Console.Write("(string) Last name : ");
                string input = Console.ReadLine();

                if (input.All(Char.IsLetter) == false || input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    lName = input;
                    check = false;
                }
            }
            check = true;

            //STUDENT NUMBER
            while (check)
            {
                Console.Write("\n(string) Student number : ");
                string input = Console.ReadLine();

                if (input.All(Char.IsDigit) == false || input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    number = input;
                    check = false;
                }
            }
            check = true;

            //AGE
            while (check)
            {
                Console.Write("\n(string) Age : ");
                string input = Console.ReadLine();

                if (input.All(Char.IsDigit) == false || input == null || Convert.ToInt32(input) <= 0)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    age = Convert.ToInt32(input);
                    check = false;
                }
            }
            check = true;

            //ADDRESS NUMBER
            while (check)
            {
                Console.Write("\n(string) Address number : ");
                string input = Console.ReadLine();

                if (input.All(Char.IsDigit) == false || input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                }
                else
                {
                    addressNumber = Convert.ToInt32(input);
                    check = false;
                }
            }
            check = true;

            //STREET
            while (check)
            {
                Console.Write("(string) Street : ");
                string input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    street = input;
                    check = false;
                }
            }
            check = true;

            //CITY
            while (check)
            {
                Console.Write("(string) City : ");
                string input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    city = input;
                    check = false;
                }
            }
            check = true;

            //COUNTRY
            while (check)
            {
                Console.Write("(string) Country : ");
                string input = Console.ReadLine();

                if (input == null)
                {
                    Console.WriteLine("ERROR : please respect the conditions");
                    Console.ReadKey();
                }
                else
                {
                    country = input;
                    check = false;
                }
            }
            check = true;

            //CREATING A STUDENT WITH ALL THE INFO GATHERED
            Address address = new Address(addressNumber, street, city, country);
            Student student = new Student(fName, lName, number, age, address);

            Console.WriteLine("Student succesfully created !");

            System.Threading.Thread.Sleep(2000);


            //ASKING WHAT THE USER WANT TO DO NOW
            Console.WriteLine();

            int valueInt = 0;

            bool asking = true;

            while (asking)
            {
                while (check)
                {
                    Console.Clear();
                    Console.WriteLine("# - Principles Of Programming : Assignment / BORDAS Alexandre - #");
                    Console.WriteLine("#################################################################");
                    Console.WriteLine();
                    Console.WriteLine("OPTIONS (please enter the desired number) :");
                    Console.WriteLine("1 - Add grades");
                    Console.WriteLine("2 - Calculate average");
                    Console.WriteLine("3 - Info about student");
                    Console.Write("=> ");
                    string value = Console.ReadLine();
                    if (value.All(Char.IsDigit) == false || value == null || value == "")
                    {
                        Console.WriteLine("ERROR : please respect the conditions");
                        Console.ReadKey();
                    }
                    else
                    {
                        valueInt = Convert.ToInt32(value);
                        check = false;
                    }
                }
                check = true;

                switch (valueInt)
                {
                    case 1:
                        {
                            Console.WriteLine("Please enter the grade you want to add to " + student.firstName + " " + student.lastName);
                            string n = Console.ReadLine();

                            if (n.All(Char.IsDigit) == false || n == null || Convert.ToInt32(n) <= 0 || Convert.ToInt32(n) > 100)
                            {
                                Console.WriteLine("ERROR : please respect the conditions");
                                Console.ReadKey();
                            }
                            else
                            {
                                student.AddMark(Convert.ToInt32(n));
                                Console.WriteLine("Grade succesfully added");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 2:
                        {
                            //student.AverageMark();
                            Console.WriteLine("Average of " + student.firstName + " " + student.lastName + " : " + student.Average);
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("INFO ABOUT THE STUDENT :");
                            Console.WriteLine("Full name = " + student.firstName + " " + student.lastName);
                            Console.WriteLine("Student number = " + student.Number);
                            Console.WriteLine("Age = " + student.Age);
                            Console.WriteLine("Address = " + student.AddressToString());
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR : value must be a number between 1 and 3");
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }
        static void SetupMsg()
        {
            Console.Clear();
            Console.WriteLine("# - Principles Of Programming : Assignment / BORDAS Alexandre - #");
            Console.WriteLine("#################################################################");
            Console.WriteLine();
            Console.WriteLine("Please, enter information about a Student :");
            Console.WriteLine("-------------------------------------------");
        }
    }
}
