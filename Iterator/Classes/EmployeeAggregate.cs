using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Classes
{
    class EmployeeAggregate : IAggregate
    {
        List<Employee> EmployeeList = new List<Employee>();
        public void Add(Employee Model) => EmployeeList.Add(Model);
        public Employee GetItem(int index) => EmployeeList[index];
        public int Count { get => EmployeeList.Count; }
        public IIterator CreateIterator() => new EmployeeIterator(this);
    }
}
