namespace IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Extensions
    {
        public static T SumAll<T>(this IEnumerable<T> collection) 
        {
            T result = (dynamic)0;

            foreach (T item in collection)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T ProductOfAll<T>(this IEnumerable<T> collection) 
        {
            T result = (dynamic)1;

            foreach (T item in collection)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinInCollection<T>(this IEnumerable<T> collection) 
        {
            return collection.Min();
        }

        public static T MaxInCollection<T>(this IEnumerable<T> collection) 
        {
            return collection.Max();
        }

        public static double CollectionAverage<T>(this IEnumerable<T> collection) 
        {
            return (dynamic)collection.SumAll() / collection.Count();
        }
    }
}