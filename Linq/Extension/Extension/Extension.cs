using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Extension
    {
        //Eager Execution
        public static IEnumerable<T> FilterV1<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (T item in list)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        //Deferred Execution
        public static IEnumerable<T> FilterV2<T>(this IEnumerable<T> list, Predicate<T> predicate)
        {
            foreach (T item in list)
            {
                if (predicate(item))
                {
                   yield return item;
                }
            }
            
        }

        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> list, Func<TSource, TResult> Selector)
        {
            foreach (TSource item in list)
            {
                    yield return Selector(item);
            }

        }
    }
}
