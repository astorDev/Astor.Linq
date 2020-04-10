using System;
using System.Collections.Generic;
using System.Linq;

namespace Astor.Linq
{
    public static class ForkHelper
    {
        public static (IEnumerable<T> satisfying, IEnumerable<T> notSatisfying) Fork<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            var lookup = source.ToLookup(predicate);
            return (lookup[true], lookup[false]);
        }
    }
}