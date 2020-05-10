using System;

namespace csharp_ass_due11may2020
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            

            CreateFile;
            GetString;

        }

        public static void CreateFile(){
        // get and store the file name specified by the user

        string userFile;
            Console.WriteLine("Enter a filename:");
            userFile = Console.ReadLine();
            Console.WriteLine("Your file is: " + userFile);
        
        return userFile;
        }

        // 
         public static void GetString(){
            string userString;
            Console.WriteLine("Now, enter a string and I will parse it with spaces");
            userString = Console.ReadLine();

            return userString;
         }
        }

    }