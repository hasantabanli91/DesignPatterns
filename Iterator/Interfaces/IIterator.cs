using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IIterator
    {
        //Is there element in the next step?
        bool HasItem();
        //Bring the element from the next step.
        void NextItem();
        //Bring the current element.
        int CurrentItem();
    }
}
