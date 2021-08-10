using System;
using System.Threading.Tasks;
using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.Async
{
    public class AsyncFromResult<T>: IAsyncScalar<T>
    {
        private IScalar<T> _source;

        public AsyncFromResult(IScalar<T> source)
        {
            _source = source;
        }

        public AsyncFromResult(Func<T> source)
            : this(new FuncOf<T>(source))
        {
            
        }
        public Task<T> Value()
        {
            return Task.FromResult(_source.Value());
        }
    }
}