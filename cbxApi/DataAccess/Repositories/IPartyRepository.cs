using System.Threading.Tasks;
using cbxApi.DataAccess.Models;

namespace cbxApi.DataAccess.Repositories
{
    public interface IPartyRepository
    {
        Task<Party[]> GetAllPartyAsync(bool includePartners = false);
        Task<Party> GetPartyAsync(long partyId, bool includePartners = false);
    }
}