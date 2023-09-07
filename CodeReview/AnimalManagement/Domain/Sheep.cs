using Ardalis.GuardClauses;
using CodeReview.AnimalManagement.Domain.Interfaces;

namespace CodeReview.AnimalManagement.Domain;

public class Sheep : IAnimal
{
    public string Tag { get; private set; }
    public DateTime BirthDate { get; private set; }

    protected Sheep(string tag, DateTime birthDate)
    {
        Tag = Guard.Against.NullOrEmpty(tag, nameof(tag));
        BirthDate = Guard.Against.NullOrInvalidInput(birthDate, nameof(birthDate),x=>x.Date >= birthDate);
    }

    public static Sheep Create(string tag, DateTime birthDate)
    {
        return new Sheep(tag,birthDate);
    }
}