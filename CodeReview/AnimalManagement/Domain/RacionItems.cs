using Ardalis.GuardClauses;

namespace CodeReview.AnimalManagement.Domain;

public class RacionItems
{
    public int Id { get; private set; }
    public int NoOfMonth { get; private set; }
    public decimal QtyToConsume { get; private set; }
    public decimal TargetToProduce { get; private set; }
    public int ItemId { get; private set; }
    public int RacionId { get; private set; }

    public RacionItems(int id, int itemId, int noOfMonth, decimal qtyToConsume, int racionId, decimal targetToProduce)
    {
        Id = Guard.Against.NegativeOrZero(id,nameof(id));
        ItemId = Guard.Against.NegativeOrZero(itemId, nameof(itemId));
        NoOfMonth = Guard.Against.NegativeOrZero(noOfMonth,nameof(noOfMonth));
        QtyToConsume = Guard.Against.Negative(qtyToConsume,nameof(qtyToConsume));
        RacionId = Guard.Against.NegativeOrZero(racionId, nameof(racionId));
        TargetToProduce = Guard.Against.Negative(targetToProduce, nameof(targetToProduce));
    }
}