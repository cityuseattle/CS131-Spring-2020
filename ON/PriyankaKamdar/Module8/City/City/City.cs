using System;

namespace City
{
    class City
    {
        private string name;
        private int population;

        public City (string cityName, int cityPopulation)
        {
            name = cityName;
            population = cityPopulation;
        }

        public string GetCity()
        {
            return name;
        }

        public int GetPopulation()
        {
            return population;
        }
        static void Main(string[] args)
        {
            City city = new City("Seattle", 1000000);
            Console.WriteLine("City name is: " +  city.GetCity());
            Console.WriteLine("City population is: " +  city.GetPopulation());
        }
    }
}
