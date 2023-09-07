using CodeReview.AnimalManagement.Proxies;

namespace CodeReview.AnimalManagement.Rules;

public abstract class RacionCycleRule
{
    public abstract bool IsMatch(int numberOfCycle);
    public abstract void AdjustSpongeDate(BoxSpongeDateProxy boxSpongeDateProxy);
}