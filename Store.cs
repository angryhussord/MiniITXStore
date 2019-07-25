using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    static class Store
    {
        private static readonly List<Part> Parts = new List<Part>();

        public static Part CreatePart(string partName, string partDescription, PartTypes partType)
        {
            var part = new Part
            {
                Name = partName,
                Description = partDescription,
                PartType = partType
            };

            return part;
        }

        public static IEnumerable<Part> GetAllPartsByName(string partName)
        {
            return Parts;
        }
    }
}
