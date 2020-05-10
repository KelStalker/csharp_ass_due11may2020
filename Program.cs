using System;
using System.Linq; //To use Linq methods on our arrays
using System.IO; //To read from files

namespace csharp_ass_due11may2020
{
    class Program
    {
        static void Main()
        {

            // Option 1 will prompt the user to enter a filename. The filename will be stored in a local variable.
            string userFileName = "";
            string userChoice = "0";

            while (userChoice != "3")
            {
                Console.WriteLine("Choice 1: Enter the filename (hardcoded file is called userFile.txt");
                Console.WriteLine("Choice 2: enter a string to replace with a blank (in this case, the word is SNOT");
                Console.WriteLine("Choice 3: End Program");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("This is choice 1");
                        Console.WriteLine("Enter a filename:");
                        userFileName = Console.ReadLine();
                    // check if userfile exists
                        if (File.Exists(userFileName)){
                            Console.WriteLine(File.Exists(userFileName)); //Returns true or false on if our file exists
                        } else {
                            Console.WriteLine("File does not exist");
                        }
                        break;
                    
                    case "2":

                    string readUserFileText;

                        Console.WriteLine("This is choice 2");
                        // check if userfile exists
                        if (File.Exists(userFileName)){
                            Console.WriteLine(File.Exists(userFileName));
                            //Returns true or false on if our file exists
                            
                            readUserFileText = File.ReadAllText(userFileName);
                            Console.WriteLine(readUserFileText);

                            Console.WriteLine("")

                        } else {
                            Console.WriteLine("File does not exist");
                        }
                        break;

                    case "3":
                        Console.WriteLine("This is choice 3");
                        break;

                    default:
                        Console.WriteLine("You have entered an incompatible choice, please choose 1,2 or 3");
                        break;

                }
            }
        }
    }
}