using Contracts.Data.Entities;
using Contracts.Models;

public static class SomeExtensions
{
    // static modifier methods promise not to have side effects
    // on the state of the system, to make external calls,
    // or to alter the reference objects passed in.
    public static SomeModel ConvertToModel(this SomeEntity input)
        => new SomeModel { Name = input.Name, Value = input.Value };

    public static SomeEntity ConvertToEntity(this SomeModel input)
        => new SomeEntity { Name = input.Name, Value = input.Value };
}