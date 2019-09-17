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

                        Store.CreatePart(partName, partDescription, PartTypes.Motherboard);
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
                            Console.WriteLine($"Part Name: {myPart.Name}");
                            Console.WriteLine($"Part Description: {myPart.Description}");
                            Console.WriteLine($"Part Creation Date: {myPart.CreatedDate}");
                            Console.WriteLine($"Part ID: {myPart.PartID}");
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
