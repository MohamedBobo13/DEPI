using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFromScratch
{
    public class MyOwnCollection<T> : IEnumerable
    {
        
            T[] arr;
            int lastIndex;
            public MyOwnCollection()
            {
                arr = new T[10];
                lastIndex = -1;
            }
            public void Add(T value)
            {
                arr[++lastIndex] = value;
            }

            public IEnumerator GetEnumerator()
            {
                return new iterator<T>(this);
            }
            class iterator<T> : IEnumerator
            {
            MyOwnCollection<T> owncollection;
                int index;
                public iterator(MyOwnCollection<T> owncollection)
                {
                    this.owncollection = owncollection;
                    index = -1;
                }
                public object Current
                {
                    get
                    {
                        return owncollection.arr[index];
                    }
                }

                public bool MoveNext()
                {
                    index++;
                    return index <= owncollection.lastIndex;
                }

                public void Reset()
                {
                    index = -1;
                }
            }
        }
    
}
