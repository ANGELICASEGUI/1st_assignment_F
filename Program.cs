using System;
using System.ComponentModel.Design;
using System.Net.Security;
namespace _1st_assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                string username = "ADMIN";
                string password = "ADMIN1234";
                int attempts = 3;

                while (attempts > 0)
                {
                    Console.Write("Username: ");
                    string a = Console.ReadLine();
                    Console.Write("Password: ");
                    string b = Console.ReadLine();

                    if (a == username && b == password)
                    {
                        attempts--;
                        Console.WriteLine("Login successful"); break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect identification");
                        attempts --;
                    }   

                    }
                    if (attempts == 0) 
                    {
                        Console.WriteLine( "failed logging in! try again later");
                        
                        
                    }
                
                



















                {




                }






            }



        }
    }
}

        