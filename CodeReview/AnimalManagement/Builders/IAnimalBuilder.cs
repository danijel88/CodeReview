using CodeReview.AnimalManagement.Domain.Interfaces;

namespace CodeReview.AnimalManagement.Builders;

public interface IAnimalBuilder
{
    IAnimalBuilder WithTag(string tag);
    IAnimalBuilder WithBirthDate(DateTime birthDate);

    IAnimal Build();
}