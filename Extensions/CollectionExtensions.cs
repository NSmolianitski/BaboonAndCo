using System.Collections.Generic;
using UnityEngine;

namespace BaboonAndCo.Extensions
{
    public static class CollectionExtensions
    {
        /// <summary>
        /// Select random element of collection.
        /// </summary>
        public static T GetRandom<T>(this IList<T> collection)
        {
            return collection.GetRandom(0);
        }

        /// <summary>
        /// Select random element of collection with specified range. Uses size of collection when max is not declared.
        /// </summary>
        public static T GetRandom<T>(this IList<T> collection, int min, int max = 0)
        {
            var rng = Random.Range(min, max == 0 ? collection.Count : max);
            return collection[rng];
        }

        /// <summary>
        /// Select random element of collection with specified range. Can have out param with RNG index
        /// </summary>
        public static T GetRandom<T>(this IList<T> collection, out int rng, int min = 0, int max = 0)
        {
            rng = Random.Range(min, max == 0 ? collection.Count : max);
            return collection[rng];
        }
    }
}