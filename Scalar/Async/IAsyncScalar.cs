using System.Threading.Tasks;

namespace ScalarAPI.Async
{
    public interface IAsyncScalar<T>
    {
        Task<T> Value();
    }
}