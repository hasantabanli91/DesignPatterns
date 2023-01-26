using Iterator.Classes;
using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeAggregate aggregate = new EmployeeAggregate();
            aggregate.Add(new Employee { Id = 1, Name = "James", Surname = "Bond" });
            aggregate.Add(new Employee { Id = 2, Name = "John", Surname = "Wick" });
            aggregate.Add(new Employee { Id = 3, Name = "Hasan", Surname = "Tabanlı" });

            IIterator iteration = aggregate.CreateIterator();
            while (iteration.HasItem())
            {
                Console.WriteLine($"ID : {aggregate.GetItem(iteration.CurrentItem()).Id}\nName : {aggregate.GetItem(iteration.CurrentItem()).Name}\nSurname : {aggregate.GetItem(iteration.CurrentItem()).Surname}\n*****");
                iteration.NextItem();
            }

            ArrayAggregate arrayAggregate = new ArrayAggregate();
            IIterator iteration2 = arrayAggregate.CreateIterator();
            while (iteration2.HasItem())
            {
                Console.WriteLine(arrayAggregate.GetItem(+ iteration2.CurrentItem()).ToString() + "\n *****");
                iteration2.NextItem();
            }

            Console.Read();
        }
    }
}
