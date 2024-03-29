﻿using DroneDeliveryService.Classes;

namespace DroneDeliveryService
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Drone> drones = new List<Drone>()
            {
                new Drone("DroneA", 200),
                new Drone("DroneB", 250),
                new Drone("DroneC", 100)
            };

            List<Location> locations = new List<Location>()
            {
                new Location("[LocationA]", 200),
                new Location("[LocationB]", 150),
                new Location("[LocationC]", 50),
                new Location("[LocationD]", 150),
                new Location("[LocationE]", 100),
                new Location("[LocationF]", 200),
                new Location("[LocationG]", 50),
                new Location("[LocationH]", 80),
                new Location("[LocationI]", 70),
                new Location("[LocationJ]", 50),
                new Location("[LocationK]", 30),
                new Location("[LocationL]", 20),
                new Location("[LocationM]", 50),
                new Location("[LocationN]", 30),
                new Location("[LocationO]", 20),
                new Location("[LocationP]", 90)
            };

            foreach (var drone in drones)
            {
                Console.WriteLine($"[{drone.Name}]");
                drone.Deliver(locations);
            }

            Console.ReadKey();
        }
    }



}
