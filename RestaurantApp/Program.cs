using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restaurant> restaurants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "Huguosi Snacks", "Snacks",4.2)
            };
            const double MinRating = 4.5;

            List<Restaurant> goodRestaurants = restaurants
                .Where(r => r.Rate >= MinRating)
                .ToList();

            foreach (var r in goodRestaurants)
            {
                Console.WriteLine($"{r.ID}. {r.Name} ({r.Type}) - {r.Rate}");
            }
        }

    }
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Rate { get; set; }

        public Restaurant(int id, string name, string type, double rate)
        {
            this.ID = id;
            this.Name = name;
            this.Type = type;
            this.Rate = rate;
        }
    }
}
