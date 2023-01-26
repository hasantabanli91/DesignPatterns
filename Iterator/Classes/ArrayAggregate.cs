using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Classes
{
    class ArrayAggregate : IAggregate
    {
        public List<int> list = new List<int>();

        public ArrayAggregate()
        {
            list = new List<int>();
            list.Add(12);
            list.Add(2);
            list.Add(17);
            list.Add(23);
            list.Add(15);
        }

        public int GetItem(int index) => list[index];

        public IIterator CreateIterator()
        {
            return new ArrayIterator(this);
        }
    }
}
