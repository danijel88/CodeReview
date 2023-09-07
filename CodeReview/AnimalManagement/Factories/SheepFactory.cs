using CodeReview.AnimalManagement.Builders;
using CodeReview.AnimalManagement.Domain;

namespace CodeReview.AnimalManagement.Factories;

public class SheepFactory : IAnimalFactory
{
    public IAnimalBuilder CreateAnimal()
    {
        return new AnimalBuilder<Sheep>();
    }
}