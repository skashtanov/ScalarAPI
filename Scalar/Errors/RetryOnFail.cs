using System;
using System.Collections.Generic;
using ScalarAPI.Interfaces;

namespace ScalarAPI.Errors
{
    public class RetryOnFail<T>: IScalar<T>, IAttempt
    {
        private readonly uint _attempts;
        private readonly IScalar<T> _scalar;
        private List<Exception> _errors;

        public RetryOnFail(IScalar<T> scalar, uint attempts)
        {
            _scalar = scalar;
            _attempts = attempts;
        }
        
        /// <summary>
        /// This method will try to evaluate the scalar a given number of times
        /// </summary>
        /// <returns>Evaluated scalar on success or default(T) on fail</returns>
        /// <exception cref="Exception"></exception>
        public T Value()
        {
            for (int attempt = 1; attempt <= _attempts; attempt++)
            {
                try
                {
                    return _scalar.Value();
                }
                catch (Exception ex)
                {
                    _errors.Add(ex);
                    if (attempt == _attempts)
                    {
                        throw new Exception($"Failed after {_attempts} iterations", ex);
                    }
                }
            }

            return default;
        }

        public bool HasErrors()
        {
            return _errors.Count == 0;
        }

        public List<Exception> Errors()
        {
            return _errors;
        }
    }
}