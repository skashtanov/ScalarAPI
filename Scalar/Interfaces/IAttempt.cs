using System;
using System.Collections.Generic;

namespace ScalarAPI.Errors
{
    public interface IAttempt
    {
        bool HasErrors();
        List<Exception> Errors();
    }
}