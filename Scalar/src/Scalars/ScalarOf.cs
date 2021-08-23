using ScalarAPI.Interfaces;

namespace ScalarAPI.Scalars
{
    public class ScalarOf<T> : IScalar<T>
    {
        private readonly T _value;

        public ScalarOf(T value)
        {
            _value = value;
        }
        
        public T Value()
        {
            return _value;
        }
    }
}