using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace MiniITXStore
{
    static class Store
    {
        private static readonly List<Part> Parts = new List<Part>();
        private static ShoppingCart Cart;

        public static void CreatePart(string partName, string partDescription, PartTypes partType, decimal price, decimal cost, string manufacturer, decimal length, decimal width, decimal height, decimal weight)
        {
            var part = new Part
            {
                Name = partName,
                Description = partDescription,
                PartType = partType,
                Price = price,
                Cost = cost,
                Manufacturer = manufacturer,
                Length = length,
                Width = width,
                Height = height,
                Weight = weight
            };

            Parts.Add(part);
        }

        public static void DeletePart(int partId)
        {
            Part partToRemove = GetPartById(partId);
            Parts.Remove(partToRemove);
            return;
        }

        public static IEnumerable<Part> GetAllPartsByName(string partName)
        {
            return Parts.Where(a => a.Name.Contains(partName));
        }

        public static Part GetPartById(int id)
        {
            return Parts.SingleOrDefault(a => a.PartID == id);
        }

        public static void AddPartToCart(int partId)
        {
            var partToAdd = Store.GetPartById(partId);
            Cart.AddPartToCart(partToAdd);
        }
    }
}
