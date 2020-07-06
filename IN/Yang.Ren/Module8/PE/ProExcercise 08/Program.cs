using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

namespace ProExcercise_08
{
    class City
    {
        private string name;
        private double population;
        private string country;
        public static string A;

        public string  GetString()
        {
            A = "City Info Version 1.0";
            return A;
        }
        //public string Country { get; private set; }
        public string GetCountry()
        {
            {
                country = "The USA";
                return country;
            }
        }
       public void setCityname(string N)
        {
            name = N;
        }
        public string GetCity()
        {
            return name;
        }
        public void setPopulation(double P)
        {
            population = P;
        }
        public double GetPop()
        {
            return population;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.setCityname("Seattle");
            Console.WriteLine("The name of city is:{0} ", city.GetCity());

            City population = new City();
            city.setPopulation(4.78);
            Console.WriteLine("The population is: {0}", city.GetPop());

            City country = new City();
         
            Console.WriteLine("The Countryname is {0}", country.GetCountry());

            City A = new City();
            Console.WriteLine("{0}", A.GetString());

        }
    }
}
