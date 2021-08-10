using System;
using System.Threading.Tasks;

namespace ScalarAPI.Async
{
    public class TaskScalar<T>: IAsyncScalar<T>
    {
        private readonly Func<Task<T>> _source;

        public TaskScalar(Func<Task<T>> source)
        {
            _source = source;
        }
        
        public Task<T> Value()
        {
            return _source();
        }
    }
}