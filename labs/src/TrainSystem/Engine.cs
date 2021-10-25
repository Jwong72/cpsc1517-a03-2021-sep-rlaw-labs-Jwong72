using System;
namespace TrainSystem
{
    public class Engine
    {
        public readonly string Model;
        public readonly string SerialNumber;
        public readonly int Weight;
        public readonly int HorsePower;

        public Engine(string model, string serialNumber, int weight, int horsePower) 
        {
            if(string.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException("model cannot be null or empty");
            if(string.IsNullOrWhiteSpace(serialNumber))
                throw new ArgumentNullException("serialNumber cannot be null or empty");
            if(weight == (weight = weight.round(-2)))
                throw new ArgumentNullException("weight must be in increments of 100");
            if(horsePower < 3500 || horsePower > 5500)
                throw new ArgumentNullException("horsePower cannot be less than 3500 or more than 5500");
            Model = model.Trim();
            SerialNumber = serialNumber.Trim();
        }

        public override string ToString()
        {
            return $"Engine Model: {Model}, Serial Number: {SerialNumber}, Weight: {Weight}, Horse Power: {HorsePower}";
        }
    }
}