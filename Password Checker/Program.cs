using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLenght = 4;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "1234567890";
            string specialChar = "!@#$%^&*()_-{}{}|.?;:<>/";
            int score = 0;

            Console.WriteLine("Please enter your passwrd to determine it's strenght:");
            string password = Console.ReadLine();
            Console.WriteLine($"You entered the password: {password}");

            if(password.Length >= minLenght)
            {
                
                ++score;
                Console.WriteLine($"Nice job on lenght. You get a point. Your score is {score}");
            }

            if (Tools.Contains(password, uppercase))
            {
                ++score;
                Console.WriteLine($"Nice job on UPPERCASE. You get a point. Your score is {score}");

            }

            if (Tools.Contains(password, lowercase))
            {
                Console.WriteLine($"Nice job on lowercase. You get a point. Your score is {score}");

            }

            switch (score)
            {
                case 5:

                    Console.WriteLine("Wow, your password is sooo strong");
                    break;


                case 4:

                    Console.WriteLine("Wow, your password is sooo strong");
                    break;


                case 3:

                    Console.WriteLine("Nice, your password is strong.");
                    break;


                case 2:

                    Console.WriteLine("Eh, your password is medium");
                    break;


                case 1:
                    Console.WriteLine("Oof, your password is weak!");
                    break;

                default:
                    Console.WriteLine("Sorry, your password doesn't meet any of our requirments!");
                    break;
            }
                
            }

        }
    }

