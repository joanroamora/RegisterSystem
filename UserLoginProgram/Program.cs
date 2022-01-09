using System;

namespace UserLoginProgram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] users = new string[10] { "Lina Maria", "", "", "", "", "", "", "", "", "" };
            int currentIndex = 1;
            int startVar;
            Console.WriteLine("Welcome to our authentication software for Windows. \n \n");
            while (true)
            {          

                if (currentIndex < 9)
                {
                    Console.WriteLine("Please select one of the next options : \n" + "- For Log in please press one, then enter. \n" + "- For register process please press two, then enter. \n");
                    startVar = Convert.ToInt32(Console.ReadLine());

                    if (startVar == 1)
                    {
                        string yourUser = "";
                        Console.WriteLine("Please write your user and before press enter.   \n");
                        yourUser = Console.ReadLine();

                        for (int i = 0; i < users.Length; i++)
                        {
                            bool a = Array.Exists(users, element => element == yourUser);
                            if (a == true)
                            {
                                Console.WriteLine("You´re in. Welcome. FUNCIONAAA!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("User not found, please restart the program. ");
                                Console.WriteLine(users[i]);
                            }
                        }

                    }



                    else if (startVar == 2)
                    {
                        Console.WriteLine("Please write your exact username, then press enter key : \n");
                        users[currentIndex] = Console.ReadLine();
                        Console.WriteLine($"The user has been created in the slot : {currentIndex} and the username created is {users[currentIndex]}");
                        currentIndex++;
                    }
                }

                else {
                    Console.WriteLine("Reservations are Over for 2022. Thanks a lot.");
                }
                }
        }
    }
}

