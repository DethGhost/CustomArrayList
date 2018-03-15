using System;
using System.Collections;

namespace CustomArrayList
{
    public class MyArrayList : IEnumerable
    {
        private Object[] array;

        public object this[int index]
        {
            get { return this.array[index]; }
            set
            {
                if (index <= this.array.Length - 1)
                {
                    this.array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public MyArrayList(Object[] array = null)
        {
            if (array == null)
            {
                this.array = new Object[1];
            }

            this.array = array;
        }

        public int Length
        {
            get { return this.array.Length; }
        }

        public void Add(Object o)
        {
            if (this.array[this.array.Length - 1] == null)
            {
                this[this.array.Length - 1] = o;
            }
            else
            {
                IncreaseArray();
                this[this.array.Length - 1] = o;
            }
        }

        public void Remove(int index)
        {
            if (this.array.Length - 1 < index)
            {
                throw new IndexOutOfRangeException();
            }

            var o = new Object[this.array.Length - 1];
            int oLengthCounter = 0;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }

                o[oLengthCounter++] = this.array[i];
            }

            this.array = o;
        }

        private void IncreaseArray()
        {
            Object[] newArray = new Object[this.array.Length + 1];
            this.array.CopyTo(newArray, 0);
            this.array = newArray;
        }

        public void Insert(int index, Object value)
        {
            if (index > this.array.Length - 1)
            {
                throw new IndexOutOfRangeException();
            }

            var o = new Object[this.array.Length + 1];
            int oCounter = 0;
            for (int i = 0; i < index; i++)
            {
                o[i] = this[i];
            }

            o[index] = value;
            for (int i = index; i < this.array.Length; i++)
            {
                o[i + 1] = this[i];
            }

            this.array = o;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                yield return this.array[i];
            }
        }
    }
}