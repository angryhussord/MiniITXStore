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

        public static void CreatePart(string partName, string partDescription, PartTypes partType, decimal price, decimal cost, string manufacturer, decimal length, decimal width, decimal height)
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
                Height = height
            };

            Parts.Add(part);
        }

        public static void UpdatePart(Part part)
        { }

        public static IEnumerable<Part> GetAllPartsByName(string partName)
        {
            return Parts.Where(a => a.Name.Contains(partName));
        }
    }
}
