using System;
using System.Linq;

namespace DataStructure_Assignment1_BORDASAlexandre
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDataList studentList = new CustomDataList();

            bool running = true;

            while(running)
            {
                Console.Clear();
                Console.WriteLine("Please, chose an option :");
                Console.WriteLine("1 - PopulateWithSampleData");
                Console.WriteLine("2 - Add(element)");
                Console.WriteLine("3 - GetElement(index)");
                Console.WriteLine("4 - RemoveByIndex(index)");
                Console.WriteLine("5 - RemoveFirst");
                Console.WriteLine("6 - RemoveLast");
                Console.WriteLine("7 - DisplayList");
                Console.WriteLine("8 - EXIT");
                Console.WriteLine();

                string value = Console.ReadLine();
                Console.WriteLine();

                if (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) <= 0 )
                {
                    Console.WriteLine("ERROR : please enter a valid number");
                }
                else
                {
                    int input = Convert.ToInt32(value);
                    switch(input)
                    {
                        case 1:
                            {
                                studentList.PopulateWithSampleData();
                                break;
                            }
                        case 2:
                            {
                                bool check2 = true;
                                string fName;
                                string lName;
                                string studentNumber;
                                float avg;

                                while(check2)
                                {
                                    Console.Write(" Add / First name : ");
                                    value = Console.ReadLine();

                                    if (value.All(Char.IsLetter) == false || value == null || value == "")
                                    {
                                        Console.WriteLine("ERROR : please enter a valid first name");
                                    }
                                    else
                                    {
                                        fName = value;
                                        Console.Write(" Add / Last name : ");
                                        value = Console.ReadLine();

                                        if (value.All(Char.IsLetter) == false || value == null || value == "")
                                        {
                                            Console.WriteLine("ERROR : please enter a valid last name");
                                        }
                                        else
                                        {
                                            lName = value;
                                            Console.Write(" Add / Student number : ");
                                            value = Console.ReadLine();

                                            if (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) <= 0)
                                            {
                                                Console.WriteLine("ERROR : please enter a valid student number");
                                            }
                                            else
                                            {
                                                studentNumber = value;
                                                Console.Write(" Add / Student average score : ");
                                                value = Console.ReadLine();
                                                if (value.All(Char.IsDigit) == false || value == null || value == "" || Convert.ToInt32(value) < 0 || Convert.ToInt32(value) >100)
                                                {
                                                    Console.WriteLine("ERROR : please enter a valid average score");
                                                }
                                                else
                                                {                                                    
                                                    avg = (float) Convert.ToDouble(value);

                                                    Student temp = new Student(fName, lName, studentNumber, avg);
                                                    studentList.Add(temp);
                                                    Console.WriteLine("Student successfully added !");
                                                    check2 = false;
                                                }
                                            }
                                        }
                                    }
                                }
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("GetElement / Please enter an index");

                                value = Console.ReadLine();

                                if (value.All(Char.IsDigit) == false || value == null || value == "")
                                {
                                    Console.WriteLine("ERROR : Please enter a valid index");
                                }
                                else
                                {
                                    int n = Convert.ToInt32(value);

                                    if(n < 0 || n >= studentList.Count())
                                    {
                                        Console.WriteLine("ERROR : Please enter a valid index");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Student #" + (n+1) + " : " + studentList.List[n].FirstName + " " + studentList.List[n].LastName + " - " + studentList.List[n].StudentNumber + ", Average score of " + studentList.List[n].AverageScore);
                                    }
                                }
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("RemoveByIndex / Please enter an index");

                                value = Console.ReadLine();

                                if (value.All(Char.IsDigit) == false || value == null || value == "")
                                {
                                    Console.WriteLine("ERROR : Please enter a valid index");
                                }
                                else
                                {
                                    int n = Convert.ToInt32(value);

                                    if (n < 0 || n >= studentList.Count())
                                    {
                                        Console.WriteLine("ERROR : Please enter a valid index");
                                    }
                                    else
                                    {
                                        studentList.List.RemoveAt(n);
                                        Console.WriteLine("Student successfully removed !");
                                    }
                                }
                                break;
                            }
                        case 5:
                            {
                                if(studentList.List.Count == 0 || studentList == null)
                                {
                                    Console.WriteLine("ERROR : list is empty !");
                                }
                                else
                                {
                                    studentList.RemoveFirst();
                                    Console.WriteLine("Student successfully removed ! ");
                                }
                                break;
                            }
                        case 6:
                            {
                                if (studentList.List.Count == 0 || studentList == null)
                                {
                                    Console.WriteLine("ERROR : list is empty !");
                                }
                                else
                                {
                                    studentList.RemoveLast();
                                    Console.WriteLine("Student successfully removed ! ");
                                }
                                break;
                            }
                        case 7:
                            {
                                studentList.DisplayList();
                                break;
                            }
                        case 8:
                            {
                                running = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("ERROR : please enter a valid option !");
                                break;
                            }
                    }
                    Console.ReadKey();
                }

            }
        }
    }
}
