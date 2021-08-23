using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScalarAPI.Async
{
    public class AsyncNoThrow<T>: IAsyncScalar<T>
    {
        private IAsyncScalar<T> _source;
        private IAsyncScalar<T> _fallback;
        private List<Exception> _errors = new List<Exception>();

        public AsyncNoThrow(IAsyncScalar<T> souce, IAsyncScalar<T> fallback)
        {
            _source = souce;
            _fallback = fallback;
        }

        public AsyncNoThrow(Func<Task<T>> source, Func<Task<T>> fallaback)
            : this(new TaskScalar<T>(source), new TaskScalar<T>(fallaback))
        {
            
        }
        
        public AsyncNoThrow(IAsyncScalar<T> source, Func<Task<T>> fallaback)
            : this(source, new TaskScalar<T>(fallaback))
        {
            
        }
        
        public AsyncNoThrow(Func<Task<T>> source, IAsyncScalar<T> fallaback)
            : this(new TaskScalar<T>(source), fallaback)
        {
            
        }

        public List<Exception> Errors() => _errors;
        
        public bool HasErrors() => _errors.Count > 0;
        
        
        public async Task<T> Value()
        {
            try
            {
                return await _source.Value();
            }
            catch (Exception ex)
            {
                _errors.Add(ex);
                return await _fallback.Value();
            }
        }
    }
}