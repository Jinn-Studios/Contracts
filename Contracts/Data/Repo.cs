using System.Threading.Tasks;

namespace Contracts.Data
{
    public partial class Repo
    {
        public async Task<Entities.SomeEntity> GetSomething(int entityID)
        {
            // Let's just pretend there's a DBContext, etc...
            return await Task.FromResult<Entities.SomeEntity>(null);
        }
        public async Task<bool> DoSomething(Entities.SomeEntity something)
        {
            // Let's just pretend there's a DBContext, etc...
            return await Task.FromResult(true);
        }
    }
}