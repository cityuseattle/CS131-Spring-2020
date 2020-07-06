using System;

namespace Starter { 
    class Program
    {
        public static void Main()
        {
            Fashion fashionDepartment = new Fashion();
            fashionDepartment.DisplayPromotions();
            Console.ReadLine();
        }
    }
    //Store sale event data
    class Promotion
    {
        public DateTime Start { get; private set; }
        public string Name { get; private set; }
        public DateTime End { get; private set; }

        public Promotion(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
        }
    }

    abstract class Department
    {
        public abstract string DepartmentName { get; protected set;}
        protected Promotion[] sales;
        protected abstract void AssignPromotions();

        public virtual void DisplayPromotions()
        {
            Console.WriteLine( "Fashion Department Promotions: " , DepartmentName);
            foreach(Promotion sale in sales)
            {
                Console.WriteLine("Name: " + sale.Name);
                Console.WriteLine("Start: " + sale.Start.ToString("m"));
                Console.WriteLine("End: " + sale.End.ToString("m"));
            }
        }
    }
    //Implementing class that sets department name and assigns promotions
    class Fashion : Department
    {
        public override string DepartmentName { get; protected set; }
        public Fashion()
        {
            DepartmentName = "Fashion";
            AssignPromotions();
        }
        protected override void AssignPromotions()
        {
            DateTime start = new DateTime(2014, 9, 1);
            DateTime end = new DateTime(2014, 9, 15);
            Promotion promotion = new Promotion ( start, end, "Fall Sale" );
            sales = new Promotion[] { promotion };
        }
    }
}
