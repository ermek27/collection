using System;
using System.Collections.Generic;

namespace CollectProj
{
    class Program
    {
        static string iceFlav()
        {
            List<string> flavors = new List<string>(){
                "chocolate",
                "mint",
                "oreo",
                "berry",
                "cranberry",
                "melon",
                "creme",
                "chunky"
            };
            Random rand = new Random();
            return flavors[rand.Next(flavors.Count)];
        }

        static Dictionary<string, string> GetUsers(){
            Dictionary<string, string> users = new Dictionary<string, string>();
            List<string> ppl = new List<string>() {"Nick", "Romoe", "Kelly", "David", "Kolas"};
            foreach(string person in ppl){
                users[person] = iceFlav();
            }
            return users;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<string, string> result = GetUsers();
            Console.WriteLine(result); 
            foreach(KeyValuePair<string, string> entry in result){
                Console.WriteLine($"{entry.Key} likes {entry.Value}");
            }
        }
    }
}
