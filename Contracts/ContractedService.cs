using Contracts.Core;
using Contracts.Models;
using System.Threading.Tasks;

public class ContractedService : IContract
{
    private readonly Contracts.Data.Repo _repo;

    // Insignificantly little work occurring in the constructor.  Certainly no external calls.
    public ContractedService(Contracts.Data.Repo repo) { _repo = repo; }

    // If your method beins with a verb for querying, such as
    // "Get" or "Retrieve", you are communicating that you don't
    // plan on having side effects.  You will only be querying.
    public SomeModel GetSomething(int entityID)
    {
        return _repo.GetSomething(entityID)
            .Result // Not saying to do this
            .ConvertToModel();
    }

    // If your method begins with a verb for taking action, you are communicating
    // that you will be changing the state of something, like a database.
    public async Task<bool> DoSomething(SomeModel something)
        => await _repo.DoSomething(something.ConvertToEntity());

    // Command-type methods may still result in a query, but query-type 
    // actions should not change state.
    public async Task<SomeModel> DoSomethingAsync(int entityID)
    {
        var entity = await _repo.GetSomething(entityID);
        var newEntity = entity with { Value = null };
        await _repo.DoSomething(newEntity);
        return newEntity.ConvertToModel();
    }
}