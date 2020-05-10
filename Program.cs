using System;

namespace csharp_ass_due11may2020
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userFile;
            string userString;

            CreateFile;
            GetString;

        }

        public static void CreateFile(string fileName){
        // get and store the file name specified by the user
            Console.WriteLine("Enter a filename:");
            userFile = Console.ReadLine();
            Console.WriteLine("Your file is: " + userFile);
        
    return fileName;
        }
        // 
         public static void GetString(fileName){
            Console.WriteLine("Now, enter a string and I will parse it with spaces");
            userString = Console.ReadLine();
         }
        }

    }
}
