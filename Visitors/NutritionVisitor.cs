public class NutritionVisitor : IFoodVisitor
{
    public void Visit(Koshari food)
    {
        Console.WriteLine($"Reviewing ingredients of {food.Name}");
    }

    public void Visit(Hawawshi food)
    {
        Console.WriteLine($"Reviewing ingredients of {food.Name}");
    }

    public void Visit(RozBelLaban food)
    {
        Console.WriteLine($"Reviewing ingredients of {food.Name}");
    }
}