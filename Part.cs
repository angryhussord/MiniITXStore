using System;
using System.Collections.Generic;
using System.Text;

namespace MiniITXStore
{
    enum PartTypes { Case, CLC, Motherboard, RAM, VideoCard, Fan, CaseAccessory, PSU, HSF};
    class Part
    {
        #region Properties
        private static int lastPartID = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        public string Manufacturer { get; set; }
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public PartTypes PartType { get; set; }
        public int PartID { get; set; }
        public DateTime CreatedDate { get; }
        #endregion

        #region Methods
        public Part()
        {
            PartID = ++lastPartID;
            CreatedDate = DateTime.Now;
        }

        
        #endregion
    }
}
