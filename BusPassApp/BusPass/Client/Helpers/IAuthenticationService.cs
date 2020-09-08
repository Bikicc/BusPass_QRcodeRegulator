using System.Threading.Tasks;
using BusPass.Shared.HelperEntities;

namespace BusPass.Client.Helpers {
    public interface IAuthenticationService {
        Task Initialize ();
        Task Login (LoginUser user);
        Task Logout ();
        bool checkIfAdmin ();
        LoginUser user {get;}
    }
}