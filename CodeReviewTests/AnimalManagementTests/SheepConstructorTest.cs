using CodeReview.AnimalManagement.Builders;
using CodeReview.AnimalManagement.Domain.Interfaces;
using CodeReview.AnimalManagement.Factories;

namespace CodeReviewTests.AnimalManagementTests;

public class SheepConstructorTest
{
    [Fact]
    public void Sheep_Create()
    {
        IAnimalFactory sheepFactory = new SheepFactory();
        IAnimalBuilder sheepBuilder = sheepFactory.CreateAnimal();
        IAnimal sheep = sheepBuilder.WithTag("Tag 1")
            .WithBirthDate(new DateTime(2023,1,15))
            .Build();

        Assert.NotNull(sheep);
        Assert.Equal("Tag 1",sheep.Tag);
        Assert.Equal(new DateTime(2023,1,15),sheep.BirthDate);
    }
}