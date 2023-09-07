using CodeReview.AnimalManagement.Proxies;

namespace CodeReview.AnimalManagement.Rules;

public class ThirdCycleRule : RacionCycleRule
{
    public override bool IsMatch(int numberOfCycle)
    {
        return 3 == numberOfCycle;
    }

    public override void AdjustSpongeDate(BoxSpongeDateProxy boxSpongeDateProxy)
    {
        boxSpongeDateProxy.AddTwoYear();
    }
}