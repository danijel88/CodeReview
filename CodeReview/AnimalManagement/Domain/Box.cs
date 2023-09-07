using Ardalis.GuardClauses;

namespace CodeReview.AnimalManagement.Domain;

public class Box
{
    public DateTime SpongeDate { get; private set; }
    public int RacionId { get; private set; }
    public Racion Racion { get; private set; }
    public Box(DateTime spongeDate,Racion racion)
    {
        SpongeDate = spongeDate;
        Racion = Guard.Against.Null(racion,nameof(racion));
    }
}