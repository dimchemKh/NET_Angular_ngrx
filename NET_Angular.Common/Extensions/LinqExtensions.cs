using System;
using System.Collections.Generic;
using System.Linq;

namespace NET_Angular.Common.Extensions
{
    public static class LinqExtensions
    {
        public static IEnumerable<T> Replace<T>(this IEnumerable<T> source, T oldValue, T newValue)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            return source.Select(x => EqualityComparer<T>.Default.Equals(x, oldValue) ? newValue : x);
        }
    }
}
