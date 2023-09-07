using CodeReview.AnimalManagement.Domain;

namespace CodeReview.AnimalManagement.Proxies;

public class BoxSpongeDateProxy
{
    public DateTime SpongeDate { get; private set; }
    public int NumberOfCycles { get; }
    
    private readonly Box _box;
    private readonly int _itemNoOfMonth;


    public BoxSpongeDateProxy(Box box, int numberOfCycle, int itemNoOfMonth)
    {
        _box = box;
        _itemNoOfMonth = itemNoOfMonth;
        NumberOfCycles = numberOfCycle;
    }

    public void CurrentYear()
    {
        SpongeDate = _box.SpongeDate.AddMonths(_itemNoOfMonth - 1);
    }

    public void AddOneYear()
    {
        SpongeDate = _box.SpongeDate.AddMonths(_itemNoOfMonth +11);
    }

    public void AddTwoYear()
    {
        SpongeDate = _box.SpongeDate.AddMonths(_itemNoOfMonth +23);
    }
}