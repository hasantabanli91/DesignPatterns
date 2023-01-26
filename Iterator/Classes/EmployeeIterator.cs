using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Classes
{
    class EmployeeIterator : IIterator
    {
        EmployeeAggregate aggregate;
        int currentindex;
        public EmployeeIterator(EmployeeAggregate aggregate) => this.aggregate = aggregate;
        public int CurrentItem() => currentindex;
        public bool HasItem()
        {
            if (currentindex < aggregate.Count)
                return true;
            return false;
        }
        public void NextItem()
        {
            currentindex++;
        }
    }
}
