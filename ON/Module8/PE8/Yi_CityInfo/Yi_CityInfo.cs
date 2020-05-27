using System;

namespace Yi_CityInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the variable
            string city = "Seattle";
            int pop = 783137;
            string country = "USA";
            
            City Seattle = new City(); //Create object for class City
            
            Console.WriteLine($"Name of City: {Seattle.GetCity(city)}"); //GetCity method is called
            Console.WriteLine($"{Seattle.GetCity(city)} population size: {Seattle.GetPopulation(pop)}"); //GetPopulation method is called
            Console.WriteLine($"{Seattle.GetCity(city)} is a state in {Seattle.GetCountry(country)}"); //GetCountry method is called
            
            City.Version();//CityVersion is called
        }
    }
    
    class City
    {
        //Creating the private variables to be use
        private string name;
        private int population;
        private string country;

        public City(){}//default constructor needed to overload

        //overloaded constructor 
        public City(string name, int population, string country)
        {
            this.name = name;
            this.population = population;
            this.country = country;
        }

        public string GetCity(string name) //displays the city name
        {
            this.name = name;
            return name;
        }

        public int GetPopulation(int population) //displays the population
        {
            this.population = population;
            return population;
        }

        public string GetCountry(string country) //displays the country
        {
            this.country = country;
            return country;
        }

        public static void Version() //displays the app version
        {
            Console.WriteLine("\n");
            Console.WriteLine("City Info Version 1.0");
        }
    }
}