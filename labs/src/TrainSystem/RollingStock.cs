using System;
namespace TrainSystem
{
    public class RollingStock
    {
        public readonly string ReportingMark;
        public readonly string Owner;
        public readonly int LightWeight;
        public readonly int LoadLimit;
        public readonly int Capacity;
        public readonly RailCarType Type;
        public readonly int YearBuilt;
        public readonly bool InService;
        public readonly string Notes;
        public int GrossWeight { get; private set; }
        public int NetWeight { get { return GrossWeight - LightWeight; } }

        private const string SPECIALCHARACTERS =@",:;\/!?@#$%^&*~`";

        public RollingStock(string reportingMark, string owner, int lightWeight, 
            int loadLimit, int capacity,  RailCarType type, int yearBuilt, bool inService, string notes) 
            {
                
            }

        public override string ToString()
       {
           return $"{ReportingMark},{Owner},{LightWeight},{LoadLimit},{Capacity},{Type},{YearBuilt},{InService},{Notes}";
       }
    }
}