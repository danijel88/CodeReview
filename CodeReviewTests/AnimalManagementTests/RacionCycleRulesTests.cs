using CodeReview.AnimalManagement.Domain;
using CodeReview.AnimalManagement.Proxies;
using CodeReview.AnimalManagement.Rules;

namespace CodeReviewTests.AnimalManagementTests;

public class RacionCycleRulesTests
{
    [Fact]
    public void RacionCycleRule_WithThreeCycles()
    {
        Racion racion = new Racion(1, "Racion 1");
        racion.AddRacionItem(new RacionItems(1, 1, 1, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 2, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 3, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 4, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 5, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 6, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 7, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 8, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 9, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 10, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 11, 1.5m, 1, 25m));
        racion.AddRacionItem(new RacionItems(1, 1, 12, 1.5m, 1, 25m));
        Box _box = new Box(new DateTime(2023, 1, 15), racion);

        var engine = new RacionSpongeDateRuleEngine
            .RacionCycleBuilder()
            .WithOneCycle()
            .WithTwoCycles()
            .WithThreeCycles()
            .Build();


        foreach (var racionItem in _box.Racion.RacionItems)
        {
            var proxy = new BoxSpongeDateProxy(_box, 1, racionItem.NoOfMonth);
            engine.ApplyRules(proxy);
            Assert.Equal(2023,proxy.SpongeDate.Year);
        }
        foreach (var racionItem in _box.Racion.RacionItems)
        {
            var proxy = new BoxSpongeDateProxy(_box, 2, racionItem.NoOfMonth);
            engine.ApplyRules(proxy);
            Assert.Equal(2024,proxy.SpongeDate.Year);
        }
        foreach (var racionItem in _box.Racion.RacionItems)
        {
            var proxy = new BoxSpongeDateProxy(_box, 3, racionItem.NoOfMonth);
            engine.ApplyRules(proxy);
            Assert.Equal(2025,proxy.SpongeDate.Year);
        }

    }
}