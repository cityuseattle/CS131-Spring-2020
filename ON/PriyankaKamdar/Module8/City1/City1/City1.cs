using System;

namespace City1
{
    class City1
    {
        private string name;                           //Declared class member name     
        private int population;                       //Declared class member population
        private string country;                      //Declared class member country

        public City1(string cityName, int cityPopulation, string countryName)  //public constructor for City1
        {
            name = cityName;
            population = cityPopulation;
            country = countryName;
        }

        public string GetCity()                                 // GetCity Method defination 
        {
            return name;
        }

        public int GetPopulation()                           //GetPopulation Method defination
        {
            return population;
        }

        public string Country                               //ReadonlyCountry Property
        {
            get { return country; }
        }

        public static void CityInfo()
        {
            Console.WriteLine("City Info Version 1.0");
        }

        static void Main(string[] args)
        {
            City1 city = new City1("Seattle", 1000000, "USA");        //creating object of City1
            Console.WriteLine("City name is: " + city.GetCity());
            Console.WriteLine("City population is: " + city.GetPopulation());
            Console.WriteLine("Country name is: " + city.Country);
            City1.CityInfo();
        }
    }
}

