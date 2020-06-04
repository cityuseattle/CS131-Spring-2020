using System;

namespace Yi_Fashion
{
    //calls Fashion class
    class Program
    {
        static void Main(string[] args)
        {
            Fashion fashionDep = new Fashion();
            fashionDep.DisplayPromotions();
            Console.ReadLine();
        }
    }
    
    //Stores sales event data
    class Promotion
    {
        public string Name { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        public Promotion(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
            
        }
    }

    //Creates the sales output
    abstract class Department
    {
        public abstract string DepartmentName { get; protected set; }
        protected Promotion[] sales;
        protected abstract void AssignPromotions();

        public virtual void DisplayPromotions()
        {
            Console.WriteLine("{0} Department Promotions: ", DepartmentName);
            foreach (Promotion sale in sales)
            {
                Console.WriteLine($"Name: {sale.Name}");
                Console.WriteLine($"Start: {sale.Start.ToString("m")}");
                Console.WriteLine($"End: {sale.End.ToString("m")}");
            }
            
        }
        
    }

    //Child class of Department
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
            DateTime Start = new DateTime(2014, 9, 1);
            DateTime End = new DateTime(2014, 9, 15);
            Promotion promotion = new Promotion(Start, End, "Fall Sale");
            sales = new Promotion[] {promotion};
        }
    }
}