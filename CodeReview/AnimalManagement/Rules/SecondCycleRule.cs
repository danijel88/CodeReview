using CodeReview.AnimalManagement.Proxies;

namespace CodeReview.AnimalManagement.Rules;

public class SecondCycleRule : RacionCycleRule
{
    public override bool IsMatch(int numberOfCycle)
    {
        return 2 == numberOfCycle;
    }

    public override void AdjustSpongeDate(BoxSpongeDateProxy boxSpongeDateProxy)
    {
        boxSpongeDateProxy.AddOneYear();
    }
}