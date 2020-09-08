using System.Threading.Tasks;

namespace BusPass.Client.Helpers {
    public interface IHttpService {
        Task<T> Post<T> (string uri, T data);
        Task<T> Get<T> (string uri);
        Task<T> Put<T> (string uri, T data);
    }
}