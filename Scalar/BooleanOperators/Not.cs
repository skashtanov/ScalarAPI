using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.BooleanOperators
{
    public class Not : IScalar<bool>
    {
        private readonly IScalar<bool> _scalar;

        public Not(IScalar<bool> scalar)
        {
            _scalar = scalar;
        }

        public Not(bool value):
            this(new ScalarOf<bool>(value))
        {
            
        }
        
        public bool Value()
        {
            return !_scalar.Value();
        }
    }
}