namespace Defining_Classes___Part_2.GenericClasses
{
    using System;
    using System.Linq;

    public class GenericList<T>
    {
        private T[] elements;
        private int length;
        private int maxCap;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
            this.maxCap = capacity;
        }

        public int Length
        {
            get
            {
                return this.maxCap;
            }
        }

        public T this[int index]
        {
            get
            {
                this.LengthCheck(index);
                T result = this.elements[index];
                return result;
            }
        }

        public void Add(T element)
        {
            this.Grow();
            this.elements[this.length] = element;
            this.length++;
        }

        public T Min()
        {
            var min = this.elements.Min();
            return min;
        }

        public T Max()
        {
            var max = this.elements.Max();
            return max;
        }

        public void Grow()
        {
            if (this.length == this.maxCap)
            {
                this.maxCap *= 2;
                T[] newArr = new T[this.maxCap];

                for (int i = 0; i < this.elements.Length; i++)
                {
                    newArr[i] = this.elements[i];
                }

                this.elements = newArr;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                this.elements[i] = default(T);
            }
        }

        public string ToString()
        {
            string result = string.Empty;
            for (int i = 0; i < this.elements.Length; i++)
            {
                result += string.Format("{0} ", this.elements[i]);
            }

            return result;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < this.elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public void InsertAt(int index, T number)
        {
            this.LengthCheck(index);
            this.length++;
            for (int i = this.elements.Length; i < index; i++)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = number;
        }

        public void RemoveAt(int index)
        {
            this.LengthCheck(index);
            for (int i = index; i < this.elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.length--;
        }

        private void LengthCheck(int index)
        {
            if (index > this.maxCap)
            {
                throw new IndexOutOfRangeException(string.Format(
                    "Invalid index: {0}.", index));
            }
        }
    }
}
