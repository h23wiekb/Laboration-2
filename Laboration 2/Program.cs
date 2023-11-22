using System.Data;

namespace Laboration_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variabler för att lagra namn, åldrar och antalet familjemedlemmar.
            string[] names = null;
            int[] ages = null;
            int numberOfFamilyMembers = 0;
            int sumOfAge = 0;
            
            //Huvudloop för programmet
            while (true)
            {
                Console.WriteLine(
                "\nChoose from the menubar below and type in the associated number to access it" +
                "\n" +
                "\n----------------------------------------------------------------------------" +
                "\n1 - Write down name and age of family members." +
                "\n" +
                "\n2 - Let the program write out the family members you added with both their name and age." +
                "\n" +
                "\n3 - Let the program write out the sum of ages of the family members." +
                "\n" +
                "\n4 - Let the program write out the average age of the family members." +
                "\n" +
                "\n5 - Exit the program." + 
                "\n-----------------------------------------------------------------------------" +
                "\n" 
                );
                               
                string choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        //Användaren anger antalet familjemedlemmar och så ser vi till att skapa arrayer för namn och ålder.
                        Console.WriteLine("Enter the amount of familymembers: ");
                        numberOfFamilyMembers = int.Parse(Console.ReadLine());
                        names = new string[numberOfFamilyMembers];
                        ages = new int[numberOfFamilyMembers]; 

                        // Mata in namn och ålder för varje medlem
                        for (int i = 0; i < numberOfFamilyMembers; i++)
                        {
                            Console.WriteLine($"Please enter name for member {i + 1}: ");
                            names[i] = Console.ReadLine();

                            Console.WriteLine($"Please enter age for member {i + 1}: ");
                            ages[i] = int.Parse(Console.ReadLine());
                        }
                        break;

                    case "2":
                             // Skriv ut alla familjemedlemmar om det finns några annars skriver vi ut att det inte finns några.    
                             if (numberOfFamilyMembers == 0)
                             {
                                 Console.WriteLine("\nNo familymembers added yet.");
                             }
                             else
                             {
                                 Console.WriteLine("\nAll familymembers: ");
                                 for (int i = 0; i < numberOfFamilyMembers;i++)
                                 {
                                     Console.WriteLine($"\nName: {names[i]} Ålder: {ages[i]}");
                                 }
                             }
                        break;

                    case "3":
                        // Beräkna och skriv ut summan av åldrarna eller så skriver vi ut att det inte finns några tillagda än. 
                        if (numberOfFamilyMembers == 0)
                        {
                            Console.WriteLine("No familymembers has been added yet.");
                        }
                        else
                        {
                            for (int i = 0; i < numberOfFamilyMembers; i++)
                            {
                                sumOfAge += ages[i];
                            }
                        }
                        Console.WriteLine($"\nThe sum of the familymembers age is: {sumOfAge}");
                        break;
                   
                    case "4":
                        // Beräkna och skriv ut medelåldern med två decimaler eller så skriver vi att det inte finns några tillagda medlemmar än. 
                        if (numberOfFamilyMembers == 0) 
                        {
                            Console.WriteLine("\nNo familymembers has been added yet.");
                        }
                        else
                        {
                            double averageAge = sumOfAge / numberOfFamilyMembers;
                            Console.WriteLine(averageAge.ToString("The middle age of the familymembers is: ##.00"));
                        }
                        break;
                    
                    case "5":
                        // Avslutar programmet om användaren väljer det
                        Console.WriteLine("\nPress anywhere to exit the program.");
                        return;

                    default:
                        // Meddela användaren om ogiltig input/val
                        Console.WriteLine("\nInvalid input, please try again.");
                        break;
                     

                  }

                }
            }
        }
    }