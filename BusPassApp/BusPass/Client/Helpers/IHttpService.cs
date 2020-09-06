using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusPass.Client.Helpers {
    public interface IHttpService {
        Task<T> Post<T> (string url, T data);
        Task<T> Get<T> (string url);
    }
}