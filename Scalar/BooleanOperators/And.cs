using ScalarAPI.Interfaces;
using ScalarAPI.Scalars;

namespace ScalarAPI.BooleanOperators
{
    public class And : IScalar<bool>
    {
        private readonly IScalar<bool> _left;
        private readonly IScalar<bool> _right;

        public And(IScalar<bool> left, IScalar<bool> right)
        {
            _left = left;
            _right = right;
        }

        public And(bool left, bool right) :
            this(new ScalarOf<bool>(left),
                new ScalarOf<bool>(right))
        {
            
        }
        
        public bool Value()
        {
            return _left.Value() && _right.Value();
        }
    }
}