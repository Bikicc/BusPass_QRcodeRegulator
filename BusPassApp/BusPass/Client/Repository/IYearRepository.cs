using BusPass.Shared.Entities;
using System.Threading.Tasks;

namespace BusPass.Client.Repository
{
    public interface IYearRepository
    {
         Task<Year[]> getYears();
    }
}