using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    enum PartType { Case, CLC, Motherboard, RAM, VideoCard, Fan, CaseAccessory, PSU, HSF};
    class Part
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Manufacturer { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string[] CaseCompatibilityList { get; set; }
        public int PartID { get; set; }
    }
}
