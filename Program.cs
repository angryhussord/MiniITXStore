using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Xsl;

namespace MiniITXStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MiniITX Part Store!");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Create a new part");
                Console.WriteLine("2. Change an existing part");
                Console.WriteLine("3. Delete a part");
                Console.WriteLine("4. Add a part to the cart");
                Console.WriteLine("5. Remove a part from the cart");
                Console.WriteLine("6. Print all parts");

                Console.Write("Select an option: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("Thank you for visiting the Mini ITX Parts Store!");
                        return;
                    case "1":
                        Console.WriteLine("Create a new part:");
                        Console.WriteLine("What's the part name?");
                        var partName = Console.ReadLine();
                        Console.WriteLine("Description:");
                        var partDescription = Console.ReadLine();

                        //list enumerators and then convert user input to an int to correspond to the enum value they chose
                        Console.WriteLine("Select a part type:");
                        var partTypes = Enum.GetNames(typeof(PartTypes));
                        for(int i = 0; i < partTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}. {partTypes[i]}");
                        }
                        var partType = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What's the part price?");
                        decimal partPrice = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("What's the part cost?");
                        decimal partCost = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("What's the part manufacturer?");
                        string partManufacturer = Console.ReadLine();
                        Console.WriteLine("What's the part length (in mm)?");
                        decimal partLength = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("What's the part width (in mm)?");
                        decimal partWidth = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("What's the part height (in mm)?");
                        decimal partHeight = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("What's the part weight (in kg)?");
                        decimal partWeight = Convert.ToDecimal(Console.ReadLine());
                        Store.CreatePart(partName, partDescription, (PartTypes)partType, partPrice, partCost, partManufacturer, partLength, partWidth, partHeight, partWeight);
                        break;
                    case "2":
                        Console.WriteLine("Change an existing part:");
                        Console.WriteLine("What's the part name?");
                        partName = Console.ReadLine();
                        var myParts = Store.GetAllPartsByName(partName);
                        int numPartsFound = ((ICollection<Part>)myParts).Count;
                        switch(numPartsFound)
                        {
                            case "0":
                                //didn't find any parts with that name, try again
                                Console.WriteLine($"We found zero that match that query. Please try a different query term.");
                                break;
                            case "1":
                                // found only a single part, continue to the editing of it
                                
                                break;
                            default:
                                //we found 2 or more parts, try again
                                Console.WriteLine($"We found {numPartsFound} that match that query. Please try a more specific query.");
                                break;
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        Console.Write("Search for a part (by name):");
                        partName = Console.ReadLine();
                        Console.WriteLine($"Looking for part named: {partName}");
                        myParts = Store.GetAllPartsByName(partName);
                        foreach (Part myPart in myParts)
                        {
                            Console.WriteLine($"-----------");
                            Console.WriteLine($"Part ID: {myPart.PartID}");
                            Console.WriteLine($"Part Creation Date: {myPart.CreatedDate}");
                            Console.WriteLine($"Part Name: {myPart.Name}");
                            Console.WriteLine($"Part Description: {myPart.Description}");
                            Console.WriteLine($"Part Manufacturer: {myPart.Manufacturer}");
                            Console.WriteLine($"Part Type: {myPart.PartType}");
                            Console.WriteLine($"Part Price: {myPart.Price}");
                            Console.WriteLine($"Part Cost: {myPart.Cost}");
                            Console.WriteLine($"Part Length: {myPart.Length}");
                            Console.WriteLine($"Part Width: {myPart.Width}");
                            Console.WriteLine($"Part Height: {myPart.Height}");
                            Console.WriteLine($"Part Weight: {myPart.Weight}");
                            Console.WriteLine($"-----------");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
