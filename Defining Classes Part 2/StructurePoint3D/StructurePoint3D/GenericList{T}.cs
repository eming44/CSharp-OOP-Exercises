using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructurePoint3D
{
    class GenericList<T>
        where T : IComparable
    {
        private int capacity = 2;
        private T[] elements;
        private int count;

        public int CapacityGet
        {
            get
            {
                return this.capacity;
            }
        }

        public GenericList() 
        {}

        public GenericList(int newCapacity)
        {
            this.capacity = this.NearestPowOfTwo(newCapacity);
            this.elements = new T[this.capacity];
            this.count = 0;
        }

        //Indexing elements in list-------------------
        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }
            set
            {
                this.elements[index] = value;
            }
        }

        //Adding element------------------------------
        public void Add(T item)
        {
            if (count == capacity)
            {
                elements = this.resizing(elements);
            }
            elements[this.count++] = item;
        }
        //Accessing element by index------------------
        public void showAt(int index)
        {
            if (index <= count)
            {
                Console.WriteLine(elements[index]);
            }
        }

        //Removing element by index-------------------
        public void removeFirst(T item)
        {
            int indexOfElement = 0;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(elements[i]))
                {
                    indexOfElement = i;
                    break;
                }
            }
            for (int i = indexOfElement; i < count - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            count--;
        }

        //Inserting element at given position---------
        public void insertAt(T item, int index)
        {
            if (index <= count)
            {
                if(count + 1 > capacity)
                {
                    elements = this.resizing(elements);
                }
                this.Add(elements[count - 1]);
                for (int i = count - 1; i > index + 1; i--)
                {
                    elements[i - 1] = elements[i - 2];
                }
                elements[index] = item;
            }
        }

        //Clearing the list---------------------------
        public void clearAll()
        {
            count = 0;
            capacity = 2;
        }

        //Finding element by its value ---------------
        public void findByValue(T item)
        {
            int index = 0;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(elements[i]))
                {
                    index = i;
                    Console.WriteLine("Element found at {0} index", index);
                    break;
                }
            }
        }

        //ToString()----------------------------------
        public override string ToString()
        {
            string elementsInList = "";
            for (int i = 0; i < this.count; i++)
            {
                if (i == count - 1)
                {
                    elementsInList += elements[i].ToString();
                }
                else
                {
                    elementsInList += (elements[i].ToString() + ", ");
                }
            }
            return elementsInList;
        }

        //ReSizing------------------------------------
        private T[] resizing(T[] array)
        {
            this.capacity *= 2;
            T[] newArray = new T[this.capacity];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }

        //Nearest power of 2--------------------------
        private int NearestPowOfTwo(int n)
        {
            var pow = 0;

            while (n > 0)
            {
                n >>= 1;
                pow++;
            }
            return 1 << pow;
        }

        //Max<T> method-------------------------------
        public T Max()
        {
            T maxValue = default(T);

            for (int i = 0; i < this.count; i++)
            {
                if(maxValue.CompareTo(this.elements[i]) == -1)
                {
                    maxValue = this.elements[i];
                }
            }
            return maxValue;
        }

        //Min<T> method-------------------------------
        public T Min()
        {
            T minValue = default(T);

            for (int i = 0; i < this.count; i++)
            {
                if (minValue.CompareTo(this.elements[i]) == 1)
                {
                    minValue = this.elements[i];
                }
            }
            return minValue;
        }
    }
}
