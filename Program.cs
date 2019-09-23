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
                Console.WriteLine("2. Delete a part");
                Console.WriteLine("3. Add a part to the cart");
                Console.WriteLine("4. Remove a part from the cart");
                Console.WriteLine("5. Display Cart and Total");
                Console.WriteLine("6. Print all parts");

                Console.Write("Select an option: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0": //exit
                        Console.WriteLine("Thank you for visiting the Mini ITX Parts Store!");
                        return;
                    case "1": //create a part
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
                    case "2: //delete a part
                        //ask for a name
                        //find the part
                        //if it's the only one returned, delete it
                        //otherwise, part not found exception?

                        break;
                    case "3": //add a part to the cart
                        break;
                    case "4": //remove a part from the cart
                        break;
                    case "5": //display cart and total
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
