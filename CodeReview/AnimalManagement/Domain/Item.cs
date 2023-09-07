using Ardalis.GuardClauses;

namespace CodeReview.AnimalManagement.Domain;

public class Item
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    public Item(int id,string name)
    {
        Id = Guard.Against.NegativeOrZero(id, nameof(id));
        Name = Guard.Against.NullOrEmpty(name, nameof(name));
    }
}