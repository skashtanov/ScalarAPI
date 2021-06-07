using ScalarAPI.Interfaces;

namespace ScalarAPI.BooleanOperators
{
    /// <summary>
    /// Object's of this type represents "false" constant 
    /// </summary>
    public class False : IScalar<bool>
    {
        public bool Value()
        {
            return false;
        }
    }
}