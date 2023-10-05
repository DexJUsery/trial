using System;
using System.Linq.Expressions;
class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Welcome to the Journal Program!");
        Entry myJournal = new Entry();
        List<string> notSavedList = new List<string>();
        var randomListLocal = Prompt.randomList;
        bool exitProgram = false;
        while(!exitProgram)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string Option = Console.ReadLine();


            switch (Option)
            {


                case "1":
                    Random random = new Random();
                    int num = random.Next(0, 6);
                    Entry entry1 = new Entry();
                    entry1._prompt = randomListLocal[num];
                    Console.WriteLine(entry1._prompt);
                    Console.Write("Enter your response: ");
                    string userResponse = Console.ReadLine();
                    entry1._response = char.ToUpper(userResponse[0]) + userResponse.Substring(1);
                    myJournal._entry.Add(entry1);
                    break;


                case "2":
                    foreach (string item in notSavedList)
                    {
                        Console.WriteLine(item);
                    }
                    myJournal.Display();
                    break;


                case "3":
                    string loadToFile;
                    Console.Write("What is the file's name?");
                    loadToFile = Console.ReadLine();
                    string filename = loadToFile;
                    string[] lines = System.IO.File.ReadAllLines(filename);
                    foreach (string line in lines)
                    {
                            Console.WriteLine(line);
                            notSavedList.Add(line);                            
                    }
                    Console.WriteLine("File loaded.");
                    break;


                case "4":
                    Console.Write("What is the file's name?");
                    string saveToFile = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(saveToFile))
                    {                   
                        foreach (Entry entry in myJournal._entry)
                        {
                        outputFile.WriteLine($"Date: {DateTime.Now.ToString("dd-MM-yyyy")} - Prompt: "+entry._prompt);
                        outputFile.WriteLine($"{entry._response}");          
                        }                      
                    };
                    break;
                

                case "5":
                    exitProgram = true;
                    break;


                default:
                    Console.WriteLine("Invalid option. Choose a valid option.");
                    break;
            }
        } 
    }
}