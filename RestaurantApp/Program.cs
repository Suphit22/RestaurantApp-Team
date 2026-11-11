using System;
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
            Console.WriteLine("--- Welcome to Restaurant ---");
            //Console.WriteLine("Suphitsara");
            //Console.WriteLine("Phichanin");

            List<Restaurant> restaurants = new List<Restaurant>
        {
            new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
            new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
            new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
        };

            ShowRestaurants(restaurants);
            AddRestaurant(restaurants);     // A
            ShowGoodRating(restaurants);    // B
            ShowSummary(restaurants);       // C

            Console.ReadKey();
        }

        static void ShowRestaurants(List<Restaurant> restaurants)
        {
            foreach (Restaurant r in restaurants)
            {
                Console.WriteLine($"{r.ID} | {r.Name} | {r.Type} | {r.Rate}");
            }
        }

        static void AddRestaurant(List<Restaurant> restaurants)
        {
            Console.WriteLine();
            Console.WriteLine("=== เพิ่มร้านอาหารใหม่ ===");

            Console.Write("ชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("ประเภท: ");
            string type = Console.ReadLine();

            Console.Write("คะแนน: ");
            double rate;
            while (!double.TryParse(Console.ReadLine(), out rate))
            {
                Console.Write("กรุณาพิมพ์ตัวเลข คะแนน: ");
            }

            int id = restaurants.Count + 1;
            restaurants.Add(new Restaurant(id, name, type, rate));

            Console.WriteLine("เพิ่มร้านเรียบร้อย");
            ShowRestaurants(restaurants);
        }
        static void ShowGoodRating(List<Restaurant> restaurants) { }
        static void ShowSummary(List<Restaurant> restaurants) { }
    }
    public class Restaurant

    {
        public int ID { get; set; }          // เดิมเป็น string ต้องเป็น int
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
