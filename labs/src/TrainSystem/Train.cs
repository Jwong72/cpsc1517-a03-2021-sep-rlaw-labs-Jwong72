using System;
using System.Collections.Generic;

namespace TrainSystem
{
    public class Train
    {
        public Engine Engine { get; private set; }
        public int GrossWeight { get { return Engine.Weight + CalculateGrossWeightOfCars(); } }
        public int MaxGrossWeight { get { return Engine.HorsePower * 2000; } }
        public List<RollingStock> RailCars { get; private set; } = new();
        //TotalCars does not include the engine.
        public int TotalCars { get { return RailCars.Count; } }

        public Train(Engine givenEngine) {}

        public void AddRailCar(RollingStock car) 
        {
         if(car == null)
            throw new ArgumentNullException(string.Empty,"No car supplied. Car not added.");
        bool found = false;
        foreach(var existingCar in RailCars)
            if (car.ReportingMark.Equals(existingCar.ReportingMark))
                    found = true;
            if (found)
                throw new ArgumentException($"The railcar {car.ReportingMark} is already attached to the train".)
            RailCars.Add(car); 
            if (GrossWeight > MaxGrossWeight)
            throw new ArgumentException("This new car will overload engine. Car not added.".);
        
        }

        private int CalculateGrossWeightOfCars() {}
    }
}