using System.Threading.Tasks;
using cbxApi.DataAccess.Models;

namespace cbxApi.DataAccess.Repositories
{
    public class PartyRepositoty : IPartyRepository
    {
        private PartyContext context;

        public PartyRepositoty(PartyContext partyContext)
        {
            context = partyContext;
        }
        public Task<Party[]> GetAllPartyAsync(bool includePartners = false)
        {
            throw new System.NotImplementedException();
        }

        public Task<Party> GetPartyAsync(long partyId, bool includePartners = false)
        {
            throw new System.NotImplementedException();
        }
    }
}