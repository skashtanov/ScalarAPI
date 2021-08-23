using System;
using System.Collections.Generic;
using System.Linq;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Collections
{
    public class ExtremumInIterable<T> : IScalar<T>
    {
        private readonly IEnumerable<T> _source;
        private readonly Func<T, T, int> _comparer;

        public ExtremumInIterable(IEnumerable<T> source, Func<T, T, int> comparer)
        {
            _source = source;
            _comparer = comparer;
        }
        
        public T Value()
        {
            T extremum = _source.First();
            foreach (T value in _source)
            {
                if (_comparer(extremum, value) < 0)
                {
                    extremum = value;
                }
            }

            return extremum;
        }
    }
}