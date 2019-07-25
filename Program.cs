using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Printing parts list:");
                        Console.WriteLine("Part Name: {myPart.Name}");
                        Console.WriteLine("Part Description: {myPart.Description}");
                        Console.WriteLine("Part Creation Date: {myPart.CreatedDate}");
                        Console.WriteLine("Part ID: {myPart.PartID}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
