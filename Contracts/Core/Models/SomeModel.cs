namespace Contracts.Models
{
    // Appending "Model" to a noun should communicate POCO classes/records, much like structs
    // Rich Domain Models are more likely to be called just by their noun without the word "Model" appended
    public record SomeModel
    {
        // Fields should always be private
        private string _name;

        // Models should be easily deserialized into
        public string Name
        {
            get => _name;           // Insignificantly little work is occuring here
            set => _name = value;   // There should be no chance of exception
        }

        // Try to move toward immutable objects
        public string Value { get; init; }

        // Models should not have much in the way of methods.
        // other than ToString, Equality, Comparer, and other
        // common object methods.
    }
}