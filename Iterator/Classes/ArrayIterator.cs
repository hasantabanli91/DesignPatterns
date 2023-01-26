using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.Classes
{
    class ArrayIterator : IIterator
    {
        ArrayAggregate aggregate;
        int currentindex;
        public ArrayIterator(ArrayAggregate aggregate) => this.aggregate = aggregate;
        public int CurrentItem() => currentindex;
        public bool HasItem()
        {
            if (currentindex < aggregate.list.Count)
                return true;
            return false;
        }
        public void NextItem()
        {
            currentindex++;
        }
    }
}
