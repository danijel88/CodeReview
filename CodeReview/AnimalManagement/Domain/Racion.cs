using Ardalis.GuardClauses;

namespace CodeReview.AnimalManagement.Domain;

public class Racion
{
    public int Id { get; private set; }
    public string Name { get; private set; }

    private readonly List<RacionItems> _racionItems = new List<RacionItems>();
    public IEnumerable<RacionItems> RacionItems => _racionItems.AsReadOnly();

    public Racion(int id, string name)
    {
        Id = Guard.Against.NegativeOrZero(id,nameof(id));
        Name = Guard.Against.NullOrEmpty(name,nameof(name));
    }

    public void AddRacionItem(RacionItems racionItem)
    {
        Guard.Against.Null(racionItem,nameof(racionItem));
        _racionItems.Add(racionItem);
    }




}