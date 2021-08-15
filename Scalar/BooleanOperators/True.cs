using ScalarAPI.Interfaces;

namespace ScalarAPI.BooleanOperators
{
    public class True: IScalar<bool>
    {
        public bool Value() => true;
    }
}