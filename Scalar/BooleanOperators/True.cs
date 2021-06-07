using ScalarAPI.Interfaces;

namespace ScalarAPI.BooleanOperators
{
    /// <summary>
    /// Object's of this type represents "true" constant 
    /// </summary>
    public class True: IScalar<bool>
    {
        public bool Value()
        {
            return true;
        }
    }
}