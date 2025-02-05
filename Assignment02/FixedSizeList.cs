using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class FixedSizeList<T> where T : IComparable<T>
    {
        public int capacity { get; set; }
        public List<T> item { get; set; }

        public FixedSizeList(int _capacity)
        {
            capacity = _capacity;
            item = new List<T>();
        }

        public void Add(T value)
        {
            if (item.Count >= capacity)
                throw new InvalidOperationException("The capicity is full you cant add items");

            item.Add(value);
        }

        public T Get(int index)
        {
            if (index >= item.Count && index < 0)
                throw new InvalidOperationException("The index is out of range");
            else
                return item[index];
        }
        public override string ToString()
        {
            return $"Capacity: {capacity},  Item: {item}";
        }
    }
}
