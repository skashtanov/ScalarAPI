using System;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Functions
{
    public class InvokesCount<T>: IScalar<T>
    {
        private readonly Func<IScalar<T>> _producer;
        public uint Invokes { get; private set; }

        public InvokesCount(Func<IScalar<T>> producer)
        {
            _producer = producer;
        }

        public InvokesCount(Func<T> producer):
            this(() => new ScalarOf<T>(producer()))
        {
            
        }

        public InvokesCount(IScalar<T> value) :
            this(() => value)
        {
            
        }

        public InvokesCount(T value) :
            this(() => new ScalarOf<T>(value))
        {
            
        }
        
        public T Value()
        {
            Invokes++;
            return _producer().Value();
        }
    }
}