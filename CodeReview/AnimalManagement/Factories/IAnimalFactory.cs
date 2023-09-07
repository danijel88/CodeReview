using CodeReview.AnimalManagement.Builders;
using CodeReview.AnimalManagement.Domain.Interfaces;

namespace CodeReview.AnimalManagement.Factories;

public interface IAnimalFactory
{
    IAnimalBuilder CreateAnimal();
}