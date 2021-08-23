namespace ScalarAPI.Interfaces
{
    /// <summary>
    /// Represents some scalar value of type T to user
    /// </summary>
    public interface IScalar<T>
    {
        T Value();
    }
}