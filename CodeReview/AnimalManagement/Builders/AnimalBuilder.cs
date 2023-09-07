using CodeReview.AnimalManagement.Domain;
using CodeReview.AnimalManagement.Domain.Interfaces;

namespace CodeReview.AnimalManagement.Builders;

public class AnimalBuilder<T> : IAnimalBuilder where T:IAnimal
{
    private string _tag;
    private DateTime _birthDate;
    public IAnimalBuilder WithTag(string tag)
    {
        this._tag = tag;
        return this;
    }

    public IAnimalBuilder WithBirthDate(DateTime birthDate)
    {
        this._birthDate = birthDate;
        return this;
    }

    public IAnimal Build()
    {
        return typeof(T) switch
        {
            Type t when t == typeof(Sheep) => Sheep.Create(_tag, _birthDate),
            _ => throw new ArgumentException("Invalid animal type.")
        };
    }
}