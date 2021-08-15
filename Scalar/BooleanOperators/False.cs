using ScalarAPI.Interfaces;

namespace ScalarAPI.BooleanOperators
{
    public class False : IScalar<bool>
    {
        public bool Value() => false;
    }
}