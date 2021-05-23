using System.Threading.Tasks;

namespace Contracts.Core
{
    // Interfaces are the quinttesential contract.  When a class
    // implements an interface, it must follow the rules therein.
    // If you find yourself picking and choosing which methods to
    // implement for an interface in different classes,
    // you're doing interfaces wrong.
    public interface IContract
    {
        Models.SomeModel GetSomething(int entityID);

        // While appending "Async" to methods is a fading practice,
        // having it on your method name is a contract that all further
        // implementation will await asynchronously
        Task<Models.SomeModel> DoSomethingAsync(int entityID);

        // If the overwhelming majority of your procedural code is
        // asynchronous, it becomes less necessary to make it contractual.
        Task<bool> DoSomething(Models.SomeModel something);
    }
}