using CodeReview.AnimalManagement.Proxies;

namespace CodeReview.AnimalManagement.Rules;

public class RacionSpongeDateRuleEngine
{
    private readonly List<RacionCycleRule> _rules = new List<RacionCycleRule>();

    public RacionSpongeDateRuleEngine(List<RacionCycleRule> rules)
    {
        _rules = rules;
    }

    public void ApplyRules(BoxSpongeDateProxy proxy)
    {
        foreach (var rule in _rules)
        {
            if (rule.IsMatch(proxy.NumberOfCycles))
            {
                rule.AdjustSpongeDate(proxy);
                break;
            }
        }
    }

    public class RacionCycleBuilder
    {
        private readonly List<RacionCycleRule> _rules = new List<RacionCycleRule>();

        public RacionCycleBuilder WithOneCycle()
        {
            _rules.Add(new FirstCycleRule());
            return this;
        }

        public RacionCycleBuilder WithTwoCycles()
        {
            _rules.Add(new SecondCycleRule());
            return this;
        }

        public RacionCycleBuilder WithThreeCycles()
        {
            _rules.Add(new ThirdCycleRule());
            return this;
        }

        public RacionSpongeDateRuleEngine Build()
        {
            return new RacionSpongeDateRuleEngine(_rules);
        }
    }
}