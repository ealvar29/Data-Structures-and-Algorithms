using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class DynamicArray
    {
        public int size;
        public int capacity = 10;
        Object[] array;
        public DynamicArray()
        {
            this.array = new Object[capacity];
        }
        public DynamicArray(int capacity)
        {
            this.capacity = capacity;
            this.array = new Object[capacity];
        }

        public void Add(Object data)
        {
            if (size >= capacity)
            {
                Grow();
            }
            array[size] = data;
            size++;
        }

        public void Insert(Object data)
        {
        }

        public void Delete(Object data)
        {
        }

        public int Search(Object data)
        {
            return -1;
        }

        private void Grow()
        {

        }

        private void Shrink()
        {

        }

        public Boolean IsEmpty()
        {
            return size == 0;
        }

        public string ToString()
        {
            string emptyString = "";
            for (int i = 0; i < size; i++)
            {
                emptyString += array[i] + ",";
            }
            if (emptyString != "")
            {
                emptyString = "[" + emptyString.Substring(0, size - 2) + "]";
            }
            else
            {
                emptyString= "[]";
            }
            return emptyString;
        }
    }
}
