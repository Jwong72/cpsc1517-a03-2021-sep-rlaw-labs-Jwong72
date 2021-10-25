using System;
using System.Collections.Generic;
using System.IO;

namespace TrainSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new Program();
            app.Ex01a();
            app.Ex01b();
        }

        private void Ex01b()
        {
            try
            {
                Console.WriteLine("Ex01b Program started");
                //build a simple train.
                Engine theEngine = new Engine("CP 8002","123658",147700,4400);
                Train theTrain = new Train(theEngine);
                theTrain.AddRailCar(new RollingStock("GATX 220455","Alberta Gov",
                    38800,130200,110000,RailCarType.BOX_CAR,1980,true,"none"));
                theTrain.AddRailCar(new RollingStock("TXLX 152635","Alberta Gov",
                    39200,125200,105000,RailCarType.COVERED_HOPPER,1980,true,"none"));
                //print out the train components to the console.
                Console.WriteLine(theTrain.Engine.ToString());
                foreach (var item in theTrain.RailCars)
                {
                    Console.WriteLine(item.ToString());
                }
                Console.WriteLine("Ex01b Program ended");
                Console.WriteLine("");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Exception in Ex01b: {ex.Message}");
            }
            
        }
    }
}