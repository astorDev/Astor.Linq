using System;
using System.Collections.Generic;
using System.Linq;

namespace Astor.Linq
{
    public static class SlicesHelper
    {
        public static IEnumerable<IEnumerable<T>> Slices<T>(this IEnumerable<T> enumerable, int sliceLength)
        {
            var sliced = 0;
            var length = enumerable.Count();

            while (sliced < length)
            {
                var slice = enumerable.Skip(sliced).Take(sliceLength);
                sliced += slice.Count();
                yield return slice;
            }
        }
    }
}