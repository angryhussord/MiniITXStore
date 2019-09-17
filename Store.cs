using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniITXStore
{
    static class Store
    {
        private static readonly List<Part> Parts = new List<Part>();

        public static void CreatePart(string partName, string partDescription, PartTypes partType)
        {
            var part = new Part
            {
                Name = partName,
                Description = partDescription,
                PartType = partType
            };

            Parts.Add(part);
        }

        public static IEnumerable<Part> GetAllPartsByName(string partName)
        {
            return Parts.Where(a => a.Name.Contains(partName));
        }
    }
}
