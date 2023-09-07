using CodeReview.AnimalManagement.Domain;
using CodeReview.AnimalManagement.Proxies;

namespace CodeReview.AnimalManagement.Rules;

public class FirstCycleRule : RacionCycleRule
{
    public override bool IsMatch(int numberOfCycle)
    {
        return 1 == numberOfCycle;
    }

    public override void AdjustSpongeDate(BoxSpongeDateProxy boxSpongeDateProxy)
    {
        boxSpongeDateProxy.CurrentYear();
    }
}